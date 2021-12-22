using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    class CChitietHoadonView
    {
        public string sohd { get; set; }
        public string ngaylaphd { get; set; }
        public string tenkh { get; set; }
        public string mahang { get; set; }
        public string tenhang { get; set; }
        public string dvt { get; set; }
        public string dongia { get; set; }
        public string soluong { get; set; }
        public string thanhtien { get; set; }
        public static List<CChitietHoadonView> getDSChitietHD(CHoaDon x)
        {
            List<CChitietHoadonView> ds = new List<CChitietHoadonView>();
            foreach(CChitietHoadon t in x.DanhsachChitietHoadon)
            {
                CChitietHoadonView a = new CChitietHoadonView();
                a.sohd = x.sohd;
                a.ngaylaphd = x.ngaylaphd.ToShortDateString();
                a.tenkh = x.tenkh;
                a.mahang = t.hanghoa.mahang;
                a.tenhang = t.hanghoa.tenhang;
                a.dvt = t.hanghoa.dvt;
                a.dongia = t.dongia.ToString();
                a.soluong = t.soluong.ToString();
                a.thanhtien = t.thanhtien().ToString();
                ds.Add(a);
            }
            return ds;
        }
    }
}
