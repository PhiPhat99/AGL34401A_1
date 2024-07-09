using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM34401A02
{
    public partial class Form1 : Form
    {

        Ivi.Visa.Interop.FormattedIO488 DMM;
        string DMM34401Aaddr = $"GPIB0::26::INSTR";
        public Form1()
        {
            InitializeComponent();
            Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
            DMM = new Ivi.Visa.Interop.FormattedIO488();

            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();
        }

        private void IOConnectBtn_Click(object sender, EventArgs e)
        {
            Ivi.Visa.Interop.ResourceManager mgr1;
            mgr1 = new Ivi.Visa.Interop.ResourceManager();

            if (DMM != null)
            {
                string DMM34401Aaddr = "GPIB::26::INSTR";
                DMM.IO = (Ivi.Visa.Interop.IMessage)mgr1.Open(DMM34401Aaddr);
                string command = "*IDN?";
                DMM.WriteString(command);

                string response = DMM.ReadString();

                MessageBox.Show("The device is connected.", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The device can not connect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IODisconnectBtn_Click(object sender, EventArgs e)
        {
            DMM.IO.Close();
            MessageBox.Show("The device is disconnected.", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
