using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    class CXulyHoadon
    {
        private List<CHoaDon> ds;
        public CXulyHoadon()
        {
            CTruycapDulieu data = CTruycapDulieu.khoitao();
            ds = data.GetDSHoadon();
        }
        public List<CHoaDon> getDSHoadon()
        {
            return ds;
        }
        public CHoaDon tim(string sohd)
        {
            foreach(CHoaDon a in ds)
            {
                if (a.sohd == sohd) return a;
            }
            return null;
        }
        public void them(CHoaDon a)
        {
            ds.Add(a);
        }
    }
}
