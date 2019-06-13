using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
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
        bool flagEnd=false;
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

        public Form1()
        {
            InitializeComponent();
            // load the buttons for enemy and player to the system
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
                if(enemyPosition[index].Enabled && rounds > 0)
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

        /*private void enemyAttackPlayer(object sender, EventArgs e)
        {
            // this function is for the CPU to make a move on the player
            // if the player position is more than 0 and there are more rounds to play
            if(playerPosition.Count > 0 && rounds > 0)
            {
                rounds--; // reduce a round from the total
                roundsText.Text = " Rounds " + rounds;

                int index = rand.Next(playerPosition.Count); // create a new in index and place a random player button
                if(playerPosition[index].Tag == "playerShip")
                {
                    playerPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                    //change its icon to the fire icon

                    enemyMoves.Text = "" + playerPosition[index].Text;
                    // show which button was attakced
                    playerPosition[index].Enabled = false;
                    // disable that button
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    //change the background color to dark blue
                    playerPosition.RemoveAt(index);
                    // remove this button from the player position list so it won't get attacked again by CPU
                    enemyTotalScore++;
                    // add 1 to the enemy score
                    enemyScore.Text = "" + enemyTotalScore;
                    // show the enemy score on the label
                    enemyPlayTimer.Stop();
                    //stop the time for the CPU

                }
                else
                {
                    // if the player tag isn't of playership
                    playerPosition[index].BackgroundImage = Properties.Resources.missIcon;
                    // show the miss icon on the button
                    enemyMoves.Text = "" + playerPosition[index].Text;
                    // update the enemy attack location on label 2
                    playerPosition[index].Enabled = false;
                    // disable the button cpu atacked
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    // change the background color to dark blue
                    playerPosition.RemoveAt(index);
                    // remove this button from the list so it won't get attack again bu cpu
                    enemyPlayTimer.Stop();
                    // stop the cpu time
                }
            }
            
            // below is th if statement thats checking wheter we won, drew or lost the game

            if(rounds<1||playerTotalScore > 2 || enemyTotalScore > 2)
            {
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
                    MessageBox.Show("YOU lost!");
                }
            }
        }*/

        /*private void enemyPicksPositions(object sender, EventArgs e)
        {
           // this function will allow the CPU to pick 3 positions on the MAP
            int index = rand.Next(enemyPosition.Count);
            // create a local variable called index and choose a random button from enemy position list
            if (enemyPosition[index].Enabled == true && enemyPosition[index].Tag == null)
            {
                // when we find the buttons we need to check if they are enabled and they don't have a tag yet
                enemyPosition[index].Tag = "enemyship";
                // now add a tag called enemy ship to the button
                totalenemy--;
                // and we will reduce the total enemy by 1
                Debug.WriteLine("Enemy Position " + enemyPosition[index].Text);
                // the line above will show us in the debug window which buttons the enemy chose
                // this can help to figure out if game is working as intended
            }
            else
            {
                // if the top condition don't match then we will run it again to select 3 positions and tags
                index = rand.Next(enemyPosition.Count);
                if (totalenemy < 1)
                {
                    // if the cpu has selected the 3 positions then we can stop the timer
                    enemyPositionPicker.Stop();
                }
            }
        }*/

        private void loadbuttons()
        {
            playerPosition = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
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
            enemyPosition = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };
            for (int i =0; i<enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyLocationList.Items.Add(enemyPosition[i].Text);
            }
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
                                    enemyPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                                    enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue; }));
                                /*enemyPosition[index].Enabled = false;
                                //disable that button
                                enemyPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                                // change the background image to the fire icon
                                enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                                // change the background color to dark blue*/
                                
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
                                    enemyPosition[index].BackgroundImage = Properties.Resources.missIcon;
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
                            if (playerPosition[index].Tag == "Ship1"|| playerPosition[index].Tag == "Ship2" || playerPosition[index].Tag == "Ship3" || playerPosition[index].Tag == "Ship4")
                            {
                                if (playerPosition[index].Tag == "Ship4")
                                {
                                    
                                    if ( playerPosition[index].Enabled)
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
                                if (playerPosition[index].Enabled != false)
                                {
                                    enemyTotalScore++;
                                }
                                playerPosition[index].Invoke(new MethodInvoker(delegate () {
                                    playerPosition[index].Enabled = false;
                                    playerPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue; }));
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
                                    playerPosition[index].BackgroundImage = Properties.Resources.missIcon;
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
            client2 = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(IP), Port);
            if(!client2.Connected)
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
        private void Form1_Shown(object sender, EventArgs e)
        {
            //Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
