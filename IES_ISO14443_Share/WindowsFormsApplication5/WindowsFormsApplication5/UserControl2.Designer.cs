namespace WindowsFormsApplication5
{
    partial class UserControl2
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAnalasys = new System.Windows.Forms.Button();
            this.btnGetControlBit = new System.Windows.Forms.Button();
            this.txtData3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtData0 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnHexToBin = new System.Windows.Forms.Button();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnViewControl = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBinary9 = new System.Windows.Forms.TextBox();
            this.txtBinary8 = new System.Windows.Forms.TextBox();
            this.txtBinary7 = new System.Windows.Forms.TextBox();
            this.txtBinary6 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAnalasys);
            this.groupBox3.Controls.Add(this.btnGetControlBit);
            this.groupBox3.Controls.Add(this.txtData3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtData2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtData1);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtData0);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btnHexToBin);
            this.groupBox3.Controls.Add(this.txtPower);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.btnViewControl);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtBinary9);
            this.groupBox3.Controls.Add(this.txtBinary8);
            this.groupBox3.Controls.Add(this.txtBinary7);
            this.groupBox3.Controls.Add(this.txtBinary6);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(15, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(710, 218);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制权限分析";
            // 
            // btnAnalasys
            // 
            this.btnAnalasys.Location = new System.Drawing.Point(596, 169);
            this.btnAnalasys.Name = "btnAnalasys";
            this.btnAnalasys.Size = new System.Drawing.Size(100, 23);
            this.btnAnalasys.TabIndex = 64;
            this.btnAnalasys.Text = "权限分析";
            this.btnAnalasys.UseVisualStyleBackColor = true;
            this.btnAnalasys.Click += new System.EventHandler(this.btnAnalasys_Click);
            // 
            // btnGetControlBit
            // 
            this.btnGetControlBit.Location = new System.Drawing.Point(19, 123);
            this.btnGetControlBit.Name = "btnGetControlBit";
            this.btnGetControlBit.Size = new System.Drawing.Size(100, 23);
            this.btnGetControlBit.TabIndex = 63;
            this.btnGetControlBit.Text = "获取控制位";
            this.btnGetControlBit.UseVisualStyleBackColor = true;
            this.btnGetControlBit.Click += new System.EventHandler(this.btnGetControlBit_Click);
            // 
            // txtData3
            // 
            this.txtData3.Enabled = false;
            this.txtData3.Location = new System.Drawing.Point(469, 171);
            this.txtData3.Name = "txtData3";
            this.txtData3.Size = new System.Drawing.Size(100, 21);
            this.txtData3.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 12);
            this.label10.TabIndex = 61;
            this.label10.Text = "控制块3的控制位C13C23C33：";
            // 
            // txtData2
            // 
            this.txtData2.Enabled = false;
            this.txtData2.Location = new System.Drawing.Point(188, 171);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(100, 21);
            this.txtData2.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 12);
            this.label9.TabIndex = 59;
            this.label9.Text = "数据块2的控制位C12C22C32：";
            // 
            // txtData1
            // 
            this.txtData1.Enabled = false;
            this.txtData1.Location = new System.Drawing.Point(596, 125);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(100, 21);
            this.txtData1.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(416, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 12);
            this.label16.TabIndex = 54;
            this.label16.Text = "数据块1的控制位C11C21C31：";
            // 
            // txtData0
            // 
            this.txtData0.Enabled = false;
            this.txtData0.Location = new System.Drawing.Point(302, 125);
            this.txtData0.Name = "txtData0";
            this.txtData0.Size = new System.Drawing.Size(100, 21);
            this.txtData0.TabIndex = 52;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(135, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 12);
            this.label17.TabIndex = 51;
            this.label17.Text = "数据块0的控制位C10C20C30：";
            // 
            // btnHexToBin
            // 
            this.btnHexToBin.Location = new System.Drawing.Point(596, 29);
            this.btnHexToBin.Name = "btnHexToBin";
            this.btnHexToBin.Size = new System.Drawing.Size(100, 23);
            this.btnHexToBin.TabIndex = 53;
            this.btnHexToBin.Text = "二进制转换";
            this.btnHexToBin.UseVisualStyleBackColor = true;
            this.btnHexToBin.Click += new System.EventHandler(this.btnHexToBin_Click);
            // 
            // txtPower
            // 
            this.txtPower.Enabled = false;
            this.txtPower.Location = new System.Drawing.Point(288, 31);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(186, 21);
            this.txtPower.TabIndex = 50;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(217, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 49;
            this.label24.Text = "控制权限：";
            // 
            // btnViewControl
            // 
            this.btnViewControl.Location = new System.Drawing.Point(19, 29);
            this.btnViewControl.Name = "btnViewControl";
            this.btnViewControl.Size = new System.Drawing.Size(100, 23);
            this.btnViewControl.TabIndex = 9;
            this.btnViewControl.Text = "查看权限";
            this.btnViewControl.UseVisualStyleBackColor = true;
            this.btnViewControl.Click += new System.EventHandler(this.btnViewControl_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(616, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "备用字节";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(471, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "C33-C30  C23-C20";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(338, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 12);
            this.label20.TabIndex = 6;
            this.label20.Text = "C13-C10  C33-C30的反";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(186, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "C23-C20的反 C13-C10的反";
            // 
            // txtBinary9
            // 
            this.txtBinary9.Location = new System.Drawing.Point(596, 79);
            this.txtBinary9.Name = "txtBinary9";
            this.txtBinary9.Size = new System.Drawing.Size(100, 21);
            this.txtBinary9.TabIndex = 4;
            // 
            // txtBinary8
            // 
            this.txtBinary8.Location = new System.Drawing.Point(471, 79);
            this.txtBinary8.Name = "txtBinary8";
            this.txtBinary8.Size = new System.Drawing.Size(100, 21);
            this.txtBinary8.TabIndex = 3;
            // 
            // txtBinary7
            // 
            this.txtBinary7.Location = new System.Drawing.Point(344, 79);
            this.txtBinary7.Name = "txtBinary7";
            this.txtBinary7.Size = new System.Drawing.Size(100, 21);
            this.txtBinary7.TabIndex = 2;
            // 
            // txtBinary6
            // 
            this.txtBinary6.Location = new System.Drawing.Point(219, 79);
            this.txtBinary6.Name = "txtBinary6";
            this.txtBinary6.Size = new System.Drawing.Size(100, 21);
            this.txtBinary6.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(197, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "控制权限对应的四字节二进制信息：";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(738, 252);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAnalasys;
        private System.Windows.Forms.Button btnGetControlBit;
        private System.Windows.Forms.TextBox txtData3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtData0;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnHexToBin;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnViewControl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBinary9;
        private System.Windows.Forms.TextBox txtBinary8;
        private System.Windows.Forms.TextBox txtBinary7;
        private System.Windows.Forms.TextBox txtBinary6;
        private System.Windows.Forms.Label label22;
    }
}
