using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            FileStream fs = new FileStream("HocSinh.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            //dsHS = (List<CHocSinh>)bf.Deserialize(fs);
            dsHS = bf.Deserialize(fs) as List<CHocSinh>; 

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsHS.Count; i++)
            {
                if (dsHS[i].MaHS == txtMaHS.Text)
                {
                    dsHS[i].HoTen = txtHoTen.Text;
                    dsHS[i].DiaChi = txtDiaChi.Text;
                    dsHS[i].NgaySinh= dtpNgaySinh.Value.Date;
                    dsHS[i].Phai = radNam.Checked;
                    break;
                }
            }
            hienthi();
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("HocSinh.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dsHS);
            fs.Close();
        }
    }
}
