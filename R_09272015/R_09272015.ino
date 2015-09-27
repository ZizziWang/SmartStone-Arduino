/*-----( Import needed libraries )-----*/
#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>
/*-----( Declare Constants and Pin Numbers )-----*/
#define CE_PIN   9
#define CSN_PIN 10
#define PIPE 0xE8E8F0F0E1LL
// NOTE: the "LL" at the end of the constant is "LongLong" type
/*const uint64_t pipe = 0xE8E8F0F0E1LL; // Define the transmit pipe*/

/*-----( Declare objects )-----*/
RF24 radio(CE_PIN, CSN_PIN); // Create a Radio
/*-----( Declare Variables )-----*/
uint32_t aCap[8];
uint32_t u32Cap;
int32_t s32Cap;
double fCap;

void setup() {
  Serial.begin(9600);
  delay(1000);
  Serial.println("nRF24L01 Receiver Starting");
  radio.begin();
  radio.openReadingPipe(1,PIPE);
  radio.startListening();
}//--(end setup )---

void loop() 
{
  Serial.println("==========================================");
  if ( radio.available() )
  {
    // Read the data payload until we've received everything
    for(int i=0; i<4; i++)
    {
      // Fetch the data payload
      radio.read( aCap, sizeof(aCap) );
      uint32_t u32Temp1 = aCap[2*i];
      uint32_t u32Temp2 = aCap[2*i+1];
      
      if((aCap[2*i]>>15)==0)                      //check capacitance POS/NEG
      {                                          //if POS
        //Serial.println("Positive");            //delete "//" to debug
        uint32_t u32Cap = ((u32Temp1<<8)+(u32Temp2>>8));    //combine MSBs & LSBs
        int32_t s32Cap = (int32_t)u32Cap;                //turn reading(unsign) into signed
        fCap = (double)s32Cap;                   //turn reading(signed) into float
        fCap/= 524288;                           ///2^19, see 8.6.1.1
      }
      else                                       //if NEG
      {
        //Serial.println("Negative");                  //delete "//" to debug
        u32Cap = ((~u32Temp1+1)<<8+(~u32Temp2+1)>>8);    //turn MSBs & LSBs (2's COMP) into unsigned(POS), combine MSBs & LSBs
        s32Cap = ((int32_t)u32Cap)*(-1);               //turn reading(unsign) into signed, NEG
        fCap = (double)s32Cap;                         //turn reading(signed) into float
        fCap/= 524288;                                 ///2^19, see 8.6.1.1
      }      
      Serial.print("Measurement ");
      Serial.print(i+1);
      Serial.print(" = ");
      Serial.print(fCap);
      Serial.println(" pF");
    }

  }
  else
  {    
      Serial.println("No radio available");
  }
  Serial.println("==========================================");
  delay(1000);

}//--(end main loop )---
