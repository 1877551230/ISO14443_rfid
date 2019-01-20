using IES_ISO14443_Share;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
namespace WindowsFormsApplication5
{

    public partial class Form1 : CCSkinMain
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
         * 打开串口操作
         */
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (!ISO14443_Tag.Is_Port)
            {
                try
                {
                    if (ISO14443_Tag.OpenPorts(cmbPorts.Text.Trim()) == "")
                    {
                        ISO14443_Tag.Is_Port = true;
                        MessageBox.Show("串口打开成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ISO14443_Tag.Is_Port = false;
                        MessageBox.Show("串口打开失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("串口已处于打开状态，无需再次打卡！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*
         * 主窗体加载给窗体送值
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           
            string[] ports = SerialPort.GetPortNames();//从系统得到串口号
            if (ports.Length > 00)
            {
                cmbPorts.Items.AddRange(ports);//将得到的串口号送给cmbPort的项目里
                cmbPorts.SelectedIndex = 0;//默认选择第一个
                txtBaud.Text = "9600";
            }
            else
            {
                MessageBox.Show("系统中没有可用串口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            for (int i = 0; i < 16; i++)
            {
                cmbSectionID.Items.Add(i.ToString());
            }
            cmbSectionID.SelectedIndex = 0;
        }
        /*
         * 寻卡操作
         */
        private void btnFindCard_Click(object sender, EventArgs e)
        {
            if (!ISO14443_Tag.Is_Port)
            {
                MessageBox.Show("寻卡前必须打开串口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string strCardID = ISO14443_Tag.ReadTag();//得到卡的标签号
                if (strCardID != "")
                {
                    txtCardID.Text = strCardID;
                    //ISO14443_Tag.Tag = strCardID;
                    ISO14443_Tag.Is_Find = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
         * 制卡操作，密钥A为AAAAAAAAAAAA，密钥B为BBBBBBBBBBBB，控制权限为08778F69
         * */
        private void btnSelectCard_Click(object sender, EventArgs e)
        {
            if (!ISO14443_Tag.Is_Find)
            {
                MessageBox.Show("选卡前必须先寻卡！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (ISO14443_Tag.TagSelect(txtCardID.Text.Trim()))
                {
                    ISO14443_Tag.Is_Select = true;
                    txtAKey.Text = "AAAAAAAAAAAA";
                    txtBKey.Text = "BBBBBBBBBBBB";
                    txtControl.Text = "08778F69";
                    MessageBox.Show("选卡成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
         * 定义listviewadd，三个参数为（listview名字，块号，定义包含字符串数组）
         */
        private void ListViewAdd(ListView lst, int blockID, string[] items)
        {
            int i;
            ListViewItem lv = new ListViewItem();
            lv.Text = "块" + blockID.ToString();
            for (i = 0; i < items.Length; i++)
            {
                lv.SubItems.Add(items[i]);
            }
            lst.Items.Add(lv);
        }

        private void uc_EventPowerAnalasys(string[] BlockControl)
        {
            //根据控制位信息在listview控件中显示
            int k;
            int blockID;
            string[] str = { };
            for (k = 0; k < 3; k++)
            {
                blockID = Convert.ToInt32(cmbSectionID.Text.Trim()) * 4 + k;
                str = RightDisp.DispDataRight(BlockControl[k]);//自定义类RightDisp中的静态方法，用于显示数据块控制位的具体信息
                ListViewAdd(listView1, blockID, str);//用于将获取到的卡权限信息显示到列表框1中
            }
            blockID = Convert.ToInt32(cmbSectionID.Text) * 4 + 3;
            str = RightDisp.DispControlRight(BlockControl[3]); //自定义类RightDisp中的静态方法，用于显示控制块控制位的具体信息
            ListViewAdd(listView2, blockID, str);//将获取到的控制信息显示到列表框2中

        }
        private void btnPowerAnalasys_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();//清空两个数据框的项目
            listView2.Items.Clear();
            UserControl2 uc = new UserControl2(txtCardID.Text.Trim(), cmbSectionID.Text.Trim());//将卡号，选择的扇区号传到用户控件
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(uc);//显示用户控件
            uc.EventPowerAnalasys += uc_EventPowerAnalasys;
        }
        private void uc_EventListViewUpdate(int blockID, string[] items)
        {
            bool flag = true;//判别当前列表中是否存在该块号的数据，如果没有则为true,如果存在则为false
            string key = "块¨¦" + blockID.ToString();//块1、块2....的显示
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == key)
                {
                    for (int j = 1; j <= items.Length; j++)
                    {
                        listView1.Items[i].SubItems[j].Text = items[j - 1];//
                    }
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                int BlockID = Convert.ToInt32(cmbSectionID.Text) * 4;

                if (blockID == BlockID || blockID == BlockID+1 || blockID == BlockID+2)//判断如果是前三个块，则为卡数据块，添加进列表框1，否则为控制块，添加到列表2
                {
                   // ListViewItem list = new ListViewItem(); 
                    //list.Text = key;//获取文本框的内容 
                   // if (listView1.Items.Contains(list))
                        //{ 
                       
                        
                        ListViewAdd(listView1, blockID, items);
                       // }
                }
                else
                {
                    ListViewAdd(listView2,blockID,items);
                }
            }
        }
        private void btnPowerCreate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            UserControl1 uc = new UserControl1(txtAKey.Text.Trim(),txtBKey.Text.Trim(),txtCardID.Text.Trim(), cmbSectionID.Text.Trim());//将制卡的密钥AB，卡号，扇区号传入用户控件
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(uc);
            uc.EventListViewUpdate += uc_EventListViewUpdate;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                if (ISO14443_Tag.Is_Select)
                {

                    if (ISO14443_Tag.KeyB((Convert.ToInt32(cmbSectionID.Text) * 4 + 3).ToString(), "FFFFFFFFFFFF", txtCardID.Text.Trim()) == "")//验证密钥B
                    {
                       // if (ISO14443_Tag.WriteData((Convert.ToInt32(cmbSectionID.Text) * 4 + 3).ToString(), Carry.ChsToHex(textBox1.Text.Trim())) == "")
                       // {
                        if (ISO14443_Tag.WriteKey(txtAKey.Text.Trim(), txtBKey.Text.Trim(), txtControl.Text.Trim(), (Convert.ToInt32(cmbSectionID.Text) * 4 + 3).ToString()) == "")//写入控制块数据
                            {
                                MessageBox.Show("制卡成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                       // }
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Carry.ChsToHex(textBox3.Text);//将输入的姓名转为十六进制
        }

        private void grpCreateCard_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSectionID_SelectedIndexChanged(object sender, EventArgs e)
        { 
            cmbBlock1.Items.Clear();
            cmbBlock2.Items.Clear();
            for (int i = Convert.ToInt32(cmbSectionID.Text)*4; i < Convert.ToInt32(cmbSectionID.Text)*4 + 3; i++)//选择想写入的块区号，由所选扇区号计算，前三个块可以写数据
            { 
               
               
                cmbBlock1.Items.Add(i.ToString());
                cmbBlock2.Items.Add(i.ToString());
            }
            cmbBlock1.SelectedIndex = 0;
            cmbBlock2.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (ISO14443_Tag.Is_Select)
                {
                    if (ISO14443_Tag.KeyB((Convert.ToInt32(cmbSectionID.Text) * 4 + 3).ToString(), "BBBBBBBBBBBB", txtCardID.Text.Trim()) == "")//验证密钥B
                    {
                        if (ISO14443_Tag.WriteData( cmbBlock1.Text.Trim(),textBox1.Text.Trim()) == "")//写数据操作
                        {
                            if (ISO14443_Tag.WriteData(cmbBlock2.Text.Trim(),textBox4.Text.Trim() ) == "")
                           {
                               MessageBox.Show("写入数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string str = string.Format("{0:X2}",Convert.ToInt32(textBox2.Text.Trim()));//将班级号转为二进制再转为字符串类型
            if (str.Length <= 32)//补全32位
            {
                int result = str.Length;
                for (int i = 0; i < 32 - result; i++)
                {
                    str = "0" + str;
                }
            }

            textBox4.Text = str;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }

        private void skinAlphaWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBlock1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}