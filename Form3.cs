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
using Game_Xếp_Hình.Properties;
namespace Game_Xếp_Hình
{
    public partial class Form3 : Form
    {
        private int x, y;
        private int[] arr = new int[9];
        private int column = 2, cell = 2;
        private bool TT_game = false;
        private int time;
        private int diem;
        private string level;
        private string FileName;
        public MainGame G;
        public Form3()
        {
            InitializeComponent();
            G = new MainGame(panel1, lbdiem, column, cell, Game_Xếp_Hình.Properties.Resources.main, TT_game);
            G.SetPanel(panel1.Width, panel1.Height);
            lbOpen.Click += LbOpen_Click;
        }

        private void LbOpen_Click(object sender, EventArgs e)
        {
            if (!TT_game)
            {
                G.open();
                FileName = G.GetImage();
                pbmain.Image = Image.FromFile(FileName);
                lbStart.Click += LbStart_Click;
                panel1.Visible = true;
            }
        }

        private void LbStart_Click(object sender, EventArgs e)
        {
            G.start();
            timer1.Start();
            TT_game = true;
            G.SetStart(TT_game);
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
            SoundPlayer sp = new SoundPlayer("click.wav");
            sp.Play();
        }
        public void playsoundswap()
        {
            SoundPlayer sp = new SoundPlayer("swap.wav");
            sp.Play();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            // showpb();
            //setmap();
            //diem = 250;
            //lbcapdo.Text = level;

        }

        
        
        Random rd = new Random();

        
        private void bPause_KeyUp(object sender, KeyEventArgs e)
        {
            //if (TT_game == true)
            //{
            //    if (e.KeyCode == Keys.Left)
            //    {
            //        playsoundswap();
            //        //Di chuyển sang phải
            //        go_right();
            //    }
            //    else if (e.KeyCode == Keys.Right)
            //    {
            //        playsoundswap();
            //        //sang trái
            //        go_left();
            //    }
            //    else if (e.KeyCode == Keys.Up)
            //    {
            //        playsoundswap();
            //        //xuống dưới
            //        go_bottom();
            //    }
            //    else if (e.KeyCode == Keys.Down)
            //    {
            //        playsoundswap();
            //        //lên trên
            //        go_top();
            //    }
            //    if (CheckWin() == true)
            //    {
            //        MessageBox.Show("You Win", "", MessageBoxButtons.OK);
            //        timer1.Stop();
            //        init();
            //        setmap();
            //        diem = 250;
            //        //ở đât có thể cho level ++
            //        // tăng độ khó

            //    }
            //    lbdiem.Text = diem.ToString();
            //}
        }

        private void lbNew_Click_1(object sender, EventArgs e)
        {
            //init();
            //setmap();
            diem = 250;
            lbdiem.Text = diem.ToString();
        }

        private void lbExit_Click_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbtime.Text = time.ToString();
            time++;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            //init();
            //setmap();
            diem = 250;
            lbdiem.Text = diem.ToString();
            panel3.BackgroundImage = Properties.Resources.pau;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            if (TT_game == true)
            {
                TT_game = false;
                G.SetStart(TT_game);
                panel3.BackgroundImage = Properties.Resources._continue;
                timer1.Stop();
            }
            else
            {
                TT_game = true;
                G.SetStart(TT_game);
                panel3.BackgroundImage = Properties.Resources.pau;
                timer1.Start();
            }
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            playsoundclick();
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void bPause_Click(object sender, EventArgs e)
        {

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

        private bool CheckWin()
        {
            for (int i = 1; i < 10; i++)
            {
                if (arr[i - 1] != i)
                    return false;
            }
            return true;
        }

    }
}
