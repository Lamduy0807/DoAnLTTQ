
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
            this.lvWinnerList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.winnerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winnerTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winnerStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvWinnerList
            // 
            this.lvWinnerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.winnerName,
            this.winnerTime,
            this.winnerStep});
            this.lvWinnerList.FullRowSelect = true;
            this.lvWinnerList.GridLines = true;
            this.lvWinnerList.HideSelection = false;
            this.lvWinnerList.Location = new System.Drawing.Point(23, 50);
            this.lvWinnerList.Name = "lvWinnerList";
            this.lvWinnerList.Size = new System.Drawing.Size(405, 342);
            this.lvWinnerList.TabIndex = 0;
            this.lvWinnerList.UseCompatibleStateImageBehavior = false;
            this.lvWinnerList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Người Chiến Thắng";
            // 
            // winnerName
            // 
            this.winnerName.Text = "Tên";
            this.winnerName.Width = 200;
            // 
            // winnerTime
            // 
            this.winnerTime.Text = "Thời gian";
            // 
            // winnerStep
            // 
            this.winnerStep.Text = "Số bước";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WinnerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 436);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvWinnerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinnerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinnerList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvWinnerList;
        private System.Windows.Forms.ColumnHeader winnerName;
        private System.Windows.Forms.ColumnHeader winnerTime;
        private System.Windows.Forms.ColumnHeader winnerStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}