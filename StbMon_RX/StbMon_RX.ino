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
byte aPack[16];
byte aTest[16]={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1};

void setup() {
  Serial.begin(38400);
  delay(1000);
  /*
  Serial.println("Nrf24L01 Receiver Starting");
  */
  radio.begin();
  radio.openReadingPipe(1,pipe);
  radio.startListening();
}//--(end setup )---

void loop() 
{
  /*
  Serial.println("==========================================");
  */
  if ( radio.available() )    // Read the data payload until we've received everything
  {
    // Fetch the data payload
    // s8RfAck = 1;
    radio.read( aPack, 16*sizeof(byte));
    /*
    Serial.write(s8RfAck);
    Serial.write(s16CapMsb);
    Serial.write(s16CapLsb);
    Serial.write(s16Ax);
    Serial.write(s16Ay);
    Serial.write(s16Az);
    Serial.write(s16Gx);
    Serial.write(s16Gy);
    Serial.write(s16Gz);
    */
    Serial.write(aPack, sizeof(aPack));
    delay(1000);
    Serial.println("Start Monitoring");
  }
  else
  {
    /*
    s8RfAck = 0;
    Serial.write(s8RfAck);
    */
    Serial.write(aTest,sizeof(aTest));
    delay(1000);
    Serial.println("No radio available");
  }
  delay(1000);

}    //--(end main loop )---
