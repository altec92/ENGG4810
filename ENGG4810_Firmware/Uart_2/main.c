/*
 * main.c
 */

#define PART_TM4C1230H6PM

#include <stdint.h>
#include <stdbool.h>
#include "driverlib/rom.h"
#include "inc/hw_memmap.h"
#include "inc/hw_types.h"
#include "inc/hw_i2c.h"
#include "inc/hw_ints.h"
#include "driverlib/i2c.h"
#include "driverlib/rom.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/pin_map.h"
#include "driverlib/uart.h"
#include "uartstdio.h"
#include "driverlib/interrupt.h"
#include "Definitions.h"

bool GPSrxFlag = false;
bool txFlag = false;

int main(void) {

    SysCtlClockSet(SYSCTL_SYSDIV_1 | SYSCTL_USE_OSC | SYSCTL_OSC_MAIN |
                       SYSCTL_XTAL_16MHZ);
		//
	    // Enable the GPIO port that is used for the on-board LED.
	    //
	   // SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);

	    //
	    // Enable the GPIO pins for the LED (PF2).
	    //
	   // GPIOPinTypeGPIOOutput(GPIO_PORTF_BASE, GPIO_PIN_2);
	    ConfigureUART();
	    GPIOPinTypeGPIOOutput(GPIO_PORTA_BASE, GPIO_PIN_2);
	    GPSConifg();
	    //UARTSend((uint8_t *)"\033[2JEnter text: ", 16);


	   while(1)
	   {
		   if(GPSrxFlag)
		   {
			   //GRab data from Uart3 while it is available
			   while(UARTCharsAvail(UART3_BASE))
			   {

				   GPS_Data_String[gCharcnt] = UARTCharGetNonBlocking(UART3_BASE);
				   gCharcnt++;
				   GPSrxFlag = false;
			   }
		   }
		   //Check for end of the String
		   if(GPS_Data_String[gCharcnt-1] == '\n')
		   {

			   int i = 0;
			   // Print String to console
			   for (i = 0; i < BUF_SIZE; i ++)
			   {
				   UARTprintf("%c", GPS_Data_String[i]);

			   }
			   UARTprintf("%d\n", gCharcnt);
			   //Reset GPS DATA STring
			   for (i = 0; i < BUF_SIZE; i ++)
			   {
				   GPS_Data_String[i] = 0;
			   }

			   gCharcnt = 0;
		   }
	   }

}

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

;
    //Set gps recieve flag;
    GPSrxFlag = true;


}

void UART0IntHandler(void)
{
    uint32_t ui32Status;

    //
    // Get the interrrupt status.
    //
    ui32Status = UARTIntStatus(UART0_BASE, true);

    //
    // Clear the asserted interrupts.
    //
    UARTIntClear(UART0_BASE, ui32Status);

    //Console recieve flag
    txFlag = true;
}


void
ConfigureUART(void)
{
    //
    // Enable the GPIO Peripheral used by the UART.
    //
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOC);

    //
    // Enable UART0
    //
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART3);

    //
    // Configure GPIO Pins for UART mode.
    //
    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);
   //Uart 2
    GPIOPinConfigure(GPIO_PC6_U3RX);
    GPIOPinConfigure(GPIO_PC7_U3TX);
    GPIOPinTypeUART(GPIO_PORTC_BASE, GPIO_PIN_6 | GPIO_PIN_7);

    //
    // Use the internal 16MHz oscillator as the UART clock source.
    //
    IntMasterEnable();

    UARTStdioConfig(0, 38400, SysCtlClockGet());

    UARTConfigSetExpClk(UART3_BASE, SysCtlClockGet(), 38400,
                                   (UART_CONFIG_WLEN_8 | UART_CONFIG_STOP_ONE |
                                    UART_CONFIG_PAR_NONE));
    IntEnable(INT_UART3);
    UARTIntEnable(UART3_BASE, UART_INT_RX | UART_INT_RT);
    IntEnable(INT_UART0);
    UARTIntEnable(UART0_BASE, UART_INT_RX | UART_INT_RT);
    //UARTClockSourceSet(UART0_BASE, UART_CLOCK_PIOSC);

    //
    // Initialize the UART for console I/O.
    //
    //UARTStdioConfig(0, 115200, SysCtlClockGet());
}

void UARTSend(const uint8_t *pui8Buffer, uint32_t ui32Count)
{
    //
    // Loop while there are more characters to send.
    //
    while(ui32Count--)
    {
        //
        // Write the next character to the UART.
        //
        UARTCharPutNonBlocking(UART0_BASE, *pui8Buffer++);
    }
}

void GPSConifg(void)
{
	int i = 0;

	for (i = 0; i < sizeof(NMEA_GPRMCmsgConfig); i++)
	{
		UARTCharPutNonBlocking(UART3_BASE, NMEA_GPRMCmsgConfig[i] );
	}

	for (i = 0; i < sizeof(NMEAoutConfig); i++)
	{
		UARTCharPutNonBlocking(UART3_BASE, NMEAoutConfig[i] );
	}

}

