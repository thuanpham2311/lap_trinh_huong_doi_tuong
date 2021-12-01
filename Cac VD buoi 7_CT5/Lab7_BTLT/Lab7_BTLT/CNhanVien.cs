using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BTLT
{
     public class CNhanVien
    {
        protected string _hoten;
        protected string _diachi;
        protected DateTime _ngaysinh;

        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public DateTime Ngaysinh { get => _ngaysinh; set => _ngaysinh = value; }

        public CNhanVien()
        {
            this._hoten = "";
            this._diachi="";
            this._ngaysinh = DateTime.Now;
        }

         public CNhanVien(string hoten, string diachi, DateTime ngaysinh)
        {
            _hoten = hoten;
            _ngaysinh = ngaysinh;
            _diachi = diachi;
        }

        public virtual void nhap()
        {
            Console.WriteLine("Nhap ho ten : ");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi : ");
            Diachi = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh : ");
            Ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ho ten:" + Hoten);
            Console.WriteLine("Dia chi:" + Diachi);
            Console.WriteLine("Ngay sinh:" + Ngaysinh);
        }
        public virtual double tinhLuong()
        {
            return 0;
        }
    } 
}
