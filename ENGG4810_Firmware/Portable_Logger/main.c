/*
 * main.c
 */

#include "Portable_Logger.h"
//*****************************************************************************
//
// Application state structure.  Gets stored to hibernate memory for
// preservation across hibernate events.
//
//*****************************************************************************

tAppState g_sAppState;

/*
 * keeps track of the number of log files on SD card for file name
 */
uint32_t ui32LogNum;


int main(void) {

	uint32_t ui32ResetCause;
	uint32_t ui32Status;
	SysCtlClockSet(SYSCTL_SYSDIV_1 | SYSCTL_USE_OSC | SYSCTL_OSC_MAIN |
			SYSCTL_XTAL_16MHZ);


	Periph_Enables();
	ConfigureUART();


	ui32ResetCause = SysCtlResetCauseGet();
	SysCtlResetCauseClear(ui32ResetCause);
	if(ui32ResetCause == SYSCTL_CAUSE_POR)
	{
		if(HibernateIsActive())
		{
			//
			// Read the status bits to see what caused the wake.
			//
			ui32Status = HibernateIntStatus(0);
			HibernateIntClear(ui32Status);

			//
			// Wake was due to the push button.
			//
			if(ui32Status & HIBERNATE_INT_PIN_WAKE)
			{
				UARTprintf("Hibernate Wake Pin Wake Event\n");

				//
				// Recover the application state variables from battery backed
				// hibernate memory.  Set ui32Mode to normal.
				//
				HibernateDataGet((uint32_t*) &g_sAppState,
						sizeof(tAppState) / 4 + 1);
				g_sAppState.state = HIBERNATE_WAKE;
			}

			//
			// Wake was due to RTC match
			//
			else if(ui32Status & HIBERNATE_INT_RTC_MATCH_0)
			{
				UARTprintf("Hibernate RTC Wake Event\n");

				//
				// Recover the application state variables from battery backed
				// hibernate memory. Set ui32Mode to briefly flash the RGB.
				//
				HibernateDataGet((uint32_t*) &g_sAppState,
						sizeof(tAppState) / 4 + 1);
				g_sAppState.state = HIBERNATE_WAKE;
			}
		}

		else
		{
			//
			// Reset was due to a cold first time power up.
			//
			UARTprintf("Power on reset. Hibernate not active.\n");
			g_sAppState.state = COLDWAKE;
		}
	}
	else
	{
		//
		// External Pin reset or other reset event occured.
		//
		UARTprintf("External or other reset\n");
		while(1)
		{
			//error occured and some unknown reset.
		}
	}

	//
	// Initialize clocking for the Hibernate module
	//
	HibernateEnableExpClk(SysCtlClockGet());

	/*Mount the SD CARD*/
	iFResult = f_mount(&g_sFatFs, "", 1);

	//iFResult = FR_OK;
	if(iFResult != FR_OK)
	{
		/*DISK ERROR*/
#if DEBUG
		UARTprintf("MOUNT UNSUCCESSFUL ERROR CODE : %s\n", StringFromFResult(iFResult));
#endif
		while(1)
		{
			//set the LED to ERROR PROBS RED
			//infinite loop to preserve state when debugging
		}
	}


	while(1)
	{
		if(g_sAppState.state == HIBERNATE_WAKE)
		{
			GPSConfigMsg(GPS_On,1);
			GPSConfigMsg(NMEA_GPRMCmsgConfig, 16 );
			GPSConfigMsg(NMEAoutConfig, 28);

		}
		else if(g_sAppState.state == COLDWAKE)
		{
			/*TURN ON AND CONFIGURE GPS*/
			GPSConfigMsg(NMEA_GPRMCmsgConfig, 16 );
			GPSConfigMsg(NMEAoutConfig, 28);
			create_log();

		}


		if(GPSrxFlag)
		{
			while(UARTCharsAvail(UART_BASE))
			{
				/*STORE RECIEVED CHARACTERS IN GPS DATA STRING*/
				GPS_Data_String[gCharcnt] = UARTCharGetNonBlocking(UART_BASE);
				gCharcnt++;
				GPSrxFlag = false;
			}
		}

		/*CHECK FOR NEW LINE CHARACTER*/

		if(GPS_Data_String[gCharcnt-1] == '\n')
		{
			if(GPS_Data_String[0] =='$')
			{
				/*Print String to console*/
#if DEBUG
				UARTprintf("%s", GPS_Data_String);
#endif
				/*Copy GPS data to the DATA_TO_WRITE string here*/
				sprintf((char *)Write_Data_String, "%s", (char *)GPS_Data_String);


				f_lseek(&g_sFileObject, f_size(&g_sFileObject));

				f_printf(&g_sFileObject, "%s", Write_Data_String);
				f_sync(&g_sFileObject);
			}
#if DEBUG
			UARTprintf("%s", Write_Data_String);
#endif


			/* print to console what was written.*/
#if DEBUG
			print_file(&g_sFileObject);

#endif
			f_close(&g_sFileObject);



#if DEBUG
			UARTprintf("%d\n", gCharcnt);
#endif
			//Reset GPS DATA STring
			int i;
			for (i = 0; i < BUF_SIZE; i ++)
			{
				GPS_Data_String[i] = 0;
			}

			gCharcnt = 0;
		}
	}
}


/*
 * ENABLES ALL REQUIRED PERIPHERALS
 */
void Periph_Enables(void)
{
	/*GPIO PIN ENABLES*/
	SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOC);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOB);

	/*UART0 AND UART3 ENABLES*/
	SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_UART1);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_HIBERNATE);


}

/***********************************
 * CONFIGURES ALL UART PERIPERHALS *
 ***********************************/
void ConfigureUART(void)
{
#if DEBUG

	/*CONFIGURE THE UART0 TO ALLOW USE OF UART STDIO FUNCTIONS*/
	UARTStdioConfig(0, 38400, SysCtlClockGet());

	/*CONFIGURE PINS FOR UART 0  */
	GPIOPinConfigure(GPIO_PA0_U0RX);
	GPIOPinConfigure(GPIO_PA1_U0TX);
	GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);
#endif
	/* CONFIGURE UART 1 */
	UARTConfigSetExpClk(UART1_BASE, SysCtlClockGet(), 38400,
			(UART_CONFIG_WLEN_8 | UART_CONFIG_STOP_ONE |
					UART_CONFIG_PAR_NONE));

	/* CONFIGURE PINS FOR UART 1 */
	GPIOPinConfigure(GPIO_PB0_U1RX);
	GPIOPinConfigure(GPIO_PB1_U1TX);
	GPIOPinTypeUART(GPIO_PORTB_BASE, GPIO_PIN_0 | GPIO_PIN_1);
	IntMasterEnable();

	/* UART INTERRUPT ENABLES */
	IntEnable(INT_UART1);
	UARTIntEnable(UART_BASE, UART_INT_RX | UART_INT_RT);

}

/********************************************
 * SEND A CONFIGURATION MESSAGE TO THE GPS  *
 ********************************************/
void GPSConfigMsg(int8_t msg[], int num)
{
	int i = 0;

	for (i = 0; i < num; i++)
	{

		UARTCharPut(UART_BASE, msg[i] );

	}
}
//*****************************************************************************
// This function is called when system has decided it is time to enter
// Hibernate.  This will prepare the hibernate peripheral, save the system
// state and then enter hibernate mode.
//
//*****************************************************************************
void AppHibernateEnter(void)
{
	//
	// Prepare Hibernation Module
	//
	HibernateGPIORetentionEnable();
	HibernateRTCSet(0);
	HibernateRTCEnable();
	HibernateRTCMatchSet(0, 1);
	HibernateWakeSet(HIBERNATE_WAKE_PIN | HIBERNATE_WAKE_RTC);

	//
	// Store state information to battery backed memory
	// since sizeof returns number of bytes we convert to words and force
	// a rounding up to next whole word.
	//
	HibernateDataSet((uint32_t*)&g_sAppState, sizeof(tAppState)/4+1);
	GPSConfigMsg(GPS_Off, 16);
	f_close(&g_sFileObject);
	HibernateRequest();


}
/*
 * Count files in directory for log file Number
 *
 */

int file_count()
{
	uint32_t ui32FileCount;

	FRESULT iFResult;


	//
	// Open the current directory for access.
	//
	iFResult = f_opendir(&g_sDirObject, g_pcCwdBuf);

	//
	// Check for error and return if there is a problem.
	//
	if(iFResult != FR_OK)
	{
		return((int)iFResult);
	}
	ui32FileCount = 0;
	//
	// Enter loop to enumerate through all directory entries.
	//
	for(;;)
	{
		//
		// Read an entry from the directory.
		//
		iFResult = f_readdir(&g_sDirObject, &g_sFileInfo);

		//
		// Check for error and return if there is a problem.
		//
		if(iFResult != FR_OK)
		{
			return((int)iFResult);
		}

		//
		// If the file name is blank, then this is the end of the listing.
		//
		if(!g_sFileInfo.fname[0])
		{
			break;
		}

		if(g_sFileInfo.fattrib & AM_DIR)
		{
		}
		//
		//  Increment the file count
		//
		else
		{
			ui32FileCount++;
		}
	}
	return ui32FileCount;
}

#if DEBUG
/******************************************************
 * CONVERTS RESULT FROM FATFS OPERATIONS TO A STRING
 *******************************************************/
const char * StringFromFResult(FRESULT iFResult)
{
	uint_fast8_t ui8Idx;

	//
	// Enter a loop to search the error code table for a matching error code.
	//
	for(ui8Idx = 0; ui8Idx < NUM_FRESULT_CODES; ui8Idx++)
	{
		//
		// If a match is found, then return the string name of the error code.
		//
		if(g_psFResultStrings[ui8Idx].iFResult == iFResult)
		{
			return(g_psFResultStrings[ui8Idx].pcResultStr);
		}
	}

	//
	// At this point no matching code was found, so return a string indicating
	// an unknown error.
	//
	return("UNKNOWN ERROR CODE");
}

void print_file(FIL *fp)
{
	int iLineCnt = 0;
	char cLine[128]; // Line buffer
	f_lseek(fp, 0);
	while (f_gets(cLine, sizeof(cLine), fp))
	{
		iLineCnt++;

	}
	UARTprintf("Line count: %d\n",iLineCnt);
	iLineCnt = 0;
}

void create_log(void)
{
	ui32LogNum = file_count();
	sprintf(g_sAppState.cFilename, "Log%d", ui32LogNum + 1);
	iFResult = f_open(&g_sFileObject, g_sAppState.cFilename, FA_OPEN_ALWAYS|FA_WRITE);
	if(iFResult != FR_OK)
	{
		/*DISK ERROR*/
#if DEBUG
		UARTprintf("WRITE UNSUCCESSFUL ERROR CODE : %s\n", StringFromFResult(iFResult));
#endif
		while(1)
		{
			//set the LED to ERROR PROBS RED
			//infinite loop to preserve state when debugging
		}
	}
}
void open_log(void)
{
	iFResult = f_open(&g_sFileObject, g_sAppState.cFilename, FA_OPEN_ALWAYS|FA_WRITE);
	if(iFResult != FR_OK)
	{
		/*DISK ERROR*/
#if DEBUG
		UARTprintf("OPEN UNSUCCESSFUL ERROR CODE : %s\n", StringFromFResult(iFResult));
#endif
		while(1)
		{
			//set the LED to ERROR PROBS RED
			//infinite loop to preserve state when debugging
		}
	}
}

#endif
/**********************
 * INTERRUPT HANDLERS *
 **********************/


void UART1IntHandler(void)
{
	uint32_t ui32Status;

	//
	// Get the interrrupt status.
	//
	ui32Status = UARTIntStatus(UART_BASE, true);

	//
	// Clear the asserted interrupts.
	//
	UARTIntClear(UART_BASE, ui32Status);


	//Set gps recieve flag;
	GPSrxFlag = true;


}
