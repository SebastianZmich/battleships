namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerScore = new System.Windows.Forms.Label();
            this.enemyScore = new System.Windows.Forms.Label();
            this.enemyMoves = new System.Windows.Forms.Label();
            this.roundsText = new System.Windows.Forms.Label();
            this.enemyLocationList = new System.Windows.Forms.ComboBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.log = new System.Windows.Forms.TextBox();
            this.toSend = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(489, 28);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(38, 26);
            this.playerScore.TabIndex = 0;
            this.playerScore.Text = "00";
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.BackColor = System.Drawing.Color.Transparent;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemyScore.ForeColor = System.Drawing.Color.White;
            this.enemyScore.Location = new System.Drawing.Point(793, 28);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(38, 26);
            this.enemyScore.TabIndex = 1;
            this.enemyScore.Text = "00";
            // 
            // enemyMoves
            // 
            this.enemyMoves.AutoSize = true;
            this.enemyMoves.BackColor = System.Drawing.Color.Transparent;
            this.enemyMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemyMoves.ForeColor = System.Drawing.Color.White;
            this.enemyMoves.Location = new System.Drawing.Point(980, 28);
            this.enemyMoves.Name = "enemyMoves";
            this.enemyMoves.Size = new System.Drawing.Size(41, 26);
            this.enemyMoves.TabIndex = 2;
            this.enemyMoves.Text = "A1";
            // 
            // roundsText
            // 
            this.roundsText.AutoSize = true;
            this.roundsText.BackColor = System.Drawing.Color.Transparent;
            this.roundsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundsText.ForeColor = System.Drawing.Color.White;
            this.roundsText.Location = new System.Drawing.Point(567, 32);
            this.roundsText.Name = "roundsText";
            this.roundsText.Size = new System.Drawing.Size(71, 20);
            this.roundsText.TabIndex = 3;
            this.roundsText.Text = "Rounds";
            // 
            // enemyLocationList
            // 
            this.enemyLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyLocationList.DropDownWidth = 95;
            this.enemyLocationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemyLocationList.FormattingEnabled = true;
            this.enemyLocationList.Location = new System.Drawing.Point(16, 12);
            this.enemyLocationList.Name = "enemyLocationList";
            this.enemyLocationList.Size = new System.Drawing.Size(100, 28);
            this.enemyLocationList.TabIndex = 5;
            // 
            // attackButton
            // 
            this.attackButton.Enabled = false;
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackButton.Location = new System.Drawing.Point(144, 12);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(80, 40);
            this.attackButton.TabIndex = 6;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackEnemyPosition);
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(95, 155);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(75, 55);
            this.w1.TabIndex = 7;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(186, 155);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(75, 55);
            this.w2.TabIndex = 8;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(280, 155);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(75, 55);
            this.w3.TabIndex = 9;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            // 
            // w4
            // 
            this.w4.Location = new System.Drawing.Point(372, 155);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(75, 55);
            this.w4.TabIndex = 10;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(95, 232);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(75, 55);
            this.x1.TabIndex = 11;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(186, 232);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 55);
            this.x2.TabIndex = 12;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(280, 232);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(75, 55);
            this.x3.TabIndex = 13;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(372, 232);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(75, 55);
            this.x4.TabIndex = 14;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(95, 310);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(75, 55);
            this.y1.TabIndex = 15;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(186, 310);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(75, 55);
            this.y2.TabIndex = 16;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(280, 310);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(75, 55);
            this.y3.TabIndex = 17;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(372, 310);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(75, 55);
            this.y4.TabIndex = 18;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(95, 386);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(75, 55);
            this.z1.TabIndex = 19;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(186, 386);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(75, 55);
            this.z2.TabIndex = 20;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            // 
            // z3
            // 
            this.z3.Location = new System.Drawing.Point(280, 386);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(75, 55);
            this.z3.TabIndex = 21;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            // 
            // z4
            // 
            this.z4.Location = new System.Drawing.Point(372, 386);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(75, 55);
            this.z4.TabIndex = 22;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(594, 155);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 55);
            this.a1.TabIndex = 23;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(687, 155);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 55);
            this.a2.TabIndex = 24;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(779, 155);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 55);
            this.a3.TabIndex = 25;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(872, 155);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(75, 55);
            this.a4.TabIndex = 26;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(594, 232);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 55);
            this.b1.TabIndex = 27;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(687, 232);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 55);
            this.b2.TabIndex = 28;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(779, 232);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 55);
            this.b3.TabIndex = 29;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(872, 232);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 55);
            this.b4.TabIndex = 30;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(594, 310);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 55);
            this.c1.TabIndex = 31;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(687, 310);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 55);
            this.c2.TabIndex = 32;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(779, 310);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 55);
            this.c3.TabIndex = 33;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(872, 310);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(75, 55);
            this.c4.TabIndex = 34;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(594, 386);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(75, 55);
            this.d1.TabIndex = 35;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(687, 386);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(75, 55);
            this.d2.TabIndex = 36;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(779, 386);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(75, 55);
            this.d3.TabIndex = 37;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(872, 386);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 55);
            this.d4.TabIndex = 38;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(26, 455);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(1027, 140);
            this.log.TabIndex = 57;
            // 
            // toSend
            // 
            this.toSend.Location = new System.Drawing.Point(26, 601);
            this.toSend.Multiline = true;
            this.toSend.Name = "toSend";
            this.toSend.Size = new System.Drawing.Size(903, 30);
            this.toSend.TabIndex = 56;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(959, 608);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 55;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.check.Location = new System.Drawing.Point(248, 12);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(80, 40);
            this.check.TabIndex = 58;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(850, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Enemy Moves:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(667, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Enemy Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Player Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1058, 643);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.log);
            this.Controls.Add(this.toSend);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.enemyLocationList);
            this.Controls.Add(this.roundsText);
            this.Controls.Add(this.enemyMoves);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.playerScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label enemyMoves;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.ComboBox enemyLocationList;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox toSend;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

