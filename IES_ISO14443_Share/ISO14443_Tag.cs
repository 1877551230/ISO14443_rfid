using KV_ISO14443;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using IES_ISO14443_Share;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IES_ISO14443_Share
{
    /// <summary>
    /// ISO14443读写器公用方法类
    /// </summary>
    public class ISO14443_Tag
    {
        #region 变量

        //判断串口是否打开
        public static bool Is_Port = false;
        
        //判断是否已经寻卡
        public static bool Is_Find = false;

        //判断是否已经选卡
        public static bool Is_Select = false;

        //判断是否要制卡
        public static bool Is_Tag = true;

        //判断Combobox控件(扇区)是否已经加载
        public static bool Is_Section = false;

        //判断块区是否已经加载
        public static bool Is_Lump = false;
        /// <summary>
        /// 制卡完成标记
        /// </summary>
        public static bool Tag_OK = false;

        /// <summary>
        /// 状态
        /// </summary>
        public static string Status = "";

        /// <summary>
        /// A密钥
        /// </summary>
        public static string Key_A = "";

        /// <summary>
        /// B密钥
        /// </summary>
        public static string Key_B = "";

        /// <summary>
        /// 0为验证A密钥，1为验证B密钥
        /// </summary>
        public static int Key_A_B;

        /// <summary>
        /// 卡片验证的完成状态 0为未完成，1为完成;
        /// </summary>
        public static byte[] TestTag_Status = new byte[4] { 0, 0, 0, 0 };

        /// <summary>
        /// 标签号
        /// </summary>
        public static string Tag = "";
        /// <summary>
        /// 扇区
        /// </summary>
        public static string Senction = "";

        /// <summary>
        /// 块区
        /// </summary>
        public static string Lump = "";

        /// <summary>
        /// 控制块的十六进制数据值
        /// </summary>
        public static string Control_Hex_Data = "";

        /// <summary>
        /// 扇区控制块的地址
        /// </summary>
        public static string Senction_Control_Address = "";

        /// <summary>
        /// 控制块的权限值
        /// </summary>
        public static string Control_Power_Data = "";

        /// <summary>
        /// 存放控制块权限值二进制
        /// </summary>
        public static String[] Control_Data_Bit = new string[4];

        /// <summary>
        /// 存放控制块权限值指令集
        /// </summary>
        public static String[] Directive = new string[4] { "000", "000", "000", "001" };

        /// <summary>
        /// 存放选择控制块指令集
        /// </summary>
        public static String[] State_Directive = new string[4] { "000", "000", "000", "001" };

        /// <summary>
        /// 某个块区的指令
        /// </summary>
        public static string Str_Directive = "";
        
        /// <summary>
        /// 判断一些用户控件是否第一次加载
        /// </summary>
        public static bool isLoadTag = true;
        public static bool isLoadStep = true;

        #endregion

        #region 串口操作

        /// <summary>
        /// 打开高频14443读写器串口
        /// </summary>
        /// <param name="ports"></param>
        /// <returns></returns>
        public static string OpenPorts(string ports)
        {
            //打开串口
            if (FR102.OpenSerialPort(ports) == 0x00)
            {
                //检测连接的串口
                if (FR102.TestReader() == FR102.StatusCode.AllDone)
                {
                    //启动设备
                    if (FR102.RestartReader() == FR102.StatusCode.AllDone)
                    {
                        //设置波特率
                        if (FR102.ChangeBaudRate(9600) == 0x00)
                        {
                            return "";
                        }
                        else
                        {
                            throw new Exception("波特率设置失败");
                        }
                    }
                    else
                    {
                        throw new Exception("设备启动失败");

                    }
                }
                else
                {
                    throw new Exception("没有检测到连接到的串口");

                }
            }
            else
            {
                throw new Exception("串口打开失败");
            }
        }

        /// <summary>
        /// 关闭高频14443读写器串口
        /// </summary>
        /// <returns></returns>
        public static string ClosePorts()
        {
            if (FR102.CloseSerialPort() == FR102.StatusCode.AllDone)
            {
                return "串口关闭成功";
            }
            else
            {
                return "串口关闭失败";
            }
        }

        #endregion

        #region 读卡方法

        /// <summary>
        /// 读卡方法
        /// </summary>
        /// <returns></returns>
        public static string ReadTag()
        {
            string Tag = "";

            Byte[] data;
            //请求所有标签
            FR102.StatusCode ec = FR102.PcdRequest(0x52, out data);
            if (ec == FR102.StatusCode.AllDone)
            {
                Byte[] TagNumber;
                //寻卡
                FR102.StatusCode sc = FR102.PcdAnticoll2(out TagNumber);

                if (sc == FR102.StatusCode.AllDone)
                {
                    Tag = Converter.ArrayToHexStr(TagNumber);

                    return Tag;
                }
                else if (sc == FR102.StatusCode.NoTagErr)
                {
                    throw new Exception("读写器天线场区内无标签" + sc.ToString());

                }
                else
                {
                    throw new Exception("失败原因不详：" + sc.ToString());
                }
            }
            else
            {
                throw new Exception("请求标签失败" + ec.ToString());
            }
        }

        /// <summary>
        /// 选择标签
        /// </summary>
        /// <param name="strTag"></param>
        /// <returns></returns>
        public static bool TagSelect(string strTag)
        {
            Byte[] TagNumber = Converter.HexStrToArray(strTag);

            FR102.StatusCode ec = FR102.PcdSelect(TagNumber);
            if (ec == FR102.StatusCode.AllDone)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region 验证密钥

        /// <summary>
        /// 验证A密钥
        /// </summary>
        /// <param name="Lump">块地址</param>
        /// <param name="KeyA">密钥A</param>
        /// <param name="Tag">标签号</param>
        /// <returns></returns>
        public static string KeyA(string Lump, string KeyA, string Tag)
        {
            //块地址的值
            Byte addr;
            try
            {
                addr = Byte.Parse(Lump);
            }
            catch
            {
                throw new Exception("你填写的块地址无效");
            }

            //密钥A的值
            Byte[] KeyAData;
            try
            {
                KeyAData = Converter.HexStrToArray(KeyA);
            }
            catch
            {
                throw new Exception("你填写的密码A无效，请确保数据都是十六进制的");
            }
            if (KeyAData.Length != 6)
            {
                throw new Exception("你填写的密钥A无效，必须是12位十六进制数据");
            }

            //标签号
            Byte[] TagNumber;
            try
            {
                TagNumber = Converter.HexStrToArray(Tag);
            }
            catch
            {
                throw new Exception("卡号无效，请先寻卡");
            }
            if (TagNumber.Length != 4)
            {
                throw new Exception("卡号无效,请先寻卡");
            }

            //验证A密钥
            FR102.StatusCode ec = FR102.PcdAuthState(0x60, addr, KeyAData, TagNumber);
            if (ec == FR102.StatusCode.AllDone)
            {
                return "";
            }
            else
            {
                throw new Exception("验证A密钥失败");
            }
        }

        /// <summary>
        /// 验证B密钥
        /// </summary>
        /// <param name="Lump">块地址</param>
        /// <param name="KeyB">密钥A</param>
        /// <param name="Tag">标签号</param>
        /// <returns></returns>
        public static string KeyB(string Lump, string KeyB, string Tag)
        {
            //块地址的值
            Byte addr;
            try
            {
                addr = Byte.Parse(Lump);
            }
            catch
            {
                throw new Exception("你填写的块地址无效");
            }

            //密钥B的值
            Byte[] KeyBData;
            try
            {
                KeyBData = Converter.HexStrToArray(KeyB);
            }
            catch
            {
                throw new Exception("你填写的密码B无效，请确保数据都是十六进制的");
            }
            if (KeyBData.Length != 6)
            {
                throw new Exception("你填写的密钥B无效，必须是12位十六进制数据");
            }

            //标签号
            Byte[] TagNumber;
            try
            {
                TagNumber = Converter.HexStrToArray(Tag);
            }
            catch
            {
                throw new Exception("卡号无效，请先寻卡");
            }
            if (TagNumber.Length != 4)
            {
                throw new Exception("卡号无效，请重新寻卡");
            }

            //验证B密钥
            FR102.StatusCode ec = FR102.PcdAuthState(0x61, addr, KeyBData, TagNumber);
            if (ec == FR102.StatusCode.AllDone)
            {
                return "";
            }
            else
            {
                throw new Exception("验证B密钥失败");
            }
        }

        #endregion

        #region 修改密钥

        
        /// <summary>
        /// 修改密钥
        /// </summary>
        /// <param name="KeyA">密钥A</param>
        /// <param name="KeyB">密钥B</param>
        /// <param name="Control">控制权限</param>
        /// <param name="Lump">块地址</param>
        /// <returns></returns>
        public static string WriteKey(string KeyA, string KeyB, string Control, string Lump_Address)
        {
            //块地址
            Byte addr;
            try
            {
                addr = Byte.Parse(Lump_Address);
            }
            catch
            {
                throw new Exception("你填写的块地址无效");
            }

            //修改密钥
            Byte[] Data;
            try
            {
                Data = Converter.HexStrToArray(KeyA + Control + KeyB);
            }
            catch
            {
                throw new Exception("填写的密钥必须为十六进制，且有12位");
            }
            if (Data.Length != 16)
            {
                throw new Exception("填写的数据必须保证为十六进制，且有16位");
            }

            //修改密钥
            FR102.StatusCode ec = FR102.PcdWrite(addr, Data);
            if (ec == FR102.StatusCode.AllDone)
            {
                return "";
            }
            else
            {
                throw new Exception("修改失败" + ec.ToString());

            }
        }
        #endregion

        #region 读取数据

        /// <summary>
        /// 读取块数据
        /// </summary>
        /// <param name="Lump">块地址</param>
        /// <returns></returns>
        public static string ReadData(string Lump_Address)
        {
            Byte addr = 0;
            String Data = "";
            try
            {
                addr = byte.Parse(Lump_Address);
                if (addr < 0)
                {
                    throw new Exception();
                }
            }
            catch { }

            Byte[] dataRead;
            FR102.StatusCode ec = FR102.PcdRead(addr, out dataRead);

            if (ec == FR102.StatusCode.AllDone)
            {
                Data = Converter.ArrayToHexStr(dataRead);
                return Data;
            }
            else
            {
                throw new Exception("读取" + Lump_Address + "块失败，你可能没有读取权限");
            }
        }

        /// <summary>
        /// 写入块数据
        /// </summary>
        /// <param name="Lump_Address"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static string WriteData(string Lump_Address, string Data)
        {
            Byte addr = 0;
            try
            {
                addr = byte.Parse(Lump_Address);
                if (addr < 0)
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Byte[] dataWrite;
            try
            {
                dataWrite = Converter.HexStrToArray(Data);
            }
            catch
            {
                throw new Exception("你所填的数据无效");
            }

            FR102.StatusCode ec = FR102.PcdWrite(addr, dataWrite);
            if (ec == FR102.StatusCode.AllDone)
            {
                return "";
            }
            else
            {
                throw new Exception("写入失败，你填写数据错误或者没有权限");
            }
        }

        #endregion

        #region 充值与扣款

        /// <summary>
        /// 充值与消费
        /// </summary>
        /// <param name="Lump_Address"></param>
        /// <param name="Money"></param>
        /// <param name="isInc"></param>
        /// <returns></returns>
        public static string IncDec(string Lump_Address, string Money, bool isInc)
        {
            //块区
            Byte addr;
            try
            {
                addr = Byte.Parse(Lump_Address);
            }
            catch
            {
                throw new Exception("填写的块地址无效");
            }

            //金额转化
            Int32 Value;
            try
            {
                Value = Int32.Parse(Money);
            }
            catch
            {
                throw new Exception("填写金额无效，请填写数字");
            }

            if (isInc)
            {
                //充值
                FR102.StatusCode ec = FR102.PcdIncrease(addr, Value);
                if (ec == FR102.StatusCode.AllDone)
                {
                    return "";
                }
                else
                {
                    throw new Exception("加值失败，你可能没有加值权限");
                }
            }
            else
            {
                //消费
                FR102.StatusCode ec = FR102.PcdDecrease(addr, Value);
                if (ec == FR102.StatusCode.AllDone)
                {
                    return "";
                }
                else
                {
                    throw new Exception("减值失败，你可能没有减值权限");
                }
            }
        }

        #endregion

        #region 初始化钱包和读取钱包

        /// <summary>
        /// 初始化钱包
        /// </summary>
        /// <param name="Lump">块区</param>
        /// <returns></returns>
        public static string IntPurse(string Lump)
        {
            Byte addr;
            try
            {
                addr = Byte.Parse(Lump);
            }
            catch
            {
                throw new Exception("填写的块地址无效");
            }
            //初始化钱包
            FR102.StatusCode ec = FR102.PcdIntPurse(addr);
            if (ec == FR102.StatusCode.AllDone)
            {
                return "";
            }
            else
            {
                throw new Exception("初始化钱包失败，原因可能是您没有写入权限");
            }
        }

        /// <summary>
        /// 读取钱包的值
        /// </summary>
        /// <param name="Lump_Address"></param>
        /// <returns></returns>
        public static string ReadPurse(string Lump_Address)
        {
            Byte addr;
            try
            {
                addr = Byte.Parse(Lump_Address);
            }
            catch
            {
                throw new Exception("填写的块地址无效");
            }
            //读取钱包中的值
            Int32 Value;
            FR102.StatusCode ec = FR102.PcdReadPurse(addr, out Value);

            if (ec == FR102.StatusCode.AllDone)
            {
                return Value.ToString();
            }
            else
            {
                throw new Exception("读取钱包失败");
            }
        }

        #endregion

        #region 读取该扇区的控制位的权限值

        /// <summary>
        /// 读取该扇区的控制位的权限值
        /// </summary>
        /// <param name="strSection">扇区</param>
        /// <returns>返回权限值</returns>
        public static void ControlData(string Section)
        {
            //计算该扇区的第4块控制位地址
            Senction_Control_Address = (Convert.ToInt16(Section) * 4 + 3).ToString();
            //读取该扇区控制位的数据值
            try
            {
                Control_Hex_Data = ReadData(Senction_Control_Address);
                //获取A密钥
                Key_A = Control_Hex_Data.Substring(0, 12);
                //获取存取控制
                Control_Power_Data = Control_Hex_Data.Substring(12, 8);
                //获取B密钥
                Key_B = Control_Hex_Data.Substring(20, 12);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        #endregion

        #region 设置新的权限

        /// <summary>
        /// 根据块区和指令设置新的权限
        /// </summary>
        /// <param name="Directive">指令</param>
        /// <param name="Lump">块区</param>
        public static void Power(string Directive, string strLump)
        {
            //获取存取控制四个字节的二进制数据
            Control_Data_Bit = Convent.StringToBin(Control_Power_Data);

            for (int i = 0; i < Control_Data_Bit.Length; i++)
            {
                if (i == 0)
                {
                    //对第一个字节的二进制数值进行全部取反
                    Control_Data_Bit[i] = Convent.SetControlBitA(Control_Data_Bit[i]);
                }
                if (i == 1)
                {
                    //对第二个字节的二进制后四位进行取反
                    Control_Data_Bit[i] = Convent.SetControlBitB(Control_Data_Bit[i]);
                }
            }

            //将String类型转化为char类型
            char[] c = Directive.ToCharArray();
            int Lump = int.Parse(strLump);

            //根据指令和块区设置新的权限值
            String[] NewData = Convent.SetControl(Control_Data_Bit, Lump, c);
            //获取该指令，该扇区的权限值
            String[] SetData = Convent.SetData(Lump, Directive);

            //对新的权限二进制进行规制取反
            for (int i = 0; i < NewData.Length; i++)
            {
                if (i == 0)
                {
                    NewData[i] = Convent.SetControlBitA(NewData[i]);
                }
                if (i == 1)
                {
                    NewData[i] = Convent.SetControlBitB(NewData[i]);
                }
            }

            //将取反后的二进制转化为十六进制
            string[] NewDataStr = Convent.BinToString(NewData);
            Control_Power_Data = "";
            foreach (String S in NewDataStr)
            {
                Control_Power_Data += S;
            }
            //将小写转化为大写
            Control_Power_Data = Control_Power_Data.ToUpper();
        }

        #endregion 

        #region 获取指令
        /// <summary>
        /// 获取指令集
        /// </summary>
        public static void SetDirective()
        {
            //将权限值由十六进制转化为二进制
            Control_Data_Bit = Convent.StringToBin(ISO14443_Tag.Control_Power_Data);

            //将BitControl数组里面的值规则进行取反
            Control_Data_Bit[0] = Convent.SetControlBitA(Control_Data_Bit[0]);
            Control_Data_Bit[1] = Convent.SetControlBitB(Control_Data_Bit[1]);

            //获取当前权限的指令集
            Directive = Convent.GetPowerInfo(Control_Data_Bit);
        }
        #endregion
    }
}
