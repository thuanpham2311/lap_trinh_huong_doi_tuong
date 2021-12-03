using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDon_HangHoa
{
    class CTruyCapDuLieu
    {
        private static CTruyCapDuLieu m_data = null;
        private List<CHangHoa> m_dshh;
        private List<CHoaDon> m_dshd;

        public CTruyCapDuLieu()
        {
            m_dshd = new List<CHoaDon>();
            m_dshh = new List<CHangHoa>();
        }
        public static CTruyCapDuLieu khoitao()
        {
            if (m_data == null)
                m_data = new CTruyCapDuLieu();
            return m_data;
        }

        public List<CHangHoa> getDSHangHoa()
        {
            return m_dshh;
        }
        public List<CHoaDon> getDSHoaDon()
        {
            return m_dshd;
        }
    }
}
