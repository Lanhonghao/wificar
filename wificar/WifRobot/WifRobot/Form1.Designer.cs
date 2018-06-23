namespace WifiVideo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLightsOff = new System.Windows.Forms.Button();
            this.btnLightsOn = new System.Windows.Forms.Button();
            this.btnEngineDown = new System.Windows.Forms.Button();
            this.btnEngineUp = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnLightsOff);
            this.groupBox1.Controls.Add(this.btnLightsOn);
            this.groupBox1.Controls.Add(this.btnEngineDown);
            this.groupBox1.Controls.Add(this.btnEngineUp);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.buttonBackward);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Controls.Add(this.buttonForward);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(4, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(649, 189);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLightsOff
            // 
            this.btnLightsOff.Location = new System.Drawing.Point(471, 57);
            this.btnLightsOff.Name = "btnLightsOff";
            this.btnLightsOff.Size = new System.Drawing.Size(96, 28);
            this.btnLightsOff.TabIndex = 20;
            this.btnLightsOff.Text = "关闭车灯(G)";
            this.btnLightsOff.UseVisualStyleBackColor = true;
            this.btnLightsOff.Click += new System.EventHandler(this.btnLightsOff_Click);
            // 
            // btnLightsOn
            // 
            this.btnLightsOn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLightsOn.Location = new System.Drawing.Point(349, 57);
            this.btnLightsOn.Name = "btnLightsOn";
            this.btnLightsOn.Size = new System.Drawing.Size(97, 28);
            this.btnLightsOn.TabIndex = 19;
            this.btnLightsOn.Text = "打开车灯(F)";
            this.btnLightsOn.UseVisualStyleBackColor = true;
            this.btnLightsOn.Click += new System.EventHandler(this.btnLightsOn_Click_1);
            // 
            // btnEngineDown
            // 
            this.btnEngineDown.Enabled = false;
            this.btnEngineDown.Location = new System.Drawing.Point(471, 111);
            this.btnEngineDown.Name = "btnEngineDown";
            this.btnEngineDown.Size = new System.Drawing.Size(96, 29);
            this.btnEngineDown.TabIndex = 18;
            this.btnEngineDown.Text = "关闭循迹模式";
            this.btnEngineDown.UseVisualStyleBackColor = true;
            this.btnEngineDown.Click += new System.EventHandler(this.btnEngineDown_Click);
            // 
            // btnEngineUp
            // 
            this.btnEngineUp.Location = new System.Drawing.Point(349, 112);
            this.btnEngineUp.Name = "btnEngineUp";
            this.btnEngineUp.Size = new System.Drawing.Size(97, 28);
            this.btnEngineUp.TabIndex = 17;
            this.btnEngineUp.Text = "开启循迹模式";
            this.btnEngineUp.UseVisualStyleBackColor = true;
            this.btnEngineUp.Click += new System.EventHandler(this.btnEngineUp_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(148, 86);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(63, 42);
            this.buttonStop.TabIndex = 16;
            this.buttonStop.Text = "X";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(219, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 15;
            this.button6.Text = "设置(F2)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.Location = new System.Drawing.Point(148, 130);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(63, 42);
            this.buttonBackward.TabIndex = 14;
            this.buttonBackward.Text = "S";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(213, 86);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(64, 42);
            this.buttonRight.TabIndex = 13;
            this.buttonRight.Text = "D";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(82, 86);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(64, 42);
            this.buttonLeft.TabIndex = 12;
            this.buttonLeft.Text = "A";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(148, 43);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(63, 42);
            this.buttonForward.TabIndex = 11;
            this.buttonForward.Text = "W";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(63, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "视频(F1)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, 639);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 106);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口控制";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(34, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "打开串口";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "扫描";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(273, 639);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 105);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据显示";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(283, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 32);
            this.button5.TabIndex = 2;
            this.button5.Text = "清空数据";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "导出数据";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 76);
            this.listBox1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "车速：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(232, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 48);
            this.label2.TabIndex = 15;
            this.label2.Text = "cm/s";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(111, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 16;
            this.label3.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 48);
            this.label4.TabIndex = 17;
            this.label4.Text = "前：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 48);
            this.label5.TabIndex = 18;
            this.label5.Text = "后：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(5, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 48);
            this.label6.TabIndex = 19;
            this.label6.Text = "左：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(5, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 48);
            this.label7.TabIndex = 20;
            this.label7.Text = "右：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(88, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 34);
            this.label8.TabIndex = 21;
            this.label8.Text = "无障碍";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(88, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 34);
            this.label9.TabIndex = 22;
            this.label9.Text = "无障碍";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(88, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 34);
            this.label10.TabIndex = 23;
            this.label10.Text = "无障碍";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(88, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 34);
            this.label11.TabIndex = 24;
            this.label11.Text = "无障碍";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(54, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 60);
            this.label12.TabIndex = 25;
            this.label12.Text = "安   全";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 36);
            this.label13.TabIndex = 26;
            this.label13.Text = "行车安全监测：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(1266, 546);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 199);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "安全监测自动停车";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(175, 136);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 35);
            this.button8.TabIndex = 28;
            this.button8.Text = "停用";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(55, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 35);
            this.button7.TabIndex = 27;
            this.button7.Text = "启用";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(86, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 48);
            this.label14.TabIndex = 26;
            this.label14.Text = "未启用";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(1266, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 528);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "行车数据";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(659, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(601, 734);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WifiVideo.Properties.Resources.molab;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 754);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能汽车系统上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEngineDown;
        private System.Windows.Forms.Button btnEngineUp;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLightsOff;
        private System.Windows.Forms.Button btnLightsOn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button8;
    }
}

