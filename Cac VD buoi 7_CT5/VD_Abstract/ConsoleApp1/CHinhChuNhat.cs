using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CHinhChuNhat:CHinhHoc
    {
        protected double m_dai;
        protected double m_rong;
        public CHinhChuNhat()
        {
            m_dai = 0;
            m_rong = 0;
        }
        public CHinhChuNhat(double dai,double rong)
        {
            m_dai = dai;
            m_rong = rong;
        }
        public virtual double ChieuDai
        {
            get { return m_dai; }
            set { m_dai = value; }
        }
        public virtual double ChieuRong
        {
            get { return m_rong; }
            set { m_rong = value; }
        }
        public override double chuvi()
        {
            return (m_dai+m_rong)*2;
        }
        public override double dientich()
        {
            return m_dai * m_rong ;
        }
        public override KieuHinh kieuDoiTuong()
        {
            return KieuHinh.HinhChuNhat;
        }
    }
}
