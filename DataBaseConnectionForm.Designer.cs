
namespace DataBaseNetWorkTool
{
    partial class DataBaseConnectionForm
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
            this.DataBaseGroup = new System.Windows.Forms.GroupBox();
            this.SelectDB = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DataBaseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataBaseTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataSet = new System.Windows.Forms.DataGridView();
            this.Sql = new System.Windows.Forms.TextBox();
            this.Exec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DBlocation = new System.Windows.Forms.TextBox();
            this.DataBaseGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBaseGroup
            // 
            this.DataBaseGroup.Controls.Add(this.SelectDB);
            this.DataBaseGroup.Controls.Add(this.Port);
            this.DataBaseGroup.Controls.Add(this.label5);
            this.DataBaseGroup.Controls.Add(this.Connect);
            this.DataBaseGroup.Controls.Add(this.label4);
            this.DataBaseGroup.Controls.Add(this.DataBaseType);
            this.DataBaseGroup.Controls.Add(this.label3);
            this.DataBaseGroup.Controls.Add(this.label2);
            this.DataBaseGroup.Controls.Add(this.UserName);
            this.DataBaseGroup.Controls.Add(this.Password);
            this.DataBaseGroup.Controls.Add(this.Host);
            this.DataBaseGroup.Controls.Add(this.label1);
            this.DataBaseGroup.Location = new System.Drawing.Point(12, 9);
            this.DataBaseGroup.Name = "DataBaseGroup";
            this.DataBaseGroup.Size = new System.Drawing.Size(211, 177);
            this.DataBaseGroup.TabIndex = 0;
            this.DataBaseGroup.TabStop = false;
            this.DataBaseGroup.Text = "数据库连接";
            // 
            // SelectDB
            // 
            this.SelectDB.Location = new System.Drawing.Point(0, 148);
            this.SelectDB.Name = "SelectDB";
            this.SelectDB.Size = new System.Drawing.Size(119, 23);
            this.SelectDB.TabIndex = 11;
            this.SelectDB.Text = "选择数据库文件";
            this.SelectDB.UseVisualStyleBackColor = true;
            this.SelectDB.Visible = false;
            this.SelectDB.Click += new System.EventHandler(this.SelectDB_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(93, 41);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(107, 21);
            this.Port.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port:";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(125, 148);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "连接";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "选择数据库类型";
            // 
            // DataBaseType
            // 
            this.DataBaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBaseType.FormattingEnabled = true;
            this.DataBaseType.Items.AddRange(new object[] {
            "MySQL",
            "Sql Server",
            "Access",
            "Sqlite"});
            this.DataBaseType.Location = new System.Drawing.Point(103, 122);
            this.DataBaseType.Name = "DataBaseType";
            this.DataBaseType.Size = new System.Drawing.Size(97, 20);
            this.DataBaseType.TabIndex = 6;
            this.DataBaseType.SelectedIndexChanged += new System.EventHandler(this.DataBaseType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserName：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password：";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(93, 68);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(107, 21);
            this.UserName.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(93, 95);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(107, 21);
            this.Password.TabIndex = 2;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(93, 12);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(107, 21);
            this.Host.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host：";
            // 
            // DataBaseTreeView
            // 
            this.DataBaseTreeView.Location = new System.Drawing.Point(12, 225);
            this.DataBaseTreeView.Name = "DataBaseTreeView";
            this.DataBaseTreeView.Size = new System.Drawing.Size(211, 421);
            this.DataBaseTreeView.TabIndex = 1;
            this.DataBaseTreeView.DoubleClick += new System.EventHandler(this.DataBaseTreeView_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.DataSet);
            this.panel1.Location = new System.Drawing.Point(237, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 598);
            this.panel1.TabIndex = 2;
            // 
            // DataSet
            // 
            this.DataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSet.Location = new System.Drawing.Point(0, 0);
            this.DataSet.Name = "DataSet";
            this.DataSet.RowTemplate.Height = 23;
            this.DataSet.Size = new System.Drawing.Size(594, 629);
            this.DataSet.TabIndex = 0;
            // 
            // Sql
            // 
            this.Sql.Location = new System.Drawing.Point(237, 15);
            this.Sql.Name = "Sql";
            this.Sql.Size = new System.Drawing.Size(513, 21);
            this.Sql.TabIndex = 3;
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(756, 11);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(60, 26);
            this.Exec.TabIndex = 4;
            this.Exec.Text = "执行";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 5;
            // 
            // DBlocation
            // 
            this.DBlocation.Location = new System.Drawing.Point(12, 189);
            this.DBlocation.Name = "DBlocation";
            this.DBlocation.ReadOnly = true;
            this.DBlocation.Size = new System.Drawing.Size(199, 21);
            this.DBlocation.TabIndex = 6;
            this.DBlocation.Visible = false;
            // 
            // DataBaseConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 658);
            this.Controls.Add(this.DBlocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.Sql);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataBaseTreeView);
            this.Controls.Add(this.DataBaseGroup);
            this.Name = "DataBaseConnectionForm";
            this.Text = "数据库连接";
            this.DataBaseGroup.ResumeLayout(false);
            this.DataBaseGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DataBaseGroup;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DataBaseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView DataBaseTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataSet;
        private System.Windows.Forms.TextBox Sql;
        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SelectDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DBlocation;
    }
}