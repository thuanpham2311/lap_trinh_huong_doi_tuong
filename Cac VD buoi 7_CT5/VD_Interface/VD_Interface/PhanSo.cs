using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Interface
{
    class PhanSo:KieuSo
    {
        private int _tuSo;
        private int _mauSo;
        public int tuSo
        {
            get { return this._tuSo; }
            set { this._tuSo = value; }
        }
        public int mauSo
        {
            get { return this._mauSo; }
            set { this._mauSo = value; }
        }
        public PhanSo()
        {
            this._tuSo = 1;
            this._mauSo = 1;
        }
        public PhanSo(int tuSo, int mauSo)
        {
            this._tuSo = tuSo;
            this._mauSo = mauSo;
        }
        //1 3 1*4 + 2*3
        //- + - = ---------//2 4 2*4
        public KieuSo cong(KieuSo a)
        {
            PhanSo tong = new PhanSo();
            tong._tuSo = this._tuSo * ((PhanSo)a).mauSo + this._mauSo *
            ((PhanSo)a)._tuSo;
            tong._mauSo = this._mauSo * ((PhanSo)a)._mauSo;
            PhanSo ketQua = new PhanSo();
            ketQua = rutGon(tong);
            return ketQua;
        }
        public int timUCLN(PhanSo a)
        {
            int tu = Math.Abs(a._tuSo);
            int mau = Math.Abs(a._mauSo);
            while (tu != mau)
            {
                if (tu > mau)
                    tu = tu - mau;
                else
                    mau = mau - tu;
            }
            return tu;
        }
        public PhanSo rutGon(PhanSo a)
        {
            PhanSo ketQua = new PhanSo();
            int uocChungLonNhat = timUCLN(a);
            ketQua._tuSo = a._tuSo / uocChungLonNhat;
            ketQua._mauSo = a._mauSo / uocChungLonNhat;
            return ketQua;
        }
        public bool laPhanSo()
        {
            return true;
        }
        public bool laSoPhuc()
        {
            return false;
        }
        public string xuat()
        {
            return this._tuSo + "/" + this._mauSo;
        }
    }
}
