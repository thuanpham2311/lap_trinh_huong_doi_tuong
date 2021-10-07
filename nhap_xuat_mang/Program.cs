using System;

namespace nhap_xuat_mang
{
    class Program
    {
        public static void nhap_mang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhập giá trị phần tử thứ " + i + ": ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void xuat_mang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }

        static void Main(string[] args)
        {
            int[] a;
            int n;

            Console.Write("Nhập n = ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];

            nhap_mang(a, n);

            xuat_mang(a, n);
        }
    }
}
