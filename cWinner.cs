using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Xếp_Hình
{
    class cWinner
    {
        public string WinnerName { get; set; }
        public string WinnerTime { get; set; }
        public string WinnerStep { get; set; }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.WinnerName, this.WinnerTime, this.WinnerStep);
        }
    }
}
