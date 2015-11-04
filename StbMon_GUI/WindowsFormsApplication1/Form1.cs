using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class StbMon_GUI : Form
    {
        double fCap, fSat, fIncX, fIncY;
        //Int32 sAX, sAY, sAZ, sGX, sGY, sGZ;
        Int16 s16AX, s16AY, s16AZ, s16GX, s16GY, s16GZ, s16AX0 = 0, s16AY0 = 0;
        SerialPort serialPort = null;
        delegate void AddDataDelegateCap(String StringCap);
        AddDataDelegateCap DelegateCap;
        delegate void AddDataDelegateSat(String StringSat);
        AddDataDelegateSat DelegateSat;
        delegate void AddDataDelegateIncX(String StringIncX);
        AddDataDelegateIncX DelegateIncX;
        delegate void AddDataDelegateIncY(String StringIncY);
        AddDataDelegateIncY DelegateIncY;
        delegate void AddDataDelegateAX(String StringAX);
        AddDataDelegateAX DelegateAX;
        delegate void AddDataDelegateAY(String StringAY);
        AddDataDelegateAY DelegateAY;
        delegate void AddDataDelegateAZ(String StringAZ);
        AddDataDelegateAZ DelegateAZ;
        delegate void AddDataDelegateGX(String StringGX);
        AddDataDelegateGX DelegateGX;
        delegate void AddDataDelegateGY(String StringGY);
        AddDataDelegateGY DelegateGY;
        delegate void AddDataDelegateGZ(String StringGZ);
        AddDataDelegateGZ DelegateGZ;
        delegate void AddDataDelegateTime(String StringTime);
        AddDataDelegateTime DelegateTime;
        delegate void AddDataDelegateData(String StringData);
        AddDataDelegateData DelegateData;

        String filePath = @"D:\Arduion file\arduino.txt";

        public StbMon_GUI()
        {
            InitializeComponent();
            setInitForm();
            this.DelegateCap = new AddDataDelegateCap(AddDataMethodCap);
            this.DelegateSat = new AddDataDelegateSat(AddDataMethodSat);
            this.DelegateIncX = new AddDataDelegateIncX(AddDataMethodIncX);
            this.DelegateIncY = new AddDataDelegateIncY(AddDataMethodIncY);
            this.DelegateAX = new AddDataDelegateAX(AddDataMethodAX);
            this.DelegateAY = new AddDataDelegateAY(AddDataMethodAY);
            this.DelegateAZ = new AddDataDelegateAZ(AddDataMethodAZ);
            this.DelegateGX = new AddDataDelegateGX(AddDataMethodGX);
            this.DelegateGY = new AddDataDelegateGY(AddDataMethodGY);
            this.DelegateGZ = new AddDataDelegateGZ(AddDataMethodGZ);
            this.DelegateTime = new AddDataDelegateTime(AddDataMethodTime);
            this.DelegateData = new AddDataDelegateData(AddDataMethodData);
        }

        private void setInitForm()
        {
            //button setting
            stopButton.Enabled = false;
            saveButton.Enabled = true;

            serialPort = new SerialPort();
            foreach (String com in SerialPort.GetPortNames())
            {
                serialPortComBox.Items.Add(com);
            }
  
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (serialPortComBox.Text == null || "".Equals(serialPortComBox.Text))
            {
                MessageBox.Show("Please select the serial port first","Error");
                return;
            }

            startButton.Enabled = false;
            stopButton.Enabled = true;
            saveButton.Enabled = false;
            openSerailPort();

        }

        private void openSerailPort()
        {
            try
            {
                serialPort.PortName = serialPortComBox.Text;
                serialPort.BaudRate = 38400;
                //serialPort.DataBits = 8;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);
                // serialPort.ReadTimeout = 5000;

                serialPort.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Serial Port open fail : " + e.ToString());             
            }      
        }

        void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            if (port.IsOpen && port.BytesToRead > 0)
            {
                port = (SerialPort)sender;
                Byte[] buffer = new Byte[32];
                Int32 length = port.Read(buffer, 0 ,buffer.Length);
          
                //Array.Resize(ref buffer, length);

                fCap = Convert.ToDouble(buffer[1] << 24 | buffer[0] << 16 | buffer[3] << 8 | buffer[2]);
                fCap /= 134217728;
                fSat = (1.32 * fCap * fCap) + (0.44 * fCap) - 19.17;

                s16AX = (Int16)(buffer[5] << 8 | buffer[4]);
                s16AY = (Int16)(buffer[7] << 8 | buffer[6]);
                s16AZ = (Int16)(buffer[9] << 8 | buffer[8]);
                s16GX = (Int16)(buffer[11] << 8 | buffer[10]);
                s16GY = (Int16)(buffer[13] << 8 | buffer[12]);
                s16GZ = (Int16)(buffer[15] << 8 | buffer[14]);
                
                fIncX = -0.0035 * (s16AX - s16AX0);
                fIncY = -0.0035 * (s16AY - s16AY0);

                String cSat = Convert.ToString(fSat);
                textBoxSat.Invoke(this.DelegateSat, cSat);

                String cCap = Convert.ToString(fCap);
                textBoxCap.Invoke(this.DelegateCap, cCap);

                String cIncX = Convert.ToString(fIncX);
                textBoxIncX.Invoke(this.DelegateIncX, cIncX);

                String cIncY = Convert.ToString(fIncY);
                textBoxIncY.Invoke(this.DelegateIncY, cIncY);

                String cTime = (DateTime.Now.ToString("MM-dd-yyyy,HH:mm:ss"));
                String cAX = Convert.ToString(s16AX);
                String cAY = Convert.ToString(s16AY);
                String cAZ = Convert.ToString(s16AZ);
                String cGX = Convert.ToString(s16GX);
                String cGY = Convert.ToString(s16GY);
                String cGZ = Convert.ToString(s16GZ);
                String cAX0 = Convert.ToString(s16AX0);
                String cAY0 = Convert.ToString(s16AY0);
                String cData = cTime + "," + cSat + "," + cCap + "," + cIncX + "," + cIncY + "," + cAX + "," + cAY + "," + cAZ + "," + cGX + "," + cGY + "," + cGZ + "," + cAX0 + "," + cAY0 + ";";
                String TextData = Convert.ToString(cData);

                textBoxAX.Invoke(this.DelegateAX, cAX);
                textBoxAY.Invoke(this.DelegateAY, cAY);
                textBoxAZ.Invoke(this.DelegateAZ, cAZ);
                textBoxGX.Invoke(this.DelegateGX, cGX);
                textBoxGY.Invoke(this.DelegateGY, cGY);
                textBoxGZ.Invoke(this.DelegateGZ, cGZ);
                textBoxTime.Invoke(this.DelegateTime, cTime);
                textBoxData.Invoke(this.DelegateData, cData);
                Console.WriteLine(cAX0);
              
            }
            Thread.Sleep(1000);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            startButton.Enabled = true;
            saveButton.Enabled = true;
        }

        private void buttonOffset_Click(object sender, EventArgs e)
        {
            s16AX0 = s16AX;
            s16AY0 = s16AY;
        }

        public void AddDataMethodCap(String StringCap)
        {
            textBoxCap.Text = StringCap;
        }
        public void AddDataMethodSat(String StringSat)
        {
            textBoxSat.Text = StringSat;
        }
        public void AddDataMethodIncX(String StringIncX)
        {
            textBoxIncX.Text = StringIncX;
        }
        public void AddDataMethodIncY(String StringIncY)
        {
            textBoxIncY.Text = StringIncY;
        }
        public void AddDataMethodAX(String StringAX)
        {
            textBoxAX.Text = StringAX;
        }
        public void AddDataMethodAY(String StringAY)
        {
            textBoxAY.Text = StringAY;
        }
        public void AddDataMethodAZ(String StringAZ)
        {
            textBoxAZ.Text = StringAZ;
        }        
        public void AddDataMethodGX(String StringGX)
        {
            textBoxGX.Text = StringGX;
        }
        public void AddDataMethodGY(String StringGY)
        {
            textBoxGY.Text = StringGY;
        }
        public void AddDataMethodGZ(String StringGZ)
        {
            textBoxGZ.Text = StringGZ;
        }
        public void AddDataMethodTime(String StringTime)
        {
            textBoxTime.Text = StringTime;
        }
        public void AddDataMethodData(String StringData)
        {
            textBoxData.AppendText(StringData + Environment.NewLine);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (textBoxData.TextLength > 0)
            {
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(textBoxData.Text);
                        sw.Close();
                    }
                }

                else if (File.Exists(filePath))
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(textBoxData.Text);
                    }
                }
                MessageBox.Show("Save successfully", "Note");
            }
            else
            {
                MessageBox.Show("No data to save", "Error");
                return;
            }
        }

        private void serialPortComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
