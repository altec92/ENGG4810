/*
 * main.c
 */

#define PART_TM4C1230H6PM

#include <stdint.h>
#include <stdbool.h>

#include "inc/hw_memmap.h"
#include "inc/hw_types.h"

#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/pin_map.h"
#include "driverlib/uart.h"
#include "driverlib/interrupt.h"
#include "driverlib/rom.h"

#include "uartstdio.h"

#include "third_party/fatfs/src/ff.h"
#include "third_party/fatfs/src/diskio.h"
#include "Defs.h"






int main(void) {
	
	SysCtlClockSet(SYSCTL_SYSDIV_1 | SYSCTL_USE_OSC | SYSCTL_OSC_MAIN |
            SYSCTL_XTAL_16MHZ);
	ConfigureUART();

	FRESULT iFResult;
	FIL fp;


	iFResult = f_mount(&g_sFatFs, "", 0);
	if(iFResult != FR_OK)
	{
		UARTprintf("f_mount error: %s\n", StringFromFResult(iFResult));
		return(1);
	}
	UARTprintf("f_mout Succeeded");
	iFResult = f_open(&fp, "/TEST.txt ", FA_OPEN_ALWAYS| FA_WRITE| FA_READ );
	//UARTprintf("f_open error: %s\n", StringFromFResult(iFResult));
#if DEBUG
	Cmd_ls();
#endif

	f_lseek(&fp, f_size(&fp));

	f_printf(&fp, "HEllo NIGGERS\n");
#if DEBUG

	char cLine[128]; // Line buffer
	f_lseek(&fp, 0);
	while (f_gets(cLine, sizeof(cLine), &fp)){
		UARTprintf("%s", cLine);
	}
#endif
	f_close(&fp);
	return 0;
}


void
ConfigureUART(void)
{
    //
    // Enable the GPIO Peripheral used by the UART.
    //
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);
    //SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOC);

    //
    // Enable UART0
    //
    //SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART3);

    //
    // Configure GPIO Pins for UART mode.
    //
    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);

    UARTStdioConfig(0, 38400, SysCtlClockGet());

}

//*****************************************************************************
//
// This function returns a string representation of an error code that was
// returned from a function call to FatFs.  It can be used for printing human
// readable error messages.
//
//*****************************************************************************
const char *
StringFromFResult(FRESULT iFResult)
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

#if DEBUG
	int Cmd_ls()
	{
		uint32_t ui32TotalSize;
		uint32_t ui32FileCount;
		uint32_t ui32DirCount;
		FRESULT iFResult;
		FATFS *psFatFs;
		char *pcFileName;
	#if _USE_LFN
		char pucLfn[_MAX_LFN + 1];
		g_sFileInfo.lfname = pucLfn;
		g_sFileInfo.lfsize = sizeof(pucLfn);
	#endif


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

		ui32TotalSize = 0;
		ui32FileCount = 0;
		ui32DirCount = 0;

		//
		// Give an extra blank line before the listing.
		//
		UARTprintf("\n");

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

			//
			// If the attribue is directory, then increment the directory count.
			//
			if(g_sFileInfo.fattrib & AM_DIR)
			{
				ui32DirCount++;
			}

			//
			// Otherwise, it is a file.  Increment the file count, and add in the
			// file size to the total.
			//
			else
			{
				ui32FileCount++;
				ui32TotalSize += g_sFileInfo.fsize;
			}

	#if _USE_LFN
			pcFileName = ((*g_sFileInfo.lfname) ? g_sFileInfo.lfname : g_sFileInfo.fname);
	#else
			pcFileName = g_sFileInfo.fname;
	#endif
			//
			// Print the entry information on a single line with formatting to show
			// the attributes, date, time, size, and name.
			//
			UARTprintf("%c%c%c%c%c %u/%02u/%02u %02u:%02u %9u  %s\n",
					   (g_sFileInfo.fattrib & AM_DIR) ? 'D' : '-',
					   (g_sFileInfo.fattrib & AM_RDO) ? 'R' : '-',
					   (g_sFileInfo.fattrib & AM_HID) ? 'H' : '-',
					   (g_sFileInfo.fattrib & AM_SYS) ? 'S' : '-',
					   (g_sFileInfo.fattrib & AM_ARC) ? 'A' : '-',
					   (g_sFileInfo.fdate >> 9) + 1980,
					   (g_sFileInfo.fdate >> 5) & 15,
					   g_sFileInfo.fdate & 31,
					   (g_sFileInfo.ftime >> 11),
					   (g_sFileInfo.ftime >> 5) & 63,
					   g_sFileInfo.fsize,
					   pcFileName);
		}

		//
		// Print summary lines showing the file, dir, and size totals.
		//
		UARTprintf("\n%4u File(s),%10u bytes total\n%4u Dir(s)",
					ui32FileCount, ui32TotalSize, ui32DirCount);

		//
		// Get the free space.
		//
		iFResult = f_getfree("/", (DWORD *)&ui32TotalSize, &psFatFs);

		//
		// Check for error and return if there is a problem.
		//
		if(iFResult != FR_OK)
		{
			return((int)iFResult);
		}

		//
		// Display the amount of free space that was calculated.
		//
		UARTprintf(", %10uK bytes free\n", (ui32TotalSize *
											psFatFs->free_clust / 2));

		//
		// Made it to here, return with no errors.
		//
		return(0);
	}
#endif
