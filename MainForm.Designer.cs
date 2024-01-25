
namespace DataBaseNetWorkTool
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataBaseConnect = new System.Windows.Forms.Button();
            this.NetCommunication = new System.Windows.Forms.Button();
            this.SerialCommunication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataBaseConnect
            // 
            this.DataBaseConnect.Location = new System.Drawing.Point(45, 32);
            this.DataBaseConnect.Name = "DataBaseConnect";
            this.DataBaseConnect.Size = new System.Drawing.Size(103, 29);
            this.DataBaseConnect.TabIndex = 0;
            this.DataBaseConnect.Text = "数据库连接工具";
            this.DataBaseConnect.UseVisualStyleBackColor = true;
            this.DataBaseConnect.Click += new System.EventHandler(this.DataBaseConnect_Click);
            // 
            // NetCommunication
            // 
            this.NetCommunication.Location = new System.Drawing.Point(45, 81);
            this.NetCommunication.Name = "NetCommunication";
            this.NetCommunication.Size = new System.Drawing.Size(103, 29);
            this.NetCommunication.TabIndex = 1;
            this.NetCommunication.Text = "网络通信工具";
            this.NetCommunication.UseVisualStyleBackColor = true;
            this.NetCommunication.Click += new System.EventHandler(this.NetCommunication_Click);
            // 
            // SerialCommunication
            // 
            this.SerialCommunication.Location = new System.Drawing.Point(45, 132);
            this.SerialCommunication.Name = "SerialCommunication";
            this.SerialCommunication.Size = new System.Drawing.Size(103, 29);
            this.SerialCommunication.TabIndex = 2;
            this.SerialCommunication.Text = "串口通信工具";
            this.SerialCommunication.UseVisualStyleBackColor = true;
            this.SerialCommunication.Click += new System.EventHandler(this.SerialCommunication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 211);
            this.Controls.Add(this.SerialCommunication);
            this.Controls.Add(this.NetCommunication);
            this.Controls.Add(this.DataBaseConnect);
            this.Name = "MainForm";
            this.Text = "欢迎";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DataBaseConnect;
        private System.Windows.Forms.Button NetCommunication;
        private System.Windows.Forms.Button SerialCommunication;
    }
}

