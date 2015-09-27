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
/*-----( Declare Constants and Pin Numbers )-----*/
#define CE_PIN   9
#define CSN_PIN 10

// NOTE: the "LL" at the end of the constant is "LongLong" type
const uint64_t pipe = 0xE8E8F0F0E1LL; // Define the transmit pipe
int FDC = B1010000;    //FDC1004's address as a slave

/*-----( Declare objects )-----*/
RF24 radio(CE_PIN, CSN_PIN); // Create a Radio

/*-----( Declare Variables )-----*/
unsigned aCap[2];
 
void setup()   /****** SETUP: RUNS ONCE ******/
{
  Serial.begin(9600);
  Wire.begin();                   //join I2C bus as a master
  for(int i=0; i<4; i++)          //MEAS_CONF setup, CHB & CAPDAC disabled, see Table 4
  {
    FDC_write(0x08+i, 0x1c+0x20*i, 0x00);
  }
  FDC_write(0x0c, 0x05, 0xF0);    //FDC register setup, rate=100S/s, see Table 5
  
  radio.begin();
  radio.openWritingPipe(pipe);  
}//--(end setup )---


void loop()   /****** LOOP: RUNS CONSTANTLY ******/
{
  for(int i=0; i<4; i++)
  {
    aCap[1] = FDC_read(0x00+2*i);
    aCap[2] = FDC_read(0x01+2*i);
    radio.write(aCap, sizeof(aCap) );
  }
  delay(1000);
}//--(end main loop )---

/*-----( Declare User-written Functions )-----*/
  void FDC_write(uint8_t u8Poi, uint8_t u8Reg1, uint8_t u8Reg2)    //write FDC1004 (pointer, REG_MSB, REG_LSB)
{
  Wire.beginTransmission(FDC);
  Wire.write(u8Poi);
  Wire.write(u8Reg1);
  Wire.write(u8Reg2);
  Wire.endTransmission();
}

uint16_t FDC_read(uint8_t u8Reg)    //read FDC1004 (REG)
{
  Wire.beginTransmission(FDC);
  Wire.write(u8Reg);
  Wire.endTransmission();
  Wire.requestFrom(FDC,2);
  uint8_t u8Temp1=Wire.read();              //MSB of returning data
  uint8_t u8Temp2=Wire.read();              //LSB of returning data
  uint16_t u16Data=(u8Temp1<<8)+u8Temp2;    //combine returning data
  return u16Data;
}
  
//NONE
//*********( THE END )***********



