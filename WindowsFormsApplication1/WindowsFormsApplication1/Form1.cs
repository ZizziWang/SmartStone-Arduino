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
    public partial class Form1 : Form
    {
        SerialPort serialPort = null;
        delegate void AddDataDelegate(String myString);
        AddDataDelegate myDelegate;
        String filePath = @"D:\Arduion file\arduino.txt";

        delegate void addLevel1(double number);
        addLevel1 level1;


        public Form1()
        {
            InitializeComponent();
            setInitForm();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            this.level1 = new addLevel1(AddLevel1);
        }

        private void AddLevel1(double number)
        {
            LabelSat.Text = Convert.ToString(number);
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
                MessageBox.Show("Please select the serial port first", "Error");
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

        unsafe void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Byte[] buffer = new Byte[1024];
            Int16 s16RfAck, s16CapMsb, s16CapLsb, s16Ax = 0, s16Ay = 0, s16Az = 0, s16Gx = 0, s16Gy = 0, s16Gz = 0;
            int s32Cap;
            double fCap, fSat, fIncX, fIncY;

            SerialPort port = (SerialPort)sender;
            if (port.IsOpen && port.BytesToRead > 0)
            {
                Int32 length = port.Read(buffer, 0, buffer.Length);
                Array.Resize(ref buffer, length);
                /*
                s16RfAck = (Int16)(buffer[0] << 8 | buffer[1]);
                s16CapMsb = (Int16)(buffer[2] << 8 | buffer[3]);
                s16CapLsb = (Int16)(buffer[4] << 8 | buffer[5]);
                s16Ax = (Int16)(buffer[6] << 8 | buffer[7]);
                s16Ay = (Int16)(buffer[8] << 8 | buffer[9]);
                s16Az = (Int16)(buffer[10] << 8 | buffer[11]);
                s16Gx = (Int16)(buffer[12] << 8 | buffer[13]);
                s16Gy = (Int16)(buffer[14] << 8 | buffer[15]);
                s16Gz = (Int16)(buffer[16] << 8 | buffer[17]);
                
                s32Cap = s16CapMsb << 16 | s16CapLsb;
                fCap = (double)s32Cap;
                fCap /= 134217728;
                fSat = 1.32 * fCap * fCap + 0.44 * fCap - 19.17;
                //LabelSat.Text = Convert.ToString(fSat);
                //LabelCap.Text = Convert.ToString(fCap);
                //LabelIncX.Text = Convert.ToString(fIncX);
                //LabelIncY.Text = Convert.ToString(fIncY);

                */


                String secondResult = System.Text.Encoding.UTF8.GetString(buffer);
                resultText.Invoke(this.myDelegate, secondResult);
                //LabelSat.Invoke(this.level1, fSat);


            }
            Thread.Sleep(1000);
        }



        private void stopButton_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            startButton.Enabled = true;
            saveButton.Enabled = true;
        }

        public void AddDataMethod(String myString)
        {
            resultText.AppendText(myString + Environment.NewLine);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (resultText.TextLength > 0)
            {
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(resultText.Text);
                        sw.Close();
                    }
                }

                else if (File.Exists(filePath))
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(resultText.Text);
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

        private void resultText_TextChanged(object sender, EventArgs e)
        {

        }

        private void serialPortComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabelCap_Click(object sender, EventArgs e)
        {

        }
    }
}
