using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IES_ISO14443_Share
{
    /// <summary>
    /// 数值转化公用类
    /// </summary>
    public class Carry
    {
        /// <summary>
        /// 汉字转十六进制
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ChsToHex(string s)
        {
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                //throw new ArgumentException("s is not valid chinese string!");
            }

            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");

            byte[] bytes = chs.GetBytes(s);

            string str = "";

            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
            }

            if (str.Length <= 32)
            {
                int result = str.Length;
                for (int i = 0; i < 32 - result; i++)
                {
                    str = "0" + str;
                }
            }

            return str;
        }

        /// <summary>
        /// 十六进制转汉字
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string HexToChs(string hex)
        {
            if (hex == null)
                throw new ArgumentNullException("hex");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
                //throw new ArgumentException("hex is not a valid number!", "hex");
            }
            // 需要将 hex 转换成 byte 数组。
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                        System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    // Rethrow an exception with custom message.
                    throw new ArgumentException("hex is not a valid hex number!", "hex");
                }
            }

            // 获得 GB2312，Chinese Simplified。
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");


            return chs.GetString(bytes);
        }
    }
}
