using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ModBus.Models;

namespace ModBus.Component
{
    public partial class SerialPanel : UserControl
    {
        private SerialPort _serialPort = new SerialPort();
        public int ReceiveDelay { get; set; }
        public SerialPanel()
        {
            InitializeComponent();
        }

        private void SerialPanel_Load(object sender, EventArgs e)
        {
            cmbPortNumber.DataSource = SerialPort.GetPortNames();
            cmbPortNumber.SelectedIndex = cmbPortNumber.Items.Count > 0 ? 0 : -1;

            cmbBaudRate.DataSource = new int[] { 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000 };
            cmbBaudRate.SelectedIndex = 3;

            cmbDataBit.DataSource = Enum.GetNames(typeof(DataBit));
            cmbDataBit.SelectedIndex = 3;

            cmbStopBit.DataSource = Enum.GetNames(typeof(StopBits));
            cmbStopBit.SelectedIndex = 1;

            cmbParity.DataSource = Enum.GetNames(typeof(Parity));
            cmbParity.SelectedIndex = 0;

            btnOpenOrClose.Text = SerialState.Open.ToString();
        }

        private void btnOpenOrClose_Click(object sender, EventArgs e)
        {
            var serialState = (SerialState)Enum.Parse(typeof(SerialState), btnOpenOrClose.Text);
            switch (serialState)
            {
                case SerialState.Open:
                    {
                        if (!_serialPort.IsOpen)
                        {
                            _serialPort.PortName = cmbPortNumber.SelectedItem.ToString();
                            _serialPort.BaudRate = Convert.ToInt32(cmbBaudRate.SelectedItem.ToString());
                            _serialPort.DataBits = Convert.ToInt32(cmbDataBit.SelectedItem.ToString());
                            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbDataBit.SelectedItem.ToString());
                            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.SelectedItem.ToString());

                            try
                            {
                                _serialPort.Open();
                                btnOpenOrClose.Text = SerialState.Close.ToString();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    break;
                case SerialState.Close:
                    {
                        if (_serialPort.IsOpen)
                        {
                            try
                            {
                                _serialPort.Close();
                                btnOpenOrClose.Text = SerialState.Open.ToString();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    break;
            }
        }
        public bool Write(string txt)
        {
            try
            {
                _serialPort.Write(txt);
                return true;
            }
            catch(Exception ex)
            {

            }
            return false;
        }
        public bool Write(byte[] bts)
        {
            try
            {
                _serialPort.Write(bts, 0, bts.Length);
                return true;
            }
            catch(Exception ex)
            {

            }
            return false;
        }
    }
}
