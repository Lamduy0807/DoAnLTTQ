using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Game_Xếp_Hình
{
    public class MainGame
    {
        #region Properties
        private int flag { get; set; }
        private Panel pnGame;
        private Label lbPoint;
        private int iColumn { get; set; } = 4;
        private int iCell { get; set; } = 4;
        private int iviTriHangOTrong { get; set; }
        private int iviTriCotOTrong { get; set; }
        private int Wpanel = 805, Hpanel = 725;
        private int point { get; set; } = 0;
        PictureBox small;
        private string stringFileName { get; set; }
        public bool isStart = true;
        PictureBox[,] listPB;
        public Image ima;

        #endregion Properties
        #region con
        private MainGame()
        {
            lbPoint.Text = "0";
            flag = 0;
            iColumn = 3;
            iCell = 3;
            point = 0;
        }
        public MainGame(Panel Game, Label lpoint, int column, int cell, Image i, bool start)
        {
            point = 0;
            pnGame = Game;
            lbPoint = lpoint;
            iColumn = column;
            iCell = cell;
            ima = i;
            isStart = start;
        }
        #endregion con


        #region Method
        public string GetImage()
        {
            return stringFileName;
        }
        public void SetPanel(int a, int b)
        {
            Wpanel = a;
            Hpanel = b;
        }
        public void SetStart(bool a)
        {
            isStart = a;
        }
        public void Draw()
        {
            if (flag == 0)
            {
                SetPanel(pnGame.Width, pnGame.Height);
                //CatAnh(ima);
            }
        }
        public void open()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.jpg|*.jpg";
            ofd.Multiselect = false;
            ofd.Title = "Hãy lựa chọn file ảnh";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pnGame.Controls.Clear();
                Image anhNho = Image.FromFile(ofd.FileName).GetThumbnailImage(pnGame.Size.Width, pnGame.Size.Height, null, new IntPtr());
                stringFileName = ofd.FileName;
                CatAnh(anhNho);
                //XaoTron();
            }
        }
        public void start()
        {
            if(!isStart)
            {
                XaoTron();
            }
        }
        // Cắt panel thành từng mảnh Pb
        private void CatAnh(Image image)
        {
            ima = image;
            // tạo list pb bằng mảng 2 chiều có số hàng và cột theo dạng 3x3 4x4 5x5
            listPB = new PictureBox[iColumn, iCell];
            for (int i = 0; i < iColumn; i++)
            {
                for (int j = 0; j < iColumn; j++)
                {
                    if (i == iCell - 1 && j == iColumn - 1)
                        break;

                    int WidthIma = pnGame.Width / iColumn;
                    int HeightIma = (pnGame.Height / iCell);
                    PictureBox pb = new PictureBox();
                    pb.BorderStyle = BorderStyle.Fixed3D;
                    pb.Size = new Size(WidthIma, HeightIma);
                    pb.Location = LayViTri(i, j);
                    pb.Image = CropImage(ima, new Rectangle(j * WidthIma, i * HeightIma, WidthIma, HeightIma));
                    pb.Tag = string.Format("{0}|{1}", i, j);
                    pb.Click += Pb_Click;

                    pnGame.Controls.Add(pb);
                    listPB[i, j] = pb;
                }
            }

            iviTriHangOTrong = iCell - 1;
            iviTriCotOTrong = iColumn - 1;
        }
        // sự kiện click chuột cho picturebox
        private void Pb_Click(object sender, EventArgs e)
        {

            PictureBox pb = (PictureBox)sender;
            //kiểm tra nút bắt đầu đã đc nhấn chưa?
            if (!isStart) return;
            //gán ô đc clich cho ô trống theo vị trí
            if (GanVoiOTrong(pb.Location))
            {
                //lấy vị trí cột và hàng mới cho ô trống (là vị trí pb đc click)
                int iviTriCotOTrongMoi = LayViTriCot(pb.Location);
                int iviTriHangOTrongMoi = LayViTriHang(pb.Location);
                if (pb.Location.X == LayViTri(iviTriHangOTrong, iviTriCotOTrong).X)
                {
                    if (pb.Location.Y < LayViTri(iviTriHangOTrong, iviTriCotOTrong).Y)  // Dịch ô xuống dưới
                    {
                        point++;
                        lbPoint.Text = point.ToString();
                        while (pb.Location.Y != LayViTri(iviTriHangOTrong, iviTriCotOTrong).Y)
                        {
                            pb.Location = new Point(pb.Location.X, pb.Location.Y + 1);
                            Delay(1000);
                        }
                        iviTriHangOTrong--;
                        //listPB[iviTriHangOTrong, iviTriCotOTrong].Location = LayViTri(iviTriHangOTrong + 1, iviTriCotOTrong);
                        listPB[iviTriHangOTrong + 1, iviTriCotOTrong] = listPB[iviTriHangOTrong, iviTriCotOTrong];
                        listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
                    }
                    else // Dịch ô lên trên
                    {
                        point++;
                        lbPoint.Text = point.ToString();
                        while (pb.Location.Y != LayViTri(iviTriHangOTrong, iviTriCotOTrong).Y)
                        {
                            pb.Location = new Point(pb.Location.X, pb.Location.Y - 1);
                            Delay(1000);
                        }
                        iviTriHangOTrong++;
                        //_listPB[_viTriHangOTrong, _viTriCotOTrong].Location = LayViTri(_viTriHangOTrong - 1, _viTriCotOTrong);
                        listPB[iviTriHangOTrong - 1, iviTriCotOTrong] = listPB[iviTriHangOTrong, iviTriCotOTrong];
                        listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
                    }
                }
                else if (pb.Location.Y == LayViTri(iviTriHangOTrong, iviTriCotOTrong).Y)
                {

                    if (pb.Location.X < LayViTri(iviTriHangOTrong, iviTriCotOTrong).X) // Dịch ô sang phải
                    {
                        point++;
                        lbPoint.Text = point.ToString();

                        while (pb.Location.X != LayViTri(iviTriHangOTrong, iviTriCotOTrong).X)
                        {
                            pb.Location = new Point(pb.Location.X + 1, pb.Location.Y);
                            Delay(1000);
                        }
                        iviTriCotOTrong--;
                        //listPB[viTriHangOTrong, viTriCotOTrong].Location = LayViTri(viTriHangOTrong, viTriCotOTrong + 1);
                        listPB[iviTriHangOTrong, iviTriCotOTrong + 1] = listPB[iviTriHangOTrong, iviTriCotOTrong];
                        listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
                    }
                    else // Dịch ô sang trái
                    {
                        point++;
                        lbPoint.Text = point.ToString();
                        while (pb.Location.X != LayViTri(iviTriHangOTrong, iviTriCotOTrong).X)
                        {
                            pb.Location = new Point(pb.Location.X - 1, pb.Location.Y);
                            Delay(1000);
                        }
                        iviTriCotOTrong++;
                        //listPB[viTriHangOTrong, viTriCotOTrong].Location = LayViTri(viTriHangOTrong, viTriCotOTrong - 1);
                        listPB[iviTriHangOTrong, iviTriCotOTrong - 1] = listPB[iviTriHangOTrong, iviTriCotOTrong];
                        listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
                    }
                }

                //pb.Location = LayViTri(_viTriHangOTrong, _viTriCotOTrong);
                //_viTriCotOTrong = viTriCotOTrongMoi;
                //_viTriHangOTrong = viTriHangOTrongMoi;
                if (CheckWin())
                {
                    isStart = false;
                    Win s = new Win();
                    s.Show();
                    int chieuRongAnh = pnGame.Width / iColumn;
                    int chieuCaoAnh = pnGame.Height / iCell;
                    PictureBox pb1 = new PictureBox();
                    pb1.BorderStyle = BorderStyle.Fixed3D;
                    pb1.Size = new Size(chieuRongAnh, chieuCaoAnh);
                    pb1.Location = LayViTri(iColumn - 1, iCell - 1);
                    pb1.Image = CropImage(ima, new Rectangle((iCell - 1) * chieuRongAnh, (iColumn - 1) * chieuCaoAnh, chieuRongAnh, chieuCaoAnh));
                    pb1.Tag = string.Format("{0}|{1}", iColumn - 1, iCell - 1);
                    pnGame.Controls.Add(pb1);
                }
            }
        }

        public void Pause_KeyDown(object sender, KeyEventArgs e) //di chuyen bang phim
        {

            if (!isStart) return;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (iviTriHangOTrong > 0)
                    {
                        point++;
                        lbPoint.Text = point.ToString();
                        DichOTrongLenTren();
                        break;
                    }
                    else
                        break;
                case Keys.Up:
                    if (iviTriHangOTrong < iCell - 1)
                    {
                        point++;
                        lbPoint.Text = point.ToString();
                        DichOTrongXuongDuoi();
                        break;
                    }
                    else
                        break;
                case Keys.Right:
                    if (iviTriCotOTrong > 0)
                    {
                        point++;
                        lbPoint.Text = point.ToString();
                        DichOTrongSangTrai();
                        break;
                    }
                    else
                        break;
                case Keys.Left:
                    if (iviTriCotOTrong < iColumn - 1)
                    {
                        point++;
                        lbPoint.Text = point.ToString();
                        DichOTrongSangPhai();
                        break;
                    }
                    else
                        break;
            }
            if (CheckWin())
            {
                isStart = false;
                Win s = new Win();
                s.Show();
                int chieuRongAnh = pnGame.Width / iColumn;
                int chieuCaoAnh = pnGame.Height / iCell;
                PictureBox pb1 = new PictureBox();
                pb1.BorderStyle = BorderStyle.Fixed3D;
                pb1.Size = new Size(chieuRongAnh, chieuCaoAnh);
                pb1.Location = LayViTri(iColumn - 1, iCell - 1);
                pb1.Image = CropImage(ima, new Rectangle((iCell - 1) * chieuRongAnh, (iColumn - 1) * chieuCaoAnh, chieuRongAnh, chieuCaoAnh));
                pb1.Tag = string.Format("{0}|{1}", iColumn - 1, iCell - 1);
                pnGame.Controls.Add(pb1);
            }


        }
        private void Delay(int miliseconds)
        {
            int x = 0;
            while (x < miliseconds)
            {
                x++;
            }
        }

        public bool CheckWin()
        {
            for (int i = 0; i < iCell; i++)
            {
                for (int j = 0; j < iColumn; j++)
                {
                    if (listPB[i, j] != null)
                    {
                        if (listPB[i, j].Tag.ToString() != string.Format("{0}|{1}", LayViTriHang(listPB[i, j].Location), LayViTriCot(listPB[i, j].Location)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private int LayViTriCot(Point viTri)
        {
            return (int)(viTri.X / (pnGame.Size.Width / iColumn));
        }

        private int LayViTriHang(Point viTri)
        {
            return (int)(viTri.Y / (pnGame.Size.Width / iCell));
        }

        private Point LayViTri(int _viTriHang, int _viTriCot)
        {

            return new Point(_viTriCot * (pnGame.Size.Width / iColumn), _viTriHang * (pnGame.Size.Width / iCell));
        }

        private bool GanVoiOTrong(Point viTri)
        {
            if ((LayViTriCot(viTri) == iviTriCotOTrong + 1 && LayViTriHang(viTri) == iviTriHangOTrong) ||
                (LayViTriCot(viTri) == iviTriCotOTrong - 1 && LayViTriHang(viTri) == iviTriHangOTrong) ||
                (LayViTriHang(viTri) == iviTriHangOTrong + 1 && LayViTriCot(viTri) == iviTriCotOTrong) ||
                (LayViTriHang(viTri) == iviTriHangOTrong - 1 && LayViTriCot(viTri) == iviTriCotOTrong))
                return true;
            else
                return false;
        }

        private Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }
        public void XaoTron()
        {
            Random rd = new Random();
            for (int t = 0; t < 5000; t++)
            {
                if (rd.Next(0, 100) % 2 == 0) //Dịch ngang
                {
                    if (iviTriCotOTrong == 0)
                    {
                        DichOTrongSangPhai();
                    }
                    else if (iviTriCotOTrong == iColumn - 1)
                    {
                        DichOTrongSangTrai();
                    }
                    else
                    {
                        if (rd.Next(0, 100) % 2 == 0) //Dịch sang trái
                        {
                            DichOTrongSangTrai();
                        }
                        else //Dịch sang phải
                        {
                            DichOTrongSangPhai();
                        }
                    }
                }
                else //Dịch dọc
                {
                    if (iviTriHangOTrong == 0)
                    {
                        DichOTrongXuongDuoi();
                    }
                    else if (iviTriHangOTrong == iCell - 1)
                    {
                        DichOTrongLenTren();
                    }
                    else
                    {
                        if (rd.Next(0, 100) % 2 == 0) //Dịch lên trên
                        {
                            DichOTrongLenTren();
                        }
                        else //Dịch xuống dưới
                        {
                            DichOTrongXuongDuoi();
                        }
                    }
                }
            }
        }

        private void DichOTrongSangTrai()
        {
            iviTriCotOTrong--;
            listPB[iviTriHangOTrong, iviTriCotOTrong].Location = LayViTri(iviTriHangOTrong, iviTriCotOTrong + 1);
            listPB[iviTriHangOTrong, iviTriCotOTrong + 1] = listPB[iviTriHangOTrong, iviTriCotOTrong];
            listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
        }

        private void DichOTrongSangPhai()
        {
            iviTriCotOTrong++;
            listPB[iviTriHangOTrong, iviTriCotOTrong].Location = LayViTri(iviTriHangOTrong, iviTriCotOTrong - 1);
            listPB[iviTriHangOTrong, iviTriCotOTrong - 1] = listPB[iviTriHangOTrong, iviTriCotOTrong];
            listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
        }

        private void DichOTrongLenTren()
        {
            iviTriHangOTrong--;
            listPB[iviTriHangOTrong, iviTriCotOTrong].Location = LayViTri(iviTriHangOTrong + 1, iviTriCotOTrong);
            listPB[iviTriHangOTrong + 1, iviTriCotOTrong] = listPB[iviTriHangOTrong, iviTriCotOTrong];
            listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
        }

        private void DichOTrongXuongDuoi()
        {
            iviTriHangOTrong++;
            listPB[iviTriHangOTrong, iviTriCotOTrong].Location = LayViTri(iviTriHangOTrong - 1, iviTriCotOTrong);
            listPB[iviTriHangOTrong - 1, iviTriCotOTrong] = listPB[iviTriHangOTrong, iviTriCotOTrong];
            listPB[iviTriHangOTrong, iviTriCotOTrong] = null;
        }
        private void Start()
        {
            if (pnGame.Controls.Count != 0 && !isStart)
            {
                XaoTron();
            }
        }


    }
    #endregion Method
}
