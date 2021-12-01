using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
      static int demSoThiSinhKhoiNangkhieu(List<CThiSinh> ds)
        {
            int dem = 0;
            //for( int i=0; i<ds.Count;i++)
            //{
            //    if (ds[i].laKhoiNangKhieu() == true)
            //        dem++;
            //}

            foreach (CThiSinh ts in ds)
            {
                if (ts.laKhoiNangKhieu() == true)
                    dem++;
            }

            //foreach (CThiSinh ts in ds)
            //{
            //    if (ts is CKhoiNangKhieu)
            //        dem++;
            //}

            return dem;
        }
        static List<CThiSinh> getDSThiSinhKhoiA(List<CThiSinh> ds)
        {
            List<CThiSinh> ts = new List<CThiSinh>();
            foreach (CThiSinh i in ds)
            {
                if (i is CKhoiA)
                    ts.Add(i);
            }
            return ts;
        }
        static double getDiemLonNhatKhoiA(List<CThiSinh> ds)
        {
            double m = 0;
            foreach (CThiSinh i in ds)
            {
                if (i is CKhoiA)
                {
                    if (i.TongDiem() > m)
                        m = i.TongDiem();
                }
            }
            return m;
        } 
        static List<CThiSinh> getDSThiSinhDat(List<CThiSinh> ds)
        {
            List<CThiSinh> tmp = new List<CThiSinh>();
            foreach (CThiSinh i in ds)
            {
                if (i.KetQua() == KieuKetQua.Dat)
                {                    
                    tmp.Add(i);                    
                }                
            }
            return tmp;
        }

        static void Main(string[] args)
        {
            List<CThiSinh> dsts = new List<CThiSinh>();
            List<CThiSinh> n = new List<CThiSinh>();
            dsts.Add(new CKhoiA("001", "abc1", 5, 6, 7));
            dsts.Add(new CKhoiA("002", "abc2", 1, 2, 7));
            dsts.Add(new CKhoiA("003", "abc3", 6, 2, 8));
            dsts.Add(new CKhoiNangKhieu("004", "abc4", 6, 8));
            dsts.Add(new CKhoiNangKhieu("005", "abc5", 9, 8));

            Console.WriteLine("\nSo thi sinh thuoc khoi nang khieu la " + demSoThiSinhKhoiNangkhieu(dsts));

            Console.WriteLine("\nDanh sach thi sinh Khoi A:\n");
            foreach(CThiSinh ts in getDSThiSinhKhoiA(dsts))
            {
                Console.WriteLine(ts.MaTS + " - " + ts.Hoten);
            }
            Console.WriteLine("Diem lon nhat la" + getDiemLonNhatKhoiA(dsts));
            Console.ReadLine();
        }
    }
}
