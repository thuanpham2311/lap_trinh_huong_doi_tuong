using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSinh
{
    public partial class Form1 : Form
    {
        private List<CHocSinh> dsHS;
        private void hienthi()
        {
            dgvHS.DataSource = dsHS.ToList();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsHS = new List<CHocSinh>();
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHocSinh hs = new CHocSinh();
            hs.MaHS = txtMaHS.Text;
            hs.HoTen = txtHoTen.Text;
            hs.NgaySinh = dtpNgaySinh.Value.Date;
            hs.DiaChi = txtDiaChi.Text;
            hs.Phai = radNam.Checked;
            dsHS.Add(hs);
            hienthi();
        }

        private void dgvHS_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHS.Text = dgvHS.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text= dgvHS.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime( dgvHS.Rows[e.RowIndex].Cells[2].Value);
            if (dgvHS.Rows[e.RowIndex].Cells[3].Value.ToString() == "True")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtDiaChi.Text = dgvHS.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsHS.Count; i++)
            {
                if (dsHS[i].MaHS == txtMaHS.Text)
                {
                    //dsHS.Remove(dsHS[i]);
                    dsHS.RemoveAt(i);
                    break;
                }
            }
            hienthi();            
        }
    }
}
