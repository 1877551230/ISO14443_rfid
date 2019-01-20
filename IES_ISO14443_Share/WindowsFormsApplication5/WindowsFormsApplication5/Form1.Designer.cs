namespace WindowsFormsApplication5
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCreateCard = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbSectionID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectCard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBKey = new System.Windows.Forms.TextBox();
            this.btnFindCard = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.txtBaud = new System.Windows.Forms.TextBox();
            this.txtAKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.btnPowerCreate = new System.Windows.Forms.Button();
            this.btnPowerAnalasys = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.cmbBlock1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbBlock2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCreateCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.grpCreateCard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 589);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Location = new System.Drawing.Point(502, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 145);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制块权限表";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView2.Location = new System.Drawing.Point(0, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(648, 112);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "块号";
            this.columnHeader6.Width = 64;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "密钥A读";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 84;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "密钥A写";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 73;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "存取控制位读";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 101;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "存取控制位写";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 94;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "密钥B读";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 77;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "密钥B写";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 83;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(502, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "卡权限信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(0, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(648, 132);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "数据块序号";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "读";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "写";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "加值";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "减值、传送、恢复";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 129;
            // 
            // grpCreateCard
            // 
            this.grpCreateCard.Controls.Add(this.button4);
            this.grpCreateCard.Controls.Add(this.cmbBlock2);
            this.grpCreateCard.Controls.Add(this.label12);
            this.grpCreateCard.Controls.Add(this.textBox4);
            this.grpCreateCard.Controls.Add(this.button3);
            this.grpCreateCard.Controls.Add(this.textBox2);
            this.grpCreateCard.Controls.Add(this.label11);
            this.grpCreateCard.Controls.Add(this.cmbBlock1);
            this.grpCreateCard.Controls.Add(this.label10);
            this.grpCreateCard.Controls.Add(this.txtControl);
            this.grpCreateCard.Controls.Add(this.label9);
            this.grpCreateCard.Controls.Add(this.label3);
            this.grpCreateCard.Controls.Add(this.button2);
            this.grpCreateCard.Controls.Add(this.textBox1);
            this.grpCreateCard.Controls.Add(this.cmbSectionID);
            this.grpCreateCard.Controls.Add(this.button1);
            this.grpCreateCard.Controls.Add(this.textBox3);
            this.grpCreateCard.Controls.Add(this.label7);
            this.grpCreateCard.Controls.Add(this.label8);
            this.grpCreateCard.Controls.Add(this.label6);
            this.grpCreateCard.Controls.Add(this.btnSelectCard);
            this.grpCreateCard.Controls.Add(this.label5);
            this.grpCreateCard.Controls.Add(this.txtBKey);
            this.grpCreateCard.Controls.Add(this.btnFindCard);
            this.grpCreateCard.Controls.Add(this.btnOpenPort);
            this.grpCreateCard.Controls.Add(this.txtBaud);
            this.grpCreateCard.Controls.Add(this.txtAKey);
            this.grpCreateCard.Controls.Add(this.label2);
            this.grpCreateCard.Controls.Add(this.label1);
            this.grpCreateCard.Controls.Add(this.txtCardID);
            this.grpCreateCard.Controls.Add(this.btnPowerCreate);
            this.grpCreateCard.Controls.Add(this.btnPowerAnalasys);
            this.grpCreateCard.Controls.Add(this.label4);
            this.grpCreateCard.Controls.Add(this.cmbPorts);
            this.grpCreateCard.Location = new System.Drawing.Point(3, 6);
            this.grpCreateCard.Name = "grpCreateCard";
            this.grpCreateCard.Size = new System.Drawing.Size(493, 292);
            this.grpCreateCard.TabIndex = 5;
            this.grpCreateCard.TabStop = false;
            this.grpCreateCard.Text = "基本操作";
            this.grpCreateCard.Enter += new System.EventHandler(this.grpCreateCard_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 60;
            this.label10.Text = "存入块号";
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(370, 59);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(105, 21);
            this.txtControl.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 58;
            this.label9.Text = "控制权限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "转换";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 21);
            this.textBox1.TabIndex = 55;
            // 
            // cmbSectionID
            // 
            this.cmbSectionID.FormattingEnabled = true;
            this.cmbSectionID.Location = new System.Drawing.Point(429, 91);
            this.cmbSectionID.Name = "cmbSectionID";
            this.cmbSectionID.Size = new System.Drawing.Size(46, 20);
            this.cmbSectionID.TabIndex = 54;
            this.cmbSectionID.SelectedIndexChanged += new System.EventHandler(this.cmbSectionID_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "制卡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 21);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "姓名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "密钥A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 53;
            this.label6.Text = "扇区号：";
            // 
            // btnSelectCard
            // 
            this.btnSelectCard.Location = new System.Drawing.Point(212, 57);
            this.btnSelectCard.Name = "btnSelectCard";
            this.btnSelectCard.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCard.TabIndex = 7;
            this.btnSelectCard.Text = "选卡";
            this.btnSelectCard.UseVisualStyleBackColor = true;
            this.btnSelectCard.Click += new System.EventHandler(this.btnSelectCard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "密钥B";
            // 
            // txtBKey
            // 
            this.txtBKey.Location = new System.Drawing.Point(245, 90);
            this.txtBKey.Name = "txtBKey";
            this.txtBKey.Size = new System.Drawing.Size(111, 21);
            this.txtBKey.TabIndex = 1;
            // 
            // btnFindCard
            // 
            this.btnFindCard.Location = new System.Drawing.Point(412, 20);
            this.btnFindCard.Name = "btnFindCard";
            this.btnFindCard.Size = new System.Drawing.Size(75, 23);
            this.btnFindCard.TabIndex = 5;
            this.btnFindCard.Text = "寻卡";
            this.btnFindCard.UseVisualStyleBackColor = true;
            this.btnFindCard.Click += new System.EventHandler(this.btnFindCard_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(327, 20);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 4;
            this.btnOpenPort.Text = "打开";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // txtBaud
            // 
            this.txtBaud.Location = new System.Drawing.Point(232, 20);
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(80, 21);
            this.txtBaud.TabIndex = 3;
            // 
            // txtAKey
            // 
            this.txtAKey.Location = new System.Drawing.Point(68, 89);
            this.txtAKey.Name = "txtAKey";
            this.txtAKey.Size = new System.Drawing.Size(111, 21);
            this.txtAKey.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号：";
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(68, 59);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(112, 21);
            this.txtCardID.TabIndex = 2;
            // 
            // btnPowerCreate
            // 
            this.btnPowerCreate.Location = new System.Drawing.Point(290, 263);
            this.btnPowerCreate.Name = "btnPowerCreate";
            this.btnPowerCreate.Size = new System.Drawing.Size(75, 23);
            this.btnPowerCreate.TabIndex = 8;
            this.btnPowerCreate.Text = "权限生成";
            this.btnPowerCreate.UseVisualStyleBackColor = true;
            this.btnPowerCreate.Click += new System.EventHandler(this.btnPowerCreate_Click);
            // 
            // btnPowerAnalasys
            // 
            this.btnPowerAnalasys.Location = new System.Drawing.Point(50, 263);
            this.btnPowerAnalasys.Name = "btnPowerAnalasys";
            this.btnPowerAnalasys.Size = new System.Drawing.Size(75, 23);
            this.btnPowerAnalasys.TabIndex = 7;
            this.btnPowerAnalasys.Text = "权限分析";
            this.btnPowerAnalasys.UseVisualStyleBackColor = true;
            this.btnPowerAnalasys.Click += new System.EventHandler(this.btnPowerAnalasys_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "标签号：";
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(68, 20);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(80, 20);
            this.cmbPorts.TabIndex = 0;
            // 
            // cmbBlock1
            // 
            this.cmbBlock1.FormattingEnabled = true;
            this.cmbBlock1.Location = new System.Drawing.Point(396, 165);
            this.cmbBlock1.Name = "cmbBlock1";
            this.cmbBlock1.Size = new System.Drawing.Size(75, 20);
            this.cmbBlock1.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 62;
            this.label11.Text = "班级";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 21);
            this.textBox2.TabIndex = 63;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 64;
            this.button3.Text = "转换";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(232, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(95, 21);
            this.textBox4.TabIndex = 65;
            // 
            // cmbBlock2
            // 
            this.cmbBlock2.FormattingEnabled = true;
            this.cmbBlock2.Location = new System.Drawing.Point(396, 207);
            this.cmbBlock2.Name = "cmbBlock2";
            this.cmbBlock2.Size = new System.Drawing.Size(75, 20);
            this.cmbBlock2.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 66;
            this.label12.Text = "存入块号";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 68;
            this.button4.Text = "写入数据";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 589);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpCreateCard.ResumeLayout(false);
            this.grpCreateCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpCreateCard;
        private System.Windows.Forms.ComboBox cmbSectionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPowerCreate;
        private System.Windows.Forms.Button btnPowerAnalasys;
        private System.Windows.Forms.Button btnSelectCard;
        private System.Windows.Forms.Button btnFindCard;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.TextBox txtBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBKey;
        private System.Windows.Forms.TextBox txtAKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBlock1;
        private System.Windows.Forms.ComboBox cmbBlock2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
    }
}

