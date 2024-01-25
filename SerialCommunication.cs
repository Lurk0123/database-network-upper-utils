using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace DataBaseNetWorkTool
{
    public partial class SerialCommunication : Form
    {
        private bool isSerialOpen = false;
        private bool isRwShow = true;
        private List<byte> receiveBuffer=new List<byte>();
        private List<byte> sendBuffer = new List<byte>();
        private int receiveCount=0;
        private int sendCount = 0;
        private Dictionary<int, Parity> checkBitDictionary=new Dictionary<int, Parity>();
        private Dictionary<int, StopBits> stopBitDictionary=new Dictionary<int, StopBits>();
        public SerialCommunication()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            checkBitDictionary.Add(0, Parity.None);
            checkBitDictionary.Add(1, Parity.Odd);
            checkBitDictionary.Add(2,Parity.Even);

            stopBitDictionary.Add(0, StopBits.One);
            stopBitDictionary.Add(1, StopBits.OnePointFive);
            stopBitDictionary.Add(2,StopBits.Two);
        }
        private void SerialLoad()
        {
            EncodingInfo[] encodings = Encoding.GetEncodings();
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            string[] sSubKeys = keyCom.GetValueNames();
            Port.Items.Clear();
            foreach(var tempValue in sSubKeys){
                string portName =keyCom.GetValue(tempValue).ToString();
                Port.Items.Add(portName);
            }
            this.BaudRate.SelectedIndex = 1;
            this.CheckBit.SelectedIndex = 0;
            this.DataBit.SelectedIndex = 3;
            this.StopBit.SelectedIndex = 0;
        }
        private void ClearCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void SerialCommunication_Load(object sender, EventArgs e)
        {
            SerialLoad();
        }

        private void OpenSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isSerialOpen)
                {
                    serialPort.PortName = Port.Text;
                    serialPort.BaudRate = Convert.ToInt32(BaudRate.Text);
                    serialPort.DataBits = Convert.ToInt32(DataBit.Text);
                    serialPort.Parity = checkBitDictionary.ContainsKey(CheckBit.SelectedIndex) ? checkBitDictionary[CheckBit.SelectedIndex] : Parity.None;
                    serialPort.StopBits = stopBitDictionary.ContainsKey(StopBit.SelectedIndex) ? stopBitDictionary[StopBit.SelectedIndex] : StopBits.None;

                    serialPort.Open();
                    isSerialOpen = true;
                    OpenSerial.Text = "关闭串口";
                    return;
                }
                serialPort.Close();
                isSerialOpen = false;
                OpenSerial.Text = "打开串口";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + Port.Text.ToString());
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (this.SendData.Text == "")
            {
                MessageBox.Show("请输入数据！");
                return;
            }
            if (!this.serialPort.IsOpen)
            {
                MessageBox.Show("请打开串口！");
                return;
            }
            foreach(char c in SendData.Text)
            {
                sendBuffer.Add(Convert.ToByte(c));
            }
            serialPort.Write(sendBuffer.ToArray(),0,sendBuffer.Count);
            sendCount = sendBuffer.Count;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isRwShow)
            {
                return;
            }
            byte[] dataTemp=new byte[serialPort.ReadBufferSize];
            serialPort.Read(dataTemp,0,dataTemp.Length); 
            receiveBuffer.AddRange(dataTemp);
            receiveCount += dataTemp.Length;
            this.Invoke(new EventHandler(delegate
            {
                ReceiveNum.Text = receiveCount.ToString();
                if (!hex.Checked)
                {
                    string tempStr = Encoding.GetEncoding("gb2312").GetString(dataTemp);
                    ReceiveData.AppendText(tempStr);
                }
                else
                {
                    Transform.ToHexString(dataTemp," ");
                }
            }));
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (isRwShow)
            {
                isRwShow = false;
                stop.Text = "取消暂停";
                return;
            }
            isRwShow = true;
            stop.Text = "暂停";
        }

        private void ReceiveHex_CheckedChanged(object sender, EventArgs e)
        {
            if (ReceiveData.Text == "")
            {
                return;
            }
            if (SendHex.Checked)
            {
                ReceiveData.Text = Transform.ToHexString(receiveBuffer.ToArray()," ");
            }
            else
            {
                ReceiveData.Text = Encoding.GetEncoding("gb2312").GetString(receiveBuffer.ToArray());
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            ReceiveNum.Text = "0";
            ReceiveData.Text = "";
        }

        private void auto_clear_CheckedChanged(object sender, EventArgs e)
        {
            if (auto_clear.Checked)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ReceiveData.Text.Length > 4096)
            {
                receiveBuffer.Clear();
                ReceiveData.Text = "";
            }
        }

        private void send_clear_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            SendData.Text="";
            sendCount = 0;
        }
    }
}
