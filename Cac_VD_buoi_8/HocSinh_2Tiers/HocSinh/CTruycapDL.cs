using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinh
{
    class CTruycapDL
    {
        private static CTruycapDL m_data = null;
        private static List<CHocSinh> m_dshs;
        public CTruycapDL()
        {
            m_dshs = new List<CHocSinh>();

        }
        public static CTruycapDL KhoiTao()
        {
            if (m_data == null)
                m_data = new CTruycapDL();
            return m_data;
        }
        public List<CHocSinh> getdshs()
        {
            return m_dshs;
        }
    }
}
