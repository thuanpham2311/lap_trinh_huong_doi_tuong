using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDon_HangHoa
{
    class CChiTietHoaDon
    {
        private int m_soluong;
        private double m_dongia;
        private CHangHoa m_hanghoa;

        public CChiTietHoaDon()
        {
            this.m_soluong = 0;
            this.m_dongia = 0;
            this.m_hanghoa = null;
        }
        public CChiTietHoaDon(int m_soluong, double m_dongia, CHangHoa m_hanghoa)
        {
            this.m_soluong = m_soluong;
            this.m_dongia = m_dongia;
            this.m_hanghoa = m_hanghoa;
        }

        public int SoLuong { get => m_soluong; set => m_soluong = value; }
        public double DonGia { get => m_dongia; set => m_dongia = value; }
        public CHangHoa HangHoa { get => m_hanghoa; set => m_hanghoa = value; }
        public double tinhThanhTien()
        {
            return m_dongia * m_soluong;
        }
    }
}
