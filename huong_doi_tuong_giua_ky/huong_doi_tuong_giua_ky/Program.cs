using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huong_doi_tuong_giua_ky
{
    public class CNhanVienKT
    {
        private string m_manv;
        private string m_hoten;
        private int m_tongsp;

        public string MaNV
        {
                get { return m_manv; }
                set { m_manv = value; }
        }

        public string HoTen
        {
                get { return m_hoten; }
                set { m_hoten = value; }

        }

        public int TongSP
        {
                get { return m_tongsp; }
                set { m_tongsp = value; }
        } 

        public CNhanVienKT()
        {
                m_manv = "";
                m_hoten = "";
                m_tongsp = 0;

        }
        public CNhanVienKT(string manv, string hoten, int tongsp)
        {
                m_manv = manv;
                m_hoten = hoten;
                m_tongsp = tongsp;
        }

        public double tinhLuong()
        {
                return m_tongsp * 100000;
        }
    }
    internal class Program
    {
            public static double tongLuong(List<CNhanVienKT> ds)
            {
                double s = 0;
                for (int i = 0; i < ds.Count; i++)
                {
                    s += ds.tinhLuong();
                }
                return s;
            }
            public static void xuatNVSXHon100SP(List<CNhanVienKT> ds)
            {
                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds.tongsp > 100)
                    {
                    Console.WriteLine(ds.manv);
                    }
                }
            }
        static void Main(string[] args)
        {
        }
    }
}
