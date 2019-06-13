namespace WindowsFormsApp1
{
    partial class Form5
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
            this.orientation = new System.Windows.Forms.GroupBox();
            this.vertical = new System.Windows.Forms.RadioButton();
            this.horizontal = new System.Windows.Forms.RadioButton();
            this.ship4 = new System.Windows.Forms.Button();
            this.ship3 = new System.Windows.Forms.Button();
            this.ship2 = new System.Windows.Forms.Button();
            this.ship1 = new System.Windows.Forms.Button();
            this.u7 = new System.Windows.Forms.Button();
            this.u6 = new System.Windows.Forms.Button();
            this.u5 = new System.Windows.Forms.Button();
            this.t7 = new System.Windows.Forms.Button();
            this.t6 = new System.Windows.Forms.Button();
            this.t5 = new System.Windows.Forms.Button();
            this.s7 = new System.Windows.Forms.Button();
            this.s6 = new System.Windows.Forms.Button();
            this.s5 = new System.Windows.Forms.Button();
            this.u4 = new System.Windows.Forms.Button();
            this.u3 = new System.Windows.Forms.Button();
            this.u2 = new System.Windows.Forms.Button();
            this.u1 = new System.Windows.Forms.Button();
            this.t4 = new System.Windows.Forms.Button();
            this.t3 = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Button();
            this.s4 = new System.Windows.Forms.Button();
            this.s3 = new System.Windows.Forms.Button();
            this.s2 = new System.Windows.Forms.Button();
            this.s1 = new System.Windows.Forms.Button();
            this.z7 = new System.Windows.Forms.Button();
            this.z6 = new System.Windows.Forms.Button();
            this.z5 = new System.Windows.Forms.Button();
            this.y7 = new System.Windows.Forms.Button();
            this.y6 = new System.Windows.Forms.Button();
            this.y5 = new System.Windows.Forms.Button();
            this.x7 = new System.Windows.Forms.Button();
            this.x6 = new System.Windows.Forms.Button();
            this.x5 = new System.Windows.Forms.Button();
            this.w7 = new System.Windows.Forms.Button();
            this.w6 = new System.Windows.Forms.Button();
            this.w5 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.toSend = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.orientation.SuspendLayout();
            this.SuspendLayout();
            // 
            // orientation
            // 
            this.orientation.BackColor = System.Drawing.Color.Transparent;
            this.orientation.Controls.Add(this.vertical);
            this.orientation.Controls.Add(this.horizontal);
            this.orientation.Location = new System.Drawing.Point(443, 12);
            this.orientation.Name = "orientation";
            this.orientation.Size = new System.Drawing.Size(150, 47);
            this.orientation.TabIndex = 56;
            this.orientation.TabStop = false;
            this.orientation.Text = "Orientation";
            // 
            // vertical
            // 
            this.vertical.AutoSize = true;
            this.vertical.Location = new System.Drawing.Point(82, 19);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(59, 17);
            this.vertical.TabIndex = 44;
            this.vertical.Text = "vertical";
            this.vertical.UseVisualStyleBackColor = true;
            // 
            // horizontal
            // 
            this.horizontal.AutoSize = true;
            this.horizontal.Checked = true;
            this.horizontal.Location = new System.Drawing.Point(6, 19);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(70, 17);
            this.horizontal.TabIndex = 43;
            this.horizontal.TabStop = true;
            this.horizontal.Text = "horizontal";
            this.horizontal.UseVisualStyleBackColor = true;
            // 
            // ship4
            // 
            this.ship4.Location = new System.Drawing.Point(328, 12);
            this.ship4.Name = "ship4";
            this.ship4.Size = new System.Drawing.Size(99, 47);
            this.ship4.TabIndex = 55;
            this.ship4.Text = "s4";
            this.ship4.UseVisualStyleBackColor = true;
            this.ship4.Click += new System.EventHandler(this.ship4_Click);
            // 
            // ship3
            // 
            this.ship3.Location = new System.Drawing.Point(223, 12);
            this.ship3.Name = "ship3";
            this.ship3.Size = new System.Drawing.Size(99, 47);
            this.ship3.TabIndex = 54;
            this.ship3.Text = "s3";
            this.ship3.UseVisualStyleBackColor = true;
            this.ship3.Click += new System.EventHandler(this.ship3_Click);
            // 
            // ship2
            // 
            this.ship2.Location = new System.Drawing.Point(118, 12);
            this.ship2.Name = "ship2";
            this.ship2.Size = new System.Drawing.Size(99, 47);
            this.ship2.TabIndex = 53;
            this.ship2.Text = "s2";
            this.ship2.UseVisualStyleBackColor = true;
            this.ship2.Click += new System.EventHandler(this.ship2_Click);
            // 
            // ship1
            // 
            this.ship1.Location = new System.Drawing.Point(13, 12);
            this.ship1.Name = "ship1";
            this.ship1.Size = new System.Drawing.Size(99, 47);
            this.ship1.TabIndex = 52;
            this.ship1.Text = "s1";
            this.ship1.UseVisualStyleBackColor = true;
            this.ship1.Click += new System.EventHandler(this.ship1_Click);
            // 
            // u7
            // 
            this.u7.Enabled = false;
            this.u7.ForeColor = System.Drawing.Color.Gray;
            this.u7.Location = new System.Drawing.Point(408, 203);
            this.u7.Name = "u7";
            this.u7.Size = new System.Drawing.Size(55, 42);
            this.u7.TabIndex = 230;
            this.u7.Text = "U7";
            this.u7.UseVisualStyleBackColor = true;
            this.u7.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // u6
            // 
            this.u6.Enabled = false;
            this.u6.ForeColor = System.Drawing.Color.Gray;
            this.u6.Location = new System.Drawing.Point(347, 203);
            this.u6.Name = "u6";
            this.u6.Size = new System.Drawing.Size(55, 42);
            this.u6.TabIndex = 229;
            this.u6.Text = "U6";
            this.u6.UseVisualStyleBackColor = true;
            this.u6.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // u5
            // 
            this.u5.Enabled = false;
            this.u5.ForeColor = System.Drawing.Color.Gray;
            this.u5.Location = new System.Drawing.Point(286, 203);
            this.u5.Name = "u5";
            this.u5.Size = new System.Drawing.Size(55, 42);
            this.u5.TabIndex = 228;
            this.u5.Text = "U5";
            this.u5.UseVisualStyleBackColor = true;
            this.u5.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // t7
            // 
            this.t7.Enabled = false;
            this.t7.ForeColor = System.Drawing.Color.Gray;
            this.t7.Location = new System.Drawing.Point(408, 155);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(55, 42);
            this.t7.TabIndex = 227;
            this.t7.Text = "T7";
            this.t7.UseVisualStyleBackColor = true;
            this.t7.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // t6
            // 
            this.t6.Enabled = false;
            this.t6.ForeColor = System.Drawing.Color.Gray;
            this.t6.Location = new System.Drawing.Point(347, 155);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(55, 42);
            this.t6.TabIndex = 226;
            this.t6.Text = "T6";
            this.t6.UseVisualStyleBackColor = true;
            this.t6.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // t5
            // 
            this.t5.Enabled = false;
            this.t5.ForeColor = System.Drawing.Color.Gray;
            this.t5.Location = new System.Drawing.Point(286, 155);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(55, 42);
            this.t5.TabIndex = 225;
            this.t5.Text = "T5";
            this.t5.UseVisualStyleBackColor = true;
            this.t5.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // s7
            // 
            this.s7.Enabled = false;
            this.s7.ForeColor = System.Drawing.Color.Gray;
            this.s7.Location = new System.Drawing.Point(408, 107);
            this.s7.Name = "s7";
            this.s7.Size = new System.Drawing.Size(55, 42);
            this.s7.TabIndex = 224;
            this.s7.Text = "S7";
            this.s7.UseVisualStyleBackColor = true;
            this.s7.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // s6
            // 
            this.s6.Enabled = false;
            this.s6.ForeColor = System.Drawing.Color.Gray;
            this.s6.Location = new System.Drawing.Point(347, 107);
            this.s6.Name = "s6";
            this.s6.Size = new System.Drawing.Size(55, 42);
            this.s6.TabIndex = 223;
            this.s6.Text = "S6";
            this.s6.UseVisualStyleBackColor = true;
            this.s6.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // s5
            // 
            this.s5.Enabled = false;
            this.s5.ForeColor = System.Drawing.Color.Gray;
            this.s5.Location = new System.Drawing.Point(286, 107);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(55, 42);
            this.s5.TabIndex = 222;
            this.s5.Text = "S5";
            this.s5.UseVisualStyleBackColor = true;
            this.s5.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // u4
            // 
            this.u4.Enabled = false;
            this.u4.ForeColor = System.Drawing.Color.Gray;
            this.u4.Location = new System.Drawing.Point(225, 203);
            this.u4.Name = "u4";
            this.u4.Size = new System.Drawing.Size(55, 42);
            this.u4.TabIndex = 221;
            this.u4.Text = "U4";
            this.u4.UseVisualStyleBackColor = true;
            this.u4.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // u3
            // 
            this.u3.Enabled = false;
            this.u3.ForeColor = System.Drawing.Color.Gray;
            this.u3.Location = new System.Drawing.Point(164, 203);
            this.u3.Name = "u3";
            this.u3.Size = new System.Drawing.Size(55, 42);
            this.u3.TabIndex = 220;
            this.u3.Text = "U3";
            this.u3.UseVisualStyleBackColor = true;
            this.u3.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // u2
            // 
            this.u2.Enabled = false;
            this.u2.ForeColor = System.Drawing.Color.Gray;
            this.u2.Location = new System.Drawing.Point(103, 203);
            this.u2.Name = "u2";
            this.u2.Size = new System.Drawing.Size(55, 42);
            this.u2.TabIndex = 219;
            this.u2.Text = "U2";
            this.u2.UseVisualStyleBackColor = true;
            this.u2.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // u1
            // 
            this.u1.Enabled = false;
            this.u1.ForeColor = System.Drawing.Color.Gray;
            this.u1.Location = new System.Drawing.Point(42, 203);
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(55, 42);
            this.u1.TabIndex = 218;
            this.u1.Text = "U1";
            this.u1.UseVisualStyleBackColor = true;
            this.u1.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // t4
            // 
            this.t4.Enabled = false;
            this.t4.ForeColor = System.Drawing.Color.Gray;
            this.t4.Location = new System.Drawing.Point(225, 155);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(55, 42);
            this.t4.TabIndex = 217;
            this.t4.Text = "T4";
            this.t4.UseVisualStyleBackColor = true;
            this.t4.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // t3
            // 
            this.t3.Enabled = false;
            this.t3.ForeColor = System.Drawing.Color.Gray;
            this.t3.Location = new System.Drawing.Point(164, 155);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(55, 42);
            this.t3.TabIndex = 216;
            this.t3.Text = "T3";
            this.t3.UseVisualStyleBackColor = true;
            this.t3.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // t2
            // 
            this.t2.Enabled = false;
            this.t2.ForeColor = System.Drawing.Color.Gray;
            this.t2.Location = new System.Drawing.Point(103, 155);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(55, 42);
            this.t2.TabIndex = 215;
            this.t2.Text = "T2";
            this.t2.UseVisualStyleBackColor = true;
            this.t2.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // t1
            // 
            this.t1.Enabled = false;
            this.t1.ForeColor = System.Drawing.Color.Gray;
            this.t1.Location = new System.Drawing.Point(42, 155);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(55, 42);
            this.t1.TabIndex = 214;
            this.t1.Text = "T1";
            this.t1.UseVisualStyleBackColor = true;
            this.t1.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // s4
            // 
            this.s4.Enabled = false;
            this.s4.ForeColor = System.Drawing.Color.Gray;
            this.s4.Location = new System.Drawing.Point(225, 107);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(55, 42);
            this.s4.TabIndex = 213;
            this.s4.Text = "S4";
            this.s4.UseVisualStyleBackColor = true;
            this.s4.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // s3
            // 
            this.s3.Enabled = false;
            this.s3.ForeColor = System.Drawing.Color.Gray;
            this.s3.Location = new System.Drawing.Point(164, 107);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(55, 42);
            this.s3.TabIndex = 212;
            this.s3.Text = "S3";
            this.s3.UseVisualStyleBackColor = true;
            this.s3.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // s2
            // 
            this.s2.Enabled = false;
            this.s2.ForeColor = System.Drawing.Color.Gray;
            this.s2.Location = new System.Drawing.Point(103, 107);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(55, 42);
            this.s2.TabIndex = 211;
            this.s2.Text = "S2";
            this.s2.UseVisualStyleBackColor = true;
            this.s2.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // s1
            // 
            this.s1.Enabled = false;
            this.s1.ForeColor = System.Drawing.Color.Gray;
            this.s1.Location = new System.Drawing.Point(42, 107);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(55, 42);
            this.s1.TabIndex = 210;
            this.s1.Text = "S1";
            this.s1.UseVisualStyleBackColor = true;
            this.s1.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // z7
            // 
            this.z7.Enabled = false;
            this.z7.ForeColor = System.Drawing.Color.Gray;
            this.z7.Location = new System.Drawing.Point(408, 395);
            this.z7.Name = "z7";
            this.z7.Size = new System.Drawing.Size(55, 42);
            this.z7.TabIndex = 209;
            this.z7.Text = "Z7";
            this.z7.UseVisualStyleBackColor = true;
            this.z7.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // z6
            // 
            this.z6.Enabled = false;
            this.z6.ForeColor = System.Drawing.Color.Gray;
            this.z6.Location = new System.Drawing.Point(347, 395);
            this.z6.Name = "z6";
            this.z6.Size = new System.Drawing.Size(55, 42);
            this.z6.TabIndex = 208;
            this.z6.Text = "Z6";
            this.z6.UseVisualStyleBackColor = true;
            this.z6.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // z5
            // 
            this.z5.Enabled = false;
            this.z5.ForeColor = System.Drawing.Color.Gray;
            this.z5.Location = new System.Drawing.Point(286, 395);
            this.z5.Name = "z5";
            this.z5.Size = new System.Drawing.Size(55, 42);
            this.z5.TabIndex = 207;
            this.z5.Text = "Z5";
            this.z5.UseVisualStyleBackColor = true;
            this.z5.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // y7
            // 
            this.y7.Enabled = false;
            this.y7.ForeColor = System.Drawing.Color.Gray;
            this.y7.Location = new System.Drawing.Point(408, 347);
            this.y7.Name = "y7";
            this.y7.Size = new System.Drawing.Size(55, 42);
            this.y7.TabIndex = 206;
            this.y7.Text = "Y7";
            this.y7.UseVisualStyleBackColor = true;
            this.y7.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // y6
            // 
            this.y6.Enabled = false;
            this.y6.ForeColor = System.Drawing.Color.Gray;
            this.y6.Location = new System.Drawing.Point(347, 347);
            this.y6.Name = "y6";
            this.y6.Size = new System.Drawing.Size(55, 42);
            this.y6.TabIndex = 205;
            this.y6.Text = "Y6";
            this.y6.UseVisualStyleBackColor = true;
            this.y6.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // y5
            // 
            this.y5.Enabled = false;
            this.y5.ForeColor = System.Drawing.Color.Gray;
            this.y5.Location = new System.Drawing.Point(286, 347);
            this.y5.Name = "y5";
            this.y5.Size = new System.Drawing.Size(55, 42);
            this.y5.TabIndex = 204;
            this.y5.Text = "Y5";
            this.y5.UseVisualStyleBackColor = true;
            this.y5.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // x7
            // 
            this.x7.Enabled = false;
            this.x7.ForeColor = System.Drawing.Color.Gray;
            this.x7.Location = new System.Drawing.Point(408, 299);
            this.x7.Name = "x7";
            this.x7.Size = new System.Drawing.Size(55, 42);
            this.x7.TabIndex = 203;
            this.x7.Text = "X7";
            this.x7.UseVisualStyleBackColor = true;
            this.x7.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // x6
            // 
            this.x6.Enabled = false;
            this.x6.ForeColor = System.Drawing.Color.Gray;
            this.x6.Location = new System.Drawing.Point(347, 299);
            this.x6.Name = "x6";
            this.x6.Size = new System.Drawing.Size(55, 42);
            this.x6.TabIndex = 202;
            this.x6.Text = "X6";
            this.x6.UseVisualStyleBackColor = true;
            this.x6.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // x5
            // 
            this.x5.Enabled = false;
            this.x5.ForeColor = System.Drawing.Color.Gray;
            this.x5.Location = new System.Drawing.Point(286, 299);
            this.x5.Name = "x5";
            this.x5.Size = new System.Drawing.Size(55, 42);
            this.x5.TabIndex = 201;
            this.x5.Text = "X5";
            this.x5.UseVisualStyleBackColor = true;
            this.x5.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // w7
            // 
            this.w7.Enabled = false;
            this.w7.ForeColor = System.Drawing.Color.Gray;
            this.w7.Location = new System.Drawing.Point(408, 251);
            this.w7.Name = "w7";
            this.w7.Size = new System.Drawing.Size(55, 42);
            this.w7.TabIndex = 200;
            this.w7.Text = "W7";
            this.w7.UseVisualStyleBackColor = true;
            this.w7.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // w6
            // 
            this.w6.Enabled = false;
            this.w6.ForeColor = System.Drawing.Color.Gray;
            this.w6.Location = new System.Drawing.Point(347, 251);
            this.w6.Name = "w6";
            this.w6.Size = new System.Drawing.Size(55, 42);
            this.w6.TabIndex = 199;
            this.w6.Text = "W6";
            this.w6.UseVisualStyleBackColor = true;
            this.w6.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // w5
            // 
            this.w5.Enabled = false;
            this.w5.ForeColor = System.Drawing.Color.Gray;
            this.w5.Location = new System.Drawing.Point(286, 251);
            this.w5.Name = "w5";
            this.w5.Size = new System.Drawing.Size(55, 42);
            this.w5.TabIndex = 198;
            this.w5.Text = "W5";
            this.w5.UseVisualStyleBackColor = true;
            this.w5.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // z4
            // 
            this.z4.Enabled = false;
            this.z4.ForeColor = System.Drawing.Color.Gray;
            this.z4.Location = new System.Drawing.Point(225, 395);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(55, 42);
            this.z4.TabIndex = 197;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // z3
            // 
            this.z3.Enabled = false;
            this.z3.ForeColor = System.Drawing.Color.Gray;
            this.z3.Location = new System.Drawing.Point(164, 395);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(55, 42);
            this.z3.TabIndex = 196;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // z2
            // 
            this.z2.Enabled = false;
            this.z2.ForeColor = System.Drawing.Color.Gray;
            this.z2.Location = new System.Drawing.Point(103, 395);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(55, 42);
            this.z2.TabIndex = 195;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // z1
            // 
            this.z1.Enabled = false;
            this.z1.ForeColor = System.Drawing.Color.Gray;
            this.z1.Location = new System.Drawing.Point(42, 395);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(55, 42);
            this.z1.TabIndex = 194;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // y4
            // 
            this.y4.Enabled = false;
            this.y4.ForeColor = System.Drawing.Color.Gray;
            this.y4.Location = new System.Drawing.Point(225, 347);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(55, 42);
            this.y4.TabIndex = 193;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // y3
            // 
            this.y3.Enabled = false;
            this.y3.ForeColor = System.Drawing.Color.Gray;
            this.y3.Location = new System.Drawing.Point(164, 347);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(55, 42);
            this.y3.TabIndex = 192;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // y2
            // 
            this.y2.Enabled = false;
            this.y2.ForeColor = System.Drawing.Color.Gray;
            this.y2.Location = new System.Drawing.Point(103, 347);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(55, 42);
            this.y2.TabIndex = 191;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // y1
            // 
            this.y1.Enabled = false;
            this.y1.ForeColor = System.Drawing.Color.Gray;
            this.y1.Location = new System.Drawing.Point(42, 347);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(55, 42);
            this.y1.TabIndex = 190;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // x4
            // 
            this.x4.Enabled = false;
            this.x4.ForeColor = System.Drawing.Color.Gray;
            this.x4.Location = new System.Drawing.Point(225, 299);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(55, 42);
            this.x4.TabIndex = 189;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // x3
            // 
            this.x3.Enabled = false;
            this.x3.ForeColor = System.Drawing.Color.Gray;
            this.x3.Location = new System.Drawing.Point(164, 299);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(55, 42);
            this.x3.TabIndex = 188;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // x2
            // 
            this.x2.Enabled = false;
            this.x2.ForeColor = System.Drawing.Color.Gray;
            this.x2.Location = new System.Drawing.Point(103, 299);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(55, 42);
            this.x2.TabIndex = 187;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // x1
            // 
            this.x1.Enabled = false;
            this.x1.ForeColor = System.Drawing.Color.Gray;
            this.x1.Location = new System.Drawing.Point(42, 299);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(55, 42);
            this.x1.TabIndex = 186;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // w4
            // 
            this.w4.Enabled = false;
            this.w4.ForeColor = System.Drawing.Color.Gray;
            this.w4.Location = new System.Drawing.Point(225, 251);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(55, 42);
            this.w4.TabIndex = 185;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // w3
            // 
            this.w3.Enabled = false;
            this.w3.ForeColor = System.Drawing.Color.Gray;
            this.w3.Location = new System.Drawing.Point(164, 251);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(55, 42);
            this.w3.TabIndex = 184;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // w2
            // 
            this.w2.Enabled = false;
            this.w2.ForeColor = System.Drawing.Color.Gray;
            this.w2.Location = new System.Drawing.Point(103, 251);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(55, 42);
            this.w2.TabIndex = 183;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // w1
            // 
            this.w1.Enabled = false;
            this.w1.ForeColor = System.Drawing.Color.Gray;
            this.w1.Location = new System.Drawing.Point(42, 251);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(55, 42);
            this.w1.TabIndex = 182;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.PlayerPicksPositions);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(570, 121);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(397, 140);
            this.log.TabIndex = 233;
            // 
            // toSend
            // 
            this.toSend.Location = new System.Drawing.Point(571, 267);
            this.toSend.Multiline = true;
            this.toSend.Name = "toSend";
            this.toSend.Size = new System.Drawing.Size(259, 30);
            this.toSend.TabIndex = 232;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(893, 274);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 231;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // discard
            // 
            this.discard.Location = new System.Drawing.Point(493, 465);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(99, 47);
            this.discard.TabIndex = 235;
            this.discard.Text = "Discard";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // accept
            // 
            this.accept.Enabled = false;
            this.accept.ForeColor = System.Drawing.Color.Gray;
            this.accept.Location = new System.Drawing.Point(363, 465);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(99, 47);
            this.accept.TabIndex = 234;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._2c;
            this.ClientSize = new System.Drawing.Size(992, 523);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.log);
            this.Controls.Add(this.toSend);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.u7);
            this.Controls.Add(this.u6);
            this.Controls.Add(this.u5);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.s7);
            this.Controls.Add(this.s6);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.u4);
            this.Controls.Add(this.u3);
            this.Controls.Add(this.u2);
            this.Controls.Add(this.u1);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.z7);
            this.Controls.Add(this.z6);
            this.Controls.Add(this.z5);
            this.Controls.Add(this.y7);
            this.Controls.Add(this.y6);
            this.Controls.Add(this.y5);
            this.Controls.Add(this.x7);
            this.Controls.Add(this.x6);
            this.Controls.Add(this.x5);
            this.Controls.Add(this.w7);
            this.Controls.Add(this.w6);
            this.Controls.Add(this.w5);
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
            this.Controls.Add(this.orientation);
            this.Controls.Add(this.ship4);
            this.Controls.Add(this.ship3);
            this.Controls.Add(this.ship2);
            this.Controls.Add(this.ship1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Shown += new System.EventHandler(this.Form5_Shown);
            this.orientation.ResumeLayout(false);
            this.orientation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox orientation;
        private System.Windows.Forms.RadioButton vertical;
        private System.Windows.Forms.RadioButton horizontal;
        private System.Windows.Forms.Button ship4;
        private System.Windows.Forms.Button ship3;
        private System.Windows.Forms.Button ship2;
        private System.Windows.Forms.Button ship1;
        private System.Windows.Forms.Button u7;
        private System.Windows.Forms.Button u6;
        private System.Windows.Forms.Button u5;
        private System.Windows.Forms.Button t7;
        private System.Windows.Forms.Button t6;
        private System.Windows.Forms.Button t5;
        private System.Windows.Forms.Button s7;
        private System.Windows.Forms.Button s6;
        private System.Windows.Forms.Button s5;
        private System.Windows.Forms.Button u4;
        private System.Windows.Forms.Button u3;
        private System.Windows.Forms.Button u2;
        private System.Windows.Forms.Button u1;
        private System.Windows.Forms.Button t4;
        private System.Windows.Forms.Button t3;
        private System.Windows.Forms.Button t2;
        private System.Windows.Forms.Button t1;
        private System.Windows.Forms.Button s4;
        private System.Windows.Forms.Button s3;
        private System.Windows.Forms.Button s2;
        private System.Windows.Forms.Button s1;
        private System.Windows.Forms.Button z7;
        private System.Windows.Forms.Button z6;
        private System.Windows.Forms.Button z5;
        private System.Windows.Forms.Button y7;
        private System.Windows.Forms.Button y6;
        private System.Windows.Forms.Button y5;
        private System.Windows.Forms.Button x7;
        private System.Windows.Forms.Button x6;
        private System.Windows.Forms.Button x5;
        private System.Windows.Forms.Button w7;
        private System.Windows.Forms.Button w6;
        private System.Windows.Forms.Button w5;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox toSend;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.Button accept;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}