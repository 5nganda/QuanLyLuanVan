﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLV01
{
    public partial class FKiemTraTienDo : Form
    {
        public FKiemTraTienDo()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ItCapNhatLuanVan x = new ItCapNhatLuanVan();
            x.ShowDialog();
        }
    }
}