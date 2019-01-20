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
    public partial class UserControl1 : UserControl
    {
        public delegate void DelegateListViewUpdate(int blockID, string[] items);
        public event DelegateListViewUpdate EventListViewUpdate;
        private string KeyA;
        private string KeyB;
        private string CardID;
        private string SectionID;
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
            string[] strBlock0Items = RightDisp.DispDataRight(cmbBlock0.Text);
            int blockID = Convert.ToInt32(SectionID) * 4 + 0;//计算该扇区第0块地址
        
            if (EventListViewUpdate != null)
            {
                EventListViewUpdate(blockID, strBlock0Items);
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
            strTemp[0] = cmbBlock3.Text.Substring(0, 1) + cmbBlock2.Text.Substring(0, 1) + cmbBlock1.Text.Substring(0, 1) + cmbBlock0.Text.Substring(0, 1);//c
            strTemp[1] = cmbBlock3.Text.Substring(1, 1) + cmbBlock2.Text.Substring(1, 1) + cmbBlock1.Text.Substring(1, 1) + cmbBlock0.Text.Substring(1, 1);
            strTemp[2] = cmbBlock3.Text.Substring(2, 1) + cmbBlock2.Text.Substring(2, 1) + cmbBlock1.Text.Substring(2, 1) + cmbBlock0.Text.Substring(2, 1);
            strByte[0] = strTemp[1] + strTemp[0];
            strByte[1] = strTemp[0] + strTemp[2];
            strByte[2] = strTemp[2] + strTemp[1];
           
            byte[] bytes = new byte[3];
            for (int i = 0; i < 3; i++)
            {
                bytes[i] = Convert.ToByte(strByte[i], 2);
            }
            bytes[0] = (byte)(bytes[0] ^ 0xff);
            bytes[1] = (byte)(bytes[1] ^ 0x0f);
            
            for (int i = 0; i < 3; i++)
            {
                strByte[i] = Convert.ToString(bytes[i], 2);
                int len = strByte[i].Length;
                if (len < 8)
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
            txtByte9.Text = "01101001";
            

          
            
        }

        private void btnCreateRight_Click(object sender, EventArgs e)
        {
            string[] str = {txtByte6.Text.Trim() ,txtByte7.Text.Trim() , txtByte8.Text.Trim() , txtByte9.Text.Trim()};
            Int32[] temp ={ Convert.ToInt32(str[0]) ,Convert.ToInt32(str[1]), Convert.ToInt32(str[2]), Convert.ToInt32(str[3])};
            Int32 temp1=temp[0]+temp[1]+temp[2]+temp[3];
            string temp2 =  Convert.ToString(temp1, 16) ;
            if (str.Length <= 8)
            {
                int result = str.Length;
                for (int i = 0; i < 8 - result; i++)
                {
                    temp2 = "0" + temp2;
                }
            }
            txtNewRight.Text = KeyA+temp2.ToUpper()+KeyB;
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            string strBlockID = (Convert.ToInt32(SectionID) * 4 + 3).ToString();
            try
            {
                if (ISO14443_Tag.Is_Select)
                {

                    if (ISO14443_Tag.KeyB(strBlockID , "BBBBBBBBBBBB", CardID) == "")
                    {
                        if (ISO14443_Tag.WriteData(strBlockID, txtNewRight.Text.Trim()) == "")
                        {
                            MessageBox.Show("写入成功！");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
