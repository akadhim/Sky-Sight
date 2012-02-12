namespace SkySight
{
    partial class Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.joystickStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.JoystickProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.xaxisStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.yaxisStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.baudrateComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.portComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.videoComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.audioComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.joystickTab = new System.Windows.Forms.TabPage();
            this.moveYLabelValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moveXLabelValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elevationLabelValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveYTrackBar = new System.Windows.Forms.TrackBar();
            this.moveXTrackBar = new System.Windows.Forms.TrackBar();
            this.elevationTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.activateJoystick = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iOTextboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.joystickTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveYTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveXTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedToolStripMenuItem,
            this.iOTextboxToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.advancedToolStripMenuItem.Text = "Joystick";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.advancedToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar2,
            this.joystickStatus,
            this.JoystickProgressBar,
            this.toolStripStatusLabel2,
            this.xaxisStatusLabel,
            this.toolStripStatusLabel4,
            this.yaxisStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "Connection Status";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.MarqueeAnimationSpeed = 10;
            this.toolStripProgressBar2.Maximum = 10;
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(16, 16);
            // 
            // joystickStatus
            // 
            this.joystickStatus.Name = "joystickStatus";
            this.joystickStatus.Size = new System.Drawing.Size(83, 17);
            this.joystickStatus.Text = "Joystick Status";
            // 
            // JoystickProgressBar
            // 
            this.JoystickProgressBar.MarqueeAnimationSpeed = 10;
            this.JoystickProgressBar.Maximum = 10;
            this.JoystickProgressBar.Name = "JoystickProgressBar";
            this.JoystickProgressBar.Size = new System.Drawing.Size(16, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "Platform: X-Axis";
            // 
            // xaxisStatusLabel
            // 
            this.xaxisStatusLabel.Name = "xaxisStatusLabel";
            this.xaxisStatusLabel.Size = new System.Drawing.Size(36, 17);
            this.xaxisStatusLabel.Text = "Value";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel4.Text = "Y-Axis";
            // 
            // yaxisStatusLabel
            // 
            this.yaxisStatusLabel.Name = "yaxisStatusLabel";
            this.yaxisStatusLabel.Size = new System.Drawing.Size(36, 17);
            this.yaxisStatusLabel.Text = "Value";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baudrateComboBox,
            this.portComboBox,
            this.videoComboBox,
            this.audioComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(880, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // baudrateComboBox
            // 
            this.baudrateComboBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.baudrateComboBox.Name = "baudrateComboBox";
            this.baudrateComboBox.Size = new System.Drawing.Size(121, 25);
            this.baudrateComboBox.Text = "Baud Rate";
            this.baudrateComboBox.SelectedIndexChanged += new System.EventHandler(this.baudrateComboBox_SelectedIndexChanged);
            // 
            // portComboBox
            // 
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 25);
            this.portComboBox.Text = "Port";
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            // 
            // videoComboBox
            // 
            this.videoComboBox.Name = "videoComboBox";
            this.videoComboBox.Size = new System.Drawing.Size(121, 25);
            this.videoComboBox.Text = "Video";
            this.videoComboBox.SelectedIndexChanged += new System.EventHandler(this.videoComboBox_SelectedIndexChanged);
            // 
            // audioComboBox
            // 
            this.audioComboBox.Name = "audioComboBox";
            this.audioComboBox.Size = new System.Drawing.Size(121, 25);
            this.audioComboBox.Text = "Audio";
            this.audioComboBox.SelectedIndexChanged += new System.EventHandler(this.audioComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.joystickTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(177, 436);
            this.tabControl1.TabIndex = 7;
            // 
            // joystickTab
            // 
            this.joystickTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.joystickTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joystickTab.Controls.Add(this.moveYLabelValue);
            this.joystickTab.Controls.Add(this.label3);
            this.joystickTab.Controls.Add(this.moveXLabelValue);
            this.joystickTab.Controls.Add(this.label2);
            this.joystickTab.Controls.Add(this.elevationLabelValue);
            this.joystickTab.Controls.Add(this.label1);
            this.joystickTab.Controls.Add(this.moveYTrackBar);
            this.joystickTab.Controls.Add(this.moveXTrackBar);
            this.joystickTab.Controls.Add(this.elevationTrackBar);
            this.joystickTab.Controls.Add(this.groupBox3);
            this.joystickTab.Controls.Add(this.groupBox2);
            this.joystickTab.Controls.Add(this.groupBox1);
            this.joystickTab.Controls.Add(this.groupBox4);
            this.joystickTab.Controls.Add(this.groupBox6);
            this.joystickTab.Controls.Add(this.groupBox5);
            this.joystickTab.Location = new System.Drawing.Point(4, 22);
            this.joystickTab.Name = "joystickTab";
            this.joystickTab.Padding = new System.Windows.Forms.Padding(3);
            this.joystickTab.Size = new System.Drawing.Size(169, 410);
            this.joystickTab.TabIndex = 1;
            this.joystickTab.Text = "Joystick";
            // 
            // moveYLabelValue
            // 
            this.moveYLabelValue.AutoSize = true;
            this.moveYLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYLabelValue.Location = new System.Drawing.Point(101, 169);
            this.moveYLabelValue.Name = "moveYLabelValue";
            this.moveYLabelValue.Size = new System.Drawing.Size(43, 16);
            this.moveYLabelValue.TabIndex = 4;
            this.moveYLabelValue.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movement Y";
            // 
            // moveXLabelValue
            // 
            this.moveXLabelValue.AutoSize = true;
            this.moveXLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXLabelValue.Location = new System.Drawing.Point(101, 110);
            this.moveXLabelValue.Name = "moveXLabelValue";
            this.moveXLabelValue.Size = new System.Drawing.Size(43, 16);
            this.moveXLabelValue.TabIndex = 4;
            this.moveXLabelValue.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movement X";
            // 
            // elevationLabelValue
            // 
            this.elevationLabelValue.AutoSize = true;
            this.elevationLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevationLabelValue.Location = new System.Drawing.Point(101, 50);
            this.elevationLabelValue.Name = "elevationLabelValue";
            this.elevationLabelValue.Size = new System.Drawing.Size(43, 16);
            this.elevationLabelValue.TabIndex = 4;
            this.elevationLabelValue.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elevation";
            // 
            // moveYTrackBar
            // 
            this.moveYTrackBar.Location = new System.Drawing.Point(17, 192);
            this.moveYTrackBar.Maximum = 32767;
            this.moveYTrackBar.Minimum = -32768;
            this.moveYTrackBar.Name = "moveYTrackBar";
            this.moveYTrackBar.Size = new System.Drawing.Size(135, 45);
            this.moveYTrackBar.TabIndex = 0;
            // 
            // moveXTrackBar
            // 
            this.moveXTrackBar.Location = new System.Drawing.Point(17, 133);
            this.moveXTrackBar.Maximum = 32767;
            this.moveXTrackBar.Minimum = -32768;
            this.moveXTrackBar.Name = "moveXTrackBar";
            this.moveXTrackBar.Size = new System.Drawing.Size(135, 45);
            this.moveXTrackBar.TabIndex = 0;
            // 
            // elevationTrackBar
            // 
            this.elevationTrackBar.Location = new System.Drawing.Point(17, 73);
            this.elevationTrackBar.Maximum = 32767;
            this.elevationTrackBar.Minimum = -32768;
            this.elevationTrackBar.Name = "elevationTrackBar";
            this.elevationTrackBar.Size = new System.Drawing.Size(135, 45);
            this.elevationTrackBar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(85, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(76, 31);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Button 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(4, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 31);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Button 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(43, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 31);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 11);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Button 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Location = new System.Drawing.Point(43, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(76, 31);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Button 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.radioButton6);
            this.groupBox6.Location = new System.Drawing.Point(83, 359);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(76, 31);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 9);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Button 6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.Location = new System.Drawing.Point(4, 359);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(76, 31);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 9);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(65, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Button 5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // activateJoystick
            // 
            this.activateJoystick.ForeColor = System.Drawing.Color.Blue;
            this.activateJoystick.Location = new System.Drawing.Point(26, 25);
            this.activateJoystick.Name = "activateJoystick";
            this.activateJoystick.Size = new System.Drawing.Size(171, 67);
            this.activateJoystick.TabIndex = 8;
            this.activateJoystick.Text = "Activate Joystick";
            this.activateJoystick.UseVisualStyleBackColor = true;
            this.activateJoystick.Click += new System.EventHandler(this.activateJoystick_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.activateJoystick);
            this.panel1.Location = new System.Drawing.Point(652, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 417);
            this.panel1.TabIndex = 8;
            // 
            // videoPanel
            // 
            this.videoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPanel.AutoSize = true;
            this.videoPanel.Location = new System.Drawing.Point(191, 74);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(455, 414);
            this.videoPanel.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-2, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 223);
            this.textBox1.TabIndex = 9;
            // 
            // iOTextboxToolStripMenuItem
            // 
            this.iOTextboxToolStripMenuItem.Name = "iOTextboxToolStripMenuItem";
            this.iOTextboxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iOTextboxToolStripMenuItem.Text = "IO Textbox";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(129, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 513);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.Text = "Sky-Sight Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Interface_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Interface_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.joystickTab.ResumeLayout(false);
            this.joystickTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveYTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveXTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel joystickStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox baudrateComboBox;
        private System.Windows.Forms.ToolStripComboBox portComboBox;
        private System.Windows.Forms.ToolStripComboBox videoComboBox;
        private System.Windows.Forms.ToolStripComboBox audioComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage joystickTab;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TrackBar moveYTrackBar;
        private System.Windows.Forms.TrackBar moveXTrackBar;
        private System.Windows.Forms.TrackBar elevationTrackBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label moveYLabelValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label moveXLabelValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label elevationLabelValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripProgressBar JoystickProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel xaxisStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel yaxisStatusLabel;
        private System.Windows.Forms.Button activateJoystick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.ToolStripMenuItem iOTextboxToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

