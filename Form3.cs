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
    public partial class Form3 : Form
    {
        private int x, y;
        private int[] arr = new int[9];
        private bool TT_game = true;
        private int time;
        private int diem;
        private string level;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void initarr()
        {
            for (int i = 1; i < 10; i++)
            {
                arr[i - 1] = i;
            }
        }
        private void init()
        {
            x = 2;
            y = 2;
            level = "dễ";
            diem = 0;
            time = 0;
            initarr();
            pbmain.Image = Game_Xếp_Hình.Properties.Resources.main;
            timer1.Start();
        }
        private int getvt(int x, int y)
        {
            return x + 3 * y;
        }
        private void getanh(PictureBox pb, int a)
        {
            switch (a)
            {
                case 1: pb.Image = Game_Xếp_Hình.Properties.Resources.image1; break;
                case 2: pb.Image = Game_Xếp_Hình.Properties.Resources.image2; break;
                case 3: pb.Image = Game_Xếp_Hình.Properties.Resources.image3; break;
                case 4: pb.Image = Game_Xếp_Hình.Properties.Resources.image4; break;
                case 5: pb.Image = Game_Xếp_Hình.Properties.Resources.image5; break;
                case 6: pb.Image = Game_Xếp_Hình.Properties.Resources.image6; break;
                case 7: pb.Image = Game_Xếp_Hình.Properties.Resources.image7; break;
                case 8: pb.Image = Game_Xếp_Hình.Properties.Resources.image8; break;
                case 9: pb.Image = null; pb.BackColor = Color.White; break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        //    lb_Score.Text = diem.ToString();
        //    switch (level)
        //    {
        //        case 1: lb_MucChoi.Text = "Dễ"; break;
        //        case 2: lb_MucChoi.Text = "Trung Bình"; break;
        //        case 3: lb_MucChoi.Text = "Khó"; break;
        //    }

            init();
            // showpb();
            setmap();
            diem = 100;
            lbcapdo.Text = level;
            
        }

        private void showpb()
        {
            getanh(pb1, arr[0]);
            getanh(pb2, arr[1]);
            getanh(pb3, arr[2]);
            getanh(pb4, arr[3]);
            getanh(pb5, arr[4]);
            getanh(pb6, arr[5]);
            getanh(pb7, arr[6]);
            getanh(pb8, arr[7]);
            getanh(pb9, arr[8]);
        }
        private void go_left()
        {
            if (x > 0)
            {
                int temp = arr[getvt(x, y)];
                arr[getvt(x, y)] = arr[getvt(x - 1, y)];
                arr[getvt(x - 1, y)] = temp;
                x--;
                diem--;
                showpb();
            }
        }
        private void go_right()
        {
            if (x < 2)
            {
                int temp = arr[getvt(x, y)];
                arr[getvt(x, y)] = arr[getvt(x + 1, y)];
                arr[getvt(x + 1, y)] = temp;
                x++;
                diem--;
                showpb();
            }
        }
        private void go_top()
        {
            if (y > 0)
            {
                int temp = arr[getvt(x, y)];
                arr[getvt(x, y)] = arr[getvt(x, y - 1)];
                arr[getvt(x, y - 1)] = temp;
                y--;
                diem--;
                showpb();
            }
        }

        private void go_bottom()
        {
            if (y < 2)
            {
                int temp = arr[getvt(x, y)];
                arr[getvt(x, y)] = arr[getvt(x, y + 1)];
                arr[getvt(x, y + 1)] = temp;
                y++;
                diem--;
                showpb();
            }
        }
        Random rd = new Random();

        private void setmap()
        {
            for (int i = 0; i < 200; i++)
            {
                int rdn = rd.Next(1, 5); // trả về giá trị từ 1-4
                switch (rdn)
                {
                    case 1: go_top(); break;
                    case 2: go_right(); break;
                    case 3: go_left(); break;
                    case 4: go_bottom(); break;

                }
            }
            int temp = arr[getvt(x, y)];
            arr[getvt(x, y)] = arr[8];
            arr[8] = temp;
            x = 2;
            y = 2;
            showpb();
        }
        

        private void bPause_KeyUp(object sender, KeyEventArgs e)
        {
            if (TT_game == true)
            {
                if (e.KeyCode == Keys.Left)
                {
                    //Di chuyển sang phải
                    go_right();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    //sang trái
                    go_left();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    //xuống dưới
                    go_bottom();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    //lên trên
                    go_top();
                }
                if (CheckWin() == true)
                {
                    MessageBox.Show("You Win", "", MessageBoxButtons.OK);
                    timer1.Stop();
                    init();
                    setmap();
                    diem = 100;
                    //ở đât có thể cho level ++
                    // tăng độ khó

                }
                lbdiem.Text = diem.ToString();
            }
        }

        

        

        private void bPause_Click(object sender, EventArgs e)
        {
            if (TT_game == true)
            {
                TT_game = false;
                bPause.Text = "Chơi Tiếp";
                timer1.Stop();
            }
            else
            {
                TT_game = true;
                bPause.Text = "Tạm Dừng";
                timer1.Start();
            }
        }

        private void lbNew_Click_1(object sender, EventArgs e)
        {
            init();
            setmap();
            diem = 100;
            lbdiem.Text = diem.ToString();
        }

        private void lbExit_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát game không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
                diem = 100;
                lbdiem.Text = diem.ToString();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbtime.Text = time.ToString();
            time++;
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
