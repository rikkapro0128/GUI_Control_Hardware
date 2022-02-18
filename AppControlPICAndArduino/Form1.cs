using System;
using System.IO.Ports;

namespace AppControlPICAndArduino
{
    public partial class Form1 : Form
    {
        string selectPort;
        string selectBraudRate;
        string[] ports;
        string[] listBraudRate = { "1200", "2400", "4800", "9600", "19200", "38400" };
        static SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.initSerial();
        }

        public void initSerial()
        {
            // search all COM
            ports = SerialPort.GetPortNames();
            // init list COM
            selectCOM.Items.AddRange(ports);
            // init list COM
            selectBraudrate.Items.AddRange(listBraudRate);
            // default select COM
            selectCOM.SelectedItem = ports[0]; // first port
            selectBraudrate.SelectedItem = listBraudRate[3]; // 9600
            // config global variable
            selectPort = ports[0];
            selectBraudRate = listBraudRate[3]; // 9600
        }
        public bool activeOpenSerial()
        {
            try
            {
                // search all COM
                if (_serialPort.IsOpen)
                {
                    MessageBox.Show("Serial is connected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    _serialPort.Open();
                    MessageBox.Show("You is connected to port: " + selectPort + "\nBraudrate is: " + selectBraudRate, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception) 
            {
                MessageBox.Show("Can't not open this serial!");
                return false;
            }
            
        }

        public bool stopOpenSerial()
        {
            try
            {   
                if(_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    MessageBox.Show("You is disconnected to port: " + selectPort + "\nBraudrate is: " + selectBraudRate, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("This serial is close!");
                return false;
            }

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void statusConnect_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            // Allow the user to set the appropriate properties.
            _serialPort.PortName = selectPort;
            _serialPort.BaudRate = int.Parse(selectBraudRate);
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;

            bool status = this.activeOpenSerial();
            if(status)
            {
                selectCOM.Enabled = false;
                selectBraudrate.Enabled = false;
                btnConnect.Enabled = false;
                statusConnect.Text = "Connecting...";
                statusConnect.BackColor = System.Drawing.Color.LightGreen;
                statusConnect.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            bool status = this.stopOpenSerial(); 
            if (status)
            {
                selectCOM.Enabled = true;
                selectBraudrate.Enabled = true;
                btnConnect.Enabled = true;
                statusConnect.Text = "Disconnected!";
                statusConnect.BackColor = System.Drawing.Color.LightCoral;
                statusConnect.ForeColor = System.Drawing.Color.Firebrick;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void selectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_serialPort.Close();
            selectPort = (string)selectCOM.SelectedItem;
        }

        private void selectBraudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_serialPort.Close();
            selectBraudRate = (string)selectBraudrate.SelectedItem;
        }
    }
}