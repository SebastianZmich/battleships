using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;
        string h = Char.ConvertFromUtf32(7);
        int numberOfRounds;
        int numberOfShips;
        bool infRounds;
        bool map_small = false;
        bool map_medium = false;
        bool map_large = false;
        public Form2()
        {
            InitializeComponent();
        }
        

        private void start_Click(object sender, EventArgs e)
        {
            if (map_small == true)
            {
                Form3 Form3 = new Form3();
                //Form3.NumberOfRoundss(rounds);
                Form3.InitialValues(Convert.ToInt32(numberOfShips));
                Form3.portnumber(int.Parse(Port.Text), IP.Text);
                //Form3.infinite(infRounds.Checked);
                client.Close();
                Form3.Show();
                Form1 Form1 = new Form1();
                Form1.NumberOfRoundss(Convert.ToInt32(numberOfRounds));
                Form1.infinite(infRounds);
                Hide();
            }
            if (map_medium == true)
            {
                Form5 Form5 = new Form5();
                //Form3.NumberOfRoundss(rounds);
                Form5.InitialValues(Convert.ToInt32(numberOfShips));
                Form5.portnumber(int.Parse(Port.Text), IP.Text);
                //Form3.infinite(infRounds.Checked);
                client.Close();
                Form5.Show();
                Form4 Form4 = new Form4();
                Form4.NumberOfRoundss(Convert.ToInt32(numberOfRounds));
                Form4.infinite(infRounds);
                Hide();
            }
            if (map_large == true)
            {
                Form7 Form7 = new Form7();
                //Form3.NumberOfRoundss(rounds);
                Form7.InitialValues(Convert.ToInt32(numberOfShips));
                Form7.portnumber(int.Parse(Port.Text), IP.Text);
                //Form3.infinite(infRounds.Checked);
                client.Close();
                Form7.Show();
                Form6 Form6 = new Form6();
                Form6.NumberOfRoundss(Convert.ToInt32(numberOfRounds));
                Form6.infinite(infRounds);
                Hide();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)  //receive data
        {
            while (client.Connected)
            {
                try
                {
                    if (Port.Enabled || IP.Enabled)
                    {
                        Port.Invoke(new MethodInvoker(delegate () { Port.Enabled = false; }));
                        IP.Invoke(new MethodInvoker(delegate () { IP.Enabled = false; }));
                    }
                    receive = STR.ReadLine();
                    if (receive[0].Equals(h[0]))
                    {
                        if (receive[1].Equals('r'))
                        {
                            numberOfRounds = Int32.Parse(receive.Substring(2));
                        }
                        if (receive[1].Equals('s'))
                        {
                            numberOfShips = Int32.Parse(receive.Substring(2));
                        }
                        if (receive[1].Equals('m'))
                        {
                            if (receive[2].Equals('s'))
                            {
                                map_small = true;
                            }
                            if (receive[2].Equals('m'))
                            {
                                map_medium = true;
                            }
                            if (receive[2].Equals('l'))
                            {
                                map_large = true;
                            }
                        }
                        if (receive[1].Equals('i'))
                        {
                            if (receive[2].Equals('t'))
                            {
                                infRounds = true;
                            }
                            else
                            {
                                infRounds = false;
                            }
                        }
                        if (receive[1].Equals('f'))
                        {
                            if (start.Enabled == false)
                            {
                                start.Invoke(new MethodInvoker(delegate () { start.Enabled = true; }));
                            }
                        }
                    }
                    else
                    {
                        this.log.Invoke(new MethodInvoker(delegate () { log.AppendText("Enemy: " + receive + "\n"); }));
                        receive = "";
                    }
                    
                }
                catch (Exception x)
                {
                    //MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(text_to_send);
                this.log.Invoke(new MethodInvoker(delegate () { log.AppendText("Me: " + text_to_send + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send failed!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (toSend.Text != "")
            {
                text_to_send = toSend.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            toSend.Text = "";
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(Port.Text));

            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    log.AppendText("connected to server" + "\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();                             // start receiving in background
                    backgroundWorker2.WorkerSupportsCancellation = true;            //ability to cancel this thread
                }
            }
            catch (Exception x)
            {
                //MessageBox.Show(x.Message.ToString());
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
