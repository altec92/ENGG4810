/*
 * Portable_Logger.h
 *
 *  Created on: 11/05/2014
 *      Author: Altec
 */

#ifndef PORTABLE_LOGGER_H_
#define PORTABLE_LOGGER_H_

#define DEBUG 1
#define UART_BASE UART1_BASE
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


/***********************
 * SD CARD DEFINITIONS *
 ***********************/

#ifdef DEBUG
int Cmd_ls();
const char * StringFromFResult(FRESULT iFResult);
#endif

/****************************************
 *  RESULT CODE FROM FATFS OPERATIONS
 ****************************************/
FRESULT iFResult;

/*****************************************************************************
 Defines the size of the buffers that hold the path, or temporary data from
 the SD card.  There are two buffers allocated of this size.  The buffer size
 must be large enough to hold the longest expected full path name, including
 the file name, and a trailing null character.
*****************************************************************************/
#define PATH_BUF_SIZE           80

/*****************************************************************************
 Defines the size of the buffer that holds the command line.
*****************************************************************************/
#define CMD_BUF_SIZE            64

/*****************************************************************************
 This buffer holds the full path to the current working directory.  Initially
 it is root ("/").
*****************************************************************************/
static char g_pcCwdBuf[PATH_BUF_SIZE] = "/";

/*****************************************************************************
 The following are data structures used by FatFs.
*****************************************************************************/
static FATFS g_sFatFs;
static DIR g_sDirObject;
static FILINFO g_sFileInfo;
static FIL g_sFileObject;

/*****************************************************************************
 A macro that holds the number of result codes.
*****************************************************************************/
#define NUM_FRESULT_CODES       (sizeof(g_psFResultStrings) /                 \
                                 sizeof(tFResultString))

/*****************************************************************************
 A macro to make it easy to add result codes to the table.					 *
*****************************************************************************/
#define FRESULT_ENTRY(f)        { (f), (#f) }

#if DEBUG
/*****************************************************************************
 A structure that holds a mapping between an FRESULT numerical code, and a
 string representation.  FRESULT codes are returned from the FatFs FAT file
 system driver.
*****************************************************************************/
typedef struct
{
    FRESULT iFResult;
    char *pcResultStr;
}
tFResultString;

/*****************************************************************************
 A table that holds a mapping between the numerical FRESULT code and it's
 name as a string.  This is used for looking up error codes for printing to
 the console.
*****************************************************************************/
tFResultString g_psFResultStrings[] =
{
    FRESULT_ENTRY(FR_OK),
    FRESULT_ENTRY(FR_DISK_ERR),
    FRESULT_ENTRY(FR_INT_ERR),
    FRESULT_ENTRY(FR_NOT_READY),
    FRESULT_ENTRY(FR_NO_FILE),
    FRESULT_ENTRY(FR_NO_PATH),
    FRESULT_ENTRY(FR_INVALID_NAME),
    FRESULT_ENTRY(FR_DENIED),
    FRESULT_ENTRY(FR_EXIST),
    FRESULT_ENTRY(FR_INVALID_OBJECT),
    FRESULT_ENTRY(FR_WRITE_PROTECTED),
    FRESULT_ENTRY(FR_INVALID_DRIVE),
    FRESULT_ENTRY(FR_NOT_ENABLED),
    FRESULT_ENTRY(FR_NO_FILESYSTEM),
    FRESULT_ENTRY(FR_MKFS_ABORTED),
    FRESULT_ENTRY(FR_TIMEOUT),
    FRESULT_ENTRY(FR_LOCKED),
    FRESULT_ENTRY(FR_NOT_ENOUGH_CORE),
    FRESULT_ENTRY(FR_TOO_MANY_OPEN_FILES),
    FRESULT_ENTRY(FR_INVALID_PARAMETER),
};
#endif

#endif /* PORTABLE_LOGGER_H_ */