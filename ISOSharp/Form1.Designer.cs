using System.Windows.Media;

namespace ISOSharp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panelBars = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panelNetwork = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lTest = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lUp = new System.Windows.Forms.Label();
            this.lDown = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label22 = new System.Windows.Forms.Label();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.elementHost5 = new System.Windows.Forms.Integration.ElementHost();
            this.gauge3 = new LiveCharts.Wpf.Gauge();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.gauge2 = new LiveCharts.Wpf.Gauge();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.gauge1 = new LiveCharts.Wpf.Gauge();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labMaxGpu = new System.Windows.Forms.Label();
            this.labCurentGpu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.angularGauge2 = new LiveCharts.Wpf.AngularGauge();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labMaxCpu = new System.Windows.Forms.Label();
            this.labCurrentCpu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.angularGauge1 = new LiveCharts.Wpf.AngularGauge();
            this.leftMenu = new System.Windows.Forms.Panel();
            this.bWindows = new ISOSharp.CircleButton();
            this.bNetwork = new ISOSharp.CircleButton();
            this.bLoad = new ISOSharp.CircleButton();
            this.bHeat = new ISOSharp.CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.panelBars.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelNetwork.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelLoad.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelTemp.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.leftMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.contentPanel);
            this.panel1.Controls.Add(this.leftMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 354);
            this.panel1.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.panelLoad);
            this.contentPanel.Controls.Add(this.panelBars);
            this.contentPanel.Controls.Add(this.panelNetwork);
            this.contentPanel.Controls.Add(this.panelTemp);
            this.contentPanel.Location = new System.Drawing.Point(145, 35);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(863, 318);
            this.contentPanel.TabIndex = 13;
            // 
            // panelBars
            // 
            this.panelBars.BackColor = System.Drawing.Color.Transparent;
            this.panelBars.Controls.Add(this.label24);
            this.panelBars.Controls.Add(this.comboBox1);
            this.panelBars.Controls.Add(this.label35);
            this.panelBars.Controls.Add(this.groupBox1);
            this.panelBars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBars.Location = new System.Drawing.Point(0, 0);
            this.panelBars.Name = "panelBars";
            this.panelBars.Size = new System.Drawing.Size(863, 318);
            this.panelBars.TabIndex = 10;
            this.panelBars.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(653, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "BAR SIZES";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BIG",
            "MEDIUM",
            "SMALL",
            "NOTIFY"});
            this.comboBox1.Location = new System.Drawing.Point(734, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Century", 11.25F);
            this.label35.ForeColor = System.Drawing.Color.Silver;
            this.label35.Location = new System.Drawing.Point(19, 10);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(341, 18);
            this.label35.TabIndex = 3;
            this.label35.Text = "ENABLE OR DISABLE INFORMATION BARS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MINI BARS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(28, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "CPU HEAT";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.Location = new System.Drawing.Point(671, 89);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(110, 17);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "INTERNET PING";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(27, 89);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "GPU HEAT";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(671, 35);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(148, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "INTERNET DOWNLOAD";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(351, 35);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "CPU LOAD";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(351, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(81, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "GPU LOAD";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // panelNetwork
            // 
            this.panelNetwork.BackColor = System.Drawing.Color.Transparent;
            this.panelNetwork.Controls.Add(this.groupBox2);
            this.panelNetwork.Controls.Add(this.panel9);
            this.panelNetwork.Controls.Add(this.label22);
            this.panelNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNetwork.Location = new System.Drawing.Point(0, 0);
            this.panelNetwork.Name = "panelNetwork";
            this.panelNetwork.Size = new System.Drawing.Size(863, 318);
            this.panelNetwork.TabIndex = 9;
            this.panelNetwork.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lTest);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.groupBox2.Location = new System.Drawing.Point(14, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SPEED TEST";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(674, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "START TEST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lTest
            // 
            this.lTest.AutoSize = true;
            this.lTest.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTest.ForeColor = System.Drawing.Color.White;
            this.lTest.Location = new System.Drawing.Point(12, 30);
            this.lTest.Name = "lTest";
            this.lTest.Size = new System.Drawing.Size(290, 16);
            this.lTest.TabIndex = 6;
            this.lTest.Text = "Click Start Test button to calculate internet speed";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel9.Controls.Add(this.lUp);
            this.panel9.Controls.Add(this.lDown);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.cartesianChart1);
            this.panel9.Location = new System.Drawing.Point(14, 31);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(839, 198);
            this.panel9.TabIndex = 5;
            // 
            // lUp
            // 
            this.lUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lUp.AutoSize = true;
            this.lUp.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUp.ForeColor = System.Drawing.Color.Silver;
            this.lUp.Location = new System.Drawing.Point(765, 168);
            this.lUp.Name = "lUp";
            this.lUp.Size = new System.Drawing.Size(14, 14);
            this.lUp.TabIndex = 6;
            this.lUp.Text = "0";
            // 
            // lDown
            // 
            this.lDown.AutoSize = true;
            this.lDown.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDown.ForeColor = System.Drawing.Color.Silver;
            this.lDown.Location = new System.Drawing.Point(113, 168);
            this.lDown.Name = "lDown";
            this.lDown.Size = new System.Drawing.Size(14, 14);
            this.lDown.TabIndex = 6;
            this.lDown.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(702, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Upload:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Download:";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(8, 5);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(825, 154);
            this.cartesianChart1.TabIndex = 6;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century", 11.25F);
            this.label22.ForeColor = System.Drawing.Color.Silver;
            this.label22.Location = new System.Drawing.Point(17, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(258, 18);
            this.label22.TabIndex = 3;
            this.label22.Text = "Download and Upload live graphics";
            // 
            // panelLoad
            // 
            this.panelLoad.BackColor = System.Drawing.Color.Transparent;
            this.panelLoad.Controls.Add(this.label1);
            this.panelLoad.Controls.Add(this.panel12);
            this.panelLoad.Controls.Add(this.panel11);
            this.panelLoad.Controls.Add(this.panel10);
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLoad.Location = new System.Drawing.Point(0, 0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(863, 318);
            this.panelLoad.TabIndex = 8;
            this.panelLoad.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current state of CPU and GPU temperatures";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel12.Controls.Add(this.label13);
            this.panel12.Controls.Add(this.elementHost5);
            this.panel12.Location = new System.Drawing.Point(546, 63);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(250, 200);
            this.panel12.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "MEM LOAD";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementHost5
            // 
            this.elementHost5.ForeColor = System.Drawing.Color.White;
            this.elementHost5.Location = new System.Drawing.Point(8, 23);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(239, 174);
            this.elementHost5.TabIndex = 4;
            this.elementHost5.Text = "elementHost3";
            this.elementHost5.Child = this.gauge3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.elementHost4);
            this.panel11.Location = new System.Drawing.Point(283, 63);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(250, 200);
            this.panel11.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "GPU LOAD";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementHost4
            // 
            this.elementHost4.ForeColor = System.Drawing.Color.White;
            this.elementHost4.Location = new System.Drawing.Point(8, 23);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(239, 174);
            this.elementHost4.TabIndex = 4;
            this.elementHost4.Text = "elementHost3";
            this.elementHost4.Child = this.gauge2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.elementHost3);
            this.panel10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel10.Location = new System.Drawing.Point(20, 63);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 200);
            this.panel10.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "CPU LOAD";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementHost3
            // 
            this.elementHost3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.elementHost3.BackColorTransparent = true;
            this.elementHost3.Cursor = System.Windows.Forms.Cursors.Default;
            this.elementHost3.ForeColor = System.Drawing.Color.White;
            this.elementHost3.Location = new System.Drawing.Point(8, 23);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(239, 174);
            this.elementHost3.TabIndex = 4;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.gauge1;
            // 
            // panelTemp
            // 
            this.panelTemp.BackColor = System.Drawing.Color.Transparent;
            this.panelTemp.Controls.Add(this.panel6);
            this.panelTemp.Controls.Add(this.panel5);
            this.panelTemp.Controls.Add(this.label6);
            this.panelTemp.Controls.Add(this.panel4);
            this.panelTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemp.Location = new System.Drawing.Point(0, 0);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(863, 318);
            this.panelTemp.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.elementHost2);
            this.panel6.Location = new System.Drawing.Point(291, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 239);
            this.panel6.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.labMaxGpu);
            this.panel8.Controls.Add(this.labCurentGpu);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 213);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(215, 26);
            this.panel8.TabIndex = 2;
            // 
            // labMaxGpu
            // 
            this.labMaxGpu.BackColor = System.Drawing.Color.Black;
            this.labMaxGpu.Dock = System.Windows.Forms.DockStyle.Right;
            this.labMaxGpu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.labMaxGpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labMaxGpu.Location = new System.Drawing.Point(134, 0);
            this.labMaxGpu.Name = "labMaxGpu";
            this.labMaxGpu.Size = new System.Drawing.Size(81, 26);
            this.labMaxGpu.TabIndex = 1;
            this.labMaxGpu.Text = "0";
            this.labMaxGpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCurentGpu
            // 
            this.labCurentGpu.Dock = System.Windows.Forms.DockStyle.Left;
            this.labCurentGpu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.labCurentGpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labCurentGpu.Location = new System.Drawing.Point(0, 0);
            this.labCurentGpu.Name = "labCurentGpu";
            this.labCurentGpu.Size = new System.Drawing.Size(77, 26);
            this.labCurentGpu.TabIndex = 0;
            this.labCurentGpu.Text = "0";
            this.labCurentGpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(79, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "GPU TEMP";
            // 
            // elementHost2
            // 
            this.elementHost2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.elementHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elementHost2.ForeColor = System.Drawing.Color.White;
            this.elementHost2.Location = new System.Drawing.Point(14, 27);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(188, 165);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost1";
            this.elementHost2.Child = this.angularGauge2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Location = new System.Drawing.Point(532, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 239);
            this.panel5.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(86, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "CPU CORES";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(6, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 202);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Temp";
            this.columnHeader2.Width = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(31, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Current state of CPU and GPU temperatures";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.elementHost1);
            this.panel4.ForeColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(34, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 239);
            this.panel4.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.labMaxCpu);
            this.panel7.Controls.Add(this.labCurrentCpu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 213);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 26);
            this.panel7.TabIndex = 2;
            // 
            // labMaxCpu
            // 
            this.labMaxCpu.BackColor = System.Drawing.Color.Black;
            this.labMaxCpu.Dock = System.Windows.Forms.DockStyle.Right;
            this.labMaxCpu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labMaxCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labMaxCpu.Location = new System.Drawing.Point(126, 0);
            this.labMaxCpu.Margin = new System.Windows.Forms.Padding(0);
            this.labMaxCpu.Name = "labMaxCpu";
            this.labMaxCpu.Size = new System.Drawing.Size(89, 26);
            this.labMaxCpu.TabIndex = 1;
            this.labMaxCpu.Text = "0";
            this.labMaxCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCurrentCpu
            // 
            this.labCurrentCpu.Dock = System.Windows.Forms.DockStyle.Left;
            this.labCurrentCpu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labCurrentCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labCurrentCpu.Location = new System.Drawing.Point(0, 0);
            this.labCurrentCpu.Margin = new System.Windows.Forms.Padding(0);
            this.labCurrentCpu.Name = "labCurrentCpu";
            this.labCurrentCpu.Size = new System.Drawing.Size(99, 26);
            this.labCurrentCpu.TabIndex = 0;
            this.labCurrentCpu.Text = "0";
            this.labCurrentCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "CPU TEMP";
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.elementHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elementHost1.ForeColor = System.Drawing.Color.White;
            this.elementHost1.Location = new System.Drawing.Point(19, 27);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(177, 162);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.angularGauge1;
            // 
            // leftMenu
            // 
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.leftMenu.Controls.Add(this.bWindows);
            this.leftMenu.Controls.Add(this.bNetwork);
            this.leftMenu.Controls.Add(this.bLoad);
            this.leftMenu.Controls.Add(this.bHeat);
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.Location = new System.Drawing.Point(0, 31);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(139, 321);
            this.leftMenu.TabIndex = 13;
            // 
            // bWindows
            // 
            this.bWindows.BackColor = System.Drawing.Color.Black;
            this.bWindows.FlatAppearance.BorderSize = 0;
            this.bWindows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.bWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bWindows.ForeColor = System.Drawing.Color.White;
            this.bWindows.Image = ((System.Drawing.Image)(resources.GetObject("bWindows.Image")));
            this.bWindows.Location = new System.Drawing.Point(44, 246);
            this.bWindows.Name = "bWindows";
            this.bWindows.Size = new System.Drawing.Size(60, 60);
            this.bWindows.TabIndex = 4;
            this.bWindows.UseVisualStyleBackColor = false;
            this.bWindows.Click += new System.EventHandler(this.label23_Click);
            // 
            // bNetwork
            // 
            this.bNetwork.BackColor = System.Drawing.Color.Black;
            this.bNetwork.FlatAppearance.BorderSize = 0;
            this.bNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.bNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNetwork.ForeColor = System.Drawing.Color.White;
            this.bNetwork.Image = ((System.Drawing.Image)(resources.GetObject("bNetwork.Image")));
            this.bNetwork.Location = new System.Drawing.Point(44, 173);
            this.bNetwork.Name = "bNetwork";
            this.bNetwork.Size = new System.Drawing.Size(60, 60);
            this.bNetwork.TabIndex = 4;
            this.bNetwork.UseVisualStyleBackColor = false;
            this.bNetwork.Click += new System.EventHandler(this.label7_Click);
            // 
            // bLoad
            // 
            this.bLoad.BackColor = System.Drawing.Color.Black;
            this.bLoad.FlatAppearance.BorderSize = 0;
            this.bLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.bLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoad.ForeColor = System.Drawing.Color.White;
            this.bLoad.Image = ((System.Drawing.Image)(resources.GetObject("bLoad.Image")));
            this.bLoad.Location = new System.Drawing.Point(44, 100);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(60, 60);
            this.bLoad.TabIndex = 4;
            this.bLoad.UseVisualStyleBackColor = false;
            this.bLoad.Click += new System.EventHandler(this.label3_Click);
            // 
            // bHeat
            // 
            this.bHeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.bHeat.FlatAppearance.BorderSize = 0;
            this.bHeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(26)))), ((int)(((byte)(248)))));
            this.bHeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHeat.ForeColor = System.Drawing.Color.White;
            this.bHeat.Image = ((System.Drawing.Image)(resources.GetObject("bHeat.Image")));
            this.bHeat.Location = new System.Drawing.Point(44, 27);
            this.bHeat.Name = "bHeat";
            this.bHeat.Size = new System.Drawing.Size(60, 60);
            this.bHeat.TabIndex = 3;
            this.bHeat.UseVisualStyleBackColor = false;
            this.bHeat.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.lTitle);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 31);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // lTitle
            // 
            this.lTitle.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lTitle.Location = new System.Drawing.Point(145, 7);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(805, 17);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "SYSTEM TEMPERATURE";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.lTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(956, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "-";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(983, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PCSUIT";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::ISOSharp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1013, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.panelBars.ResumeLayout(false);
            this.panelBars.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelNetwork.ResumeLayout(false);
            this.panelNetwork.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelLoad.ResumeLayout(false);
            this.panelLoad.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panelTemp.ResumeLayout(false);
            this.panelTemp.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.leftMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.AngularGauge angularGauge1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.AngularGauge angularGauge2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labCurentGpu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labCurrentCpu;
        private System.Windows.Forms.Label labMaxGpu;
        private System.Windows.Forms.Label labMaxCpu;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Integration.ElementHost elementHost5;
        private LiveCharts.Wpf.Gauge gauge3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private LiveCharts.Wpf.Gauge gauge2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelNetwork;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panelBars;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel leftMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircleButton bHeat;
        private CircleButton bLoad;
        private CircleButton bNetwork;
        private CircleButton bWindows;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label label1;
        private LiveCharts.Wpf.Gauge gauge1;
        private System.Windows.Forms.Panel panel9;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label lUp;
        private System.Windows.Forms.Label lDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lTest;
    }
}

