using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Xếp_Hình
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panel2.Width >= 850)
            {
                panel2.Width += rand.Next(5,10);
            }
            else
                panel2.Width = panel2.Width + 5;
            if (panel2.Width >= panel1.Width)
            {
                timer1.Stop();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }
    }
}
