using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Check
{
    /// <summary>
    /// 纵向冗余校验
    /// </summary>
    internal class LRC
    {
        /// <summary>
        /// 计算ModBus在ASCII传输模式下的LRC校验码
        /// (:01030000000A
        /// 内容相加：Ox01+Ox03+Ox00+Ox00+Ox00+Ox0A=Ox0E
        /// 结果取反：0000 1110 => 1111 0001（OxF1）
        /// 结果加1：OxF1+Ox01=OxF2)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToModBus(string input)
        {
            string result = string.Empty;
            input = input.Trim();
            //ASCII表示方式
            if (input.StartsWith(":"))
            {
                input = input.Substring(1);
                result = GetASCIILRC(input);
            }
            //十六进制表示方式
            else if (input.StartsWith("3A"))
            {
                var checkList = new List<int>();
                input = input.Substring(2);
                var hexAsciis = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var hex in hexAsciis)
                {
                    if (hex.Length > 2)
                    {

                    }
                    else
                    {
                        checkList.Add(Convert.ToInt32(hex, 16));
                    }
                }
            }
            return result;
        }
        static string GetASCIILRC(string ascii)
        {
            int li = 0;
            int ho = 0;
            //1.内容求和
            for (int i = 0; i < ascii.Length; i++)
            {
                //跳过分割字符（空格）
                if (char.IsWhiteSpace(ascii[i])) continue;

                //LI
                if (i % 2 == 0)
                {
                    li += ConvertHexCharToInt(ascii[i]);
                }
                //HO
                else
                {
                    ho += ConvertHexCharToInt(ascii[i]);
                }
            }
            //2.取反码值
            var liReverse = 15 - (li + ho / 16) % 16;
            var hoReverse = 15 - ho % 16;
            //3.结果加1
            hoReverse++;
            liReverse = (liReverse + hoReverse / 16) % 16;
            hoReverse = hoReverse % 16;
            return new string(new char[] { ConvertIntToHexChar(liReverse), ConvertIntToHexChar(hoReverse) });
        }
        /// <summary>
        /// 获取十六进制字符对应的十进制值
        /// ( 0 =>0 ...  A =>10)
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        static int ConvertHexCharToInt(char ch)
        {
            return char.IsNumber(ch) ? ch - 48 : char.ToUpper(ch) - 55;
        }
        static char ConvertIntToHexChar(int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException("value can't less than zero!");

            if (value > 9)
            {
                return (char)(value + 55);
            }
            else
            {
                return (char)(value + 48);
            }
        }
    }
}
