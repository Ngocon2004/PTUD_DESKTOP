using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212363
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bntCanCel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void Reset()
        {
            this.cbMaHV.Text = "";
            this.txtHoVaTen.Text = "";
            this.dtpNgayDangKy.Value=DateTime.Now;
            this.rdNam.Checked=true;
            this.chkTinHocA.Checked=false;
            this.chkTinHocB.Checked=false;
            this.chkTiengAnhA.Checked=false;
            this.chkTiengAnhB.Checked=false;
            this.txtTongTien.Text = "";
        }
        private void bntTinhTien_Click(object sender, EventArgs e)
        {

            int s = 0;
            if (chkTinHocA.Checked)
                s += int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                s += int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                s += int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                s += int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đồng";

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
