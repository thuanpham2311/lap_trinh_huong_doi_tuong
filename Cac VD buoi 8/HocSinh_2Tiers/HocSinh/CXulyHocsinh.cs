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
    public class CXulyHocsinh
    {
        private List<CHocSinh> dsHS;
        public CXulyHocsinh()
        {
            //dsHS = new List<CHocSinh>();
            //CTruycapDL tc = CTruycapDL.KhoiTao();
            dsHS = CTruycapDL.KhoiTao().getdshs();
        }
        public List<CHocSinh> getDSHocSinh()
        {
            return dsHS.ToList();
        }
        public CHocSinh tim(string mshs)
        {
            foreach(CHocSinh hs in dsHS)
            {
                if (hs.MaHS == mshs)
                    return hs;
            }
            return null;
        }
        public void them( CHocSinh hs)
        {
            CHocSinh n = new CHocSinh();
            if (tim(hs.MaHS) == null)
            {
                dsHS.Add(hs);
            }
            else
                MessageBox.Show("Mã họ sinh" + hs.MaHS + " đã tồn tại");             
        }    
        public void xoa(string mshs)
        {
            CHocSinh n = tim(mshs);
            if(n==null)
            {
                MessageBox.Show("Khong ton tai");                   
            }
            else
            {
                dsHS.Remove(n);
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
            try {
                FileStream fs = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsHS);
                fs.Close();
                MessageBox.Show("Save File Successfully");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void docFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                dsHS = new List<CHocSinh>();
                BinaryFormatter bf = new BinaryFormatter();
                dsHS = (List<CHocSinh>)bf.Deserialize(fs);
            }
            catch(Exception error)
            {
                MessageBox.Show("Not have File to Read Data");
            }
        }
    }
}
