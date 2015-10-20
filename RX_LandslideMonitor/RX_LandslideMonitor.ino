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
int16_t aPack[8];
int32_t s32Cap, s32Cap1, s32Cap2;
double fCap, fIncX, fIncY, fSat;
int16_t ax, ay, az, gx, gy, gz, ax0 = 0, ay0 = 0;

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
  Serial.println("==========================================");
  if ( radio.available() )    // Read the data payload until we've received everything
  {
    // Fetch the data payload
    radio.read( aPack, 8*sizeof(int16_t));
    s32Cap1 = aPack[0];
    s32Cap2 = aPack[1];
    s32Cap = (s32Cap1)<<16+(s32Cap2);
    fCap = (double)s32Cap;
    fCap /= 134217728;    // fCap/=2^27, capacitance=(CapData>>8)/2^19, see 8.6.1.1
    fSat = (-0.0005)*fCap*fCap+0.0911*fCap+3.9707;
    ax = aPack[2];
    ay = aPack[3];
    az = aPack[4];
    gx = aPack[5];
    gy = aPack[6];
    gz = aPack[7];

    if (ax0 == 0 && ay0 == 0) {
      ax0 = ax;
      ay0 = ay;
    }
    
    fIncX = -0.0035*(ax-ax0);
    fIncY = -0.0035*(ay-ay0);
    Serial.print("Saturation = ");Serial.println(fSat);
    Serial.print("Incline_x = ");Serial.println(fIncX);
    Serial.print("Incline_y = ");Serial.println(fIncY);
    Serial.print("Capacitance = ");Serial.print(fCap); Serial.println(" pF");
    Serial.print("accel_x = "); Serial.println(ax);
    Serial.print("accel_y = "); Serial.println(ay);
    Serial.print("accel_z = "); Serial.println(az);
    Serial.print("gyro_x = "); Serial.println(gx);
    Serial.print("gyro_y = "); Serial.println(gy);
    Serial.print("gyro_z = "); Serial.println(gz);
  }
  else
  {    
      Serial.println("No radio available");
  }
  Serial.println("==========================================");
  delay(1000);

}    //--(end main loop )---
