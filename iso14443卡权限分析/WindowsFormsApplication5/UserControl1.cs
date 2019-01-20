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
    public partial class UserControl1 : UserControl
    {
        public delegate void DelegateListViewUpdate(int blockID, string[] items);//委托，参数为块号和字符串组
        public event DelegateListViewUpdate EventListViewUpdate;//定义委托时间
        private string KeyA;
        private string KeyB;
        private string CardID;
        private string SectionID;
        /*
         * 将主窗体的数据keyA，keyB，卡号和扇区号传递进来
         */
        public UserControl1(string keyA,string keyB,string cardID, string sectionID)
        {
            InitializeComponent();
            this.KeyA = keyA;
            this.KeyB = keyB;
            this.CardID = cardID;
            this.SectionID = sectionID;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void cmbBlock0_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strBlock0Items = RightDisp.DispDataRight(cmbBlock0.Text);//将类RightDisp中对应的字符串数据传递进来
            int blockID = Convert.ToInt32(SectionID) * 4 + 0;//计算该扇区第0块地址
        
            if (EventListViewUpdate != null)
            {
                EventListViewUpdate(blockID, strBlock0Items);//将用户控件里的块号和类里的字符串数组传递到主窗体
            }   

        }

       

        private void cmbBlock1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strBlock0Items = RightDisp.DispDataRight(cmbBlock1.Text);
            int blockID = Convert.ToInt32(SectionID) * 4 + 1;//计算该扇区第1块地址
    
            if (EventListViewUpdate != null)
            {
                EventListViewUpdate( blockID, strBlock0Items);
            }   
        }

        private void cmbBlock2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strBlock0Items = RightDisp.DispDataRight(cmbBlock2.Text);
            int blockID = Convert.ToInt32(SectionID) * 4 + 2;//计算该扇区第2块地址
            
            if (EventListViewUpdate != null)
            {
                EventListViewUpdate( blockID, strBlock0Items);
            }   
        }

        private void cmbBlock3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strBlock0Items = RightDisp.DispControlRight(cmbBlock3.Text);
            int blockID = Convert.ToInt32(SectionID) * 4 + 3;//计算该扇区第3块地址
            
            if (EventListViewUpdate != null)
            {
                EventListViewUpdate( blockID, strBlock0Items);
            }   
        }

        private void btnTransByte_Click(object sender, EventArgs e)
        {
           /* string[] strTemp = {   cmbBlock3.Text.Substring(0, 1) + cmbBlock2.Text.Substring(0, 1)+ cmbBlock1.Text.Substring(0, 1) + cmbBlock0.Text.Substring(0, 1), 
                                   cmbBlock3.Text.Substring(1, 1) + cmbBlock2.Text.Substring(1, 1) + cmbBlock1.Text.Substring(1, 1) + cmbBlock0.Text.Substring(1, 1),
                                   cmbBlock3.Text.Substring(2, 1) +  cmbBlock2.Text.Substring(2, 1) + cmbBlock1.Text.Substring(2, 1) + cmbBlock0.Text.Substring(2, 1)  };
           string[] strByte = { strTemp[1] + strTemp[0], strTemp[0] + strTemp[2], strTemp[2] + strTemp[1] }; */
            string[] strRight=new string[4];
            string[] strTemp = new string[3];
            string[] strByte = new string[3];
            strRight[0] = cmbBlock0.Text;
            strRight[1] = cmbBlock1.Text;
            strRight[2] = cmbBlock2.Text;
            strRight[3] = cmbBlock3.Text;
            strTemp[0] = cmbBlock3.Text.Substring(0, 1) + cmbBlock2.Text.Substring(0, 1) + cmbBlock1.Text.Substring(0, 1) + cmbBlock0.Text.Substring(0, 1);//对照图分析，将需要的字符截取出来并连接
            strTemp[1] = cmbBlock3.Text.Substring(1, 1) + cmbBlock2.Text.Substring(1, 1) + cmbBlock1.Text.Substring(1, 1) + cmbBlock0.Text.Substring(1, 1);
            strTemp[2] = cmbBlock3.Text.Substring(2, 1) + cmbBlock2.Text.Substring(2, 1) + cmbBlock1.Text.Substring(2, 1) + cmbBlock0.Text.Substring(2, 1);
            /*
             * 对照图，得到字节6、7、8
             */
            strByte[0] = strTemp[1] + strTemp[0];
            strByte[1] = strTemp[0] + strTemp[2];
            strByte[2] = strTemp[2] + strTemp[1];
           
            byte[] bytes = new byte[3];//定义byte数组
            for (int i = 0; i < 3; i++)
            {
                bytes[i] = Convert.ToByte(strByte[i], 2);//将二进制字符串转为byte
            }
            bytes[0] = (byte)(bytes[0] ^ 0xff);//根据权限对照表，取反
            bytes[1] = (byte)(bytes[1] ^ 0x0f);//根据权限对照表，后四位取反
            
            for (int i = 0; i < 3; i++)
            {
                strByte[i] = Convert.ToString(bytes[i], 2);//byte转字符串
                int len = strByte[i].Length;
                if (len < 8)//如果小于8位，前面加“0”
                {
                    for (int j = 0; j < 8 - len; j++)
                    {
                        strByte[i] = "0" + strByte[i];
                    }
                }
            }
            txtByte6.Text = strByte[0];
            txtByte7.Text = strByte[1];
            txtByte8.Text = strByte[2];
            txtByte9.Text = "01101001";//最后备用字节永远为69（01101001）
            

          
            
        }
       
        private void btnCreateRight_Click(object sender, EventArgs e)
        {
           
            string str1=txtByte6.Text.Trim()+txtByte7.Text.Trim()+txtByte8.Text.Trim()+txtByte9.Text.Trim();//将四个框里的二进制字符串连成一个
         string str=    string.Format("{0:X}", System.Convert.ToInt32(str1, 2));//字符串转为十六进制
            
            if (str.Length <= 8)//如果不够8位，补全8位
            {
                int result = str.Length;
                for (int i = 0; i < 8 - result; i++)
                {
                    str = "0" + str;
                }
            }
            txtNewRight.Text = str.ToUpper();//把str转为大写送入文本框
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            string strBlockID = (Convert.ToInt32(SectionID) * 4 + 3).ToString();//由扇区号得到块号
            try
            {
                if (ISO14443_Tag.Is_Select)
                {

                    if (ISO14443_Tag.KeyB(strBlockID , KeyB, CardID) == "")//验证B密钥
                    {
                        if (ISO14443_Tag.WriteData(strBlockID, KeyA + txtNewRight.Text.Trim() + KeyB) == "")//写入权限
                        {
                            MessageBox.Show("写入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strBlockID = (Convert.ToInt32(SectionID) * 4 + 3).ToString();//通过扇区号计算块号
            try
            {
                if (ISO14443_Tag.KeyB(strBlockID, KeyB, CardID) == "")//验证秘钥B
                {

                    string strPower = ISO14443_Tag.ReadData(strBlockID).Substring(12,8);//读取控制权限
                    textBox1.Text = strPower;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void skinGroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
