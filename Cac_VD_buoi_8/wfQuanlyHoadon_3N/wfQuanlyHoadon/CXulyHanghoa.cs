using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    class CXulyHanghoa
    {
        private List<CHangHoa> ds;
        public CXulyHanghoa()
        {
            CTruycapDulieu data = CTruycapDulieu.khoitao();
            ds = data.getDSHanghoa();
        }
        public List<CHangHoa> getDSHanghoa()
        {
            return ds;
        }
        public CHangHoa tim(string mahang)
        {
            foreach(CHangHoa a in ds)
            {
                if (a.mahang == mahang) return a;
            }
            return null;
        }
        public void them(CHangHoa a)
        {
            ds.Add(a);
        }
        public void xoa(string mahang)
        {
            CHangHoa a = tim(mahang);
            if (a != null) ds.Remove(a);
        }
        public void sua(CHangHoa a)
        {
            CHangHoa x = tim(a.mahang);
            if (x != null)
            {
                x.tenhang = a.tenhang;
                x.dvt = a.dvt;
                x.dongia = a.dongia;
            }
        }
    }
}
