using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceSystem
{
    internal static class UIHelper
    {
        /// <summary>
        /// 获取文本框内容
        /// </summary>
        /// <param name="tx"></param>
        /// <returns>内容为空返回null</returns>
        public static string GetText(TextBox tx)
        {
            if (string.IsNullOrEmpty(tx.Text))
                return null;
            else
                return tx.Text.Trim();
        }
        /// <summary>
        /// 获取组合框选中项的索引
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="selected">选中项</param>
        /// <returns>选中项不存在返回-1</returns>
        public static int GetCombBoxSelectedIndex(ComboBox cmb, string selected)
        {
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if (cmb.Items[i].ToString() == selected)
                    return i;
            }

            return -1;
        }
        /// <summary>
        /// 提示弹窗
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        public static void ShowHint(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 错误弹窗
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        public static void ShowError(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 警告弹窗
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <returns>返回DialogResult.Yes或DialogResult.No</returns>
        public static DialogResult ShowWarning(string title, string content)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 解析枚举项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ParseEnumObject<T>(object obj) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), obj.ToString());
        }
        public static void Test2()
        {
            //新的修改
        }
    }
}
