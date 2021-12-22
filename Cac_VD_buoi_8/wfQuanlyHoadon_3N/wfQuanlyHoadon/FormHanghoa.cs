using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wfQuanlyHoadon
{
    public partial class FormHanghoa : Form
    {
        private CXulyHanghoa xuly;
        public FormHanghoa()
        {
            InitializeComponent();
        }

        private void FormHanghoa_Load(object sender, EventArgs e)
        {
            xuly = new CXulyHanghoa();
            hienthi(xuly.getDSHanghoa());
        }
        private void hienthi(List<CHangHoa> ds)
        {
            lst.Items.Clear();
            foreach(CHangHoa a in ds)
            {
                ListViewItem lvi = new ListViewItem(a.mahang);
                lvi.SubItems.Add(a.tenhang);
                lvi.SubItems.Add(a.dvt);
                lvi.SubItems.Add(a.dongia.ToString());
                lst.Items.Add(lvi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHangHoa a = new CHangHoa();
            a.mahang = txtMahang.Text;
            a.tenhang = txtTenhang.Text;
            a.dvt = txtDvt.Text;
            a.dongia = double.Parse(txtDongia.Text);

            xuly.them(a);
            hienthi(xuly.getDSHanghoa());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lst.SelectedItems)
            {
                string mahang = lvi.SubItems[0].Text;
                xuly.xoa(mahang);
            }
            hienthi(xuly.getDSHanghoa());
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lst.SelectedItems)
            {
                string mahang = lvi.SubItems[0].Text;
                CHangHoa a = xuly.tim(mahang);
                if(a!=null)
                {
                    txtMahang.Text = a.mahang;
                    txtTenhang.Text = a.tenhang;
                    txtDvt.Text = a.dvt;
                    txtDongia.Text = a.dongia.ToString();
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHangHoa a = new CHangHoa();
            a.mahang = txtMahang.Text;
            a.tenhang = txtTenhang.Text;
            a.dvt = txtDvt.Text;
            a.dongia = double.Parse(txtDongia.Text);

            xuly.sua(a);
            hienthi(xuly.getDSHanghoa());
        }
    }
}
