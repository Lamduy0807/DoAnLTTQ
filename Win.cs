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
    public partial class Win : Form
    {
        private string t, s;
        private bool flagsound= true;
        public Win(string time, string step, bool flag)
        {
            t = time;
            s = step;
            flagsound = flag;
            InitializeComponent();
            this.TransparencyKey = Color.Gray;
            playsoundwin();
        }
        private void playsoundwin()
        {
            if (flagsound)
            {
                SoundPlayer sp = new SoundPlayer("win.wav");
                sp.Play();
            }
        }
        private void Win_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Close();
                Form bg = new Form();
                try
                {
                    using (winner q = new winner(t, s))
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
}
