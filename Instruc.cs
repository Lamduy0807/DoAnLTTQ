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
    public partial class Instruc : Form
    {
        public Instruc()
        {
            InitializeComponent();
            this.BackColor = Color.DimGray;
            this.TransparencyKey = Color.DimGray;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
