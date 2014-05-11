/*
 * Portable_Logger.h
 *
 *  Created on: 11/05/2014
 *      Author: Altec
 */

#ifndef PORTABLE_LOGGER_H_
#define PORTABLE_LOGGER_H_

#define DEBUG 1

#include <stdint.h>
#include <stdbool.h>

#include "inc/hw_memmap.h"
#include "inc/hw_types.h"
#include "inc/hw_i2c.h"
#include "inc/hw_ints.h"

#include "driverlib/rom.h"
#include "driverlib/i2c.h"
#include "driverlib/rom.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/pin_map.h"
#include "driverlib/uart.h"
#include "driverlib/interrupt.h"

#include "utils/uartstdio.h"

#include "third_party/fatfs/src/ff.h"
#include "third_party/fatfs/src/diskio.h"

//ARBITRARY BUFFER SIZE FOR GPS DATA STRING
#define BUF_SIZE 128
/**************************************************************
 * String to hold any characters received from the GPS module *
 **************************************************************/
static int8_t  GPS_Data_String[BUF_SIZE];

/***************************************************************
 * Counter to keep track of the number of Characters received  *
 * from GPS module											   *
 ***************************************************************/

static int32_t gCharcnt = 0;

/**************************************************
 * BOOLEAN FOR DETERMINING RECIEVED GPS CHARACTER *
 **************************************************/
bool GPSrxFlag = false;

/****************************
 * Function Prototypes      *
 ****************************/
void ConfigureUART(void);
void GPSConfigMsg(int8_t msg[], int num);
void Periph_Enables(void);

/*****************************
 * GPS CONFIGURATION COMMANDS*
 *****************************/

/*CONFIGURE GPS TO USE NMEA GPRMC PROTOCOL*/
int8_t NMEA_GPRMCmsgConfig[] = { 0xB5, 0x62, 0x06, 0x01, 0x08, 0x00, 0xF0, 0x04,
									0x01, 0x01, 0x01, 0x01, 0x01, 0x00, 0x08, 0x53 };

/*CONFIGURE GPS TO OUTPUT IN THE NMEA FORMAT*/
int8_t NMEAoutConfig[] = {0xB5, 0x62, 0x06, 0x00, 0x14, 0x00, 0x01, 0x00, 0x00, 0x00, 0xD0, 0x08, 0x00, 0x00, 0x00,
							0x96, 0x00, 0x00, 0x07, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x92, 0x8A};


#endif /* PORTABLE_LOGGER_H_ */
