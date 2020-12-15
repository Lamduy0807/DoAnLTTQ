namespace Game_Xếp_Hình
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eButton2 = new Game_Xếp_Hình.EButton();
            this.eButton1 = new Game_Xếp_Hình.EButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.eButton2);
            this.panel1.Controls.Add(this.eButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 565);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(311, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 72);
            this.panel2.TabIndex = 2;
            // 
            // eButton2
            // 
            this.eButton2.BackColor = System.Drawing.Color.DimGray;
            this.eButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eButton2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eButton2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.eButton2.Image = ((System.Drawing.Image)(resources.GetObject("eButton2.Image")));
            this.eButton2.Location = new System.Drawing.Point(189, 401);
            this.eButton2.Name = "eButton2";
            this.eButton2.Size = new System.Drawing.Size(90, 85);
            this.eButton2.TabIndex = 1;
            this.eButton2.Text = "Cancel";
            this.eButton2.UseVisualStyleBackColor = false;
            // 
            // eButton1
            // 
            this.eButton1.BackColor = System.Drawing.Color.DimGray;
            this.eButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eButton1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eButton1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.eButton1.Image = ((System.Drawing.Image)(resources.GetObject("eButton1.Image")));
            this.eButton1.Location = new System.Drawing.Point(341, 401);
            this.eButton1.Name = "eButton1";
            this.eButton1.Size = new System.Drawing.Size(87, 85);
            this.eButton1.TabIndex = 0;
            this.eButton1.Text = "OK";
            this.eButton1.UseVisualStyleBackColor = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 565);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Setting";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private EButton eButton2;
        private EButton eButton1;
        private System.Windows.Forms.Panel panel2;
    }
}