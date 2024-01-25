using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DataBaseNetWorkTool
{
    public partial class NetWorkConnection : Form
    {
        public NetWorkConnection()
        {
            InitializeComponent();
            receiveTextUpdater = new RichTextBoxUpdate(ShowInfo);
            buttonTextUpdater = new ButtonTextUpdate(updateButtonText);
        }
        private delegate void RichTextBoxUpdate(RichTextBox richText,string context);
        private delegate void ButtonTextUpdate(Button button, string text);
        private RichTextBoxUpdate receiveTextUpdater;
        private ButtonTextUpdate buttonTextUpdater;
        private bool isListening = false;
        private bool isConnecting = false;
        private bool isReadySend = false;
        private TcpClient hostTcpClient = null;
        private void Listen_Click(object sender, EventArgs e)
        {
            if (ListenProtocol.Text.Length == 0)
            {
                MessageBox.Show("请选择通信协议！");
                return;
            }
            if (ListenPort.Text.Length == 0)
            {
                MessageBox.Show("请输入监听端口");
                return;
            }
            if (isListening)
            {
                isListening = false;
                Listen.Text = "开始监听";
                MessageBox.Show("监听已停止！");
                return;
            }
            int port = int.Parse(ListenPort.Text);
            if (!IsPortAvailable(port))
            {
                MessageBox.Show("端口占用，请等待端口释放或主动关闭端口");
                return;
            }
            isListening = true;
            Listen.Text = "停止监听";
            MessageBox.Show("开始监听！");
            if (ListenProtocol.Text == "TCP")
            {
                ThreadPool.QueueUserWorkItem(state => TCPListenerHandler(port));
                return;
            }
            ThreadPool.QueueUserWorkItem(state => UDPListenerHandler(port));
        }
        private void TCPListenerHandler(int port)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            TcpClient tcpClient=tcpListener.AcceptTcpClient();
            MessageBox.Show("建立连接成功！");
            NetworkStream stream=tcpClient.GetStream();
            byte[] buffer = new byte[1024];
            while (isListening&&tcpClient.Connected)
            {
                int readLength=stream.Read(buffer, 0, buffer.Length);
                if (readLength <= 0)
                {
                    break;
                }
                byte[] newData = new byte[1024];
                Array.Copy(buffer, 0, newData, 0, readLength);
                string context= Encoding.UTF8.GetString(newData);
                receiveTextUpdater(ReceiveArea, context);
            }
            MessageBox.Show("连接已断开！");
            buttonTextUpdater(Listen,"开始监听");
            stream.Close();
            tcpClient.Close();
            tcpListener.Stop();
        }
        private void UDPListenerHandler(int port)
        {
            UdpClient udpClient= new UdpClient(port);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, port);
            while (isListening)
            {
                byte[] buffer = udpClient.Receive(ref groupEP);
                string context = Encoding.UTF8.GetString(buffer);
                receiveTextUpdater(ReceiveArea,context);
            }
            MessageBox.Show("停止监听！");
            buttonTextUpdater(Listen,"开始监听");
            udpClient.Close();
        }

        private void HostConnect_Click(object sender, EventArgs e)
        {
            if (HostAddress.Text.Length==0)
            {
                MessageBox.Show("远程主机IP不可为空");
                return;
            }
            if (HostPort.Text.Length == 0)
            {
                MessageBox.Show("远程主机端口不可为空");
                return;
            }
            if (HostProtocol.Text.Length == 0)
            {
                MessageBox.Show("请选择协议!"); 
            }
            if (isConnecting)
            {
                isConnecting = false;
                isReadySend = false;
                HostConnect.Text = "建立连接";
                return;
            }
            HostConnect.Text = "断开连接";
            if (HostProtocol.Text == "TCP")
            {
                string ipAddress = HostAddress.Text;
                int hostPort = int.Parse(HostPort.Text);
                ThreadPool.QueueUserWorkItem(state => HostTCPHandler(ipAddress,hostPort));
                return;
            }
            HostUDPHandler();
        }
        private void HostTCPHandler(string ipAddress,int port)
        {
            MessageBox.Show("尝试与远程主机"+ipAddress+":"+port+"建立连接");
            isConnecting = true;
            while (isConnecting)
            {
                hostTcpClient = new TcpClient();
                IAsyncResult result = hostTcpClient.BeginConnect(ipAddress, port, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(2000, true);
                if (success)
                {
                    MessageBox.Show("连接成功");
                    isReadySend = true;
                    break;
                }
            }
            while (isConnecting&& hostTcpClient.Connected)
            {
                Thread.Sleep(2000);
                bool connected=IsSocketConnect(hostTcpClient);
                if (!connected)
                {
                    MessageBox.Show("主机已断开连接！");
                    break;
                }
            }
            isReadySend = false;
            buttonTextUpdater(HostConnect,"建立连接");
            hostTcpClient.Close();
        }
        private void HostUDPHandler()
        {
            isConnecting = true;
            isReadySend = true;
            buttonTextUpdater(HostConnect,"建立连接");
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (SendText.Text.Length==0)
            {
                MessageBox.Show("发送内容不可为空");
                return;
            }
            if (!isReadySend||!isConnecting)
            {
                MessageBox.Show("请先连接或配置主机");
                return;
            }
            if (HostProtocol.Text == "TCP")
            {
                NetworkStream networkStream = hostTcpClient.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(SendText.Text);
                networkStream.Write(buffer, 0, buffer.Length);
                MessageBox.Show("发送成功！");
                return;
            }
            string hostAddress = HostAddress.Text;
            int port = int.Parse(HostPort.Text);
            UdpClient udpClient = new UdpClient();
            byte[] context = Encoding.UTF8.GetBytes(SendText.Text);
            udpClient.Send(context, context.Length, hostAddress,port);
            MessageBox.Show("发送成功！");
        }

        private void SendTextClear_Click(object sender, EventArgs e)
        {
            SendText.Clear();
        }

        private void ReceiveClear_Click(object sender, EventArgs e)
        {
            ReceiveArea.Clear();
        }
        private void ShowInfo(RichTextBox richTextBox,string context)
        {
            richTextBox.Invoke(new Action(() =>
            {
                richTextBox.AppendText(context);
            }));
        }
        private void updateButtonText(Button button,string context)
        {
            button.Invoke(new Action(() =>
            {
                button.Text = context;
            }));
        }
        bool IsPortAvailable(int port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] activeEndpoints = ipGlobalProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endpoint in activeEndpoints)
            {
                if (endpoint.Port == port)
                {
                    // 端口已被占用
                    return false;
                }
            }
            // 端口未被占用
            return true;
        }
        public bool IsSocketConnect(TcpClient client) //判断一个socket是否处于连接状态
        {
            if (client == null || client.Client == null)
            {
                return false;
            }
            //先看看状态
            if (client.Client.Connected == false || client.Client.RemoteEndPoint == null)
            {
                return false;
            }
            //尝试发送以非阻塞模式发送一个消息 注意这个非阻塞模式不会影响异步发送
            bool blockingState = client.Client.Blocking;
            try
            {
                byte[] tmp = new byte[1];
                client.Client.Blocking = false;
                client.Client.Send(tmp, 1, 0);
                return true;
            }
            catch (SocketException e)
            {
                // 产生 10035 == WSAEWOULDBLOCK 错误，说明被阻止了，但是还是连接的  这个错误是说发送缓冲区已满或者客户端的接收缓冲区已满
                if (e.NativeErrorCode.Equals(10035))
                    return true;
                else
                    return false;
            }
            finally
            {
                client.Client.Blocking = blockingState; //恢复状态
            }
        }
    }

}
