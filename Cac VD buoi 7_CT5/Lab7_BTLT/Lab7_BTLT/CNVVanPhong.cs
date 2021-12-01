using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTLT
{
    class CNVVanPhong:CNhanVien
    {
        protected float heSoLuong;
        protected double luongCoBan;

        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public CNVVanPhong():base()
        {
            this.heSoLuong = 0;
            this.luongCoBan = 0;
        }
        public CNVVanPhong(string hoten, string diachi, DateTime ngaysinh,float heSoLuong, double luongCoBan):base(hoten,diachi,ngaysinh)
        {
            this.heSoLuong = heSoLuong;
            this.luongCoBan = luongCoBan;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap he so luong:" + heSoLuong);
            Console.WriteLine("Nhap luong co ban:" + luongCoBan);
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("He so luong la:"+heSoLuong);
            Console.WriteLine("Luong co ban la:" + luongCoBan);
        }
        public override double tinhLuong()
        {
            return heSoLuong*luongCoBan;
        }
    }
}
