using System;
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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "https://cntt.dlu.edu.vn/category/dao-tao/do-an/";
            this.linklblLienHe.Links.Add(0,lienhe.Length,lienhe);
            this.cboMaso.SelectedItem = this.cboMaso.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                //this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItem[i]);
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            int i=this.lbMonHocDay.SelectedItems.Count - 1;
            while(i >= 0)
            {
                //this.lb
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //reset()
        }
        public void Reset()
        {
            this.cboMaso.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0;i<chkNgoaiNgu.Items.Count -1; i++)
                
        }
    }
}
