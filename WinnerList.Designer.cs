
namespace Game_Xếp_Hình
{
    partial class WinnerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvWinnerList = new System.Windows.Forms.ListView();
            this.winnerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winnerTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winnerStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lvWinnerList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 644);
            this.panel1.TabIndex = 1;
            // 
            // lvWinnerList
            // 
            this.lvWinnerList.BackColor = System.Drawing.Color.DimGray;
            this.lvWinnerList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvWinnerList.BackgroundImage")));
            this.lvWinnerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWinnerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.winnerName,
            this.winnerTime,
            this.winnerStep});
            this.lvWinnerList.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvWinnerList.ForeColor = System.Drawing.Color.Sienna;
            this.lvWinnerList.FullRowSelect = true;
            this.lvWinnerList.GridLines = true;
            this.lvWinnerList.HideSelection = false;
            this.lvWinnerList.Location = new System.Drawing.Point(222, 196);
            this.lvWinnerList.Margin = new System.Windows.Forms.Padding(4);
            this.lvWinnerList.Name = "lvWinnerList";
            this.lvWinnerList.Size = new System.Drawing.Size(449, 305);
            this.lvWinnerList.TabIndex = 2;
            this.lvWinnerList.UseCompatibleStateImageBehavior = false;
            this.lvWinnerList.View = System.Windows.Forms.View.Details;
            // 
            // winnerName
            // 
            this.winnerName.Text = "Name";
            this.winnerName.Width = 120;
            // 
            // winnerTime
            // 
            this.winnerTime.Text = "Time";
            this.winnerTime.Width = 118;
            // 
            // winnerStep
            // 
            this.winnerStep.Text = "Steps";
            this.winnerStep.Width = 117;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(528, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 51);
            this.label2.TabIndex = 16;
            this.label2.Text = "Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WinnerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 644);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinnerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerList";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvWinnerList;
        private System.Windows.Forms.ColumnHeader winnerName;
        private System.Windows.Forms.ColumnHeader winnerTime;
        private System.Windows.Forms.ColumnHeader winnerStep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}