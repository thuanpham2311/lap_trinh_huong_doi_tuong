using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDon_HangHoa
{
    class CXuLyHangHoa
    {
        private List<CHangHoa> ds;
        public CXuLyHangHoa()
        {
            CTruyCapDuLieu tc = CTruyCapDuLieu.khoitao();
            ds = tc.getDSHangHoa();
        }
        public List<CHangHoa> getDSHangHoa()
        {
            return ds;
        }
        public CHangHoa tim(string ma)
        {
            foreach (CHangHoa i in ds)
                if (i.MaHang == ma)
                    return i;
            return null;
        }
        public void them(CHangHoa a)
        {
            if (tim(a.MaHang) == null)
                ds.Add(a);
            else
                MessageBox.Show("Mã hàng hóa đã tồn tại trong danh sách hàng hóa. Không thêm được.");
        }
        public void xoa(string mahang)
        {
            CHangHoa h = tim(mahang);
            if (h != null)
                ds.Remove(h);
            else
                MessageBox.Show("Mã hàng hóa không tồn tại trong danh sách hàng hóa. Không xóa được.");
        }
        public void sua(CHangHoa a)
        {
            CHangHoa h = tim(a.MaHang);
            if (h != null)
            {
                h.TenHang = a.TenHang;
                h.DonGia = a.DonGia;
                h.DVT = a.DVT;
            }                
            else
                MessageBox.Show("Mã hàng hóa không tồn tại trong danh sách hàng hóa. Không sửa được.");
        }

    }
}
