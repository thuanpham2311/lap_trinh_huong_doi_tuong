using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Interface
{
    class Program
    {
        public static void nhap(List<KieuSo> ds)
        {
            int n,c;
            Console.WriteLine("Nhap so phan tu:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                do
                {
                    Console.WriteLine("1.Nhap phan so");
                    Console.WriteLine("2.Nhap sp phuc");
                    Console.Write("Nhap lua chon:");
                    c = Convert.ToInt32(Console.ReadLine());
                } while (c != 1 && c != 2);
                if(c==1)
                {
                    PhanSo p = new PhanSo();
                    Console.Write("Nhap tu so:");
                    p.tuSo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap mau so:");
                    p.mauSo = Convert.ToInt32(Console.ReadLine());
                    ds.Add(p);
                }
                else
                {
                    SoPhuc s = new SoPhuc();
                    Console.Write("Nhap phan thuc:");
                    s.phanThuc = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap phan ao:");
                    s.phanAo = Convert.ToInt32(Console.ReadLine());
                    ds.Add(s);
                }
            }
        }
        public static void xuat(List<KieuSo> ds)
        {
            foreach(KieuSo k in ds)
            {
                if(k.laPhanSo())
                {
                    Console.Write("Phan so:");
                    Console.WriteLine( k.xuat());
                }
                else
                {
                    Console.Write("So phuc:");
                    Console.WriteLine(k.xuat());
                }
            }
        }
        static void Main(string[] args)
        {
            //PhanSo ps1 = new PhanSo(1, 2);
            //PhanSo ps2 = new PhanSo(3, 4);
            //KieuSo tong = new PhanSo();
            //tong = ps1.cong(ps2);
            //string ketQua = tong.xuat();
            //Console.WriteLine("Tong 2 phan so la:" + ketQua);
            //SoPhuc sp1 = new SoPhuc(3, 2);
            //SoPhuc sp2 = new SoPhuc(5, 8);
            //KieuSo tong2SoPhuc = new SoPhuc();
            //tong2SoPhuc = sp1.cong(sp2);
            //string ketQuaCongSoPhuc = tong2SoPhuc.xuat();
            //Console.WriteLine("Tong 2 so phuc la:" + ketQuaCongSoPhuc);

            List<KieuSo> ds = new List<KieuSo>();
            Console.WriteLine("NHAP DAY SO:");
            nhap(ds);
            Console.WriteLine("XUAT DAY SO:");
            xuat(ds);
            Console.ReadLine();
        }
    }
}
