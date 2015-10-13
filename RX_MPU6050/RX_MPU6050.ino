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
int16_t aPac[6];
int16_t ax, ay, az;
int16_t gx, gy, gz;

void setup() {
  Serial.begin(38400);
  delay(1000);
  Serial.println("Nrf24L01 Receiver Starting");
  radio.begin();
  radio.openReadingPipe(1,pipe);
  radio.startListening();
}//--(end setup )---

void loop() 
{
  if ( radio.available() )    // Read the data payload until we've received everything
  {
    // Fetch the data payload
    radio.read( aPac, 6*sizeof(int16_t));
    ax = aPac[0];
    ay = aPac[1];
    az = aPac[2];
    gx = aPac[3];
    gy = aPac[4];
    gz = aPac[5];
    // display tab-separated accel/gyro x/y/z values
    Serial.print("a/g:\t");
    Serial.print(ax); Serial.print("\t");
    Serial.print(ay); Serial.print("\t");
    Serial.print(az); Serial.print("\t");
    Serial.print(gx); Serial.print("\t");
    Serial.print(gy); Serial.print("\t");
    Serial.println(gz);
  }
  else
  {    
      Serial.println("No radio available");
  }
  delay(1000);

}    //--(end main loop )---
