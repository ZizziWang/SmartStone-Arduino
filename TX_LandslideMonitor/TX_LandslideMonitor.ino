/* YourDuinoStarter Example: nRF24L01 Transmit Joystick values
 - WHAT IT DOES: Reads Analog values on A0, A1 and transmits
   them over a nRF24L01 Radio Link to another transceiver.
 - SEE the comments after "//" on each line below
 - CONNECTIONS: nRF24L01 Modules See:
 http://arduino-info.wikispaces.com/Nrf24L01-2.4GHz-HowTo
   1 - GND
   2 - VCC 3.3V !!! NOT 5V
   3 - CE to Arduino pin 9
   4 - CSN to Arduino pin 10
   5 - SCK to Arduino pin 13
   6 - MOSI to Arduino pin 11
   7 - MISO to Arduino pin 12
   8 - UNUSED
   - 
   Analog Joystick or two 10K potentiometers:
   GND to Arduino GND
   VCC to Arduino +5V
   X Pot to Arduino A0
   Y Pot to Arduino A1
   
 - V1.00 11/26/13
   Based on examples at http://www.bajdi.com/
   Questions: terry@yourduino.com */

/*-----( Import needed libraries )-----*/
#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>
#include <Wire.h>    //I2C LIB
#include <I2Cdev.h>
#include <MPU6050.h>
/*-----( Declare Constants and Pin Numbers )-----*/
#define CE_PIN   9
#define CSN_PIN 10

// NOTE: the "LL" at the end of the constant is "LongLong" type
const uint64_t pipe = 0xE8E8F0F0E1LL; // Define the transmit pipe
int FDC = B1010000;    //FDC1004's address as a slave

/*-----( Declare objects )-----*/
MPU6050 accelgyro;
RF24 radio(CE_PIN, CSN_PIN);    // Create a Radio

/*-----( Declare Variables )-----*/
int16_t aPack[8];
int16_t ax, ay, az;
int16_t gx, gy, gz;
 
void setup()   /****** SETUP: RUNS ONCE ******/
{
  Serial.begin(38400);
  Wire.begin();    //join I2C bus as a master
  FDC_write(0x08, 0x0c, 0x00);    //MEAS1_CONF setup, POS:CIN1, NEG:CIN4, see Table 4
  FDC_write(0x0c, 0x05, 0xF0);    //FDC register setup, rate=100S/s, see Table 5
  accelgyro.initialize();
  radio.begin();
  radio.openWritingPipe(pipe);
}//--(end setup )---


void loop()    /****** LOOP: RUNS CONSTANTLY ******/
{
  accelgyro.getMotion6(&ax, &ay, &az, &gx, &gy, &gz);    //read IMU raw data
  aPack[0] = FDC_read(0x00);    //read CIN1 MSB
  aPack[1] = FDC_read(0x01);    //read CIN1 LSB
  aPack[2] = ax;
  aPack[3] = ay;
  aPack[4] = az;
  aPack[5] = gx;
  aPack[6] = gy;
  aPack[7] = gz;
  radio.write(aPack, 8*sizeof(int16_t));
  delay(1000);
}    //--(end main loop )---

/*-----( Declare User-written Functions )-----*/
  void FDC_write(int8_t s8Poi, int8_t s8Reg1, int8_t s8Reg2)    //write FDC1004 (pointer, REG_MSB, REG_LSB)
{
  Wire.beginTransmission(FDC);
  Wire.write(s8Poi);
  Wire.write(s8Reg1);
  Wire.write(s8Reg2);
  Wire.endTransmission();
}

uint16_t FDC_read(int8_t s8Reg)    //read FDC1004 (REG)
{
  Wire.beginTransmission(FDC);
  Wire.write(s8Reg);
  Wire.endTransmission();
  Wire.requestFrom(FDC,2);
  int8_t s8Temp1=Wire.read();    //MSB of returning data
  int8_t s8Temp2=Wire.read();    //LSB of returning data
  int16_t s16Data=(s8Temp1<<8)+s8Temp2;    //combine returning data
  return s16Data;
}
  
//NONE
//*********( THE END )***********
