using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
  public enum KieuSoNghiem { VoNghiem = 0, MotNghiem = 1, HaiNghiem = 2, VoSoNghiem = 3 }
  class Program {
    // public static KieuSoNghiem giaiPTBac1(double a, double b, ref double x)
    //{
    //    if (a == 0)
    //        if (b == 0)
    //            return KieuSoNghiem.VoSoNghiem;
    //        else
    //            return KieuSoNghiem.VoNghiem;
    //    else
    //    {
    //        x = -b / a;
    //        return KieuSoNghiem.MotNghiem;
    //    }
    //}

    public static KieuSoNghiem giaiPTBac2(double a, double b, double c, ref double x1,
                                          ref double x2) {
      if (a == 0)
        if (b == 0)
          if (c == 0)
            return KieuSoNghiem.VoSoNghiem;
          else
            return KieuSoNghiem.VoNghiem;
        else {
          x1 = x2 = -c / b;
          return KieuSoNghiem.MotNghiem;
        }
      else {
        double delta;
        delta = (b * b) - (4 * a * c);
        if (delta < 0)
          return KieuSoNghiem.VoNghiem;
        else if (delta == 0) {
          x1 = -b / (2 * a);
          x2 = -b / (2 * a);
          return KieuSoNghiem.MotNghiem;
        } else {
          x1 = (-b - Math.Sqrt(delta)) / (2 * a);
          x2 = (-b + Math.Sqrt(delta)) / (2 * a);
          return KieuSoNghiem.HaiNghiem;
        }
      }
    }

    static void Main(string[] args) {
      // double a, b, x=0;
      // Console.Write("Nhap a=");
      // a = Convert.ToDouble(Console.ReadLine());
      // Console.Write("Nhap b=");
      // b = Convert.ToDouble(Console.ReadLine());
      // KieuSoNghiem kq = giaiPTBac1(a, b, ref x);
      // if (kq == KieuSoNghiem.VoSoNghiem)
      //    Console.WriteLine("PT co vo so nghiem");
      // else if (kq == KieuSoNghiem.VoNghiem)
      //    Console.WriteLine("PT vo nghiem");
      // else if (kq == KieuSoNghiem.MotNghiem)
      //    Console.WriteLine("PT co 1 nghiem = " + x);
      double a, b, c, x1 = 0, x2 = 0;
      Console.Write("Nhap a= ");
      a = Convert.ToDouble(Console.ReadLine());
      Console.Write("Nhap b= ");
      b = Convert.ToDouble(Console.ReadLine());
      Console.Write("Nhap c= ");
      c = Convert.ToDouble(Console.ReadLine());
      KieuSoNghiem kq = giaiPTBac2(a, b, c, ref x1, ref x2);
      if (kq == KieuSoNghiem.VoNghiem)
        Console.WriteLine("Pt vo nghiem");
      else if (kq == KieuSoNghiem.MotNghiem)
        Console.WriteLine("pt co nghiem kep x =" + x1);
      else if (kq == KieuSoNghiem.HaiNghiem)
        Console.WriteLine("Pt co hai nghiem x1 =" + x1 + "\t x2 = " + x2);
      else if (kq == KieuSoNghiem.VoSoNghiem)
        Console.WriteLine("PT vo so nghiem");
      Console.ReadLine();
    }
  }
}
