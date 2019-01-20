using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IES_ISO14443_Share;
using CCWin;
namespace WindowsFormsApplication5
{
    public partial class UserControl2 : UserControl
    {
        public delegate void DelegatePowerAnalasys(string[] BlockControl);//定义委托，参数为块号字符串组
        public event DelegatePowerAnalasys EventPowerAnalasys;//定义事件
        private string CardID;
        private string SectionID;
        public UserControl2(string cardID,string sectionID)//从主体获取卡标签号，所选扇区号
        {
            InitializeComponent();
            this.CardID = cardID;
            this.SectionID = sectionID;
           
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void btnViewControl_Click(object sender, EventArgs e)
        { 
           string strBlockID=(Convert.ToInt32(SectionID) * 4 + 3).ToString();//通过扇区号求得块号
            try
            {
                if(ISO14443_Tag.KeyB(strBlockID,"BBBBBBBBBBBB",CardID)=="")//验证秘钥B
                {
                    
                    string strPower = ISO14443_Tag.ReadData(strBlockID);//读取控制权限所在的块数据
                    txtPower.Text = strPower.Substring(12, 8);//截取控制权限
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*private string[] HexToBin(string HexStr)
        {									
              string[] Binstrs = new string[4]; //用于存放转换后的四字节二进制串
              byte[] bytes = new byte[4];
              for (int i = 0; i < 4; i++)
            {
                bytes[i] = Convert.ToByte(HexStr.Substring(i * 2, 2), 16);
            }
              for (int i =  bytes.Length-1; i>=0; i--)
            {
               Binstrs[3-i] = Convert.ToString(bytes[i], 2);
               int len = Binstrs[3-i].Length;
               if (len< 8)
                {
                  for (int j = 0; j < 8 - len; j++)
                    {
                     Binstrs[3-i] = "0" + Binstrs[3-i];
                    }
                }
            }
                return Binstrs;
        }
        */
        /*
         * 定义一个函数，参数为字符串，可将字符串转为二进制
         */
private string[] HexToBin(string HexStr)   //ff078069
        {
             string[] Binstrs = new string[4]; //用于存放转换后的四字节二进制串
             Int32 Decdata = Convert.ToInt32(HexStr, 16);//将16进制串转为32位的整数
             byte[] bytes = BitConverter.GetBytes(Decdata);//将整型数据转换为字节数组,0下标存数据的低字节
             for (int i = 0; i <bytes.Length; i++)
            {
              Binstrs[i] = Convert.ToString(bytes[i], 2);
              int len = Binstrs[i].Length;
              if (len< 8)
                {
                for (int j = 0; j < 8 - len; j++)
                    {
                Binstrs[i] = "0" + Binstrs[i];
                    }
                }
            }
                return Binstrs;
        }
        
        private void btnHexToBin_Click(object sender, EventArgs e)
        {
           
            string[] Binstrs=HexToBin(txtPower.Text);//调用函数，送入txtpower文本框的值，再将得到的值送入四个文本框
            txtBinary9.Text = Binstrs[0];
            txtBinary8.Text = Binstrs[1];
            txtBinary7.Text = Binstrs[2];
            txtBinary6.Text = Binstrs[3];
        }
        /*
         * 参照表截取相应的值，送入到块0-块3的控制位
         */
        private void btnGetControlBit_Click(object sender, EventArgs e)
        {
            txtData0.Text = txtBinary7.Text.Substring(3, 1) + txtBinary8.Text.Substring(7, 1) + txtBinary8.Text.Substring(3, 1);
            txtData1.Text = txtBinary7.Text.Substring(2, 1) + txtBinary8.Text.Substring(6, 1) + txtBinary8.Text.Substring(2, 1);
            txtData2.Text = txtBinary7.Text.Substring(1, 1) + txtBinary8.Text.Substring(5, 1) + txtBinary8.Text.Substring(1, 1);
            txtData3.Text = txtBinary7.Text.Substring(0, 1) + txtBinary8.Text.Substring(4, 1) + txtBinary8.Text.Substring(0, 1);
        }
        /*
         * 分析权限
         */
        private void btnAnalasys_Click(object sender, EventArgs e)
        {
                string[] blockControl=new string[4];//定义一个字符串数组
                blockControl[0] = txtData0.Text.Trim();//将四个文本框的字符串存入数组
                blockControl[1] = txtData1.Text.Trim();
                blockControl[2] = txtData2.Text.Trim();
                blockControl[3] = txtData3.Text.Trim();
            if (EventPowerAnalasys != null)
            {
               
               // lstData.Items.Clear();
               // lstPower.Items.Clear();
                 EventPowerAnalasys(blockControl);//将用户窗体的字符串数组传送到主窗体
            }
           

        }
    }
}
