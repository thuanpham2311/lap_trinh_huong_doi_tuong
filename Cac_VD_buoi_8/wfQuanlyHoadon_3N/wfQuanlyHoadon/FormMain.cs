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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CTruycapDulieu.docFile("hoadon.dat");
        }

        private void hanghoaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormHanghoa f = new FormHanghoa();
            f.Show();
        }

        private void hoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoadon f = new FormHoadon();
            f.Show();
        }

        private void ghiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt=CTruycapDulieu.ghiFile("hoadon.dat");
            if (kt == true) MessageBox.Show("Ghi dữ liệu thành công!!!");
            else MessageBox.Show("Không ghi được dữ liệu!!!");
        }
    }
}
