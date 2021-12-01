using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HocSinh
{
    public class CXulyHocsinh1
    {
        //private List<CHocSinh> dsHS;
        private Dictionary<string, CHocSinh> dsHS;
        public CXulyHocsinh1()
        {
            dsHS = new Dictionary<string, CHocSinh>();
        }
        public List<CHocSinh> getDSHocSinh()
        {
            return dsHS.Values.ToList();
        }
        public CHocSinh tim(string mshs)
        {
            foreach (CHocSinh hs in dsHS.Values)
            {
                if (hs.MaHS == mshs)
                    return hs;
            }
            return null;
        }
        public void them(CHocSinh hs)
        {
            
            if (tim(hs.MaHS) == null)
            {
                dsHS.Add(hs.MaHS,hs);
            }
            else
                MessageBox.Show("Mã họ sinh" + hs.MaHS + " đã tồn tại");
        }
        public void xoa(string mshs)
        {
            CHocSinh n = tim(mshs);
            if (n == null)
            {
                MessageBox.Show("Khong ton tai");
            }
            else
            {
                dsHS.Remove(mshs);
            }
        }
        public void sua(CHocSinh hs)
        {
            CHocSinh n = tim(hs.MaHS);
            if (n == null)
            {
                MessageBox.Show("0 ton tai");
            }
            else
            {
                n.HoTen = hs.HoTen;
                n.NgaySinh = hs.NgaySinh;
                n.DiaChi = hs.DiaChi;
                n.Phai = hs.Phai;
            }
        }
        public void ghiFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsHS);
                fs.Close();
                MessageBox.Show("Save File Successfully");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void docFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                dsHS = new Dictionary<string,CHocSinh>();
                BinaryFormatter bf = new BinaryFormatter();
                dsHS = (Dictionary<string, CHocSinh>)bf.Deserialize(fs);
            }
            catch (Exception error)
            {
                MessageBox.Show("Not have File to Read Data");
            }
        }
    }
}
