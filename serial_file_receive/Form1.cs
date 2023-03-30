using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial_file_receive
{
    public partial class Form1 : Form
    {
        private bool receiving = false;
        private int bytes_received = 0;
        private MemoryStream memoryStream;
        private static List<KeyValuePair<string, string>> listPorts1 = new List<KeyValuePair<string, string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabelFilename_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = saveFileDialog1.FileName;
            }
        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            //TODO if disconnected... terminate & kill file
            if (receiving)
            {
                receiving = false;

                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                if (bytes_received > 0)
                {
                    try
                    {
                        string filename = textBoxFile.Text;
                        FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        memoryStream.WriteTo(file);
                        file.Close();

                        MessageBox.Show("File saved:  " + filename, "File saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No data to save", "No data received", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                try
                {
                    bytes_received = 0;
                    memoryStream = new MemoryStream();

                    // try to start receiving... 
                    string filename = textBoxFile.Text;
                    if (string.IsNullOrEmpty(filename))
                    {
                        textBoxFile.Focus();
                        return;
                    }

                    // 2) try to open serial port
                    string connection_port = comboBoxComPort1.SelectedValue.ToString();
                    string connection_speed = Utils.getComboBoxText(comboBoxBitsPerSecond);
                    string connection_databits = Utils.getComboBoxText(comboBoxDataBits);
                    string connection_parity = Utils.getComboBoxText(comboBoxParity);
                    string connection_stopbits = Utils.getComboBoxText(comboBoxStopBits);
                    string connection_flowcontrol = Utils.getComboBoxText(comboBoxFlowControl);

                    if (string.IsNullOrEmpty(connection_port))
                    {
                        comboBoxComPort1.Focus();
                        return;
                    }

                    if (!Utils.IsNumeric(connection_speed))
                    {
                        comboBoxBitsPerSecond.Focus();
                        comboBoxBitsPerSecond.SelectAll();
                        return;
                    }

                    int _baudrate = 57600;
                    int.TryParse(connection_speed, out _baudrate);

                    int _databits = 8;
                    int.TryParse(connection_databits, out _databits);

                    Parity _parity;
                    switch (connection_parity)
                    {
                        case "Even":
                            _parity = Parity.Even;
                            break;
                        case "Mark":
                            _parity = Parity.Mark;
                            break;

                        case "Odd":
                            _parity = Parity.Odd;
                            break;
                        case "Space":
                            _parity = Parity.Space;
                            break;
                        case "None":
                        // fall through
                        default:
                            _parity = Parity.None;
                            break;

                    }

                    Handshake _handshake;
                    switch (connection_flowcontrol.ToLower())
                    {
                        case "none":
                            _handshake = Handshake.None;
                            break;
                        case "hardware":
                            _handshake = Handshake.RequestToSend;
                            break;
                        case "both":
                            _handshake = Handshake.RequestToSendXOnXOff;
                            break;
                        default:
                            _handshake = Handshake.XOnXOff;
                            break;
                    }

                    StopBits _stopbits;
                    switch (connection_stopbits)
                    {
                        case "1":
                            _stopbits = StopBits.One;
                            break;
                        case "2":
                            _stopbits = StopBits.Two;
                            break;

                        case "1.5":
                            _stopbits = StopBits.OnePointFive;
                            break;
                        default:
                            _stopbits = StopBits.None;
                            break;
                    }

                    serialPort1.PortName = connection_port;
                    serialPort1.BaudRate = _baudrate;
                    serialPort1.Parity = _parity;
                    serialPort1.DataBits = _databits;
                    serialPort1.StopBits = _stopbits;
                    serialPort1.Handshake = _handshake;
                    serialPort1.Open();

                    receiving = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error opening serial port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (receiving && !serialPort1.IsOpen)
            {
                receiving = false;
                // TODO: did the connection die?  handle more stuff?
            }

            buttonReceive.Text = receiving ? "&Stop Receiving" : "&Start Receiving";
            labelBytesReceived.Text = bytes_received.ToString();
            textBoxFile.Enabled = !receiving;
            comboBoxBitsPerSecond.Enabled = !receiving;
            comboBoxComPort1.Enabled = !receiving;
            comboBoxDataBits.Enabled = !receiving;
            comboBoxFlowControl.Enabled = !receiving;
            comboBoxParity.Enabled = !receiving;
            comboBoxStopBits.Enabled = !receiving;

            this.Text = serialPort1.IsOpen ? Application.ProductName + " - " + serialPort1.PortName + ":" + serialPort1.BaudRate.ToString() : Application.ProductName + " - disconnected";

        }

        public void ThreadSafeDelegate(MethodInvoker method)
        {
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!receiving)
                return;

            try
            {
                SerialPort sp = (SerialPort)sender;
                int byteLength = sp.BytesToRead;

                byte[] buffer = new byte[byteLength];
                int zz = sp.Read(buffer, 0, byteLength);
                bytes_received += byteLength;
                memoryStream.Write(buffer, 0, byteLength);
                
                //ThreadSafeDelegate(delegate
                //{
                //    labelBytesReceived.Text = bytes_received.ToString();
                //});

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;

            LoadPortsList();

            comboBoxComPort1.DataSource = listPorts1;
            comboBoxComPort1.ValueMember = "Key";
            comboBoxComPort1.DisplayMember = "Value";

            comboBoxBitsPerSecond.SelectedItem = "115200";
            comboBoxDataBits.SelectedItem = "8";
            comboBoxParity.SelectedItem = "None";
            comboBoxStopBits.SelectedItem = "1";
            comboBoxFlowControl.SelectedItem = "None";

            refresh_port_options();
        }

        private void LoadPortsList()
        {
            listPorts1.Clear();
            string str_query_pnp = "Select * from Win32_PnPEntity Where Name LIKE '% (COM%)'";

            listPorts1.Add(new KeyValuePair<string, string>("", ""));

            try
            {

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(str_query_pnp);
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject item in collection)
                {
                    string fn = item.Properties["Name"].Value.ToString();
                    string strPattern = @"^(?<porttext>.*?)\((?<portname>COM[\d]+)\)$";
                    Match m = Regex.Match(fn, strPattern);

                    if (m.Success)
                    {
                        string portname = m.Groups["portname"].Value.ToString();
                        string porttext = m.Groups["porttext"].Value.ToString();
                        listPorts1.Add(new KeyValuePair<string, string>(portname, portname.PadRight(6, ' ') + porttext));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get serial port list!", "Serial Ports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Also search Win32_SerialPort for any not found
            string str_query_serialport = "Select * from Win32_SerialPort";

            try
            {

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(str_query_serialport);
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject item in collection)
                {
                    string portname = item.Properties["DeviceID"].Value.ToString();
                    string porttext = item.Properties["Name"].Value.ToString();

                    KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(portname, portname.PadRight(6, ' ') + porttext);

                    var pair = listPorts1.FirstOrDefault(x => x.Key == portname);

                    if (pair.Key == null)
                    {
                        Console.WriteLine("Missing:  {0}", portname);
                        listPorts1.Add(kvp);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get serial port list!", "Serial Ports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void refresh_port_options()
        {
            Console.WriteLine("REFRESH!");
            comboBoxComPort1.DataSource = listPorts1;
            int selectedindex = 0;
            //for (int i = 0; i < listPorts1.Count; i++)
            //{
            //    if (listPorts1[i].Key == last_port)
            //    {
            //        selectedindex = i;
            //        break;
            //    }
            //}
            comboBoxComPort1.SelectedIndex = selectedindex;
        }

    }
}
