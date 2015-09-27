#include <Wire.h>    //I2C LIB

int FDC = B1010000;    //FDC1004's address as a slave

void setup() 
{
  Serial.begin(9600);
  Wire.begin();                   //join I2C bus as a master
  for(int i=0; i<4; i++)          //MEAS_CONF setup, CHB & CAPDAC disabled, see Table 4
  {
    FDC_write(0x08+i, 0x1c+0x20*i, 0x00);
  }
  FDC_write(0x0c, 0x05, 0xF0);    //FDC register setup, rate=100S/s, see Table 5
}

void loop()
{
  Serial.println("==========================================");
  for(int i=0; i<4; i++)
  {
    uint32_t u32Cap;
    double fCap;
    int32_t s32Cap;
    Serial.print("Measurement ");
    Serial.print(i+1);
    Serial.print(" = ");
    uint16_t u16Temp1 = FDC_read(0x00+2*i);    //read MSBs(16-bit)
    uint32_t u32Cap1 = u16Temp1;               //turn MSBs(16-bit) into 32-bit
    uint16_t u16Temp2 = FDC_read(0x01+2*i);    //read LSBs(16-bit)
    uint32_t u32Cap2 = u16Temp2;               //turn LSBs(16-bit) into 32-bit
    if((u16Temp1>>15)==0)                      //check capacitance POS/NEG
    {                                          //if POS
      //Serial.println("Positive");            //delete "//" to debug
      u32Cap = ((u32Cap1<<8)+(u32Cap2>>8));    //combine MSBs & LSBs
      s32Cap = (int32_t)u32Cap;                //turn reading(unsign) into signed
      fCap = (double)s32Cap;                   //turn reading(signed) into float
      fCap/= 524288;                           ///2^19, see 8.6.1.1
    }
    else                                       //if NEG
    {
      //Serial.println("Negative");                  //delete "//" to debug
      u32Cap = ((~u32Cap1+1)<<8+(~u32Cap2+1)>>8);    //turn MSBs & LSBs (2's COMP) into unsigned(POS), combine MSBs & LSBs
      s32Cap = ((int32_t)u32Cap)*(-1);               //turn reading(unsign) into signed, NEG
      fCap = (double)s32Cap;                         //turn reading(signed) into float
      fCap/= 524288;                                 ///2^19, see 8.6.1.1
    }      
    Serial.print(fCap);
    Serial.println(" pF");
  }
  delay(1000);
}

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
