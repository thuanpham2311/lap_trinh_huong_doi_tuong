using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace wfQuanlyHoadon
{
    [Serializable]
    class CTruycapDulieu
    {
        private static CTruycapDulieu m_data = null;
        private List<CHangHoa> dsHH;
        private List<CHoaDon> dsHD;
        private CTruycapDulieu()
        {
            dsHD = new List<CHoaDon>();
            dsHH = new List<CHangHoa>();
        }
        public static CTruycapDulieu khoitao()
        {
            if (m_data == null) m_data = new CTruycapDulieu();
            return m_data;
        }
        public List<CHangHoa> getDSHanghoa()
        {
            return dsHH;
        }
        public List<CHoaDon> GetDSHoadon()
        {
            return dsHD;
        }
        public static bool ghiFile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                if (f == null) return false;
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, m_data);
                f.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public static bool  docFile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                if (f == null) return false;
                BinaryFormatter bf = new BinaryFormatter();
                m_data = bf.Deserialize(f) as CTruycapDulieu;
                f.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
    }
}
