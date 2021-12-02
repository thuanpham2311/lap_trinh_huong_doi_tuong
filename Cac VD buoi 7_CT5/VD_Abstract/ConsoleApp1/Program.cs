using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
  class Program {
    public static CHinhHoc timHinhDienTichNhoNhat(List<CHinhHoc> ds) {
      /*HinhHoc minDT = new CHinhHoc();*/
      CHinhHoc minDT = ds[0];
      foreach (CHinhHoc a in ds) {
        if (a.dientich() < minDT.dientich())
          minDT = a;
      }
      return minDT;
    }
    public static CHinhChuNhat timHinhChuNhatChuViLonNhat(List<CHinhHoc> ds) {
      // CHinhChuNhat hcn = null;
      // foreach(CHinhHoc m in ds)
      //{
      //     if(m.kieuDoiTuong()==KieuHinh.HinhChuNhat )
      //     {
      //          hcn =(CHinhChuNhat) m;
      //     }
      // }
      // foreach(CHinhHoc n in ds)
      //{
      //     if(n.kieuDoiTuong() == KieuHinh.HinhChuNhat && n.chuvi()> hcn.chuvi())
      //     {
      //         hcn = (CHinhChuNhat) n;
      //     }
      // }
      // return hcn;

      CHinhChuNhat max = null;
      foreach (CHinhHoc h in ds) {
        if (h.kieuDoiTuong() == KieuHinh.HinhChuNhat)
          if (max == null)
            max = (CHinhChuNhat)h;
          else if (max.chuvi() < h.chuvi())
            max = (CHinhChuNhat)h;
      }
      return max;
    }
    static void Main(string[] args) {
      List<CHinhHoc> ds = new List<CHinhHoc>();
      ds.Add(new CHinhChuNhat(3, 4));
      ds.Add(new CHinhVuong(5));
      ds.Add(new CHinhChuNhat(2, 6));
      ds.Add(new CHinhVuong(7));
      foreach (CHinhHoc a in ds) {
        if (a.kieuDoiTuong() == KieuHinh.HinhChuNhat)
          Console.WriteLine("Day la hinh chu nhat co dien tich = " + a.dientich() +
                            " va chu vi = " + a.chuvi());
        else if (a.kieuDoiTuong() == KieuHinh.HinhVuong)
          Console.WriteLine("Day la hinh vuong co dien tich = " + a.dientich() +
                            " va chu vi = " + a.chuvi());
      }
      CHinhHoc mindt = timHinhDienTichNhoNhat(ds);
      Console.WriteLine("dien tich nho nhat là:" + mindt.dientich());
      CHinhChuNhat maxChuVi = timHinhChuNhatChuViLonNhat(ds);
      Console.WriteLine("hinh chu nhat co chu vi lon nhat la:" + maxChuVi.chuvi());

      Console.ReadLine();
    }
  }
}
