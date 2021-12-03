using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDon_HangHoa
{
    public partial class frmHangHoa : Form
    {
        private CXuLyHangHoa xl;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            xl = new CXuLyHangHoa();
        }
        private void HienThi()
        {
            dgvHH.DataSource = xl.getDSHangHoa().ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CHangHoa h = new CHangHoa();
            h.MaHang = txtMaHang.Text;
            h.TenHang = txtTenHang.Text;
            h.DVT = txtDVT.Text;
            h.DonGia = Convert.ToInt32(txtDonGia.Text);
            xl.them(h);
            HienThi();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHang.Text;
            xl.xoa(ma);
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHangHoa h = new CHangHoa();
            h.MaHang = txtMaHang.Text;
            h.TenHang = txtTenHang.Text;
            h.DonGia = Convert.ToInt32(txtDonGia.Text);
            h.DVT = txtDVT.Text;
            xl.sua(h);
            HienThi();
        }

        private void dgvHH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvHH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHang.Text = dgvHH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDonGia.Text = dgvHH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDVT.Text = dgvHH.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            CHangHoa h = xl.tim(txtMaHang.Text);
            if (h != null)
            {
                txtTenHang.Text = h.TenHang;
                txtDVT.Text = h.DVT;
                txtDonGia.Text = h.DonGia.ToString();
            }
            else
                MessageBox.Show("Ko tìm thấy.");
        }
    }
}
