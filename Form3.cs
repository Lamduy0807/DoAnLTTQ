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
        private bool TT_game;
        private int time;
        private int diem;
        private int level;
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
            x = 0;
            y = 0;
            level = 1;
            diem = 0;
            time = 0;
            initarr();
        }
        private int getvt(int x, int y)
        {
            return x + 3 * y;
        }
        private void getanh(PictureBox pb, int a)
        {
            switch (a)
            {
                case 1: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_1; break;
                case 2: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_2; break;
                case 3: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_3; break;
                case 4: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_4; break;
                case 5: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_5; break;
                case 6: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_6; break;
                case 7: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_7; break;
                case 8: pb.Image = Game_Xếp_Hình.Properties.Resources.xep_hinh_8; break;
                case 9: pb.Image = null; pb.BackColor = Color.White; break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            init();
            showpb();
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
        }

    }
}
