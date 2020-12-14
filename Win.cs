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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Gray;
        }

        private void Win_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Close(); 
            }
        }
    }
}
