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
    public partial class Form6 : Form
    {
        Form3 form3 = new Form3();
        Form2 form2 = new Form2();
        List<Button> playerPosition; // list for all the player positions buttons
        List<Button> playerPosition1;
        List<Button> enemyPosition; // list for all the enemy positions buttons
        Random rand = new Random(); // create a new instance for the random class rand
        static int rounds; // total rounds to play(each will play 5 rounds)
        int playerTotalScore = 0; // default player score
        int enemyTotalScore = 0; // default enemy score
        static bool infRounds;
        private TcpClient client;
        TcpListener listener;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;
        int port;
        int index;
        string h = Char.ConvertFromUtf32(7);
        int HitCounterS1;
        int HitCounterS2;
        int HitCounterS3;
        int HitCounterS4;
        bool flagS1 = false;
        bool flagEnd = false;
        public void portnumber(int port1)
        {
            port = port1;
        }
        public void NumberOfRoundss(int nrounds)
        {
            rounds = nrounds;
        }
        public void infinite(bool inf)
        {
            infRounds = inf;
        }
        public void loadPlayerPositions(List<Button> positions)
        {
            this.playerPosition1 = positions;
            loadbuttons();
        }
        public Form6()
        {
            InitializeComponent();
            enemyLocationList.Text = null; // nulify the enemy location drop down box
            if (infRounds == true)
            {
                roundsText.Text = "Rounds INF ";
            }
            else
            {
                roundsText.Text = " Rounds " + rounds;
            }
        }

        private void attackEnemyPosition(object sender, EventArgs e)
        {
            // we need to check ig the player can choose a location from the drop down list
            if (enemyLocationList.Text != "")
            {
                // if location is appropriately picked
                var attackPos = enemyLocationList.Text;
                // create a variable called attackPos and give it the value of the text selected from drop down menu
                attackPos = attackPos.ToLower();
                // change the string to lower case to matach the button name
                index = enemyPosition.FindIndex(a => a.Name == attackPos);
                // in this int we will run the index of the enemy location and search for the string the player picked
                // once its found it will be saved inside the index local variable

                // in the if statement below we will link that index number to the enemy position list
                // and we need to check if we have more rounds to player
                if (enemyPosition[index].Enabled && rounds > 0)
                {
                    text_to_send = h + "f" + index.ToString();
                    STW.WriteLine(text_to_send);
                    if (HitCounterS1 > 0 && flagS1 == false)
                    {
                        flagS1 = true;
                    }
                    else
                    {
                        attackButton.Enabled = false;
                        attackButton.BackColor = System.Drawing.SystemColors.Control;
                        if (flagEnd == false)
                        {
                            text_to_send = h + "e";
                            STW.WriteLine(text_to_send);
                        }
                        flagS1 = false;
                    }

                }
            }
            else
            {
                // if player doesn't pick a location from the drop down list, alert them to do so
                MessageBox.Show("Choose a location from the drop down list.");
            }
        }
        private void loadbuttons()
        {
            playerPosition = new List<Button> { o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, u1, u2, u3, u4, u5, u6, u7, u8, u9, u10, w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, y1, y2, y3, y4, y5, y6, y7, y8, y9, y10, z1, z2, z3, z4, z5, z6, z7, z8, z9, z10 };
            for (int i = 0; i < playerPosition.Count; i++)
            {
                playerPosition[i].Tag = playerPosition1[i].Tag;
                playerPosition[i].BackColor = playerPosition1[i].BackColor;
                if (playerPosition[i].Tag == "Ship1")
                {
                    HitCounterS1 = 1;
                }
                if (playerPosition[i].Tag == "Ship2")
                {
                    HitCounterS2 = 2;
                }
                if (playerPosition[i].Tag == "Ship3")
                {
                    HitCounterS3 = 3;
                }
                if (playerPosition[i].Tag == "Ship4")
                {
                    HitCounterS4 = 4;
                }
            }
            enemyPosition = new List<Button> { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, j1, j2, j3, j4, j5, j6, j7, j8, j9, j10 };
            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyLocationList.Items.Add(enemyPosition[i].Text);
            }
        }
        private void startServ()
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            form3.Close();
            form2.Close();
            backgroundWorker1.RunWorkerAsync();                             // start receiving in background
            backgroundWorker2.WorkerSupportsCancellation = true;            // ability to cancel this thread
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    if (receive[0].Equals(h[0]))
                    {
                        if (receive[1].Equals('s'))
                        {
                            if (receive[2].Equals('f'))
                            {
                                playerTotalScore++;
                                if (enemyPosition[index].Tag == "Shoot")
                                {
                                    playerTotalScore--;
                                }
                                enemyPosition[index].Invoke(new MethodInvoker(delegate () {
                                    enemyPosition[index].Enabled = false;
                                    enemyPosition[index].Tag = "Shoot";
                                    enemyPosition[index].BackgroundImage = Properties.Resources.fireIcons;
                                    enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                }));

                                //disable that button

                                // change the background image to the fire icon

                                // change the background color to dark blue
                                //playerTotalScore++;
                                // increase 1 to the player score
                                playerScore.Invoke(new MethodInvoker(delegate () { playerScore.Text = "" + playerTotalScore; }));
                                // update the palyer score on the player label
                            }
                            if (receive[2].Equals('m'))
                            {
                                enemyPosition[index].Invoke(new MethodInvoker(delegate () {
                                    enemyPosition[index].Enabled = false;
                                    enemyPosition[index].BackgroundImage = Properties.Resources.missIcons;
                                    enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                }));
                            }
                            if (receive[2].Equals('c'))
                            {
                                enemyPosition[index].Invoke(new MethodInvoker(delegate () {
                                    //enemyPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                                    enemyPosition[index].BackColor = System.Drawing.Color.Red;
                                }));
                                attackButton.Invoke(new MethodInvoker(delegate ()
                                {
                                    attackButton.Enabled = true;
                                    attackButton.BackColor = System.Drawing.Color.Red;
                                    // activate the attack button
                                }));
                            }
                            if (receive[2].Equals('e'))
                            {
                                enemyPosition[index].Invoke(new MethodInvoker(delegate () {
                                    //enemyPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                                    enemyPosition[index].BackColor = System.Drawing.Color.Green;
                                }));
                                attackButton.Invoke(new MethodInvoker(delegate ()
                                {
                                    attackButton.Enabled = true;
                                    attackButton.BackColor = System.Drawing.Color.Red;
                                    // activate the attack button
                                }));
                            }
                        }
                        if (receive[1].Equals('f'))
                        {
                            index = Int32.Parse(receive.Substring(2));
                            if (playerPosition[index].Tag == "Ship1" || playerPosition[index].Tag == "Ship2" || playerPosition[index].Tag == "Ship3" || playerPosition[index].Tag == "Ship4")
                            {
                                if (playerPosition[index].Enabled != false)
                                {
                                    enemyTotalScore++;
                                }
                                if (playerPosition[index].Tag == "Ship4")
                                {
                                    if (playerPosition[index].Enabled)
                                    {
                                        HitCounterS4--;
                                        if (HitCounterS4 > 0)
                                        {
                                            if (enemyPosition[index].Enabled)
                                            {
                                                text_to_send = h + "f" + index.ToString();
                                                STW.WriteLine(text_to_send);
                                            }
                                        }
                                    }
                                }
                                playerPosition[index].Invoke(new MethodInvoker(delegate () {
                                    playerPosition[index].Enabled = false;          
                                    playerPosition[index].BackgroundImage = Properties.Resources.fireIcons;
                                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                }));
                                enemyMoves.Invoke(new MethodInvoker(delegate ()
                                {
                                    enemyMoves.Text = "" + playerPosition[index].Text;
                                }));
                                //enemyTotalScore++;
                                // add 1 to the enemy score
                                enemyScore.Invoke(new MethodInvoker(delegate () { enemyScore.Text = "" + enemyTotalScore; }));
                                //enemyScore.Text = "" + enemyTotalScore;
                                if (playerPosition[index].Tag == "Ship1")
                                {
                                    HitCounterS1--;
                                }
                                if (playerPosition[index].Tag == "Ship2")
                                {
                                    HitCounterS2--;
                                }
                                if (playerPosition[index].Tag == "Ship3")
                                {
                                    HitCounterS3--;
                                }
                                
                                text_to_send = h + "s" + "f";
                                STW.WriteLine(text_to_send);
                                if (HitCounterS1 <= 0 && HitCounterS2 <= 0 && HitCounterS3 <= 0 && HitCounterS4 <= 0)
                                {
                                    flagEnd = true;
                                    text_to_send = h + "w";
                                    STW.WriteLine(text_to_send);
                                    check.Invoke(new MethodInvoker(delegate ()
                                    {
                                        check.Enabled = false;
                                        check.BackColor = System.Drawing.SystemColors.Control;
                                    }));
                                    attackButton.Invoke(new MethodInvoker(delegate ()
                                    {
                                        attackButton.Enabled = false;
                                        attackButton.BackColor = System.Drawing.SystemColors.Control;
                                    }));
                                    MessageBox.Show("YOU LOST!", "Loosing");
                                }
                            }
                            else
                            {
                                playerPosition[index].Invoke(new MethodInvoker(delegate () {
                                    playerPosition[index].Enabled = false;
                                    playerPosition[index].BackgroundImage = Properties.Resources.missIcons;
                                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                }));
                                enemyMoves.Invoke(new MethodInvoker(delegate ()
                                {
                                    enemyMoves.Text = "" + playerPosition[index].Text;
                                }));
                                text_to_send = h + "s" + "m";
                                STW.WriteLine(text_to_send);
                            }
                        }
                        if (receive[1].Equals('e'))
                        {
                            if (infRounds != true)
                            {
                                rounds--;
                                roundsText.Invoke(new MethodInvoker(delegate ()
                                {
                                    roundsText.Text = " Rounds " + rounds;
                                }));
                            }
                            if (rounds < 1)
                            {
                                check.Invoke(new MethodInvoker(delegate ()
                                {
                                    check.Enabled = false;
                                    check.BackColor = System.Drawing.SystemColors.Control;
                                }));
                                attackButton.Invoke(new MethodInvoker(delegate ()
                                {
                                    attackButton.Enabled = false;
                                    attackButton.BackColor = System.Drawing.SystemColors.Control;
                                }));
                                if (playerTotalScore > enemyTotalScore)
                                {
                                    MessageBox.Show("YOU WON!", "Winning");
                                }
                                if (playerTotalScore == enemyTotalScore)
                                {
                                    MessageBox.Show("DRAW");
                                }
                                if (enemyTotalScore > playerTotalScore)
                                {
                                    MessageBox.Show("YOU LOST!", "Loosing");
                                }
                            }
                            if (flagEnd == false)
                            {
                                if (HitCounterS3 > 0)
                                {
                                    check.Invoke(new MethodInvoker(delegate ()
                                    {
                                        check.Enabled = true;
                                        check.BackColor = System.Drawing.Color.Green;
                                    }));
                                }
                                else
                                {
                                    attackButton.Invoke(new MethodInvoker(delegate ()
                                    {
                                        attackButton.Enabled = true;
                                        attackButton.BackColor = System.Drawing.Color.Red;
                                        // activate the attack button
                                    }));
                                    //attackButton.Enabled = true;
                                    //attackButton.BackColor = System.Drawing.Color.Red;
                                }
                            }
                        }
                        if (receive[1].Equals('c'))
                        {
                            index = Int32.Parse(receive.Substring(2));
                            if ((playerPosition[index].Tag == "Ship1" || playerPosition[index].Tag == "Ship2" || playerPosition[index].Tag == "Ship3" || playerPosition[index].Tag == "Ship4") && HitCounterS2 <= 0)
                            {
                                text_to_send = h + "s" + "c";
                                STW.WriteLine(text_to_send);
                            }
                            else
                            {
                                text_to_send = h + "s" + "e";
                                STW.WriteLine(text_to_send);
                            }
                        }
                        if (receive[1].Equals('w'))
                        {
                            flagEnd = true;
                            check.Invoke(new MethodInvoker(delegate ()
                            {
                                check.Enabled = false;
                                check.BackColor = System.Drawing.SystemColors.Control;
                            }));
                            attackButton.Invoke(new MethodInvoker(delegate ()
                            {
                                attackButton.Enabled = false;
                                attackButton.BackColor = System.Drawing.SystemColors.Control;
                            }));
                            MessageBox.Show("YOU WON!", "Winning");
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

        private void check_Click(object sender, EventArgs e)
        {
            if (enemyLocationList.Text != "")
            {
                var checkPos = enemyLocationList.Text;
                checkPos = checkPos.ToLower();
                index = enemyPosition.FindIndex(a => a.Name == checkPos);
                if (enemyPosition[index].Enabled && rounds > 0)
                {
                    text_to_send = h + "c" + index.ToString();
                    STW.WriteLine(text_to_send);
                    check.Enabled = false;
                    check.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            startServ();
        }

        private void Form6_Shown(object sender, EventArgs e)
        {
            if (flagEnd == false)
            {
                if (HitCounterS3 > 0)
                {
                    check.Enabled = true;
                    check.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    attackButton.Enabled = true;
                    attackButton.BackColor = System.Drawing.Color.Red;
                    // activate the attack button
                }
            }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
