using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IES_ISO14443_Share
{
    /// <summary>
    /// 权限设置类
    /// </summary>
    public class Convent
    {
        #region 将十六进制转化为二进制

        /// <summary>
        /// 十六进制转化为二进制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String[] StringToBin(string str)
        {
            String result;
            Int32[] strs = new Int32[str.Length / 2];
            String[] test = new String[str.Length / 2];

            for (int i = 0; i < str.Length; i = i + 2)
            {
                result = str.Substring(i, 2);

                strs[i / 2] = Convert.ToInt32(result, 16);//转化成十进制
                test[i / 2] = Convert.ToString(strs[i / 2], 2);//十进制转化为二进制

                //如果转化的二进制不足八位，进行补位。
                switch (test[i / 2].Length)
                {
                    case 1:
                        test[i / 2] = "0000000" + test[i / 2];

                        break;
                    case 2:
                        test[i / 2] = "000000" + test[i / 2];
                        break;
                    case 3:
                        test[i / 2] = "00000" + test[i / 2];
                        break;
                    case 4:
                        test[i / 2] = "0000" + test[i / 2];
                        break;
                    case 5:
                        test[i / 2] = "000" + test[i / 2];
                        break;
                    case 6:
                        test[i / 2] = "00" + test[i / 2];
                        break;
                    case 7:
                        test[i / 2] = "0" + test[i / 2];
                        break;
                    default:
                        break;
                }
            }

            return test;
        }

        #endregion

        #region 将二进制转化为十六进制

        /// <summary>
        /// 将二进制转化为十六进制
        /// </summary>
        /// <param name="str">二进制数组</param>
        /// <returns></returns>
        public static string[] BinToString(string[] str)
        {
            string[] Result = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                //将二进制数值转化为十六进制值
                Result[i] = Convert.ToString(Convert.ToInt32(str[i], 2), 16);
                if (Result[i].Length == 1)
                {
                    Result[i] = "0" + Result[i];
                }
            }
            return Result;
        }

        #endregion

        #region 控制位取反

        /// <summary>
        /// 对控制位1进行全部取反
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SetControlBitA(string str)
        {
            int[] Data = new int[8];
            String S = "";

            for (int i = 0; i < str.Length; i++)
            {
                Data[i] = Convert.ToInt32(str.Substring(i, 1));

                if (Data[i] == 0)
                {
                    Data[i] = 1;
                }
                else
                {
                    Data[i] = 0;
                }
                S = S + Convert.ToString(Data[i]);
            }
            return S;
        }

        /// <summary>
        /// 对控制位2后面四位取反
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SetControlBitB(string str)
        {
            int[] Data = new int[8];
            String S = "";

            for (int i = 0; i < str.Length; i++)
            {
                Data[i] = Convert.ToInt32(str.Substring(i, 1));

                if (i >= 4)
                {

                    if (Data[i] == 0)
                    {
                        Data[i] = 1;
                    }
                    else
                    {
                        Data[i] = 0;
                    }
                }
                S = S + Convert.ToString(Data[i]);
            }
            return S;
        }

        #endregion

        #region 返回控制块区和数据块区的十六进制权限值

        /// <summary>
        /// 控制块区的权限
        /// </summary>
        /// <param name="str">取反后的字节数组</param>
        /// <param name="data">块</param>
        /// <param name="ca">命令</param>
        /// <returns></returns>
        public static string[] SetControl(string[] str, int data, char[] ca)
        {
            if (data == 0)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    char[] c = str[i].ToCharArray();
                    //将字符char型的值重新赋给二进制值
                    if (i == 0)
                    {
                        c[3] = ca[1];
                        c[7] = ca[0];
                    }
                    if (i == 1)
                    {
                        c[3] = ca[0];
                        c[7] = ca[2];
                    }
                    if (i == 2)
                    {
                        c[3] = ca[2];
                        c[7] = ca[1];
                    }
                    str[i] = new string(c);
                }

            }
            else if (data == 1)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    char[] c = str[i].ToCharArray();
                    //将字符char型的值重新赋给二进制值
                    if (i == 0)
                    {
                        c[2] = ca[1];
                        c[6] = ca[0];
                    }
                    if (i == 1)
                    {
                        c[2] = ca[0];
                        c[6] = ca[2];
                    }
                    if (i == 2)
                    {
                        c[2] = ca[2];
                        c[6] = ca[1];
                    }
                    str[i] = new string(c);
                }
            }
            else if (data == 2)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    char[] c = str[i].ToCharArray();
                    //将字符char型的值重新赋给二进制值
                    if (i == 0)
                    {
                        c[1] = ca[1];
                        c[5] = ca[0];
                    }
                    if (i == 1)
                    {
                        c[1] = ca[0];
                        c[5] = ca[2];
                    }
                    if (i == 2)
                    {
                        c[1] = ca[2];
                        c[5] = ca[1];
                    }
                    str[i] = new string(c);
                }
            }
            else
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    char[] c = str[i].ToCharArray();
                    //将字符char型的值重新赋给二进制值
                    if (i == 0)
                    {
                        c[0] = ca[1];
                        c[4] = ca[0];
                    }
                    if (i == 1)
                    {
                        c[0] = ca[0];
                        c[4] = ca[2];
                    }
                    if (i == 2)
                    {
                        c[0] = ca[2];
                        c[4] = ca[1];
                    }
                    str[i] = new string(c);
                }
            }

            return str;
        }

        #endregion

        #region 获取当前权限值

        /// <summary>
        /// 获取当前权限值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] GetPowerInfo(string[] str)
        {
            string[] Directive = new string[4];

            string s1 = "", s2 = "", s3 = "";

            for (int i = 0; i < 4; i++)
            {

                s2 = str[0].Substring(3 - i, 1);
                s1 = str[1].Substring(3 - i, 1);
                s3 = str[2].Substring(3 - i, 1);

                Directive[i] = s1 + s2 + s3;

            }

            return Directive;
        }

        /*
         *  C2Y    C23_b C22_b C21_b C20_b   C1Y   C13_b C12_b C11_b C10_b
         *  C1Y    C13   C12   C11   C10     C3Y   C33_b C32_b C31_b C30_b
         *  C3Y    C33   C32   C31   C30     C2Y   C23   C22   C21   C20
         *  将存取控制四个字节都转化为二进制
         *  将二进制的第一个字节全部取反
         *  将二进制的第二个字节后面四位取反
         *  根据数据块的值和命令返回新的二进制块的权限值
         *  重新将二进制的第一个字节全部取反
         *  将二进制的第二个字节后面四位取反
         *  重新将二进制转化为十六进制
        */

        #endregion

        #region 设置标签数据块和控制块的权限值
        /// <summary>
        /// 返回标签数据快和控制块权限值
        /// </summary>
        /// <param name="str">取反后的二进制值</param>
        /// <param name="data">块区</param>
        /// <param name="sText">命令</param>
        /// <returns>返回权限值表</returns>
        public static string[] SetData(int data, string sText)
        {
            string[] Result = null;

            if (sText == "000")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "KeyA|B", "KeyA|B", "Never", "KeyA|B", "KeyA|B", };
                }
                else
                {
                    Result = new string[] { "KeyA|B", "KeyA|B", "KeyA|B", "KeyA|B" };
                }
            }
            if (sText == "010")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "Never", "KeyA|B", "Never", "KeyA|B", "Never" };
                }
                else
                {
                    Result = new string[] { "KeyA|B", "Never", "Never", "Never" };
                }
            }
            if (sText == "100")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "KeyB", "KeyA|B", "Never", "Never", "KeyB" };
                }
                else
                {
                    Result = new string[] { "KeyA|B", "KeyB", "Never", "Never" };
                }
            }
            if (sText == "110")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "Never", "KeyA|B", "Never", "Never", "Never" };
                }
                else
                {
                    Result = new string[] { "KeyA|B", "KeyB", "KeyB", "KeyA|B" };
                }
            }
            if (sText == "001")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "KeyA|B", "KeyA|B", "KeyA|B", "KeyA|B", "KeyA|B" };
                }
                else
                {
                    Result = new string[] { "KeyA|B", "Never", "Never", "KeyA|B" };
                }
            }
            if (sText == "011")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "KeyB", "KeyA|B", "KeyB", "Never", "KeyB" };
                }
                else
                {
                    Result = new string[] { "KeyB", "KeyB", "Never", "Never" };
                }
            }
            if (sText == "101")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "Never", "KeyA|B", "KeyB", "Never", "Never" };
                }
                else
                {
                    Result = new string[] { "KeyB", "Never", "Never", "Never" };
                }
            }
            if (sText == "111")
            {
                if (data == 3)
                {
                    Result = new string[] { "Never", "Never", "KeyA|B", "Never", "Never", "Never" };
                }
                else
                {
                    Result = new string[] { "Never", "Never", "Never", "Never" };
                }
            }

            return Result;

        }
        #endregion

        #region 根据指令获取当前权限值
        /// <summary>
        /// 根据指令获取组成新控制权限
        /// </summary>
        /// <param name="Directive"></param>
        /// <returns></returns>
        public static string[] GetDirective(string[] Directive)
        {
            string[] BitControl = new string[4];
            string[] Bit = new string[6];

            //将各块区的指令转化为Char类型数组
            char[] C0 = Directive[0].ToCharArray();
            char[] C1 = Directive[1].ToCharArray();
            char[] C2 = Directive[2].ToCharArray();
            char[] C3 = Directive[3].ToCharArray();

            //根据规则 生成新的指令
            Bit[0] = C3[1].ToString() + C2[1].ToString() + C1[1].ToString() + C0[1].ToString();

            Bit[2] = C3[0].ToString() + C2[0].ToString() + C1[0].ToString() + C0[0].ToString();
            Bit[4] = C3[2].ToString() + C2[2].ToString() + C1[2].ToString() + C0[2].ToString();

            Bit[1] = Bit[2];
            Bit[3] = Bit[4];
            Bit[5] = Bit[0];

            BitControl[0] = Bit[0] + Bit[1];
            BitControl[1] = Bit[2] + Bit[3];
            BitControl[2] = Bit[4] + Bit[5];
            BitControl[3] = "01101001";

            return BitControl;
        }
        #endregion

    }
}
