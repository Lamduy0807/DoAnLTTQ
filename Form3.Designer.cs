namespace Game_Xếp_Hình
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pbmain = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.LbChooseImage = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbcapdo = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.pnHome = new System.Windows.Forms.Panel();
            this.pnConPau = new System.Windows.Forms.Panel();
            this.pnRestart = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnExit = new System.Windows.Forms.Panel();
            this.pnIns = new System.Windows.Forms.Panel();
            this.pnOpt = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdiem = new System.Windows.Forms.Label();
            this.lbPau = new System.Windows.Forms.Panel();
            this.lbIn = new System.Windows.Forms.Label();
            this.lbHome = new System.Windows.Forms.Label();
            this.lbConPau = new System.Windows.Forms.Label();
            this.lbRe = new System.Windows.Forms.Label();
            this.lbSet = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.lb_level = new System.Windows.Forms.Label();
            this.pn_Next = new System.Windows.Forms.Panel();
            this.pn_Return = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbmain)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.lbPau.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbmain
            // 
            this.pbmain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbmain.Location = new System.Drawing.Point(1391, 436);
            this.pbmain.Name = "pbmain";
            this.pbmain.Size = new System.Drawing.Size(234, 213);
            this.pbmain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmain.TabIndex = 3;
            this.pbmain.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(204, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 736);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Controls.Add(this.LbChooseImage);
            this.panel10.Controls.Add(this.lbStart);
            this.panel10.Location = new System.Drawing.Point(1210, 674);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(625, 419);
            this.panel10.TabIndex = 36;
            // 
            // LbChooseImage
            // 
            this.LbChooseImage.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbChooseImage.ForeColor = System.Drawing.Color.Red;
            this.LbChooseImage.Location = new System.Drawing.Point(142, 36);
            this.LbChooseImage.Name = "LbChooseImage";
            this.LbChooseImage.Size = new System.Drawing.Size(370, 53);
            this.LbChooseImage.TabIndex = 41;
            this.LbChooseImage.Text = "Choose Image";
            this.LbChooseImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbChooseImage.Click += new System.EventHandler(this.LbChooseImage_Click);
            // 
            // lbStart
            // 
            this.lbStart.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStart.ForeColor = System.Drawing.Color.Red;
            this.lbStart.Location = new System.Drawing.Point(208, 153);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(235, 53);
            this.lbStart.TabIndex = 40;
            this.lbStart.Text = "Start";
            this.lbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcapdo
            // 
            this.lbcapdo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcapdo.BackColor = System.Drawing.Color.Transparent;
            this.lbcapdo.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcapdo.ForeColor = System.Drawing.Color.Coral;
            this.lbcapdo.Location = new System.Drawing.Point(1490, 105);
            this.lbcapdo.Name = "lbcapdo";
            this.lbcapdo.Size = new System.Drawing.Size(139, 62);
            this.lbcapdo.TabIndex = 38;
            this.lbcapdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLevel
            // 
            this.lbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Coral;
            this.lbLevel.Location = new System.Drawing.Point(1418, 46);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(160, 53);
            this.lbLevel.TabIndex = 37;
            this.lbLevel.Text = "Level";
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.Transparent;
            this.pnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnHome.BackgroundImage")));
            this.pnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHome.Location = new System.Drawing.Point(3, 464);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(95, 92);
            this.pnHome.TabIndex = 29;
            this.pnHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnHome_MouseClick);
            this.pnHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHome_MouseMove);
            // 
            // pnConPau
            // 
            this.pnConPau.BackColor = System.Drawing.Color.Transparent;
            this.pnConPau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnConPau.BackgroundImage")));
            this.pnConPau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnConPau.Location = new System.Drawing.Point(3, 278);
            this.pnConPau.Name = "pnConPau";
            this.pnConPau.Size = new System.Drawing.Size(89, 87);
            this.pnConPau.TabIndex = 28;
            this.pnConPau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnConPau_MouseClick);
            this.pnConPau.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnConPau_MouseMove);
            // 
            // pnRestart
            // 
            this.pnRestart.BackColor = System.Drawing.Color.Transparent;
            this.pnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnRestart.BackgroundImage")));
            this.pnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnRestart.Location = new System.Drawing.Point(5, 180);
            this.pnRestart.Name = "pnRestart";
            this.pnRestart.Size = new System.Drawing.Size(90, 92);
            this.pnRestart.TabIndex = 27;
            this.pnRestart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnRestart_MouseClick);
            this.pnRestart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnRestart_MouseMove);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.pnExit);
            this.panel8.Controls.Add(this.pnIns);
            this.panel8.Controls.Add(this.pnHome);
            this.panel8.Controls.Add(this.pnOpt);
            this.panel8.Controls.Add(this.pnRestart);
            this.panel8.Controls.Add(this.pnConPau);
            this.panel8.Location = new System.Drawing.Point(1827, -2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(93, 1057);
            this.panel8.TabIndex = 34;
            // 
            // pnExit
            // 
            this.pnExit.BackColor = System.Drawing.Color.Transparent;
            this.pnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnExit.BackgroundImage")));
            this.pnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnExit.Location = new System.Drawing.Point(1, 4);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(92, 83);
            this.pnExit.TabIndex = 31;
            this.pnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnExit_MouseClick);
            this.pnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnExit_MouseMove);
            // 
            // pnIns
            // 
            this.pnIns.BackColor = System.Drawing.Color.Transparent;
            this.pnIns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnIns.BackgroundImage")));
            this.pnIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnIns.Location = new System.Drawing.Point(3, 371);
            this.pnIns.Name = "pnIns";
            this.pnIns.Size = new System.Drawing.Size(90, 89);
            this.pnIns.TabIndex = 32;
            this.pnIns.Click += new System.EventHandler(this.panel7_Click);
            this.pnIns.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnIns_MouseMove);
            // 
            // pnOpt
            // 
            this.pnOpt.BackColor = System.Drawing.Color.Transparent;
            this.pnOpt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnOpt.BackgroundImage")));
            this.pnOpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnOpt.Location = new System.Drawing.Point(3, 93);
            this.pnOpt.Name = "pnOpt";
            this.pnOpt.Size = new System.Drawing.Size(92, 83);
            this.pnOpt.TabIndex = 30;
            this.pnOpt.Click += new System.EventHandler(this.panel5_Click);
            this.pnOpt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnOpt_MouseMove);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(1352, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 67);
            this.label4.TabIndex = 35;
            this.label4.Text = "Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(1352, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 69);
            this.label1.TabIndex = 34;
            this.label1.Text = "Steps";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtime
            // 
            this.lbtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtime.BackColor = System.Drawing.Color.Transparent;
            this.lbtime.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.ForeColor = System.Drawing.Color.DarkRed;
            this.lbtime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbtime.Location = new System.Drawing.Point(1497, 345);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(220, 67);
            this.lbtime.TabIndex = 33;
            this.lbtime.Text = "0 s";
            this.lbtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdiem
            // 
            this.lbdiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdiem.BackColor = System.Drawing.Color.Transparent;
            this.lbdiem.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiem.ForeColor = System.Drawing.Color.DarkRed;
            this.lbdiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbdiem.Location = new System.Drawing.Point(1526, 264);
            this.lbdiem.Name = "lbdiem";
            this.lbdiem.Size = new System.Drawing.Size(120, 69);
            this.lbdiem.TabIndex = 36;
            this.lbdiem.Text = "0";
            this.lbdiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPau
            // 
            this.lbPau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPau.BackColor = System.Drawing.Color.Transparent;
            this.lbPau.Controls.Add(this.lbIn);
            this.lbPau.Controls.Add(this.lbHome);
            this.lbPau.Controls.Add(this.lbConPau);
            this.lbPau.Controls.Add(this.lbRe);
            this.lbPau.Controls.Add(this.lbSet);
            this.lbPau.Controls.Add(this.lbExit);
            this.lbPau.Location = new System.Drawing.Point(1688, 1);
            this.lbPau.Name = "lbPau";
            this.lbPau.Size = new System.Drawing.Size(147, 643);
            this.lbPau.TabIndex = 39;
            // 
            // lbIn
            // 
            this.lbIn.AutoSize = true;
            this.lbIn.BackColor = System.Drawing.Color.White;
            this.lbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIn.Location = new System.Drawing.Point(49, 394);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(95, 24);
            this.lbIn.TabIndex = 7;
            this.lbIn.Text = "Instruction";
            this.lbIn.Visible = false;
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.BackColor = System.Drawing.Color.White;
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.Location = new System.Drawing.Point(82, 490);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(62, 24);
            this.lbHome.TabIndex = 6;
            this.lbHome.Text = "Home";
            this.lbHome.Visible = false;
            // 
            // lbConPau
            // 
            this.lbConPau.AutoSize = true;
            this.lbConPau.BackColor = System.Drawing.Color.White;
            this.lbConPau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConPau.Location = new System.Drawing.Point(3, 294);
            this.lbConPau.Name = "lbConPau";
            this.lbConPau.Size = new System.Drawing.Size(144, 24);
            this.lbConPau.TabIndex = 5;
            this.lbConPau.Text = "Continue/Pause";
            this.lbConPau.Visible = false;
            // 
            // lbRe
            // 
            this.lbRe.AutoSize = true;
            this.lbRe.BackColor = System.Drawing.Color.White;
            this.lbRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRe.Location = new System.Drawing.Point(77, 204);
            this.lbRe.Name = "lbRe";
            this.lbRe.Size = new System.Drawing.Size(67, 24);
            this.lbRe.TabIndex = 3;
            this.lbRe.Text = "Restart";
            this.lbRe.Visible = false;
            // 
            // lbSet
            // 
            this.lbSet.AutoSize = true;
            this.lbSet.BackColor = System.Drawing.Color.White;
            this.lbSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSet.Location = new System.Drawing.Point(72, 118);
            this.lbSet.Name = "lbSet";
            this.lbSet.Size = new System.Drawing.Size(75, 24);
            this.lbSet.TabIndex = 1;
            this.lbSet.Text = "Options";
            this.lbSet.Visible = false;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.White;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(106, 20);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(41, 24);
            this.lbExit.TabIndex = 0;
            this.lbExit.Text = "Exit";
            this.lbExit.Visible = false;
            // 
            // lb_level
            // 
            this.lb_level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_level.BackColor = System.Drawing.Color.Transparent;
            this.lb_level.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_level.ForeColor = System.Drawing.Color.Coral;
            this.lb_level.Location = new System.Drawing.Point(1440, 110);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(115, 53);
            this.lb_level.TabIndex = 40;
            this.lb_level.Text = "3x3";
            this.lb_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_Next
            // 
            this.pn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Next.BackColor = System.Drawing.Color.Transparent;
            this.pn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_Next.BackgroundImage")));
            this.pn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Next.Location = new System.Drawing.Point(1563, 110);
            this.pn_Next.Name = "pn_Next";
            this.pn_Next.Size = new System.Drawing.Size(56, 57);
            this.pn_Next.TabIndex = 41;
            this.pn_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_Next_MouseClick);
            // 
            // pn_Return
            // 
            this.pn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Return.BackColor = System.Drawing.Color.Transparent;
            this.pn_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_Return.BackgroundImage")));
            this.pn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Return.Location = new System.Drawing.Point(1374, 110);
            this.pn_Return.Name = "pn_Return";
            this.pn_Return.Size = new System.Drawing.Size(45, 53);
            this.pn_Return.TabIndex = 42;
            this.pn_Return.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_Return_MouseClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.pn_Return);
            this.Controls.Add(this.pn_Next);
            this.Controls.Add(this.lb_level);
            this.Controls.Add(this.lbPau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbcapdo);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.lbdiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbmain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbmain)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.lbPau.ResumeLayout(false);
            this.lbPau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbmain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Panel pnConPau;
        private System.Windows.Forms.Panel pnRestart;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnIns;
        private System.Windows.Forms.Panel pnOpt;
        private System.Windows.Forms.Label lbcapdo;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbdiem;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Label LbChooseImage;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Panel lbPau;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbConPau;
        private System.Windows.Forms.Label lbRe;
        private System.Windows.Forms.Label lbSet;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.Panel pn_Next;
        private System.Windows.Forms.Panel pn_Return;
    }
}