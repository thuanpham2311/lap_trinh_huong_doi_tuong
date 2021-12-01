using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum KieuHinh { HinhHoc,HinhChuNhat,HinhVuong,HinhTamGia,HinhTamGiacCan}
    abstract class CHinhHoc
    {
        public abstract double chuvi();
        public abstract double dientich();
        public virtual KieuHinh kieuDoiTuong()
        {
            return KieuHinh.HinhHoc;
        }
    }
}
