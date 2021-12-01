using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinh
{
    [Serializable]
    public class CHocSinh
    {
        private string m_MaHS;
        private string m_HoTen;
        private DateTime m_NgaySinh;
        private bool m_Phai;
        private string m_DiaChi;

        //public string MaHs { get => m_MaHS;set => m_MaHS = value; }
        //public string HoTn { get => m_HoTen; set => m_HoTen = value; }
        //public DateTime NgaySinh { get => m_NgaySinh; set => m_NgaySinh = value; }
        //public bool Phai { get => m_Phai; set => m_Phai = value; }
        //public string DiaChi { get => m_DiaChi; set => m_DiaChi = value; }
        public string MaHS
        {
            get { return m_MaHS; }
            set { m_MaHS = value; }
        }
        public string HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }
        public bool Phai
        {
            get { return m_Phai; }
            set { m_Phai = value; }
        }
        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        public CHocSinh(string maHS,string hoTen,DateTime ngaySinh,bool phai,string diaChi)
        {
            m_MaHS = maHS;
            m_HoTen = hoTen;
            m_NgaySinh = ngaySinh;
            m_Phai = phai;
            m_DiaChi = diaChi;
        }
        public CHocSinh()
        {
            m_MaHS = "";
            m_HoTen = "";
            m_NgaySinh = DateTime.Today;
            m_Phai = false;
            m_DiaChi = "";
        }

    }
}
