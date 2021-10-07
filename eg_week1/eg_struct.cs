using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct PHANSO
    {
        int tuso, mauso;
        public void nhapPhanSo()
        {
            Console.Write("\nNhap tu so =");
            tuso = Convert.ToInt32( Console.ReadLine());
            Console.Write("\nNhap mau so =");
            mauso = Convert.ToInt32(Console.ReadLine());
        }
        public void xuatPhanSo()
        {
            Console.Write(tuso + "/" + mauso);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            PHANSO ps = new PHANSO();
            ps.nhapPhanSo();
            ps.xuatPhanSo();
            PHANSO ps1 = new PHANSO();
            ps1.nhapPhanSo();
            ps1.xuatPhanSo();

            Console.ReadLine();
        }
    }
}
