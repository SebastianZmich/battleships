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
    public partial class Form4 : Form
    {
        List<Button> playerPosition; // list for all the player positions buttons
        List<Button> playerPosition1;
        List<Button> enemyPosition; // list for all the enemy positions buttons
        Random rand = new Random(); // create a new instance for the random class rand
        //int totalShips = 3; // number of total player ships
        //int totalenemy = 3; // number of total enemy ships
        static int rounds; // total rounds to play(each will play 5 rounds)
        int playerTotalScore = 0; // default player score
        int enemyTotalScore = 0; // default enemy score
        static bool infRounds;
        private TcpClient client2;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;
        int Port;
        string IP;
        int index;
        string h = Char.ConvertFromUtf32(7);
        int HitCounterS1 = 0;
        int HitCounterS2 = 0;
        int HitCounterS3 = 0;
        int HitCounterS4 = 0;
        bool flagS1 = false;
        bool flagEnd = false;
        public void portnumber(int port1, string ip1)
        {
            Port = port1;
            IP = ip1;
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
        public Form4()
        {
            InitializeComponent();
            attackButton.Enabled = false; // disable the player attack button
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

                // in the if statement below we will link tat index number to the enemy position list
                // and we need to check if we have more rounds to player
                if (enemyPosition[index].Enabled && rounds > 0)
                {
                    // update the rounds text
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
                        text_to_send = h + "e";
                        STW.WriteLine(text_to_send);
                        if (infRounds != true)
                        {
                            rounds--;
                            // reduce 1 from the rounds
                            roundsText.Text = " Rounds " + rounds;
                        }
                        flagS1 = false;
                        if (rounds < 1)
                        {
                            attackButton.Enabled = false;
                            attackButton.BackColor = System.Drawing.SystemColors.Control;
                            check.Enabled = false;
                            check.BackColor = System.Drawing.SystemColors.Control;
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
                    }
                }

            }
            else
            {
                // if player doesn;t pick a location from the drop down list, alert them to do so
                MessageBox.Show("Choose a location from the drop down list.");
            }
        }
        private void loadbuttons()
        {
            playerPosition = new List<Button> { s1, s2, s3, s4, s5, s6, s7, t1, t2, t3, t4, t5, t6, t7, u1, u2, u3, u4, u5, u6, u7, w1, w2, w3, w4, w5, w6, w7, x1, x2, x3, x4, x5, x6, x7, y1, y2, y3, y4, y5, y6, y7, z1, z2, z3, z4, z5, z6, z7 };
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
            enemyPosition = new List<Button> { a1, a2, a3, a4, a5, a6, a7, b1, b2, b3, b4, b5, b6, b7, c1, c2, c3, c4, c5, c6, c7, d1, d2, d3, d4, d5, d6, d7, e1, e2, e3, e4, e5, e6, e7, f1, f2, f3, f4, f5, f6, f7, g1, g2, g3, g4, g5, g6, g7 };
            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyLocationList.Items.Add(enemyPosition[i].Text);
            }
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
        private void Connect()
        {
            client2 = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(IP), Port);
            if (!client2.Connected)
            {
                try
                {
                    client2.Connect(IP_End);
                    if (client2.Connected)
                    {
                        log.AppendText("connected to server" + "\n");
                        STW = new StreamWriter(client2.GetStream());
                        STR = new StreamReader(client2.GetStream());
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
        private void Send_Click(object sender, EventArgs e)
        {
            if (toSend.Text != "")
            {
                text_to_send = toSend.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            toSend.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client2.Connected)
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
                                /*enemyPosition[index].Enabled = false;
                                //disable that button
                                enemyPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                                // change the background image to the fire icon
                                enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                // change the background color to dark blue*/
                                //playerTotalScore++;
                                // increase 1 to the player score
                                //playerScore.Text = "" + playerTotalScore;
                                playerScore.Invoke(new MethodInvoker(delegate () {
                                    playerScore.Text = "" + playerTotalScore;
                                }));
                                // update the palyer score on the player label
                            }
                            if (receive[2].Equals('m'))
                            {
                                enemyPosition[index].Invoke(new MethodInvoker(delegate () {
                                    enemyPosition[index].Enabled = false;
                                    enemyPosition[index].BackgroundImage = Properties.Resources.missIcons;
                                    enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                }));
                                /* enemyPosition[index].Enabled = false;
                                 // we disable that button
                                 enemyPosition[index].BackgroundImage = Properties.Resources.missIcon;
                                 // change the background image to miss icon
                                 enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;*/
                                // change the background to dark blue
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
                                /* // if the player tag isn't of playership
                                 playerPosition[index].BackgroundImage = Properties.Resources.missIcon;
                                 // show the miss icon on the button
                                 enemyMoves.Text = "" + playerPosition[index].Text;
                                 // update the enemy attack location on label 2
                                 playerPosition[index].Enabled = false;
                                 // disable the button cpu atacked
                                 playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                 // change the background color to dark blue */
                                text_to_send = h + "s" + "m";
                                STW.WriteLine(text_to_send);
                            }
                        }
                        if (receive[1].Equals('e'))
                        {
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
                                    // attackButton.BackColor = System.Drawing.Color.Red;
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
            if (client2.Connected)
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

        private void Form4_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
