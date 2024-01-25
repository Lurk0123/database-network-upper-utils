using System;
using System.Windows.Forms;

namespace DataBaseNetWorkTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DataBaseConnect_Click(object sender, EventArgs e)
        {
             DataBaseConnectionForm dataBaseConnectionForm = new DataBaseConnectionForm();
            dataBaseConnectionForm.ShowDialog();
        }

        private void NetCommunication_Click(object sender, EventArgs e)
        {
            NetWorkConnection netWorkConnection = new NetWorkConnection();
            netWorkConnection.ShowDialog();
        }

        private void SerialCommunication_Click(object sender, EventArgs e)
        {
            SerialCommunication serialCommunication = new SerialCommunication();
            serialCommunication.ShowDialog();
        }
    }
}
