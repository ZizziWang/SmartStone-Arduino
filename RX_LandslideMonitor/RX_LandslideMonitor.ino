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
/*-----( Declare Constants and Pin Numbers )-----*/
#define CE_PIN   9
#define CSN_PIN 10

// NOTE: the "LL" at the end of the constant is "LongLong" type
const uint64_t pipe = 0xE8E8F0F0E1LL;    // Define the transmit pipe

/*-----( Declare objects )-----*/
RF24 radio(CE_PIN, CSN_PIN);    // Create a Radio
/*-----( Declare Variables )-----*/
uint16_t aCap[2];
uint32_t u32Cap;
int32_t s32Cap;
uint32_t u32Cap1;
uint32_t u32Cap2;
double fCap;

void setup() {
  Serial.begin(9600);
  delay(1000);
  Serial.println("Nrf24L01 Receiver Starting");
  radio.begin();
  radio.openReadingPipe(1,pipe);
  radio.startListening();;  
}//--(end setup )---

void loop() 
{
  Serial.println("==========================================");
  if ( radio.available() )    // Read the data payload until we've received everything
  {
    // Fetch the data payload
    radio.read( aCap, 2*sizeof(uint16_t));
    u32Cap1 = aCap[0];
    u32Cap2 = aCap[1];
    /*check capacitance POS/NEG*/
    if((aCap[0]>>15)==0)    //if capacitance>0
    {
      u32Cap = ((u32Cap1<<8)+(u32Cap2>>8));    //combine MSBs & LSBs
      s32Cap = (int32_t)u32Cap;    //turn reading(unsign) into signed
      fCap = (double)s32Cap;    //turn reading(signed) into float
      fCap/= 524288;    //capacitance=CapData/2^19, see 8.6.1.1
    }
    else    //if capacitance<0
    {
      u32Cap = ((~u32Cap1+1)<<8+(~u32Cap2+1)>>8);    //turn MSBs & LSBs (2's COMP) into unsigned(POS), combine MSBs & LSBs
      s32Cap = ((int32_t)u32Cap)*(-1);    //turn reading(unsign) into signed, NEG
      fCap = (double)s32Cap;    //turn reading(signed) into float
      fCap/= 524288;    //capacitance=CapData/2^19, see 8.6.1.1
    }      
    Serial.print("Capacitance = ");
    Serial.print(fCap);
    Serial.println(" pF");
  }
  else
  {    
      Serial.println("No radio available");
  }
  Serial.println("==========================================");
  delay(1000);

}    //--(end main loop )---
