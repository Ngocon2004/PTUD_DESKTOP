using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class MonHoc
    {
        public int iD { get; set; }
        public int soTC { get; set; }
        public string tenMH { get; set; }
        public MonHoc() { }
        public MonHoc(int iD, int soTC, string ten)
        {
            this.iD = iD;
            this.soTC = soTC;
            this.tenMH = ten;
        }
        public MonHoc(string ten)
        {
            this.tenMH = ten;
        }
        public override string ToString()
        {
            return tenMH; 
        }
    }
}
