namespace WindowsFormsApplication5
{
    partial class UserControl1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTransByte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtByte9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtByte8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtByte7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtByte6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateCard = new System.Windows.Forms.Button();
            this.txtNewRight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCreateRight = new System.Windows.Forms.Button();
            this.cmbBlock3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbBlock2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBlock1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBlock0 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransByte);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCreateCard);
            this.groupBox1.Controls.Add(this.txtNewRight);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnCreateRight);
            this.groupBox1.Controls.Add(this.cmbBlock3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbBlock2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbBlock1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbBlock0);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 248);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制权限的生成";
            // 
            // btnTransByte
            // 
            this.btnTransByte.Location = new System.Drawing.Point(620, 31);
            this.btnTransByte.Name = "btnTransByte";
            this.btnTransByte.Size = new System.Drawing.Size(81, 23);
            this.btnTransByte.TabIndex = 66;
            this.btnTransByte.Text = "转为字节 ";
            this.btnTransByte.UseVisualStyleBackColor = true;
            this.btnTransByte.Click += new System.EventHandler(this.btnTransByte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtByte9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtByte8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtByte7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtByte6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 100);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "存取控制位信息";
            // 
            // txtByte9
            // 
            this.txtByte9.Location = new System.Drawing.Point(582, 49);
            this.txtByte9.Name = "txtByte9";
            this.txtByte9.Size = new System.Drawing.Size(100, 21);
            this.txtByte9.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "字节9：";
            // 
            // txtByte8
            // 
            this.txtByte8.Location = new System.Drawing.Point(420, 49);
            this.txtByte8.Name = "txtByte8";
            this.txtByte8.Size = new System.Drawing.Size(100, 21);
            this.txtByte8.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "字节8：";
            // 
            // txtByte7
            // 
            this.txtByte7.Location = new System.Drawing.Point(245, 49);
            this.txtByte7.Name = "txtByte7";
            this.txtByte7.Size = new System.Drawing.Size(100, 21);
            this.txtByte7.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "字节7：";
            // 
            // txtByte6
            // 
            this.txtByte6.Location = new System.Drawing.Point(71, 49);
            this.txtByte6.Name = "txtByte6";
            this.txtByte6.Size = new System.Drawing.Size(100, 21);
            this.txtByte6.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "字节6：";
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Location = new System.Drawing.Point(620, 192);
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.Size = new System.Drawing.Size(81, 23);
            this.btnCreateCard.TabIndex = 64;
            this.btnCreateCard.Text = "写入权限";
            this.btnCreateCard.UseVisualStyleBackColor = true;
            this.btnCreateCard.Click += new System.EventHandler(this.btnCreateCard_Click);
            // 
            // txtNewRight
            // 
            this.txtNewRight.Location = new System.Drawing.Point(332, 194);
            this.txtNewRight.Name = "txtNewRight";
            this.txtNewRight.Size = new System.Drawing.Size(117, 21);
            this.txtNewRight.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 62;
            this.label15.Text = "新权限：";
            // 
            // btnCreateRight
            // 
            this.btnCreateRight.Location = new System.Drawing.Point(13, 192);
            this.btnCreateRight.Name = "btnCreateRight";
            this.btnCreateRight.Size = new System.Drawing.Size(81, 23);
            this.btnCreateRight.TabIndex = 61;
            this.btnCreateRight.Text = "生成权限";
            this.btnCreateRight.UseVisualStyleBackColor = true;
            this.btnCreateRight.Click += new System.EventHandler(this.btnCreateRight_Click);
            // 
            // cmbBlock3
            // 
            this.cmbBlock3.FormattingEnabled = true;
            this.cmbBlock3.Items.AddRange(new object[] {
            "000",
            "001",
            "010",
            "011",
            "100",
            "101",
            "110",
            "111"});
            this.cmbBlock3.Location = new System.Drawing.Point(546, 33);
            this.cmbBlock3.Name = "cmbBlock3";
            this.cmbBlock3.Size = new System.Drawing.Size(58, 20);
            this.cmbBlock3.TabIndex = 60;
            this.cmbBlock3.SelectedIndexChanged += new System.EventHandler(this.cmbBlock3_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(469, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 59;
            this.label14.Text = "块3权限选择：";
            // 
            // cmbBlock2
            // 
            this.cmbBlock2.FormattingEnabled = true;
            this.cmbBlock2.Items.AddRange(new object[] {
            "000",
            "001",
            "010",
            "011",
            "100",
            "101",
            "110",
            "111"});
            this.cmbBlock2.Location = new System.Drawing.Point(396, 33);
            this.cmbBlock2.Name = "cmbBlock2";
            this.cmbBlock2.Size = new System.Drawing.Size(58, 20);
            this.cmbBlock2.TabIndex = 58;
            this.cmbBlock2.SelectedIndexChanged += new System.EventHandler(this.cmbBlock2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 57;
            this.label13.Text = "块2权限选择：";
            // 
            // cmbBlock1
            // 
            this.cmbBlock1.FormattingEnabled = true;
            this.cmbBlock1.Items.AddRange(new object[] {
            "000",
            "001",
            "010",
            "011",
            "100",
            "101",
            "110",
            "111"});
            this.cmbBlock1.Location = new System.Drawing.Point(246, 33);
            this.cmbBlock1.Name = "cmbBlock1";
            this.cmbBlock1.Size = new System.Drawing.Size(58, 20);
            this.cmbBlock1.TabIndex = 56;
            this.cmbBlock1.SelectedIndexChanged += new System.EventHandler(this.cmbBlock1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 55;
            this.label12.Text = "块1权限选择：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 54;
            this.label11.Text = "块0权限选择：";
            // 
            // cmbBlock0
            // 
            this.cmbBlock0.FormattingEnabled = true;
            this.cmbBlock0.Items.AddRange(new object[] {
            "000",
            "001",
            "010",
            "011",
            "100",
            "101",
            "110",
            "111"});
            this.cmbBlock0.Location = new System.Drawing.Point(91, 33);
            this.cmbBlock0.Name = "cmbBlock0";
            this.cmbBlock0.Size = new System.Drawing.Size(58, 20);
            this.cmbBlock0.TabIndex = 53;
            this.cmbBlock0.SelectedIndexChanged += new System.EventHandler(this.cmbBlock0_SelectedIndexChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(897, 305);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTransByte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtByte9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtByte8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtByte7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtByte6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateCard;
        private System.Windows.Forms.TextBox txtNewRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCreateRight;
        private System.Windows.Forms.ComboBox cmbBlock3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbBlock2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBlock1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBlock0;
    }
}
