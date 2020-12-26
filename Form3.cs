using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Xếp_Hình.Properties;
namespace Game_Xếp_Hình
{
    public partial class Form3 : Form
    {
        private bool flagmusic = true;
        private bool IsXT = false;
        private int column = 3, cell = 3;
        private bool TT_game = false;
        private bool Ispause = false;
        private bool CheckHaveImage = false;
        private int time;
        private int diem;
        private string FileName;
        public MainGame G;
        private string cTime, cStep;
        public Form3()
        {
            InitializeComponent();
            G = new MainGame(panel1, lbdiem, column, cell, Game_Xếp_Hình.Properties.Resources.main, TT_game);
            G.SetPanel(panel1.Width, panel1.Height);
        }

        private void LbStart_Click(object sender, EventArgs e)
        {
            if (!Ispause)
            {
                G.start();
                timer1.Start();
                TT_game = true;
                G.SetStart(TT_game);
                IsXT = true;
            }
        }

        void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }

        public void playsoundclick()
        {
            if (flagmusic == true)
            {
                SoundPlayer sp = new SoundPlayer("click.wav");
                sp.Play();
            }
        }
        public void playsoundswap()
        {
            if (flagmusic == true)
            {
                SoundPlayer sp = new SoundPlayer("swap.wav");
                sp.Play();
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbtime.Text = (time / 60).ToString() + ":" + (time % 60).ToString() + "s";
            time++;
            cTime = lbtime.Text;
            cStep = lbdiem.Text;
            if (G.CheckWin()&& IsXT)
            {
                timer1.Stop();
                TT_game = false;
                G.SetStart(false);
                Ispause = false;
                IsXT = false;
                panel3.BackgroundImage = Properties.Resources._continue;
                Win s = new Win(cTime,cStep);
                s.Show();
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            if (TT_game)
            {
                diem = 0;
                G.ResetPoint();
                lbtime.Text = "0 s";
                time = 0;
                lbdiem.Text = diem.ToString();
                panel3.BackgroundImage = Properties.Resources.pau;
                G.XaoTron();
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            if (TT_game == true)
            {
                Ispause = true;
                TT_game = false;
                G.SetStart(TT_game);
                panel3.BackgroundImage = Properties.Resources._continue;
                timer1.Stop();
            }
            else if (TT_game == false && CheckHaveImage == true && IsXT)
            {
                Ispause = false;
                TT_game = true;
                G.SetStart(TT_game);
                panel3.BackgroundImage = Properties.Resources.pau;
                timer1.Start();
            }
            else
                return;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

       

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            lbExit.Visible = true;
            panel9.MouseLeave += Panel9_MouseLeave;
        }

        private void Panel9_MouseLeave(object sender, EventArgs e)
        {
            lbExit.Visible = false;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            lbSet.Visible = true;
            panel5.MouseLeave += Panel5_MouseLeave;
        }

        private void Panel5_MouseLeave(object sender, EventArgs e)
        {
            lbSet.Visible = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            lbRe.Visible = true;
            panel2.MouseLeave += Panel2_MouseLeave;
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            lbRe.Visible = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            lbConPau.Visible = true;

            panel3.MouseLeave += Panel3_MouseLeave;
        }

        private void Panel3_MouseLeave(object sender, EventArgs e)
        {
            lbConPau.Visible = false;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            lbIn.Visible = true;
            panel7.MouseLeave += Panel7_MouseLeave;
        }

        private void Panel7_MouseLeave(object sender, EventArgs e)
        {
            lbIn.Visible = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            lbHome.Visible = true;
            panel4.MouseLeave += Panel4_MouseLeave;
        }

        private void Panel4_MouseLeave(object sender, EventArgs e)
        {
            lbHome.Visible = false;
        }

        private void pn_Next_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            if (!TT_game)
            {
                if (lb_level.Text == "3x3")
                {
                    lb_level.Text = "4x4";
                    column = 4;
                    cell = 4;
                }
                else if (lb_level.Text == "4x4")
                {
                    lb_level.Text = "5x5";
                    column = 5;
                    cell = 5;
                }
                else if (lb_level.Text == "5x5")
                {
                    lb_level.Text = "3x3";
                    column = 3;
                    cell = 3;
                }
            }
        }

        private void LbChooseImage_Click(object sender, EventArgs e)
        {
            playsoundclick();

            if (!TT_game )
            {
                Ispause = false;
                IsXT = false;
                panel3.BackgroundImage = Properties.Resources.pau;
                time = 0;
                lbtime.Text = "0 s";
                diem = 0;
                G.ResetPoint();
                lbdiem.Text = diem.ToString();
                G.open(column, cell);
                if (!string.IsNullOrEmpty(G.GetImage()))
                {
                    FileName = G.GetImage();
                    pbmain.Image = Image.FromFile(FileName);
                    CheckHaveImage = true;
                    lbStart.Click += LbStart_Click;
                    panel1.Visible = true;
                }
            }
        }

        private void Form3_KeyUp_1(object sender, KeyEventArgs e)
        {
            G.Pause_KeyDown(sender, e);
        }

        private void pn_Return_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            if (!TT_game)
            {
                if (lb_level.Text == "3x3")
                {
                    lb_level.Text = "5x5";
                    column = 5;
                    cell = 5;
                }
                else if (lb_level.Text == "4x4")
                {
                    lb_level.Text = "3x3";
                    column = 3;
                    cell = 3;
                }
                else if (lb_level.Text == "5x5")
                {
                    lb_level.Text = "4x4";
                    column = 4;
                    cell = 4;
                }
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            playsoundclick();
            if (!TT_game)
            { 
                TT_game = false;
                if (CheckHaveImage)
                    panel3.BackgroundImage = Properties.Resources._continue;
                timer1.Stop();
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

        private void panel5_Click(object sender, EventArgs e)
        {
            playsoundclick();
            if (!TT_game)
            {
                Form bg = new Form();
                try
                {
                    using (Setting q = new Setting(flagmusic))
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
                        //q.ShowDialog();
                        if (q.ShowDialog() == DialogResult.OK)
                        {
                            flagmusic = q.flag;
                        }
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

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            TT_game = false;
            panel3.BackgroundImage = Properties.Resources._continue;
            timer1.Stop();
            Form bg = new Form();
            try
            {
                using (Quit q = new Quit())
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
