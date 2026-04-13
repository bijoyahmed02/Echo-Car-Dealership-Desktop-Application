using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ChatIng_Web_Application
{
    public partial class Main_Page : Form
    {
        // Variables for moving the form
        int mov;
        int movx;
        int movy;

        // Network-related variables
        private TcpClient client;
        private TcpListener listener;
        public StreamReader STR;
        public StreamWriter STW;
        public string reciver;
        public string TextToSent;



        public Main_Page()
        {
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIPTextBox.Text = address.ToString();
                }
            }
            chats_ScreenBox.ReadOnly = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int port;
            if (!int.TryParse(serverPORT.Text, out port))
            {
                MessageBox.Show("Invalid port number.");
                return;
            }

            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            chats_ScreenBox.AppendText("Server started. Waiting for a connection...\n");

            try
            {
                client = listener.AcceptTcpClient();
                chats_ScreenBox.AppendText("Client connected.\n");
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream()) { AutoFlush = true };

                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                }
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd;

            if (!IPAddress.TryParse(ClientIPTextBox.Text, out IPAddress ip))
            {
                MessageBox.Show("Invalid IP address.");
                return;
            }

            if (!int.TryParse(ClientPort.Text, out int port))
            {
                MessageBox.Show("Invalid port number.");
                return;
            }

            IpEnd = new IPEndPoint(ip, port);

            try
            {
                chats_ScreenBox.AppendText("Connecting to Server...\n");
                client.Connect(IpEnd);
                chats_ScreenBox.AppendText("Connected to Server.\n");
                STW = new StreamWriter(client.GetStream()) { AutoFlush = true };
                STR = new StreamReader(client.GetStream());

                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                }
                backgroundWorker1.RunWorkerAsync();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Socket Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client != null && client.Connected && !backgroundWorker1.CancellationPending)
            {
                try
                {
                    reciver = STR.ReadLine();
                    if (reciver != null)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            chats_ScreenBox.AppendText("-->You: " + reciver + "\n");
                        }));
                    }
                }
                catch (IOException ex)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        chats_ScreenBox.AppendText("Connection lost.\n");
                    }));
                    break;
                }
                catch (Exception ex)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        MessageBox.Show("Reading Error: " + ex.Message);
                    }));
                    break;
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    STW.WriteLine(TextToSent);
                    this.Invoke(new MethodInvoker(delegate
                    {
                        chats_ScreenBox.AppendText("-->Me: " + TextToSent + "\n");
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        MessageBox.Show("Not connected to server.");
                    }));
                }
            }
            catch (IOException ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    MessageBox.Show("Sending Failed: " + ex.Message);
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    MessageBox.Show("Sending Error: " + ex.Message);
                }));
            }
        }

        private void SentMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msg_textBox.Text))
            {
                TextToSent = msg_textBox.Text;
                if (!backgroundWorker2.IsBusy)
                {
                    backgroundWorker2.RunWorkerAsync();
                }
                msg_textBox.Text = "";
            }
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
            {
                this.Location = Screen.AllScreens[1].WorkingArea.Location;
            }
            else
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
        }

        private void Main_Page_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void Main_Page_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void Main_Page_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void chats_ScreenBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Hide();
        }

        private void name_list_Click(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            var info =new Sign_In_Page();
            info.Show();
            this.Close();
        }
    }
}
