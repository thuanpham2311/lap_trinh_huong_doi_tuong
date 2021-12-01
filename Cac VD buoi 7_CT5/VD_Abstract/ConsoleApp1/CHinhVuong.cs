using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CHinhVuong:CHinhChuNhat
    {
        public CHinhVuong():base()
        {

        }
        public CHinhVuong(double canh):base(canh,canh)
        {

        }
        public override double ChieuDai { get => base.ChieuDai; set => base.ChieuDai = value; }
        public override double ChieuRong { get => base.ChieuDai; set => base.ChieuDai = value; }
        public override KieuHinh kieuDoiTuong()
        {
            return KieuHinh.HinhVuong;
        }
    }
}
