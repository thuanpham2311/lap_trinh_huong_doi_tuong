using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonPhepTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtKetQua.Text = "";
            txtNhapA.Select();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble( txtNhapA.Text);
            double b = Convert.ToDouble(txtNhapB.Text);
            double c = a + b;
            txtKetQua.Text = c.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNhapA.Text);
            double b = Convert.ToDouble(txtNhapB.Text);
            if (b == 0)
                txtKetQua.Text = "Không chia cho số 0";
            else
            {
                double c = a / b;
                txtKetQua.Text = c.ToString();
            }
        }
    }
}
