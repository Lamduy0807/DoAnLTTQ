namespace Game_Xếp_Hình
{
    partial class winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStep = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbOK = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbStep);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbOK);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 600);
            this.panel1.TabIndex = 0;
            // 
            // lbStep
            // 
            this.lbStep.AutoSize = true;
            this.lbStep.BackColor = System.Drawing.Color.Transparent;
            this.lbStep.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStep.ForeColor = System.Drawing.Color.Black;
            this.lbStep.Location = new System.Drawing.Point(446, 278);
            this.lbStep.Name = "lbStep";
            this.lbStep.Size = new System.Drawing.Size(84, 40);
            this.lbStep.TabIndex = 17;
            this.lbStep.Text = "label";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbTime.Location = new System.Drawing.Point(446, 220);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(84, 40);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "label";
            // 
            // lbOK
            // 
            this.lbOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOK.AutoSize = true;
            this.lbOK.BackColor = System.Drawing.Color.Transparent;
            this.lbOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbOK.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOK.ForeColor = System.Drawing.Color.Black;
            this.lbOK.Location = new System.Drawing.Point(366, 452);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(88, 51);
            this.lbOK.TabIndex = 15;
            this.lbOK.Text = "OK";
            this.lbOK.Click += new System.EventHandler(this.lbOK_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.SandyBrown;
            this.tbName.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(408, 362);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 45);
            this.tbName.TabIndex = 0;
            // 
            // winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "winner";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbStep;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbOK;
    }
}