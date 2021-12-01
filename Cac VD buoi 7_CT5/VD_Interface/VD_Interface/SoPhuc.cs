using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Interface
{
    class SoPhuc:KieuSo
    {
        private double _phanThuc;
        private double _phanAo;
        public double phanThuc
        {
            get { return this._phanThuc; }
            set { this._phanThuc = value; }
        }
        public double phanAo
        {
            get { return this._phanAo; }
            set { this._phanAo = value; }
        }
        public SoPhuc()
        {
            this._phanThuc = 1;
            this._phanAo = 1;
        }
        public SoPhuc(double thuc, double ao)
        {
            this._phanThuc = thuc;
            this._phanAo = ao;
        }
        public KieuSo cong(KieuSo a)
        {
            SoPhuc tong = new SoPhuc();
            tong._phanThuc = this._phanThuc + ((SoPhuc)a)._phanThuc;
            tong._phanAo = this._phanAo + ((SoPhuc)a)._phanAo;
            return tong;
        }
        public bool laPhanSo()
        {
            return false;
        }
        public bool laSoPhuc()
        {
            return true;
        }
        public string xuat()
        {
            return this._phanThuc + "+" + this._phanAo + "i";
        }
    }
}
