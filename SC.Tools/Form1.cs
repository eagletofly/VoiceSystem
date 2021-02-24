using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC.Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var obj1 = ParseValue("3.5");
            var obj2 = ParseValue("-34");
            var obj3 = ParseValue("false");

            var flag1 = obj1 == obj2;
            var flag2 = obj1 == obj3;
            var flag3 = obj2 == obj3;
            var flag4 = obj1 == (object)3.5;
        }
        object ParseValue(string value)
        {
            if (bool.TryParse(value, out bool boolData))
            {
                return boolData;
            }
            else if (int.TryParse(value, out int intData))
            {
                return intData;
            }
            else if (float.TryParse(value, out float floatData))
            {
                return floatData;
            }

            return null;
        }
        private void Calcbutton_Click(object sender, EventArgs e)
        {
            UnSignedDectextBox.Clear();
            SignedDectextBox.Clear();

            var hex = HextextBox.Text;
            if (string.IsNullOrEmpty(hex))
            {
                MessageBox.Show("输入字符不可为空！");
            }
            else if (!CheckData(hex))
            {
                MessageBox.Show("输入字符中存在非法字符！");
            }
            else
            {
                var hexList = new List<string>();
                var hexArray = hex.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (hexArray.Length == 1)
                {
                    hexList.AddRange(GetHexArray(hex));
                }
                else
                {
                    hexList.AddRange(hexArray.SelectMany(a => GetHexArray(a)));
                }

                var bts = hexList.Select(h => Convert.ToByte(h, 16));

                if (bts.Count() > 8)
                {
                    MessageBox.Show("超出最大计算值！");
                }
                else
                {
                    //数据反转
                    if (!LowerFirstcheckBox.Checked) bts = bts.Reverse();

                    UnSignedDectextBox.Text = ParseUnsigned(bts.ToList()).ToString();
                    //SignedDectextBox.Text = ParseSigned(bts.ToList());
                    SignedDectextBox.Text = ParseSigned(bts.ToList()).ToString();
                }
            }
        }
        string[] GetHexArray(string hex)
        {
            if (hex.Length <= 2)
            {
                return new string[] { hex };
            }
            else
            {
                var hexList = new List<string>();

                var len = hex.Length / 2;
                var remain = hex.Length % 2;

                for (int i = 0; i < len; i++)
                {
                    hexList.Add(hex.Substring(i * 2, 2));
                }

                //添加单字符数据
                if (remain != 0)
                {
                    hexList.Add(hex[hex.Length - 1].ToString());
                }

                return hexList.ToArray();
            }
        }
        bool CheckData(string hex)
        {
            bool flag = true;
            foreach (var ch in hex)
            {
                flag &= Regex.IsMatch(ch.ToString(), "[0-9a-fA-F]") || char.IsWhiteSpace(ch);
                //flag &= char.IsDigit(ch) || (char.IsLetter(ch) && (char.ToUpper(ch) >= 'A' && char.ToUpper(ch) <= 'F'));
            }
            return flag;
        }
        ulong ParseUnsigned(List<byte> bts)
        {
            int count = bts.Count;
            //不足的前面添零
            for (int i = 0; i < 8 - count; i++)
            {
                bts.Add(0x00);
            }

            return BitConverter.ToUInt64(bts.ToArray(), 0);
        }
        //Int16 ParseSigned(List<byte> bts)
        //{
        //    int count = bts.Count;
        //    //不足的前面添零
        //    for (int i = 0; i < 4 - count; i++)
        //    {
        //        bts.Add(0x00);
        //    }

        //    return BitConverter.ToInt16(bts.ToArray(), 0);
        //}
        string ParseSigned(List<byte> bts)
        {
            var leading = bts.Last();
            var firstBit = (leading & 0x80) >> 7;
            //负数
            if (firstBit == 1)
            {
                var sum = 0L;
                var count = 0;
                foreach (var bt in bts)
                {
                    sum += (long)bt << (8 * count);
                    count++;
                }

                //总数减1然后取反相加
                var reverse = BitConverter.GetBytes(sum - 1);
                sum = 0;
                count = 0;

                //剔除多余数据
                for (int i = 0; i < bts.Count; i++)
                {
                    sum += ((byte)~reverse[i]) << (8 * count);
                    count++;
                }

                return "-" + sum;
            }
            else
            {
                return ParseUnsigned(bts).ToString();
            }
        }
    }
}
