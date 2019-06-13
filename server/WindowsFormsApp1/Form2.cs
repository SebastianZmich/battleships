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
        TcpListener listener;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;
        string h = Char.ConvertFromUtf32(7);
        public Form2()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());   // get my own IP
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    //IP.Text = address.ToString();
                }
            }
            
        }
        int rounds;
        private void infRounds_CheckedChanged(object sender, EventArgs e)
        {
            if (infRounds.Checked == true)
            {
                numberOfRounds.Enabled = false;
                numberOfRounds.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                numberOfRounds.Enabled = true;
                numberOfRounds.BackColor = System.Drawing.Color.White;
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            
            
            rounds = Convert.ToInt32(numberOfRounds.Value);
            text_to_send = h+"r"+numberOfRounds.Value.ToString();
            STW.WriteLine(text_to_send);
            text_to_send = h + "s" + numberOfShips.Value.ToString();
            STW.WriteLine(text_to_send);
            if (infRounds.Checked)
            {
                text_to_send = h + "i" + "t";
                STW.WriteLine(text_to_send);
            }
            else
            {
                text_to_send = h + "i" + "f";
                STW.WriteLine(text_to_send);
            }

            if (map_small.Checked == true)
            {
                text_to_send = h + "ms";
                STW.WriteLine(text_to_send);
                Form3 Form3 = new Form3();
                Form1 Form1 = new Form1();
                //Form3.NumberOfRoundss(rounds);
                Form3.InitialValues(Convert.ToInt32(numberOfShips.Value));
                Form3.portnumber(int.Parse(Port.Text));
                //Form3.infinite(infRounds.Checked);
                text_to_send = h + "f";
                STW.WriteLine(text_to_send);
                listener.Stop();
                //client.Close();
                Form3.Show();
                Hide();
                Form1.NumberOfRoundss(Convert.ToInt32(numberOfRounds.Value));
                Form1.infinite(infRounds.Checked);
            }
            if (map_medium.Checked == true)
            {
                text_to_send = h + "mm";
                STW.WriteLine(text_to_send);
                Form5 form5 = new Form5();
                Form4 form4 = new Form4();
                form5.InitialValues(Convert.ToInt32(numberOfShips.Value));
                form5.portnumber(int.Parse(Port.Text));
                text_to_send = h + "f";
                STW.WriteLine(text_to_send);
                listener.Stop();
                //client.Close();
                form5.Show();
                Hide();
                form4.NumberOfRoundss(Convert.ToInt32(numberOfRounds.Value));
                form4.infinite(infRounds.Checked);
            }
            if (map_large.Checked == true)
            {
                text_to_send = h + "ml";
                STW.WriteLine(text_to_send);
                Form7 form7 = new Form7();
                Form6 form6 = new Form6();
                form7.InitialValues(Convert.ToInt32(numberOfShips.Value));
                form7.portnumber(int.Parse(Port.Text));
                text_to_send = h + "f";
                STW.WriteLine(text_to_send);
                listener.Stop();
                //client.Close();
                form7.Show();
                Hide();
                form6.NumberOfRoundss(Convert.ToInt32(numberOfRounds.Value));
                form6.infinite(infRounds.Checked);
            }


            
        }

        private void startServ_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, int.Parse(Port.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();                             // start receiving in background
            backgroundWorker2.WorkerSupportsCancellation = true;            //ability to cancel this thread
            IP.Enabled = false;
            Port.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)  //receive data
        {
            while (client.Connected)
            {
                if (start.Enabled == false)
                {
                    start.Invoke(new MethodInvoker(delegate () { start.Enabled = true; }));
                }
                try
                {
                    receive = STR.ReadLine();
                    this.log.Invoke(new MethodInvoker(delegate () { log.AppendText("Enemy: " + receive + "\n"); }));
                    receive = "";
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

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
