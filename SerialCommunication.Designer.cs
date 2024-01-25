
namespace DataBaseNetWorkTool
{
    partial class SerialCommunication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenSerial = new System.Windows.Forms.Button();
            this.DTR_ch = new System.Windows.Forms.CheckBox();
            this.RTS_ch = new System.Windows.Forms.CheckBox();
            this.StopBit = new System.Windows.Forms.ComboBox();
            this.DataBit = new System.Windows.Forms.ComboBox();
            this.CheckBit = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.Port = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.receive = new System.Windows.Forms.TextBox();
            this.save_data = new System.Windows.Forms.Button();
            this.select_dir = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.hex = new System.Windows.Forms.CheckBox();
            this.auto_clear = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.auto_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.send_file_text = new System.Windows.Forms.TextBox();
            this.send_file = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.Button();
            this.send_clear = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.SendHex = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ReceiveData = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SendData = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ReceiveNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenSerial);
            this.groupBox1.Controls.Add(this.DTR_ch);
            this.groupBox1.Controls.Add(this.RTS_ch);
            this.groupBox1.Controls.Add(this.StopBit);
            this.groupBox1.Controls.Add(this.DataBit);
            this.groupBox1.Controls.Add(this.CheckBit);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // OpenSerial
            // 
            this.OpenSerial.Location = new System.Drawing.Point(91, 168);
            this.OpenSerial.Name = "OpenSerial";
            this.OpenSerial.Size = new System.Drawing.Size(104, 38);
            this.OpenSerial.TabIndex = 12;
            this.OpenSerial.Text = "打开串口";
            this.OpenSerial.UseVisualStyleBackColor = true;
            this.OpenSerial.Click += new System.EventHandler(this.OpenSerial_Click);
            // 
            // DTR_ch
            // 
            this.DTR_ch.AutoSize = true;
            this.DTR_ch.Location = new System.Drawing.Point(24, 190);
            this.DTR_ch.Name = "DTR_ch";
            this.DTR_ch.Size = new System.Drawing.Size(42, 16);
            this.DTR_ch.TabIndex = 11;
            this.DTR_ch.Text = "DTR";
            this.DTR_ch.UseVisualStyleBackColor = true;
            // 
            // RTS_ch
            // 
            this.RTS_ch.AutoSize = true;
            this.RTS_ch.Location = new System.Drawing.Point(24, 168);
            this.RTS_ch.Name = "RTS_ch";
            this.RTS_ch.Size = new System.Drawing.Size(42, 16);
            this.RTS_ch.TabIndex = 10;
            this.RTS_ch.Text = "RTS";
            this.RTS_ch.UseVisualStyleBackColor = true;
            // 
            // StopBit
            // 
            this.StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBit.FormattingEnabled = true;
            this.StopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBit.Location = new System.Drawing.Point(66, 132);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(129, 20);
            this.StopBit.TabIndex = 9;
            // 
            // DataBit
            // 
            this.DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBit.FormattingEnabled = true;
            this.DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBit.Location = new System.Drawing.Point(66, 106);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(129, 20);
            this.DataBit.TabIndex = 8;
            // 
            // CheckBit
            // 
            this.CheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckBit.FormattingEnabled = true;
            this.CheckBit.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.CheckBit.Location = new System.Drawing.Point(66, 79);
            this.CheckBit.Name = "CheckBit";
            this.CheckBit.Size = new System.Drawing.Size(129, 20);
            this.CheckBit.TabIndex = 7;
            // 
            // BaudRate
            // 
            this.BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(66, 53);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(129, 20);
            this.BaudRate.TabIndex = 6;
            // 
            // Port
            // 
            this.Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port.FormattingEnabled = true;
            this.Port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.Port.Location = new System.Drawing.Point(66, 25);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(129, 20);
            this.Port.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "波特率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "停止位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.receive);
            this.groupBox2.Controls.Add(this.save_data);
            this.groupBox2.Controls.Add(this.select_dir);
            this.groupBox2.Controls.Add(this.stop);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.hex);
            this.groupBox2.Controls.Add(this.auto_clear);
            this.groupBox2.Location = new System.Drawing.Point(14, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // receive
            // 
            this.receive.Location = new System.Drawing.Point(3, 107);
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(173, 21);
            this.receive.TabIndex = 6;
            // 
            // save_data
            // 
            this.save_data.Location = new System.Drawing.Point(101, 72);
            this.save_data.Name = "save_data";
            this.save_data.Size = new System.Drawing.Size(75, 23);
            this.save_data.TabIndex = 5;
            this.save_data.Text = "保存数据";
            this.save_data.UseVisualStyleBackColor = true;
            // 
            // select_dir
            // 
            this.select_dir.Location = new System.Drawing.Point(7, 72);
            this.select_dir.Name = "select_dir";
            this.select_dir.Size = new System.Drawing.Size(75, 23);
            this.select_dir.TabIndex = 4;
            this.select_dir.Text = "选择路径";
            this.select_dir.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(101, 46);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "暂停";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(101, 17);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "手动清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Location = new System.Drawing.Point(6, 50);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(72, 16);
            this.hex.TabIndex = 1;
            this.hex.Text = "十六进制";
            this.hex.UseVisualStyleBackColor = true;
            this.hex.CheckedChanged += new System.EventHandler(this.ReceiveHex_CheckedChanged);
            // 
            // auto_clear
            // 
            this.auto_clear.AutoSize = true;
            this.auto_clear.Location = new System.Drawing.Point(7, 21);
            this.auto_clear.Name = "auto_clear";
            this.auto_clear.Size = new System.Drawing.Size(72, 16);
            this.auto_clear.TabIndex = 0;
            this.auto_clear.Text = "自动清空";
            this.auto_clear.UseVisualStyleBackColor = true;
            this.auto_clear.CheckedChanged += new System.EventHandler(this.auto_clear_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.auto_time);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.send_file_text);
            this.groupBox3.Controls.Add(this.send_file);
            this.groupBox3.Controls.Add(this.open_file);
            this.groupBox3.Controls.Add(this.send_clear);
            this.groupBox3.Controls.Add(this.Send);
            this.groupBox3.Controls.Add(this.SendHex);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 174);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // auto_time
            // 
            this.auto_time.Location = new System.Drawing.Point(115, 146);
            this.auto_time.Name = "auto_time";
            this.auto_time.Size = new System.Drawing.Size(61, 21);
            this.auto_time.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "自动发送周期(ms)";
            // 
            // send_file_text
            // 
            this.send_file_text.Location = new System.Drawing.Point(8, 107);
            this.send_file_text.Name = "send_file_text";
            this.send_file_text.Size = new System.Drawing.Size(168, 21);
            this.send_file_text.TabIndex = 6;
            // 
            // send_file
            // 
            this.send_file.Location = new System.Drawing.Point(101, 72);
            this.send_file.Name = "send_file";
            this.send_file.Size = new System.Drawing.Size(75, 23);
            this.send_file.TabIndex = 5;
            this.send_file.Text = "发送文件";
            this.send_file.UseVisualStyleBackColor = true;
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(7, 72);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(75, 23);
            this.open_file.TabIndex = 4;
            this.open_file.Text = "打开文件";
            this.open_file.UseVisualStyleBackColor = true;
            // 
            // send_clear
            // 
            this.send_clear.Location = new System.Drawing.Point(101, 46);
            this.send_clear.Name = "send_clear";
            this.send_clear.Size = new System.Drawing.Size(75, 23);
            this.send_clear.TabIndex = 3;
            this.send_clear.Text = "清空发送";
            this.send_clear.UseVisualStyleBackColor = true;
            this.send_clear.Click += new System.EventHandler(this.send_clear_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(101, 17);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "手动发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // SendHex
            // 
            this.SendHex.AutoSize = true;
            this.SendHex.Location = new System.Drawing.Point(6, 50);
            this.SendHex.Name = "SendHex";
            this.SendHex.Size = new System.Drawing.Size(72, 16);
            this.SendHex.TabIndex = 1;
            this.SendHex.Text = "十六进制";
            this.SendHex.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 21);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(72, 16);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "自动发送";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ReceiveData);
            this.groupBox4.Location = new System.Drawing.Point(236, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 324);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // ReceiveData
            // 
            this.ReceiveData.Location = new System.Drawing.Point(0, 19);
            this.ReceiveData.Name = "ReceiveData";
            this.ReceiveData.Size = new System.Drawing.Size(388, 305);
            this.ReceiveData.TabIndex = 0;
            this.ReceiveData.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SendData);
            this.groupBox5.Location = new System.Drawing.Point(237, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 194);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // SendData
            // 
            this.SendData.Location = new System.Drawing.Point(-1, 20);
            this.SendData.Name = "SendData";
            this.SendData.Size = new System.Drawing.Size(387, 173);
            this.SendData.TabIndex = 0;
            this.SendData.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox7);
            this.groupBox6.Controls.Add(this.richTextBox3);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(632, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(156, 292);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "指令解析";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(9, 232);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(108, 16);
            this.checkBox7.TabIndex = 10;
            this.checkBox7.Text = "启动数据帧接收";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(9, 164);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(128, 60);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "数据帧";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(48, 47);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(88, 21);
            this.textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(48, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 21);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(48, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(88, 21);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(48, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 21);
            this.textBox4.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "数据4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "数据3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "数据2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "数据1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.ReceiveNum,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel2.Text = "初始化正常！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel4.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // ReceiveNum
            // 
            this.ReceiveNum.AutoSize = false;
            this.ReceiveNum.Name = "ReceiveNum";
            this.ReceiveNum.Size = new System.Drawing.Size(50, 17);
            this.ReceiveNum.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel7.Text = "清空计数";
            this.toolStripStatusLabel7.Click += new System.EventHandler(this.ClearCount_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SerialCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SerialCommunication";
            this.Text = "SerialCommunication";
            this.Load += new System.EventHandler(this.SerialCommunication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox StopBit;
        private System.Windows.Forms.ComboBox DataBit;
        private System.Windows.Forms.ComboBox CheckBit;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenSerial;
        private System.Windows.Forms.CheckBox DTR_ch;
        private System.Windows.Forms.CheckBox RTS_ch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox receive;
        private System.Windows.Forms.Button save_data;
        private System.Windows.Forms.Button select_dir;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox hex;
        private System.Windows.Forms.CheckBox auto_clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox auto_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox send_file_text;
        private System.Windows.Forms.Button send_file;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.Button send_clear;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.CheckBox SendHex;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox ReceiveData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox SendData;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel ReceiveNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
    }
}