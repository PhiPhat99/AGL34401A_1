using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agilent_34401A_Multimeter_Test
{
    public partial class Form1 : Form
    {
        bool meterRemoteStare = false;
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void AddDataDelegate(string Agilent34401A_Date);
        public AddDataDelegate myDelegate;

        public void AddDataMethod(string Data)
        {
            textBox1.AppendText("Received data - " + Data + "\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!meterRemoteStare)
            {
                meterRemoteStare = true;
                button1.Text = "LOCAL";
                button1.BackColor = Color.LightYellow;
                if (!(serialPort1.IsOpen)) 
                {
                    serialPort1.Open();
                    serialPort1.Write("SYST:REM\n");
                }
            }
            else
            {
                meterRemoteStare = false;
                button1.Text = "Remote";
                button1.BackColor = Color.Red;
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("SYST:LOC\n");
                    serialPort1.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("MEAS:VOLT:DC? 10\n");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String Data = serialPort1.ReadLine();
            textBox1.Invoke(this.myDelegate, new object[] { Data });
        }
    }
}
