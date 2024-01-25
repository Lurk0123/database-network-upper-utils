
namespace DataBaseNetWorkTool
{
    partial class NetWorkConnection
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendTextClear = new System.Windows.Forms.Button();
            this.SendMessage = new System.Windows.Forms.Button();
            this.SendText = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReceiveClear = new System.Windows.Forms.Button();
            this.ReceiveArea = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HostProtocol = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HostPort = new System.Windows.Forms.TextBox();
            this.HostConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HostAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListenPort = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ListenProtocol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Listen = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendTextClear);
            this.groupBox2.Controls.Add(this.SendMessage);
            this.groupBox2.Controls.Add(this.SendText);
            this.groupBox2.Location = new System.Drawing.Point(231, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送区";
            // 
            // SendTextClear
            // 
            this.SendTextClear.Location = new System.Drawing.Point(460, 154);
            this.SendTextClear.Name = "SendTextClear";
            this.SendTextClear.Size = new System.Drawing.Size(75, 23);
            this.SendTextClear.TabIndex = 3;
            this.SendTextClear.Text = "清除内容";
            this.SendTextClear.UseVisualStyleBackColor = true;
            this.SendTextClear.Click += new System.EventHandler(this.SendTextClear_Click);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(460, 183);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(75, 23);
            this.SendMessage.TabIndex = 2;
            this.SendMessage.Text = "发送";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(6, 20);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(448, 186);
            this.SendText.TabIndex = 1;
            this.SendText.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReceiveClear);
            this.groupBox3.Controls.Add(this.ReceiveArea);
            this.groupBox3.Location = new System.Drawing.Point(233, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 196);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收区";
            // 
            // ReceiveClear
            // 
            this.ReceiveClear.Location = new System.Drawing.Point(458, 167);
            this.ReceiveClear.Name = "ReceiveClear";
            this.ReceiveClear.Size = new System.Drawing.Size(75, 23);
            this.ReceiveClear.TabIndex = 4;
            this.ReceiveClear.Text = "清除内容";
            this.ReceiveClear.UseVisualStyleBackColor = true;
            this.ReceiveClear.Click += new System.EventHandler(this.ReceiveClear_Click);
            // 
            // ReceiveArea
            // 
            this.ReceiveArea.Location = new System.Drawing.Point(11, 18);
            this.ReceiveArea.Name = "ReceiveArea";
            this.ReceiveArea.Size = new System.Drawing.Size(441, 172);
            this.ReceiveArea.TabIndex = 0;
            this.ReceiveArea.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择协议(TCP/UDP)：";
            // 
            // HostProtocol
            // 
            this.HostProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostProtocol.FormattingEnabled = true;
            this.HostProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.HostProtocol.Location = new System.Drawing.Point(138, 27);
            this.HostProtocol.Name = "HostProtocol";
            this.HostProtocol.Size = new System.Drawing.Size(71, 20);
            this.HostProtocol.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HostPort);
            this.groupBox1.Controls.Add(this.HostConnect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HostAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目标主机配置";
            // 
            // HostPort
            // 
            this.HostPort.Location = new System.Drawing.Point(114, 55);
            this.HostPort.Name = "HostPort";
            this.HostPort.Size = new System.Drawing.Size(83, 21);
            this.HostPort.TabIndex = 3;
            // 
            // HostConnect
            // 
            this.HostConnect.Location = new System.Drawing.Point(122, 98);
            this.HostConnect.Name = "HostConnect";
            this.HostConnect.Size = new System.Drawing.Size(75, 23);
            this.HostConnect.TabIndex = 10;
            this.HostConnect.Text = "建立连接";
            this.HostConnect.UseVisualStyleBackColor = true;
            this.HostConnect.Click += new System.EventHandler(this.HostConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "目标端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "目标IP：";
            // 
            // HostAddress
            // 
            this.HostAddress.Location = new System.Drawing.Point(97, 20);
            this.HostAddress.Name = "HostAddress";
            this.HostAddress.Size = new System.Drawing.Size(100, 21);
            this.HostAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "使用端口(可选)：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 21);
            this.textBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "监听端口：";
            // 
            // ListenPort
            // 
            this.ListenPort.Location = new System.Drawing.Point(97, 66);
            this.ListenPort.Name = "ListenPort";
            this.ListenPort.Size = new System.Drawing.Size(100, 21);
            this.ListenPort.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ListenProtocol);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Listen);
            this.groupBox4.Controls.Add(this.ListenPort);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 133);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "本机配置";
            // 
            // ListenProtocol
            // 
            this.ListenProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListenProtocol.FormattingEnabled = true;
            this.ListenProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.ListenProtocol.Location = new System.Drawing.Point(131, 27);
            this.ListenProtocol.Name = "ListenProtocol";
            this.ListenProtocol.Size = new System.Drawing.Size(66, 20);
            this.ListenProtocol.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "选择协议(TCP/UDP)：";
            // 
            // Listen
            // 
            this.Listen.Location = new System.Drawing.Point(122, 104);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(75, 23);
            this.Listen.TabIndex = 10;
            this.Listen.Text = "开始监听";
            this.Listen.UseVisualStyleBackColor = true;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // NetWorkConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HostProtocol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "NetWorkConnection";
            this.Text = "NetWorkConnection";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SendTextClear;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.RichTextBox SendText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ReceiveClear;
        private System.Windows.Forms.RichTextBox ReceiveArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HostProtocol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox HostPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HostAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ListenPort;
        private System.Windows.Forms.Button HostConnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.ComboBox ListenProtocol;
        private System.Windows.Forms.Label label6;
    }
}