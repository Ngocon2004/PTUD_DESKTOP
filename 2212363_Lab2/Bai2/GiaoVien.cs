using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class GiaoVien
    {
        public string MaSo {  get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10]; 
        }
        public GiaoVien(string maSo, string hoTen, DateTime ngaySinh, DanhMucMonHoc ds,
            string gt, string[] nn, string soDT, string mail)
        {
            this.MaSo = maSo;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.dsMonHoc = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.SoDT = soDT;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Ma So :" + MaSo +
                "\n" + "Ho Ten:" + HoTen +
                 "\n" + "Ngay Sinh:" + NgaySinh.ToString() +
                 "\n" + "Gioi Tinh:" + GioiTinh +
                 "\n" + "So Dien Thoai:" + SoDT +
                 "\n" + "Mail:" + Mail;
            string snNgoaiNgu = "Ngoai Ngu:";
            foreach (string t in NgoaiNgu)
            
                snNgoaiNgu += t + ";";
            
            string MonDay = "Danh sach mon day:";
            foreach (MonHoc mh in dsMonHoc.ds)
            
                MonDay += mh + ";";
            s += "\n" + snNgoaiNgu + "\n" + MonDay;

            return s;
        }
    }
}
