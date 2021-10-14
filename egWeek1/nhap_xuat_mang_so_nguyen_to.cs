using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
  class Program {
    public static void nhapMang(int[] a, int n) {
      for (int i = 0; i < n; i++) {
        Console.Write("Nhap phan tu thu " + i + ":");
        a[i] = Convert.ToInt32(Console.ReadLine());
      }
    }
    public static void xuatMang(int[] a, int n) {
      for (int i = 0; i < n; i++) {
        Console.Write(a[i] + "\t");
      }
    }
    public static int tongMang(int[] a, int n) {
      int t = 0;
      for (int i = 0; i < n; i++)
        t += a[i];
      return t;
    }
    public static int kiemtraSNT(int n) {
      if (n < 2)
        return 0;
      else {
        for (int i = 2; i <= n / 2; i++)
          if (n % i == 0)
            return 0;
        return 1;
      }
    }
    public static void xuatSNT(int[] a, int n) {
      for (int i = 0; i < n; i++)
        if (kiemtraSNT(a[i]) == 1)
          Console.WriteLine(a[i]);
    }
    static void Main(string[] args) {
      int[] a;
      int n;
      Console.Write("Nhap so phan tu cua mang:");
      n = Convert.ToInt32(Console.ReadLine());
      a = new int[n];
      nhapMang(a, n);
      xuatMang(a, n);
      Console.WriteLine("\nTong mang=" + tongMang(a, n));
      Console.WriteLine("\nCac snt=");
      xuatSNT(a, n);

      Console.ReadLine();
    }
  }
}
