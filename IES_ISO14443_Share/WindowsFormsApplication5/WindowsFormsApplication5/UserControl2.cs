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

namespace WindowsFormsApplication5
{
    public partial class UserControl2 : UserControl
    {
        public delegate void DelegatePowerAnalasys(string[] BlockControl);
        public event DelegatePowerAnalasys EventPowerAnalasys;
        private string CardID;
        private string SectionID;
        public UserControl2(string cardID,string sectionID)
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
           string strBlockID=(Convert.ToInt32(SectionID) * 4 + 3).ToString();
            try
            {
                if(ISO14443_Tag.KeyB(strBlockID,"BBBBBBBBBBBB",CardID)=="")
                {
                    MessageBox.Show("密钥B验证成功！");
                    string strPower = ISO14443_Tag.ReadData(strBlockID);
                    txtPower.Text = strPower.Substring(12, 8);
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
           
            string[] Binstrs=HexToBin(txtPower.Text);
            txtBinary9.Text = Binstrs[0];
            txtBinary8.Text = Binstrs[1];
            txtBinary7.Text = Binstrs[2];
            txtBinary6.Text = Binstrs[3];
        }

        private void btnGetControlBit_Click(object sender, EventArgs e)
        {
            txtData0.Text = txtBinary7.Text.Substring(3, 1) + txtBinary8.Text.Substring(7, 1) + txtBinary8.Text.Substring(3, 1);
            txtData1.Text = txtBinary7.Text.Substring(2, 1) + txtBinary8.Text.Substring(6, 1) + txtBinary8.Text.Substring(2, 1);
            txtData2.Text = txtBinary7.Text.Substring(1, 1) + txtBinary8.Text.Substring(5, 1) + txtBinary8.Text.Substring(1, 1);
            txtData3.Text = txtBinary7.Text.Substring(0, 1) + txtBinary8.Text.Substring(4, 1) + txtBinary8.Text.Substring(0, 1);
        }

        private void btnAnalasys_Click(object sender, EventArgs e)
        {
            string[] blockControl=new string[4];
                blockControl[0] = txtData0.Text.Trim();
                blockControl[1] = txtData1.Text.Trim();
                blockControl[2] = txtData2.Text.Trim();
                blockControl[3] = txtData3.Text.Trim();
            if (EventPowerAnalasys != null)
            {
               
               // lstData.Items.Clear();
               // lstPower.Items.Clear();
                 EventPowerAnalasys(blockControl);
            }
           

        }
    }
}
