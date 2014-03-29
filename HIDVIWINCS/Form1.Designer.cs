namespace HIDVIWINCS
{
    partial class MainForm
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
            this.label_DeviceName = new System.Windows.Forms.Label();
            this.label_DeviceStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_BlueFlash = new System.Windows.Forms.Button();
            this.button_BlueOn = new System.Windows.Forms.Button();
            this.button_BlueOff = new System.Windows.Forms.Button();
            this.button_RedFlash = new System.Windows.Forms.Button();
            this.button_RedOn = new System.Windows.Forms.Button();
            this.button_RedOff = new System.Windows.Forms.Button();
            this.button_GreenFlash = new System.Windows.Forms.Button();
            this.button_GreenOn = new System.Windows.Forms.Button();
            this.button_GreenOff = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_GreenOnDuty = new System.Windows.Forms.TextBox();
            this.textBox_GreenOffDuty = new System.Windows.Forms.TextBox();
            this.textBox_RedOffDuty = new System.Windows.Forms.TextBox();
            this.textBox_RedOnDuty = new System.Windows.Forms.TextBox();
            this.textBox_BlueOffDuty = new System.Windows.Forms.TextBox();
            this.textBox_BlueOnDuty = new System.Windows.Forms.TextBox();
            this.textBox_BluePower = new System.Windows.Forms.TextBox();
            this.textBox_BlueOffset = new System.Windows.Forms.TextBox();
            this.textBox_RedPower = new System.Windows.Forms.TextBox();
            this.textBox_RedOffset = new System.Windows.Forms.TextBox();
            this.textBox_GreenPower = new System.Windows.Forms.TextBox();
            this.textBox_GreenOffset = new System.Windows.Forms.TextBox();
            this.button_BlueApply = new System.Windows.Forms.Button();
            this.button_RedApply = new System.Windows.Forms.Button();
            this.button_GreenApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_UpdateSwitch = new System.Windows.Forms.Button();
            this.checkBox_SwitchAudiConfirm = new System.Windows.Forms.CheckBox();
            this.checkBox_SwitchAutoClear = new System.Windows.Forms.CheckBox();
            this.checkBox_Switch = new System.Windows.Forms.CheckBox();
            this.button_BuzzerStart = new System.Windows.Forms.Button();
            this.button_BuzzerStop = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_BuzzerFreq = new System.Windows.Forms.TextBox();
            this.textBox_BuzzerRepeat = new System.Windows.Forms.TextBox();
            this.textBox_BuzzerOnTime = new System.Windows.Forms.TextBox();
            this.textBox_BuzzerOffTime = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_PreScaler = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button_Prescaler = new System.Windows.Forms.Button();
            this.button_Sync = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DeviceName
            // 
            this.label_DeviceName.AutoSize = true;
            this.label_DeviceName.Location = new System.Drawing.Point(31, 16);
            this.label_DeviceName.Name = "label_DeviceName";
            this.label_DeviceName.Size = new System.Drawing.Size(72, 13);
            this.label_DeviceName.TabIndex = 0;
            this.label_DeviceName.Text = "DeviceName:";
            // 
            // label_DeviceStatus
            // 
            this.label_DeviceStatus.AutoSize = true;
            this.label_DeviceStatus.Location = new System.Drawing.Point(31, 32);
            this.label_DeviceStatus.Name = "label_DeviceStatus";
            this.label_DeviceStatus.Size = new System.Drawing.Size(74, 13);
            this.label_DeviceStatus.TabIndex = 1;
            this.label_DeviceStatus.Text = "DeviceStatus:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_Quit);
            this.groupBox1.Controls.Add(this.button_Open);
            this.groupBox1.Controls.Add(this.label_DeviceStatus);
            this.groupBox1.Controls.Add(this.label_DeviceName);
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(479, 48);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(77, 28);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "&Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(632, 47);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(77, 28);
            this.button_Quit.TabIndex = 8;
            this.button_Quit.Text = "&Quit";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(392, 48);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(77, 28);
            this.button_Open.TabIndex = 6;
            this.button_Open.Text = "&Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_BlueFlash);
            this.groupBox2.Controls.Add(this.button_BlueOn);
            this.groupBox2.Controls.Add(this.button_BlueOff);
            this.groupBox2.Controls.Add(this.button_RedFlash);
            this.groupBox2.Controls.Add(this.button_RedOn);
            this.groupBox2.Controls.Add(this.button_RedOff);
            this.groupBox2.Controls.Add(this.button_GreenFlash);
            this.groupBox2.Controls.Add(this.button_GreenOn);
            this.groupBox2.Controls.Add(this.button_GreenOff);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Control";
            // 
            // button_BlueFlash
            // 
            this.button_BlueFlash.Location = new System.Drawing.Point(143, 88);
            this.button_BlueFlash.Name = "button_BlueFlash";
            this.button_BlueFlash.Size = new System.Drawing.Size(40, 22);
            this.button_BlueFlash.TabIndex = 16;
            this.button_BlueFlash.Text = "Flash";
            this.button_BlueFlash.UseVisualStyleBackColor = true;
            this.button_BlueFlash.Click += new System.EventHandler(this.button_BlueFlash_Click);
            // 
            // button_BlueOn
            // 
            this.button_BlueOn.Location = new System.Drawing.Point(97, 88);
            this.button_BlueOn.Name = "button_BlueOn";
            this.button_BlueOn.Size = new System.Drawing.Size(40, 22);
            this.button_BlueOn.TabIndex = 15;
            this.button_BlueOn.Text = "On";
            this.button_BlueOn.UseVisualStyleBackColor = true;
            this.button_BlueOn.Click += new System.EventHandler(this.button_BlueOn_Click);
            // 
            // button_BlueOff
            // 
            this.button_BlueOff.Location = new System.Drawing.Point(51, 88);
            this.button_BlueOff.Name = "button_BlueOff";
            this.button_BlueOff.Size = new System.Drawing.Size(40, 22);
            this.button_BlueOff.TabIndex = 14;
            this.button_BlueOff.Text = "Off";
            this.button_BlueOff.UseVisualStyleBackColor = true;
            this.button_BlueOff.Click += new System.EventHandler(this.button_BlueOff_Click);
            // 
            // button_RedFlash
            // 
            this.button_RedFlash.Location = new System.Drawing.Point(143, 62);
            this.button_RedFlash.Name = "button_RedFlash";
            this.button_RedFlash.Size = new System.Drawing.Size(40, 22);
            this.button_RedFlash.TabIndex = 11;
            this.button_RedFlash.Text = "Flash";
            this.button_RedFlash.UseVisualStyleBackColor = true;
            this.button_RedFlash.Click += new System.EventHandler(this.button_RedFlash_Click);
            // 
            // button_RedOn
            // 
            this.button_RedOn.Location = new System.Drawing.Point(97, 62);
            this.button_RedOn.Name = "button_RedOn";
            this.button_RedOn.Size = new System.Drawing.Size(40, 22);
            this.button_RedOn.TabIndex = 10;
            this.button_RedOn.Text = "On";
            this.button_RedOn.UseVisualStyleBackColor = true;
            this.button_RedOn.Click += new System.EventHandler(this.button_RedOn_Click);
            // 
            // button_RedOff
            // 
            this.button_RedOff.Location = new System.Drawing.Point(51, 62);
            this.button_RedOff.Name = "button_RedOff";
            this.button_RedOff.Size = new System.Drawing.Size(40, 22);
            this.button_RedOff.TabIndex = 9;
            this.button_RedOff.Text = "Off";
            this.button_RedOff.UseVisualStyleBackColor = true;
            this.button_RedOff.Click += new System.EventHandler(this.button_RedOff_Click);
            // 
            // button_GreenFlash
            // 
            this.button_GreenFlash.Location = new System.Drawing.Point(143, 34);
            this.button_GreenFlash.Name = "button_GreenFlash";
            this.button_GreenFlash.Size = new System.Drawing.Size(40, 22);
            this.button_GreenFlash.TabIndex = 7;
            this.button_GreenFlash.Text = "Flash";
            this.button_GreenFlash.UseVisualStyleBackColor = true;
            this.button_GreenFlash.Click += new System.EventHandler(this.button_GreenFlash_Click);
            // 
            // button_GreenOn
            // 
            this.button_GreenOn.Location = new System.Drawing.Point(97, 34);
            this.button_GreenOn.Name = "button_GreenOn";
            this.button_GreenOn.Size = new System.Drawing.Size(40, 22);
            this.button_GreenOn.TabIndex = 6;
            this.button_GreenOn.Text = "On";
            this.button_GreenOn.UseVisualStyleBackColor = true;
            this.button_GreenOn.Click += new System.EventHandler(this.button_GreenOn_Click);
            // 
            // button_GreenOff
            // 
            this.button_GreenOff.Location = new System.Drawing.Point(51, 34);
            this.button_GreenOff.Name = "button_GreenOff";
            this.button_GreenOff.Size = new System.Drawing.Size(40, 22);
            this.button_GreenOff.TabIndex = 5;
            this.button_GreenOff.Text = "Off";
            this.button_GreenOff.UseVisualStyleBackColor = true;
            this.button_GreenOff.Click += new System.EventHandler(this.button_GreenOff_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Yellow";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Blue";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Red";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Flash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "On";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Off";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "OffDuty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "OnDuty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Offset";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Power";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Apply";
            // 
            // textBox_GreenOnDuty
            // 
            this.textBox_GreenOnDuty.Location = new System.Drawing.Point(6, 37);
            this.textBox_GreenOnDuty.Name = "textBox_GreenOnDuty";
            this.textBox_GreenOnDuty.Size = new System.Drawing.Size(40, 20);
            this.textBox_GreenOnDuty.TabIndex = 5;
            this.textBox_GreenOnDuty.Text = "50";
            // 
            // textBox_GreenOffDuty
            // 
            this.textBox_GreenOffDuty.Location = new System.Drawing.Point(55, 37);
            this.textBox_GreenOffDuty.Name = "textBox_GreenOffDuty";
            this.textBox_GreenOffDuty.Size = new System.Drawing.Size(40, 20);
            this.textBox_GreenOffDuty.TabIndex = 6;
            this.textBox_GreenOffDuty.Text = "50";
            // 
            // textBox_RedOffDuty
            // 
            this.textBox_RedOffDuty.Location = new System.Drawing.Point(55, 63);
            this.textBox_RedOffDuty.Name = "textBox_RedOffDuty";
            this.textBox_RedOffDuty.Size = new System.Drawing.Size(40, 20);
            this.textBox_RedOffDuty.TabIndex = 11;
            this.textBox_RedOffDuty.Text = "50";
            // 
            // textBox_RedOnDuty
            // 
            this.textBox_RedOnDuty.Location = new System.Drawing.Point(6, 63);
            this.textBox_RedOnDuty.Name = "textBox_RedOnDuty";
            this.textBox_RedOnDuty.Size = new System.Drawing.Size(40, 20);
            this.textBox_RedOnDuty.TabIndex = 10;
            this.textBox_RedOnDuty.Text = "50";
            // 
            // textBox_BlueOffDuty
            // 
            this.textBox_BlueOffDuty.Location = new System.Drawing.Point(55, 89);
            this.textBox_BlueOffDuty.Name = "textBox_BlueOffDuty";
            this.textBox_BlueOffDuty.Size = new System.Drawing.Size(40, 20);
            this.textBox_BlueOffDuty.TabIndex = 16;
            this.textBox_BlueOffDuty.Text = "50";
            // 
            // textBox_BlueOnDuty
            // 
            this.textBox_BlueOnDuty.Location = new System.Drawing.Point(6, 89);
            this.textBox_BlueOnDuty.Name = "textBox_BlueOnDuty";
            this.textBox_BlueOnDuty.Size = new System.Drawing.Size(40, 20);
            this.textBox_BlueOnDuty.TabIndex = 15;
            this.textBox_BlueOnDuty.Text = "50";
            // 
            // textBox_BluePower
            // 
            this.textBox_BluePower.Location = new System.Drawing.Point(151, 89);
            this.textBox_BluePower.Name = "textBox_BluePower";
            this.textBox_BluePower.Size = new System.Drawing.Size(40, 20);
            this.textBox_BluePower.TabIndex = 18;
            this.textBox_BluePower.Text = "80";
            // 
            // textBox_BlueOffset
            // 
            this.textBox_BlueOffset.Location = new System.Drawing.Point(102, 89);
            this.textBox_BlueOffset.Name = "textBox_BlueOffset";
            this.textBox_BlueOffset.Size = new System.Drawing.Size(40, 20);
            this.textBox_BlueOffset.TabIndex = 17;
            this.textBox_BlueOffset.Text = "0";
            // 
            // textBox_RedPower
            // 
            this.textBox_RedPower.Location = new System.Drawing.Point(151, 63);
            this.textBox_RedPower.Name = "textBox_RedPower";
            this.textBox_RedPower.Size = new System.Drawing.Size(40, 20);
            this.textBox_RedPower.TabIndex = 13;
            this.textBox_RedPower.Text = "80";
            // 
            // textBox_RedOffset
            // 
            this.textBox_RedOffset.Location = new System.Drawing.Point(102, 63);
            this.textBox_RedOffset.Name = "textBox_RedOffset";
            this.textBox_RedOffset.Size = new System.Drawing.Size(40, 20);
            this.textBox_RedOffset.TabIndex = 12;
            this.textBox_RedOffset.Text = "0";
            // 
            // textBox_GreenPower
            // 
            this.textBox_GreenPower.Location = new System.Drawing.Point(151, 37);
            this.textBox_GreenPower.Name = "textBox_GreenPower";
            this.textBox_GreenPower.Size = new System.Drawing.Size(40, 20);
            this.textBox_GreenPower.TabIndex = 8;
            this.textBox_GreenPower.Text = "80";
            // 
            // textBox_GreenOffset
            // 
            this.textBox_GreenOffset.Location = new System.Drawing.Point(102, 37);
            this.textBox_GreenOffset.Name = "textBox_GreenOffset";
            this.textBox_GreenOffset.Size = new System.Drawing.Size(40, 20);
            this.textBox_GreenOffset.TabIndex = 7;
            this.textBox_GreenOffset.Text = "0";
            // 
            // button_BlueApply
            // 
            this.button_BlueApply.Location = new System.Drawing.Point(198, 89);
            this.button_BlueApply.Name = "button_BlueApply";
            this.button_BlueApply.Size = new System.Drawing.Size(48, 22);
            this.button_BlueApply.TabIndex = 19;
            this.button_BlueApply.Text = "Apply";
            this.button_BlueApply.UseVisualStyleBackColor = true;
            this.button_BlueApply.Click += new System.EventHandler(this.button_BlueApply_Click);
            // 
            // button_RedApply
            // 
            this.button_RedApply.Location = new System.Drawing.Point(198, 63);
            this.button_RedApply.Name = "button_RedApply";
            this.button_RedApply.Size = new System.Drawing.Size(48, 22);
            this.button_RedApply.TabIndex = 14;
            this.button_RedApply.Text = "Apply";
            this.button_RedApply.UseVisualStyleBackColor = true;
            this.button_RedApply.Click += new System.EventHandler(this.button_RedApply_Click);
            // 
            // button_GreenApply
            // 
            this.button_GreenApply.Location = new System.Drawing.Point(198, 35);
            this.button_GreenApply.Name = "button_GreenApply";
            this.button_GreenApply.Size = new System.Drawing.Size(48, 22);
            this.button_GreenApply.TabIndex = 9;
            this.button_GreenApply.Text = "Apply";
            this.button_GreenApply.UseVisualStyleBackColor = true;
            this.button_GreenApply.Click += new System.EventHandler(this.button_GreenApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_UpdateSwitch);
            this.groupBox3.Controls.Add(this.checkBox_SwitchAudiConfirm);
            this.groupBox3.Controls.Add(this.checkBox_SwitchAutoClear);
            this.groupBox3.Controls.Add(this.checkBox_Switch);
            this.groupBox3.Location = new System.Drawing.Point(628, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 146);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Swtich Control";
            // 
            // button_UpdateSwitch
            // 
            this.button_UpdateSwitch.Location = new System.Drawing.Point(13, 112);
            this.button_UpdateSwitch.Name = "button_UpdateSwitch";
            this.button_UpdateSwitch.Size = new System.Drawing.Size(77, 28);
            this.button_UpdateSwitch.TabIndex = 3;
            this.button_UpdateSwitch.Text = "&Update";
            this.button_UpdateSwitch.UseVisualStyleBackColor = true;
            this.button_UpdateSwitch.Click += new System.EventHandler(this.button_UpdateSwitch_Click);
            // 
            // checkBox_SwitchAudiConfirm
            // 
            this.checkBox_SwitchAudiConfirm.AutoSize = true;
            this.checkBox_SwitchAudiConfirm.Location = new System.Drawing.Point(6, 80);
            this.checkBox_SwitchAudiConfirm.Name = "checkBox_SwitchAudiConfirm";
            this.checkBox_SwitchAudiConfirm.Size = new System.Drawing.Size(88, 17);
            this.checkBox_SwitchAudiConfirm.TabIndex = 2;
            this.checkBox_SwitchAudiConfirm.Text = "AudioConfirm";
            this.checkBox_SwitchAudiConfirm.UseVisualStyleBackColor = true;
            this.checkBox_SwitchAudiConfirm.CheckedChanged += new System.EventHandler(this.checkBox_SwitchAudiConfirm_CheckedChanged);
            // 
            // checkBox_SwitchAutoClear
            // 
            this.checkBox_SwitchAutoClear.AutoSize = true;
            this.checkBox_SwitchAutoClear.Location = new System.Drawing.Point(6, 57);
            this.checkBox_SwitchAutoClear.Name = "checkBox_SwitchAutoClear";
            this.checkBox_SwitchAutoClear.Size = new System.Drawing.Size(72, 17);
            this.checkBox_SwitchAutoClear.TabIndex = 1;
            this.checkBox_SwitchAutoClear.Text = "AutoClear";
            this.checkBox_SwitchAutoClear.UseVisualStyleBackColor = true;
            this.checkBox_SwitchAutoClear.CheckedChanged += new System.EventHandler(this.checkBox_SwitchAutoClear_CheckedChanged);
            // 
            // checkBox_Switch
            // 
            this.checkBox_Switch.AutoCheck = false;
            this.checkBox_Switch.AutoSize = true;
            this.checkBox_Switch.Enabled = false;
            this.checkBox_Switch.Location = new System.Drawing.Point(6, 21);
            this.checkBox_Switch.Name = "checkBox_Switch";
            this.checkBox_Switch.Size = new System.Drawing.Size(56, 17);
            this.checkBox_Switch.TabIndex = 0;
            this.checkBox_Switch.Text = "Status";
            this.checkBox_Switch.UseVisualStyleBackColor = true;
            // 
            // button_BuzzerStart
            // 
            this.button_BuzzerStart.Location = new System.Drawing.Point(110, 19);
            this.button_BuzzerStart.Name = "button_BuzzerStart";
            this.button_BuzzerStart.Size = new System.Drawing.Size(48, 22);
            this.button_BuzzerStart.TabIndex = 2;
            this.button_BuzzerStart.Text = "Start";
            this.button_BuzzerStart.UseVisualStyleBackColor = true;
            this.button_BuzzerStart.Click += new System.EventHandler(this.button_BuzzerStart_Click);
            // 
            // button_BuzzerStop
            // 
            this.button_BuzzerStop.Location = new System.Drawing.Point(110, 50);
            this.button_BuzzerStop.Name = "button_BuzzerStop";
            this.button_BuzzerStop.Size = new System.Drawing.Size(48, 22);
            this.button_BuzzerStop.TabIndex = 5;
            this.button_BuzzerStop.Text = "Stop";
            this.button_BuzzerStop.UseVisualStyleBackColor = true;
            this.button_BuzzerStop.Click += new System.EventHandler(this.button_BuzzerStop_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Freq";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Repeat";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "OnTime";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "OffTime";
            // 
            // textBox_BuzzerFreq
            // 
            this.textBox_BuzzerFreq.Location = new System.Drawing.Point(54, 19);
            this.textBox_BuzzerFreq.Name = "textBox_BuzzerFreq";
            this.textBox_BuzzerFreq.Size = new System.Drawing.Size(46, 20);
            this.textBox_BuzzerFreq.TabIndex = 1;
            this.textBox_BuzzerFreq.Text = "2";
            // 
            // textBox_BuzzerRepeat
            // 
            this.textBox_BuzzerRepeat.Location = new System.Drawing.Point(54, 52);
            this.textBox_BuzzerRepeat.Name = "textBox_BuzzerRepeat";
            this.textBox_BuzzerRepeat.Size = new System.Drawing.Size(46, 20);
            this.textBox_BuzzerRepeat.TabIndex = 4;
            this.textBox_BuzzerRepeat.Text = "2";
            // 
            // textBox_BuzzerOnTime
            // 
            this.textBox_BuzzerOnTime.Location = new System.Drawing.Point(54, 81);
            this.textBox_BuzzerOnTime.Name = "textBox_BuzzerOnTime";
            this.textBox_BuzzerOnTime.Size = new System.Drawing.Size(46, 20);
            this.textBox_BuzzerOnTime.TabIndex = 7;
            this.textBox_BuzzerOnTime.Text = "6";
            // 
            // textBox_BuzzerOffTime
            // 
            this.textBox_BuzzerOffTime.Location = new System.Drawing.Point(54, 112);
            this.textBox_BuzzerOffTime.Name = "textBox_BuzzerOffTime";
            this.textBox_BuzzerOffTime.Size = new System.Drawing.Size(46, 20);
            this.textBox_BuzzerOffTime.TabIndex = 9;
            this.textBox_BuzzerOffTime.Text = "2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_PreScaler);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.button_Prescaler);
            this.groupBox4.Controls.Add(this.button_Sync);
            this.groupBox4.Controls.Add(this.textBox_GreenOnDuty);
            this.groupBox4.Controls.Add(this.button_BlueApply);
            this.groupBox4.Controls.Add(this.textBox_RedOnDuty);
            this.groupBox4.Controls.Add(this.textBox_RedOffDuty);
            this.groupBox4.Controls.Add(this.button_RedApply);
            this.groupBox4.Controls.Add(this.textBox_GreenOffDuty);
            this.groupBox4.Controls.Add(this.textBox_BlueOnDuty);
            this.groupBox4.Controls.Add(this.button_GreenApply);
            this.groupBox4.Controls.Add(this.textBox_BlueOffDuty);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox_BluePower);
            this.groupBox4.Controls.Add(this.textBox_GreenOffset);
            this.groupBox4.Controls.Add(this.textBox_RedOffset);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox_BlueOffset);
            this.groupBox4.Controls.Add(this.textBox_GreenPower);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_RedPower);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(196, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 146);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED Parameters";
            // 
            // textBox_PreScaler
            // 
            this.textBox_PreScaler.Location = new System.Drawing.Point(152, 118);
            this.textBox_PreScaler.Name = "textBox_PreScaler";
            this.textBox_PreScaler.Size = new System.Drawing.Size(40, 20);
            this.textBox_PreScaler.TabIndex = 22;
            this.textBox_PreScaler.Text = "10";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(84, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Prescaler(ms)";
            // 
            // button_Prescaler
            // 
            this.button_Prescaler.Location = new System.Drawing.Point(198, 117);
            this.button_Prescaler.Name = "button_Prescaler";
            this.button_Prescaler.Size = new System.Drawing.Size(48, 22);
            this.button_Prescaler.TabIndex = 23;
            this.button_Prescaler.Text = "Apply";
            this.button_Prescaler.UseVisualStyleBackColor = true;
            this.button_Prescaler.Click += new System.EventHandler(this.button_Prescaler_Click);
            // 
            // button_Sync
            // 
            this.button_Sync.Location = new System.Drawing.Point(6, 117);
            this.button_Sync.Name = "button_Sync";
            this.button_Sync.Size = new System.Drawing.Size(72, 22);
            this.button_Sync.TabIndex = 20;
            this.button_Sync.Text = "&Sync";
            this.button_Sync.UseVisualStyleBackColor = true;
            this.button_Sync.Click += new System.EventHandler(this.button_Sync_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_BuzzerStop);
            this.groupBox5.Controls.Add(this.button_BuzzerStart);
            this.groupBox5.Controls.Add(this.textBox_BuzzerFreq);
            this.groupBox5.Controls.Add(this.textBox_BuzzerOffTime);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textBox_BuzzerOnTime);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBox_BuzzerRepeat);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(458, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 146);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buzzer Control";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 246);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Delcom C# USB HID Visual Indicator Control v1.5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_DeviceName;
        private System.Windows.Forms.Label label_DeviceStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_BlueFlash;
        private System.Windows.Forms.Button button_BlueOn;
        private System.Windows.Forms.Button button_BlueOff;
        private System.Windows.Forms.Button button_RedFlash;
        private System.Windows.Forms.Button button_RedOn;
        private System.Windows.Forms.Button button_RedOff;
        private System.Windows.Forms.Button button_GreenFlash;
        private System.Windows.Forms.Button button_GreenOn;
        private System.Windows.Forms.Button button_GreenOff;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_BluePower;
        private System.Windows.Forms.TextBox textBox_BlueOffset;
        private System.Windows.Forms.TextBox textBox_RedPower;
        private System.Windows.Forms.TextBox textBox_RedOffset;
        private System.Windows.Forms.TextBox textBox_GreenPower;
        private System.Windows.Forms.TextBox textBox_GreenOffset;
        private System.Windows.Forms.TextBox textBox_BlueOffDuty;
        private System.Windows.Forms.TextBox textBox_BlueOnDuty;
        private System.Windows.Forms.TextBox textBox_RedOffDuty;
        private System.Windows.Forms.TextBox textBox_RedOnDuty;
        private System.Windows.Forms.TextBox textBox_GreenOffDuty;
        private System.Windows.Forms.TextBox textBox_GreenOnDuty;
        private System.Windows.Forms.Button button_BlueApply;
        private System.Windows.Forms.Button button_RedApply;
        private System.Windows.Forms.Button button_GreenApply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_BuzzerOnTime;
        private System.Windows.Forms.TextBox textBox_BuzzerRepeat;
        private System.Windows.Forms.TextBox textBox_BuzzerFreq;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_BuzzerStop;
        private System.Windows.Forms.Button button_BuzzerStart;
        private System.Windows.Forms.TextBox textBox_BuzzerOffTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_SwitchAudiConfirm;
        private System.Windows.Forms.CheckBox checkBox_SwitchAutoClear;
        private System.Windows.Forms.CheckBox checkBox_Switch;
        private System.Windows.Forms.Button button_UpdateSwitch;
        private System.Windows.Forms.TextBox textBox_PreScaler;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button_Prescaler;
        private System.Windows.Forms.Button button_Sync;
    }
}

