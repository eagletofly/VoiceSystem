using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModBus.Tools;
using ModBus.Models;

namespace ModBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmCheck_Click(object sender, EventArgs e)
        {
            CheckTool ckTool = new CheckTool();
            ckTool.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSerialPattern.DataSource = Enum.GetNames(typeof(SerialPattern));
            cmbSerialPattern.SelectedIndex = 1;

            cmbFunctionCode.DataSource = Enum.GetNames(typeof(FunctionCode));
            cmbFunctionCode.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSlaveID.Text) || string.IsNullOrEmpty(txtStartAddress.Text) || string.IsNullOrEmpty(txtDataLength.Text))
            {
                MessageBox.Show("输入参数未填写完整！");
                txtSlaveID.Clear();
                return;
            }

            if (!int.TryParse(txtSlaveID.Text, out int s))
            {
                MessageBox.Show("从地址必须为整数！");
                txtSlaveID.Clear();
                return;
            }

            if (!int.TryParse(txtStartAddress.Text, out int s2))
            {
                MessageBox.Show("开始地址必须为整数！");
                txtStartAddress.Clear();
                return;
            }

            if (!int.TryParse(txtDataLength.Text, out int s3))
            {
                txtDataLength.Clear();
                MessageBox.Show("数据长度必须为整数！");
                return;
            }

            var serialPattern = (SerialPattern)Enum.Parse(typeof(SerialPattern), cmbSerialPattern.SelectedItem.ToString());
            switch (serialPattern)
            {
                case SerialPattern.ASCII:
                    {

                    }
                    break;
                case SerialPattern.RTU:
                    {

                    }
                    break;
            }
        }
    }
}
