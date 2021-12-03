using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDon_HangHoa
{
    class CHangHoa
    {
        private string m_mahang;
        private string m_tenhang;
        private string m_dvt;
        private double m_dongia;

        public CHangHoa()
        {
            this.m_mahang = "";
            this.m_tenhang = "";
            this.m_dvt = "";
            this.m_dongia = 0;
        }
        public CHangHoa(string m_mahang, string m_tenhang, string m_dvt, double m_dongia)
        {
            this.m_mahang = m_mahang;
            this.m_tenhang = m_tenhang;
            this.m_dvt = m_dvt;
            this.m_dongia = m_dongia;
        }

        public string MaHang { get => m_mahang; set => m_mahang = value; }
        public string TenHang { get => m_tenhang; set => m_tenhang = value; }
        public string DVT { get => m_dvt; set => m_dvt = value; }
        public double DonGia { get => m_dongia; set => m_dongia = value; }

    }
}
