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
            this.start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.log = new System.Windows.Forms.TextBox();
            this.toSend = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(137, 330);
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
            this.label5.Location = new System.Drawing.Point(236, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "PORT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(46, 60);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(366, 33);
            this.Connect.TabIndex = 16;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(282, 34);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 15;
            this.Port.Text = "9000";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(98, 34);
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
            this.log.Location = new System.Drawing.Point(46, 99);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(397, 140);
            this.log.TabIndex = 22;
            // 
            // toSend
            // 
            this.toSend.Location = new System.Drawing.Point(47, 245);
            this.toSend.Multiline = true;
            this.toSend.Name = "toSend";
            this.toSend.Size = new System.Drawing.Size(259, 30);
            this.toSend.TabIndex = 21;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(369, 252);
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
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.toSend);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.start);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox IP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox toSend;
        private System.Windows.Forms.Button Send;
    }
}