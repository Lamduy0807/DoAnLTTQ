using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Xếp_Hình
{
    public partial class winner : Form
    {
        public winner(string time, string step)
        {
            InitializeComponent();
            this.BackColor = Color.DimGray;
            this.TransparencyKey = Color.DimGray;
            lbTime.Text = time;
            lbStep.Text = step;
        }

        private void lbOK_Click(object sender, EventArgs e)
        {
            cWinner winner = new Game_Xếp_Hình.cWinner();
            winner.WinnerName = tbName.Text;
            winner.WinnerTime = lbTime.Text;
            winner.WinnerStep = lbStep.Text;
            Record.WriteRecord(winner.ToString());
            this.Close();
        }
    }
}
