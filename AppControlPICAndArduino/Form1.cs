using System;
using System.IO.Ports;

namespace AppControlPICAndArduino
{
    public partial class Form1 : Form
    {
        string selectPort;
        string selectBraudRate;
        bool isConnected;
        static int chartReceived = 0; 
        string[] ports;
        string[] listBraudRate = { "1200", "2400", "4800", "9600", "19200", "38400" };
        string[] listBoard = { "Arduino Mega", "PIC18F4550" };
        static string chooseBoard;
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
            // init list board
            typeBoard.Items.AddRange(listBoard);
            // default select COM
            selectCOM.SelectedItem = ports[0]; // first port
            typeBoard.SelectedItem = listBoard[0]; // Arduino Mega
            chooseBoard = listBoard[0];
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
                }
                return true;
            }
            catch (Exception) 
            {
                MessageBox.Show("Can't not open this serial!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("This serial is close!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(this.receiveDataBySerial);
            bool status = this.activeOpenSerial();
            if(status)
            {
                isConnected = true;
                selectCOM.Enabled = false;
                selectBraudrate.Enabled = false;
                btnConnect.Enabled = false;
                statusConnect.Text = "Connecting...";
                statusConnect.BackColor = System.Drawing.Color.LightGreen;
                statusConnect.ForeColor = System.Drawing.Color.Green;
            }
        }

        public void receiveDataBySerial(object sender, SerialDataReceivedEventArgs e)
        {
            
            Invoke(
                new MethodInvoker(
                    () => {
                        SerialPort sp = (SerialPort)sender;
                        console.Text += sp.ReadExisting();
                        chartReceived += 1;
                        this.numReceived.Text = chartReceived.ToString();
                    }
                )
            );

        }

        private void sendData_Click(object sender, EventArgs e)
        {
            if(isConnected)
            {
                if(permitData.Checked)
                {
                    _serialPort.Write(contentSend.Text);
                }
                else
                {
                    MessageBox.Show("You must be permit send data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("You must be connect Serial before send data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onLed_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if(chooseBoard == listBoard[0]) // arduino mega
                {
                    _serialPort.Write("@Lle_on&");
                }else if(chooseBoard == listBoard[1]) // pic18f4550
                {
                    _serialPort.Write("@le_on&");
                } 

            }
            else
            {
                MessageBox.Show("You must be connect Serial before send data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void offLed_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if(chooseBoard == listBoard[0]) // arduino mega
                {
                    _serialPort.Write("@Lle_of&");
                }else if(chooseBoard == listBoard[1]) // pic18f4550
                {
                    _serialPort.Write("@le_of&");
                } 
            }
            else
            {
                MessageBox.Show("You must be connect Serial before send data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            if(isConnected)
            {
                _serialPort.Close();
            }
            this.Close();
        }

        private void contentSend_textChanged(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            bool status = this.stopOpenSerial(); 
            if (status)
            {
                isConnected = false;
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
        
        private void permitData_CheckedChanged(object sender, EventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void console_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseBoard = (string)typeBoard.SelectedItem;
        }
    }
}