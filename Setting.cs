using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Xếp_Hình
{
    public partial class Setting : Form
    {
        public bool flag;
        public Setting(bool f)
        {
            InitializeComponent();
            this.BackColor = Color.DimGray;
            panel1.BorderStyle = BorderStyle.None;
            this.TransparencyKey = Color.DimGray;
            if (f == true)
            {
                flag = f;
                panel2.BackgroundImage = Properties.Resources.on;
            }
            else
            {
                panel2.BackgroundImage = Properties.Resources.off;
                flag = f;
            }
        }
        public void playsoundclick()
        {
            if (flag == true)
            {
                SoundPlayer sp = new SoundPlayer("click.wav");
                sp.Play();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            n.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                panel2.BackgroundImage = Properties.Resources.off;
            }
            else
            {
                flag = true;
                panel2.BackgroundImage = Properties.Resources.on;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            playsoundclick();
            Form bg = new Form();
            try
            {
                using (WinnerList q = new WinnerList())
                {
                    bg.StartPosition = FormStartPosition.Manual;
                    bg.FormBorderStyle = FormBorderStyle.None;
                    bg.Opacity = .50d;
                    bg.BackColor = Color.Black;
                    bg.WindowState = FormWindowState.Maximized;
                    bg.TopMost = true;
                    bg.Location = this.Location;
                    bg.ShowInTaskbar = false;
                    bg.Show();
                    q.Owner = bg;
                    q.ShowDialog();
                    bg.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bg.Dispose();
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            playsoundclick();
            Form bg = new Form();
            try
            {
                using (Instruc q = new Instruc())
                {
                    bg.StartPosition = FormStartPosition.Manual;
                    bg.FormBorderStyle = FormBorderStyle.None;
                    bg.Opacity = .50d;
                    bg.BackColor = Color.Black;
                    bg.WindowState = FormWindowState.Maximized;
                    bg.TopMost = true;
                    bg.Location = this.Location;
                    bg.ShowInTaskbar = false;
                    bg.Show();
                    q.Owner = bg;
                    q.ShowDialog();
                    bg.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bg.Dispose();
            }
        }
    }
}
