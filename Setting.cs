﻿using System;
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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            this.BackColor = Color.DimGray;
            panel1.BorderStyle = BorderStyle.None;
            this.TransparencyKey = Color.DimGray;
        }
    }
}