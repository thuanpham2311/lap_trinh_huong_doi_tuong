using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Interface
{
    interface KieuSo
    {
        KieuSo cong(KieuSo a);
        bool laPhanSo();
        bool laSoPhuc();
        string xuat();
    }
}
