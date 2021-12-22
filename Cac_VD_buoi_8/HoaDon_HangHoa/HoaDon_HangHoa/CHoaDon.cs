using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDon_HangHoa
{
    class CHoaDon
    {
        private string m_sohd;
        private DateTime m_ngaylaphd;
        private string m_tenkh;
        private List<CChiTietHoaDon> m_cthd;

        public CHoaDon()
        {
            this.m_sohd = "";
            this.m_ngaylaphd = DateTime.Now;
            this.m_tenkh = "";
            m_cthd = new List<CChiTietHoaDon>();
        }
        public CHoaDon(string m_sohd, DateTime m_ngaylaphd, string m_tenkh)
        {
            this.m_sohd = m_sohd;
            this.m_ngaylaphd = m_ngaylaphd;
            this.m_tenkh = m_tenkh;
            m_cthd = new List<CChiTietHoaDon>();
        }

        public string Sohd { get => m_sohd; set => m_sohd = value; }
        public DateTime Ngaylaphd { get => m_ngaylaphd; set => m_ngaylaphd = value; }
        public string Tenkh { get => m_tenkh; set => m_tenkh = value; }
        public List<CChiTietHoaDon> Cthd { get => m_cthd; }
        public double tinhThanhTien()
        {
            double t = 0;
            foreach(CChiTietHoaDon c in m_cthd)
            {
                t += c.tinhThanhTien();
            }
            return t;
        }
    }
}
