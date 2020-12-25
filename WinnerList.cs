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
    public partial class WinnerList : Form
    {
        public WinnerList()
        {
            InitializeComponent();
            LoadListView();
        }

        private void LoadListView()
        {
            foreach (cWinner winner in Record.ReadRecordList())
            {
                ListViewItem lvItem = new ListViewItem(winner.WinnerName);
                lvItem.SubItems.Add(winner.WinnerTime);
                lvItem.SubItems.Add(winner.WinnerStep);
                lvWinnerList.Items.Add(lvItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
