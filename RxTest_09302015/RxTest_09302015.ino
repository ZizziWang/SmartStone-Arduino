/*-----( Import needed libraries )-----*/
#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>
/*-----( Declare Constants and Pin Numbers )-----*/
#define CE_PIN   9
#define CSN_PIN 10

// NOTE: the "LL" at the end of the constant is "LongLong" type
const uint64_t pipe = 0xE8E8F0F0E1LL; // Define the transmit pipe

/*-----( Declare objects )-----*/
RF24 radio(CE_PIN, CSN_PIN); // Create a Radio
/*-----( Declare Variables )-----*/
uint16_t aCap[2];

void setup() {
  Serial.begin(9600);
  delay(1000);
  Serial.println("Nrf24L01 Receiver Starting");
  radio.begin();
  radio.openReadingPipe(1,pipe);
  radio.startListening();
}//--(end setup )---

void loop()
{
  Serial.println("==========================================");
  if ( radio.available() )
  {
    // Read the data payload until we've received everything
    radio.read( aCap, sizeof(aCap) );
    Serial.print(aCap[0], BIN);
    Serial.print("  ");
    Serial.println(aCap[1], BIN);
  }
  else
  {
      Serial.println("No radio available");
  }
  Serial.println("==========================================");
  delay(1000);

}//--(end main loop )---
