﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmThongBaoGV : Form
    {
        public frmThongBaoGV()
        {
            InitializeComponent();
        }

        private void lblThongBao_Load(object sender, EventArgs e)
        {
            
        }
        public void SetText(string s)
        {
            this.lblTHongBao.Text = s;
        }
    }
}
