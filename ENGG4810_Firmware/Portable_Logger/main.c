/*
 * main.c
 */

#include "Portable_Logger.h"


int main(void) {

	SysCtlClockSet(SYSCTL_SYSDIV_1 | SYSCTL_USE_OSC | SYSCTL_OSC_MAIN |
	                       SYSCTL_XTAL_16MHZ);
	

	Periph_Enables();
	ConfigureUART();

	GPSConfigMsg(NMEA_GPRMCmsgConfig, 16 );

	GPSConfigMsg(NMEAoutConfig, 28);



   while(1)
   {
	   if(GPSrxFlag)
	   {

		   while(UARTCharsAvail(UART3_BASE))
		   {
			   /*STORE RECIEVED CHARACTERS IN GPS DATA STRING*/
			  GPS_Data_String[gCharcnt] = UARTCharGetNonBlocking(UART3_BASE);
			  gCharcnt++;
			  GPSrxFlag = false;
		   }
	   }

	   /*CHECK FOR NEW LINE CHARACTER*/
	   if(GPS_Data_String[gCharcnt-1] == '\n')
	   {
		   //Print String to console

		   UARTprintf("%s", GPS_Data_String);
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

	/*UART0 AND UART3 ENABLES*/
	SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_UART3);


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
    /* CONFIGURE UART 3 */
       UARTConfigSetExpClk(UART3_BASE, SysCtlClockGet(), 38400,
                                      (UART_CONFIG_WLEN_8 | UART_CONFIG_STOP_ONE |
                                       UART_CONFIG_PAR_NONE));

    /* CONFIGURE PINS FOR UART 3 */
    GPIOPinConfigure(GPIO_PC6_U3RX);
    GPIOPinConfigure(GPIO_PC7_U3TX);
    GPIOPinTypeUART(GPIO_PORTC_BASE, GPIO_PIN_6 | GPIO_PIN_7);
    IntMasterEnable();

   /* UART INTERRUPT ENABLES */
    IntEnable(INT_UART3);
    UARTIntEnable(UART3_BASE, UART_INT_RX | UART_INT_RT);

}

/********************************************
 * SEND A CONFIGURATION MESSAGE TO THE GPS  *
 ********************************************/
void GPSConfigMsg(int8_t msg[], int num)
{
	int i = 0;

	for (i = 0; i < num; i++)
	{

		UARTCharPut(UART3_BASE, msg[i] );

	}
}
/**********************
 * INTERRUPT HANDLERS *
 **********************/


void UART3IntHandler(void)
{
    uint32_t ui32Status;

    //
    // Get the interrrupt status.
    //
    ui32Status = UARTIntStatus(UART3_BASE, true);

    //
    // Clear the asserted interrupts.
    //
    UARTIntClear(UART3_BASE, ui32Status);


    //Set gps recieve flag;
    GPSrxFlag = true;


}
