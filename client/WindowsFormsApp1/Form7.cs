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
    public partial class Form7 : Form
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
        public Form7()
        {
            InitializeComponent();
            loadbuttons();
        }

        public void portnumber(int port1, string ip1)
        {
            Port = port1;
            IP = ip1;
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
                for (int i = 9; i < playerPosition.Count; i = i + 10)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 1; i < playerPosition.Count; i = i + 10)
                {
                    for (int j = 0; j < 9; j++)
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
                for (int i = playerPosition.Count - 10; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 10; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag != null)
                    {
                        if (playerPosition[i - 10].Tag == null)
                        {
                            playerPosition[i - 10].Enabled = false;
                            playerPosition[i - 10].ForeColor = System.Drawing.Color.Gray;
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
                for (int i = 8; i < playerPosition.Count; i = i + 10)
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
                for (int i = 2; i < playerPosition.Count; i = i + 10)
                {
                    if (playerPosition[i - 1].Tag != null)
                    {
                        if (playerPosition[i - 2].Tag == null)
                        {
                            playerPosition[i - 2].Enabled = false;
                            playerPosition[i - 2].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    for (int j = 0; j < 7; j++)
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
                for (int i = playerPosition.Count - 20; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 20; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag != null)
                    {
                        if (playerPosition[i - 20].Tag == null)
                        {
                            playerPosition[i - 20].Enabled = false;
                            playerPosition[i - 20].ForeColor = System.Drawing.Color.Gray;
                        }
                        if (playerPosition[i - 10].Tag == null)
                        {
                            playerPosition[i - 10].Enabled = false;
                            playerPosition[i - 10].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    if (playerPosition[i - 10].Tag != null)
                    {
                        if (playerPosition[i - 20].Tag == null)
                        {
                            playerPosition[i - 20].Enabled = false;
                            playerPosition[i - 20].ForeColor = System.Drawing.Color.Gray;
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
                for (int i = 7; i < playerPosition.Count; i = i + 10)
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
                for (int i = 3; i < playerPosition.Count; i = i + 10)
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
                    for (int j = 0; j < 6; j++)
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
                for (int i = playerPosition.Count - 30; i < playerPosition.Count; i++)
                {
                    if (playerPosition[i].Tag == null)
                    {
                        playerPosition[i].Enabled = false;
                        playerPosition[i].ForeColor = System.Drawing.Color.Gray;
                    }
                }
                for (int i = 30; i < playerPosition.Count; i++)
                {
                    for (int j = 30; j >= 10; j = j - 10)
                    {
                        if (playerPosition[i - j].Tag != null)
                        {
                            playerPosition[i - j].Enabled = false;
                            playerPosition[i - j].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    if (playerPosition[i - 20].Tag != null)
                    {
                        if (playerPosition[i - 30].Tag == null)
                        {
                            playerPosition[i - 30].Enabled = false;
                            playerPosition[i - 30].ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                    if (playerPosition[i - 10].Tag != null)
                    {
                        for (int k = 20; k <= 30; k = k + 10)
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
                        for (int k = 10; k <= 30; k = k + 10)
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

        private void loadbuttons()
        {
            playerPosition = new List<Button> { o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, u1, u2, u3, u4, u5, u6, u7, u8, u9, u10, w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, y1, y2, y3, y4, y5, y6, y7, y8, y9, y10, z1, z2, z3, z4, z5, z6, z7, z8, z9, z10 };
            for (int i = 0; i < playerPosition.Count; i++)
            {
                playerPosition[i].Tag = null;
            }
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
                        playerPosition[index + 10].Tag = "Ship2";
                        playerPosition[index + 10].BackColor = System.Drawing.Color.Green;
                        playerPosition[index + 10].Enabled = false;
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
                        for (int i = 10; i <= 20; i = i + 10)
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
                        for (int i = 10; i <= 30; i = i + 10)
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

        private void accept_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.loadPlayerPositions(this.playerPosition);
            //Form1.NumberOfRoundss(rounds);
            //Form1.infinite(infRounds);
            Form6.portnumber(Port, IP);
            //client1.Close();
            Form6.Show();
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

        private void Form7_Shown(object sender, EventArgs e)
        {
            //Connect();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
