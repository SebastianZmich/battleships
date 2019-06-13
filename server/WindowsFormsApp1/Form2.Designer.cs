namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numberOfRounds = new System.Windows.Forms.NumericUpDown();
            this.infRounds = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberOfShips = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.map_large = new System.Windows.Forms.RadioButton();
            this.map_medium = new System.Windows.Forms.RadioButton();
            this.map_small = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startServ = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.log = new System.Windows.Forms.TextBox();
            this.toSend = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRounds)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfShips)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numberOfRounds);
            this.groupBox3.Controls.Add(this.infRounds);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 71);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ilość Rund";
            // 
            // numberOfRounds
            // 
            this.numberOfRounds.Location = new System.Drawing.Point(85, 10);
            this.numberOfRounds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfRounds.Name = "numberOfRounds";
            this.numberOfRounds.Size = new System.Drawing.Size(35, 20);
            this.numberOfRounds.TabIndex = 5;
            this.numberOfRounds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // infRounds
            // 
            this.infRounds.AutoSize = true;
            this.infRounds.Location = new System.Drawing.Point(11, 48);
            this.infRounds.Name = "infRounds";
            this.infRounds.Size = new System.Drawing.Size(100, 17);
            this.infRounds.TabIndex = 7;
            this.infRounds.Text = "Nieograniczona";
            this.infRounds.UseVisualStyleBackColor = true;
            this.infRounds.CheckedChanged += new System.EventHandler(this.infRounds_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numberOfShips);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 34);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ilość Statków";
            // 
            // numberOfShips
            // 
            this.numberOfShips.Location = new System.Drawing.Point(85, 8);
            this.numberOfShips.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfShips.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfShips.Name = "numberOfShips";
            this.numberOfShips.Size = new System.Drawing.Size(35, 20);
            this.numberOfShips.TabIndex = 4;
            this.numberOfShips.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.map_large);
            this.groupBox1.Controls.Add(this.map_medium);
            this.groupBox1.Controls.Add(this.map_small);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapa";
            // 
            // map_large
            // 
            this.map_large.AutoSize = true;
            this.map_large.Location = new System.Drawing.Point(131, 19);
            this.map_large.Name = "map_large";
            this.map_large.Size = new System.Drawing.Size(48, 17);
            this.map_large.TabIndex = 2;
            this.map_large.Text = "duża";
            this.map_large.UseVisualStyleBackColor = true;
            // 
            // map_medium
            // 
            this.map_medium.AutoSize = true;
            this.map_medium.Location = new System.Drawing.Point(66, 19);
            this.map_medium.Name = "map_medium";
            this.map_medium.Size = new System.Drawing.Size(59, 17);
            this.map_medium.TabIndex = 1;
            this.map_medium.Text = "średnia";
            this.map_medium.UseVisualStyleBackColor = true;
            // 
            // map_small
            // 
            this.map_small.AutoSize = true;
            this.map_small.Checked = true;
            this.map_small.Location = new System.Drawing.Point(11, 19);
            this.map_small.Name = "map_small";
            this.map_small.Size = new System.Drawing.Size(49, 17);
            this.map_small.TabIndex = 0;
            this.map_small.TabStop = true;
            this.map_small.Text = "mała";
            this.map_small.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(271, 337);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(199, 56);
            this.start.TabIndex = 13;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "PORT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Server";
            // 
            // startServ
            // 
            this.startServ.Location = new System.Drawing.Point(347, 88);
            this.startServ.Name = "startServ";
            this.startServ.Size = new System.Drawing.Size(366, 33);
            this.startServ.TabIndex = 16;
            this.startServ.Text = "Start Server";
            this.startServ.UseVisualStyleBackColor = true;
            this.startServ.Click += new System.EventHandler(this.startServ_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(583, 62);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 15;
            this.Port.Text = "9000";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(399, 62);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(100, 20);
            this.IP.TabIndex = 14;
            this.IP.Text = "127.0.0.1";
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
            this.log.Location = new System.Drawing.Point(347, 127);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(397, 140);
            this.log.TabIndex = 22;
            // 
            // toSend
            // 
            this.toSend.Location = new System.Drawing.Point(348, 273);
            this.toSend.Multiline = true;
            this.toSend.Name = "toSend";
            this.toSend.Size = new System.Drawing.Size(259, 30);
            this.toSend.TabIndex = 21;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(670, 280);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 20;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.toSend);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startServ);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRounds)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfShips)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox infRounds;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.NumericUpDown numberOfShips;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton map_large;
        private System.Windows.Forms.RadioButton map_medium;
        private System.Windows.Forms.RadioButton map_small;
        private System.Windows.Forms.Button start;
        public System.Windows.Forms.NumericUpDown numberOfRounds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startServ;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox IP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox toSend;
        private System.Windows.Forms.Button Send;
    }
}