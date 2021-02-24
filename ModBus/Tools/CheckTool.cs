using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModBus.Check;

namespace ModBus.Tools
{
    public partial class CheckTool : Form
    {
        public CheckTool()
        {
            InitializeComponent();
        }

        private void CheckTool_Load(object sender, EventArgs e)
        {
            cmboxCheckPattern.DataSource = Enum.GetNames(typeof(CheckPattern));
            cmboxCheckPattern.SelectedIndex = cmboxCheckPattern.Items.Count > 0 ? 0 : -1;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            if (cmboxCheckPattern.SelectedItem != null && !string.IsNullOrEmpty(rtxtInput.Text))
            {
                string result = string.Empty;
                var input = rtxtInput.Text;
                var selectedPattern = (CheckPattern)Enum.Parse(typeof(CheckPattern), cmboxCheckPattern.SelectedItem.ToString());
                switch (selectedPattern)
                {
                    case CheckPattern.CRC:
                        {
                            result = CRC.ToModbusCRC16(input);
                        }
                        break;
                    case CheckPattern.LRC:
                        {
                            result = LRC.ToModBus(input);
                        }
                        break;
                    default:
                        break;
                }
                txtResult.Text = result;
            }
        }
    }
}
