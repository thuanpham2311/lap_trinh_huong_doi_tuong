using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfQuanlyHoadon
{
    public partial class FormHoadon : Form
    {
        private CHoaDon hd;

        private CXulyHanghoa xlHH;
        private CXulyHoadon xlHD;
        public FormHoadon()
        {
            InitializeComponent();
        }

        private void FormHoadon_Load(object sender, EventArgs e)
        {
            hd = new CHoaDon();

            xlHH = new CXulyHanghoa();
            xlHD = new CXulyHoadon();

            hienthi(xlHD.getDSHoadon());

            cmbMahang.DisplayMember = "mahang";
            cmbMahang.ValueMember = "mahang";
            cmbMahang.DataSource = xlHH.getDSHanghoa();
            //hienthiDSMaHang(xlHH.getDSHanghoa());
        }
        private void hienthi(List<CHoaDon> ds)
        {
            lst.Items.Clear();
            foreach (CHoaDon a in ds)
            {
                ListViewItem lvi = new ListViewItem(a.sohd);
                lvi.SubItems.Add(a.ngaylaphd.ToShortDateString());
                lvi.SubItems.Add(a.tenkh);
                lst.Items.Add(lvi);
            }
        }
        //private void hienthiDSMaHang(List<CHangHoa> ds)
        //{
        //    cmbMahang.Items.Clear();
        //    foreach(CHangHoa h in ds)
        //    {
        //        cmbMahang.Items.Add(h.mahang.ToString());
        //    }
        //}
        private void cmbMahang_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource= xlHH.getDSHanghoa();
            cmbMahang.DataSource = bs;
        }

        private void cmbMahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahang = cmbMahang.SelectedValue.ToString();
            CHangHoa a = xlHH.tim(mahang);
            if(a!=null)
            {
                txtTenhang.Text = a.tenhang;
                txtDvt.Text = a.dvt;
                txtDongia.Text = a.dongia.ToString();
                txtSoluong.Text = "1";
            }
        }

        private void btbChonhh_Click(object sender, EventArgs e)
        {
            string mahang = cmbMahang.SelectedValue.ToString();
            CHangHoa a = xlHH.tim(mahang);
            if (a != null)
            {
                CChitietHoadon b = new CChitietHoadon();
                b.hanghoa = a;
                b.dongia = a.dongia;
                b.soluong = int.Parse(txtSoluong.Text);
                hd.DanhsachChitietHoadon.Add(b);

                dgv.DataSource = CChitietHoadonView.getDSChitietHD(hd);
            }
        }

        private void btnLaphd_Click(object sender, EventArgs e)
        {
            if (hd.DanhsachChitietHoadon.Count <= 0) return;
            hd.sohd = txtSohd.Text;
            hd.ngaylaphd = dtpNgaylaphd.Value;
            hd.tenkh = txtTenKH.Text;

            xlHD.them(hd);
            hienthi(xlHD.getDSHoadon());

            hd = new CHoaDon();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lst.SelectedItems)
            {
                string sohd = lvi.SubItems[0].Text;
                CHoaDon a = xlHD.tim(sohd);
                if(a!=null)
                {
                    txtSohd.Text = a.sohd;
                    txtTenKH.Text = a.tenkh;
                    dtpNgaylaphd.Value = a.ngaylaphd;

                    dgv.DataSource = CChitietHoadonView.getDSChitietHD(a);
                }
            }
        }

        private void btnNgaylapHD_Click(object sender, EventArgs e)
        {
            List<CHoaDon> ds = new List<CHoaDon>();
            foreach(CHoaDon a in xlHD.getDSHoadon())
            {
                if (a.ngaylaphd.Date == dtpNgaylaphd.Value.Date) ds.Add(a);
            }
            hienthi(ds);
        }
    }
}
