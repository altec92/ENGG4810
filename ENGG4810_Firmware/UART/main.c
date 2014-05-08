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
#include "driverlib/i2c.h"
#include "driverlib/rom.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/pin_map.h"
#include "driverlib/uart.h"
#include "uartstdio.h"
#define APP_INPUT_BUF_SIZE 128
#define SLAVE_ADDR 0x77
static char g_cInput[APP_INPUT_BUF_SIZE];


void ConfigureUART(void);
void I2C_Config(void);
void I2C_Write(uint8_t SlaveAddr, uint8_t Data );
int main(void) {
	SysCtlClockSet(SYSCTL_SYSDIV_5 | SYSCTL_XTAL_16MHZ |
	                       SYSCTL_OSC_MAIN);
	//SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);
	uint32_t Data = 0;
	ConfigureUART();
	I2C_Config();
	UARTprintf("Welcome to the Tiva C Series TM4C123G LaunchPad!\n");
	//I2C_Write(SLAVE_ADDR, 0xf4);
	I2CMasterSlaveAddrSet(I2C0_BASE, SLAVE_ADDR, false);
	I2CMasterDataPut(I2C0_BASE, 0xF4);
	I2CMasterControl(I2C0_BASE, I2C_MASTER_CMD_BURST_SEND_START);
	while(I2CMasterBusy(I2C0_BASE)){
			// wait while master is transferring
	}
	SysCtlDelay(100);
	//I2CMasterSlaveAddrSet(I2C0_BASE, SLAVE_ADDR, false);
	I2CMasterDataPut(I2C0_BASE, 0x2E);
	I2CMasterControl(I2C0_BASE, I2C_MASTER_CMD_BURST_SEND_FINISH);
	while(I2CMasterBusy(I2C0_BASE)){
		// wait while master is transferring
	}
	SysCtlDelay(60000);
	I2CMasterSlaveAddrSet(I2C0_BASE, SLAVE_ADDR, false);
	I2CMasterDataPut(I2C0_BASE, 0xF6);
	I2CMasterControl(I2C0_BASE, I2C_MASTER_CMD_BURST_SEND_START);
	while(I2CMasterBusy(I2C0_BASE)){
		// wait while master is transferring
	}
	I2CMasterSlaveAddrSet(I2C0_BASE, SLAVE_ADDR, true);

	I2CMasterControl(I2C0_BASE, I2C_MASTER_CMD_SINGLE_RECEIVE);

	while(I2CMasterBusy(I2C0_BASE)){
			// wait while master is transferring
	}

	Data = I2CMasterDataGet(I2C0_BASE);

	UARTprintf("%d", Data);


	while(1){

		//UARTgets(g_cInput, sizeof(g_cInput));
		//UARTprintf(g_cInput);
	}

}

//*****************************************************************************
//
// Configure the UART and its pins.  This must be called before UARTprintf().
//
//*****************************************************************************
void
ConfigureUART(void)
{
    //
    // Enable the GPIO Peripheral used by the UART.
    //
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);

    //
    // Enable UART0
    //
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);

    //
    // Configure GPIO Pins for UART mode.
    //
    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);

    //
    // Use the internal 16MHz oscillator as the UART clock source.
    //
    UARTClockSourceSet(UART0_BASE, UART_CLOCK_PIOSC);

    //
    // Initialize the UART for console I/O.
    //
    UARTStdioConfig(0, 115200, SysCtlClockGet());
}

void I2C_Config(void){
	SysCtlPeripheralEnable(SYSCTL_PERIPH_I2C0);

	    //
	    // For this example I2C0 is used with PortB[3:2].  The actual port and
	    // pins used may be different on your part, consult the data sheet for
	    // more information.  GPIO port B needs to be enabled so these pins can
	    // be used.
	    // TODO: change this to whichever GPIO port you are using.
	    //
	    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOB);

	    //
	    // Configure the pin muxing for I2C0 functions on port B2 and B3.
	    // This step is not necessary if your part does not support pin muxing.
	    // TODO: change this to select the port/pin you are using.
	    //
	    GPIOPinConfigure(GPIO_PB2_I2C0SCL);
	    GPIOPinConfigure(GPIO_PB3_I2C0SDA);

	    //
	    // Select the I2C function for these pins.  This function will also
	    // configure the GPIO pins pins for I2C operation, setting them to
	    // open-drain operation with weak pull-ups.  Consult the data sheet
	    // to see which functions are allocated per pin.
	    // TODO: change this to select the port/pin you are using.
	    //
	    GPIOPinTypeI2CSCL(GPIO_PORTB_BASE,GPIO_PIN_2);
	    GPIOPinTypeI2C(GPIO_PORTB_BASE, GPIO_PIN_3);

	    I2CMasterInitExpClk(I2C0_BASE, SysCtlClockGet(), false);

}

void I2C_Write(uint8_t SlaveAddr, uint8_t Data ){
	I2CMasterSlaveAddrSet(I2C0_BASE, SlaveAddr, false);
	I2CMasterDataPut(I2C0_BASE, Data);
	I2CMasterControl(I2C0_BASE, I2C_MASTER_CMD_SINGLE_SEND);
	while(I2CMasterBusy(I2C0_BASE)){
		// wait while master is transferring
	}
}


