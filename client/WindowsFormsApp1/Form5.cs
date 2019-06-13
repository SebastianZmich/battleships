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
    public partial class Form5 : Form
    {
        List<Button> playerPosition;
        int shiptype;
        int totalShips;
        int totalShipsMem;
        bool ship1flag = false;
        bool ship2flag = false;
        bool ship3flag = false;
        bool ship4flag = false;
        bool flagReady = false;
        private TcpClient client1;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;
        Form2 form2 = new Form2();
        int Port;
        string IP;
        string h = Char.ConvertFromUtf32(7);
        public void InitialValues(int numberOfShips)
        {
            totalShips = numberOfShips;
            totalShipsMem = totalShips;
        }
        public Form5()
        {
            InitializeComponent();
            loadbuttons();
        }

        public void portnumber(int port1, string ip1)
        {
            Port = port1;
            IP = ip1;
        }

        private void loadbuttons()
        {
            playerPosition = new List<Button> { s1, s2, s3, s4, s5, s6, s7, t1, t2, t3, t4, t5, t6, t7, u1, u2, u3, u4, u5, u6, u7, w1, w2, w3, w4, w5, w6, w7, x1, x2, x3, x4, x5, x6, x7, y1, y2, y3, y4, y5, y6, y7, z1, z2, z3, z4, z5, z6, z7 };
            for (int i = 0; i < playerPosition.Count; i++)
            {
                playerPosition[i].Tag = null;
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.loadPlayerPositions(this.playerPosition);
            //Form1.NumberOfRoundss(rounds);
            //Form1.infinite(infRounds);
            Form4.portnumber(Port, IP);
            //client1.Close();
            Form4.Show();
            Hide();
        }

        private void discard_Click(object sender, EventArgs e)
        {
            ship1.Enabled = true;
            ship2.Enabled = true;
            ship3.Enabled = true;
            ship4.Enabled = true;
            orientation.Enabled = true;
            totalShips = totalShipsMem;
            ship1flag = false;
            ship2flag = false;
            ship3flag = false;
            ship4flag = false;
            accept.Enabled = false;
            for (int i = 0; i < playerPosition.Count; i++)
            {

                playerPosition[i].Enabled = false;
                playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                playerPosition[i].BackColor = System.Drawing.SystemColors.Control;
                playerPosition[i].Tag = null;
            }
        }
        private void PlayerPicksPositions(object sender, EventArgs e)
        {
            if (totalShips > 0)
            {
                // if total ships is mor than 0 then we check
                var button = (Button)sender;
                int index = playerPosition.FindIndex(a => a.Text == button.Text);
                // which button was clicked
                button.Enabled = false;
                // disable that button 
                if (shiptype == 1)
                {
                    button.BackColor = System.Drawing.Color.Blue;
                    button.Tag = "Ship1";
                    //put a tag on it called playership    
                    ship1flag = true;
                    ship1.Enabled = false;
                }
                if (shiptype == 2)
                {
                    button.Tag = "Ship2";
                    button.BackColor = System.Drawing.Color.Green;
                    if (horizontal.Checked == true)
                    {
                        playerPosition[index + 1].Tag = "Ship2";
                        playerPosition[index + 1].BackColor = System.Drawing.Color.Green;
                        playerPosition[index + 1].Enabled = false;
                    }
                    if (vertical.Checked == true)
                    {
                        playerPosition[index + 7].Tag = "Ship2";
                        playerPosition[index + 7].BackColor = System.Drawing.Color.Green;
                        playerPosition[index + 7].Enabled = false;
                    }
                    ship2flag = true;
                    ship2.Enabled = false;
                }
                if (shiptype == 3)
                {
                    button.Tag = "Ship3";
                    button.BackColor = System.Drawing.Color.Orange;
                    if (horizontal.Checked == true)
                    {
                        for (int i = 1; i <= 2; i++)
                        {
                            playerPosition[index + i].Tag = "Ship3";
                            playerPosition[index + i].BackColor = System.Drawing.Color.Orange;
                            playerPosition[index + i].Enabled = false;
                        }
                    }
                    if (vertical.Checked == true)
                    {
                        for (int i = 7; i <= 14; i = i + 7)
                        {
                            playerPosition[index + i].Tag = "Ship3";
                            playerPosition[index + i].BackColor = System.Drawing.Color.Orange;
                            playerPosition[index + i].Enabled = false;
                        }
                    }
                    ship3flag = true;
                    ship3.Enabled = false;
                }
                if (shiptype == 4)
                {
                    button.Tag = "Ship4";
                    button.BackColor = System.Drawing.Color.Aqua;
                    if (horizontal.Checked == true)
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            playerPosition[index + i].Tag = "Ship4";
                            playerPosition[index + i].BackColor = System.Drawing.Color.Aqua;
                            playerPosition[index + i].Enabled = false;
                        }
                    }
                    if (vertical.Checked == true)
                    {
                        for (int i = 7; i <= 21; i = i + 7)
                        {
                            playerPosition[index + i].Tag = "Ship4";
                            playerPosition[index + i].BackColor = System.Drawing.Color.Aqua;
                            playerPosition[index + i].Enabled = false;
                        }
                    }
                    ship4flag = true;
                    ship4.Enabled = false;
                }
                for (int i = 0; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                totalShips--;
                // decrease the total ships by 1
                if (totalShips > 0)
                {
                    orientation.Enabled = true;
                    if (ship1flag != true)
                    {
                        ship1.Enabled = true;
                    }
                    if (ship2flag != true)
                    {
                        ship2.Enabled = true;
                    }
                    if (ship3flag != true)
                    {
                        ship3.Enabled = true;
                    }
                    if (ship4flag != true)
                    {
                        ship4.Enabled = true;
                    }
                }
            }
            if (totalShips == 0 && flagReady == true)
            {
                accept.Enabled = true;
                accept.ForeColor = System.Drawing.Color.Black;
            }
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
        private void Connect()
        {
            client1 = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(IP), Port);
            while (!client1.Connected)
            {
                try
                {
                    client1.Connect(IP_End);
                    if (client1.Connected)
                    {
                        log.AppendText("connected to server" + "\n");
                        STW = new StreamWriter(client1.GetStream());
                        STR = new StreamReader(client1.GetStream());
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
        }
        private void ship1_Click(object sender, EventArgs e)
        {
            ship2.Enabled = false;
            ship3.Enabled = false;
            ship4.Enabled = false;
            orientation.Enabled = false;
            shiptype = 1;
            for (int i = 0; i < playerPosition.Count; i++)
            {
                if (playerPosition[i].Tag == null)
                {
                    playerPosition[i].Enabled = true;
                    playerPosition[i].ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void ship2_Click(object sender, EventArgs e)
        {
            ship1.Enabled = false;
            ship3.Enabled = false;
            ship4.Enabled = false;
            orientation.Enabled = false;
            shiptype = 2;
            for (int i = 0; i < playerPosition.Count; i++)
            {
                if (playerPosition[i].Tag == null)
                {
                    playerPosition[i].Enabled = true;
                    playerPosition[i].ForeColor = System.Drawing.Color.Black;
                }
            }
            if (horizontal.Checked == true)
            {
                for (int i = 6; i < playerPosition.Count; i = i + 7)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 1; i < playerPosition.Count; i = i + 7)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (playerPosition[i + j].Tag != null)
                        {
                            if (playerPosition[i + j - 1].Tag == null)
                            {
                                playerPosition[i + j - 1].Enabled = false;
                                playerPosition[i + j - 1].ForeColor = System.Drawing.Color.Gray;
                            }
                        }
                    }
                }
            }
            if (vertical.Checked == true)
            {
                for (int i = playerPosition.Count - 7; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 7; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag != null)
                    {
                        if (playerPosition[i - 7].Tag == null)
                        {
                            playerPosition[i - 7].Enabled = false;
                            playerPosition[i - 7].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                }
            }
        }

        private void ship3_Click(object sender, EventArgs e)
        {
            ship1.Enabled = false;
            ship2.Enabled = false;
            ship4.Enabled = false;
            orientation.Enabled = false;
            shiptype = 3;
            for (int i = 0; i < playerPosition.Count; i++)
            {
                if (playerPosition[i].Tag == null)
                {
                    playerPosition[i].Enabled = true;
                    playerPosition[i].ForeColor = System.Drawing.Color.Black;
                }
            }
            if (horizontal.Checked == true)
            {
                for (int i = 5; i < playerPosition.Count; i = i + 7)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                    if (playerPosition[i + 1].Tag == null)
                    {
                        playerPosition[i + 1].Enabled = false;
                        playerPosition[i + 1].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 2; i < playerPosition.Count; i = i + 7)
                {
                    if (playerPosition[i - 1].Tag != null)
                    {
                        if (playerPosition[i - 2].Tag == null)
                        {
                            playerPosition[i - 2].Enabled = false;
                            playerPosition[i - 2].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (playerPosition[i + j].Tag != null)
                        {
                            if (playerPosition[i + j - 2].Tag == null)
                            {
                                playerPosition[i + j - 2].Enabled = false;
                                playerPosition[i + j - 2].ForeColor = System.Drawing.Color.Gray;
                            }
                            if (playerPosition[i + j - 1].Tag == null)
                            {
                                playerPosition[i + j - 1].Enabled = false;
                                playerPosition[i + j - 1].ForeColor = System.Drawing.Color.Gray;
                            }
                        }
                    }
                }
            }
            if (vertical.Checked == true)
            {
                for (int i = playerPosition.Count - 14; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 14; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag != null)
                    {
                        if (playerPosition[i - 14].Tag == null)
                        {
                            playerPosition[i - 14].Enabled = false;
                            playerPosition[i - 14].ForeColor = System.Drawing.Color.Gray;
                        }
                        if (playerPosition[i - 7].Tag == null)
                        {
                            playerPosition[i - 7].Enabled = false;
                            playerPosition[i - 7].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    if (playerPosition[i - 7].Tag != null)
                    {
                        if (playerPosition[i - 14].Tag == null)
                        {
                            playerPosition[i - 14].Enabled = false;
                            playerPosition[i - 14].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                }
            }
        }

        private void ship4_Click(object sender, EventArgs e)
        {
            ship1.Enabled = false;
            ship2.Enabled = false;
            ship3.Enabled = false;
            orientation.Enabled = false;
            shiptype = 4;
            for (int i = 0; i < playerPosition.Count; i++)
            {
                if (playerPosition[i].Tag == null)
                {
                    playerPosition[i].Enabled = true;
                    playerPosition[i].ForeColor = System.Drawing.Color.Black;
                }
            }
            if (horizontal.Checked == true)
            {
                for (int i = 4; i < playerPosition.Count; i = i + 7)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (playerPosition[i + j].Tag == null)
                        {
                            playerPosition[i + j].Enabled = false;
                            playerPosition[i + j].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                }
                for (int i = 3; i < playerPosition.Count; i = i + 7)
                {
                    if (playerPosition[i - 1].Tag != null)
                    {
                        if (playerPosition[i - 2].Tag == null)
                        {
                            playerPosition[i - 2].Enabled = false;
                            playerPosition[i - 2].ForeColor = System.Drawing.Color.Gray;
                        }
                        if (playerPosition[i - 3].Tag == null)
                        {
                            playerPosition[i - 3].Enabled = false;
                            playerPosition[i - 3].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    if (playerPosition[i - 2].Tag != null)
                    {
                        if (playerPosition[i - 3].Tag == null)
                        {
                            playerPosition[i - 3].Enabled = false;
                            playerPosition[i - 3].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        if (playerPosition[i + j].Tag != null)
                        {
                            for (int k = 3; k >= 1; k--)
                            {
                                if (playerPosition[i + j - k].Tag == null)
                                {
                                    playerPosition[i + j - k].Enabled = false;
                                    playerPosition[i + j - k].ForeColor = System.Drawing.Color.Gray;
                                }
                            }
                        }
                    }
                }
            }
            if (vertical.Checked == true)
            {
                for (int i = playerPosition.Count - 21; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 21; i < playerPosition.Count; i++)
                {
                    for (int j = 21; j >= 7; j = j - 7)
                    {
                        if (playerPosition[i - j].Tag != null)
                        {
                            playerPosition[i - j].Enabled = false;
                            playerPosition[i - j].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    if (playerPosition[i - 14].Tag != null)
                    {
                        if (playerPosition[i - 21].Tag == null)
                        {
                            playerPosition[i - 21].Enabled = false;
                            playerPosition[i - 21].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    if (playerPosition[i - 7].Tag != null)
                    {
                        for (int k = 14; k <= 21; k = k + 7)
                        {
                            if (playerPosition[i - k].Tag == null)
                            {
                                playerPosition[i - k].Enabled = false;
                                playerPosition[i - k].ForeColor = System.Drawing.Color.Gray;
                            }
                        }
                    }
                    if (playerPosition[i].Tag != null)
                    {
                        for (int k = 7; k <= 21; k = k + 7)
                        {
                            if (playerPosition[i - k].Tag == null)
                            {
                                playerPosition[i - k].Enabled = false;
                                playerPosition[i - k].ForeColor = System.Drawing.Color.Gray;
                            }
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client1.Connected)
            {

                try
                {
                    receive = STR.ReadLine();
                    if (receive[0].Equals(h[0]))
                    {
                        if (receive[1].Equals('a'))
                        {
                            flagReady = true;
                            if (totalShips == 0 && flagReady == true)
                            {
                                accept.Invoke(new MethodInvoker(delegate () { accept.Enabled = true; accept.ForeColor = System.Drawing.Color.Black; }));
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
            if (client1.Connected)
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

        private void Form5_Shown(object sender, EventArgs e)
        {
            //Connect();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
