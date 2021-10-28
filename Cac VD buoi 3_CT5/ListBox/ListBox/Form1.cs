using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(txtNhap.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lst2.Items.Add(lst1.Items[0].ToString());
            lst1.Items.RemoveAt(0);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(lst2.Items[0].ToString());
            lst2.Items.RemoveAt(0);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lst1.Items.Count;i++)
            {
                lst2.Items.Add(lst1.Items[0].ToString());
                lst1.Items.RemoveAt(0);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst2.Items.Count; i++)
            {
                lst1.Items.Add(lst2.Items[0].ToString());
                lst2.Items.RemoveAt(0);
            }
        }
    }
}
