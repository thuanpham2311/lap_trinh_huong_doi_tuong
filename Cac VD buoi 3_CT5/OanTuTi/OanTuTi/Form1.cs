using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OanTuTi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            // bua = 1 bao = 2 keo =3
            Random r = new Random();
            int i = r.Next(1, 4);

            if (radBua.Checked == true)
            {
                if (i==2) //may ra bao
                {
                    lblKQ.Text = "Ban Thua";
                }
                else if (i==3  )
                {
                    lblKQ.Text = "Ban Thang";
                }
                else
                {
                    lblKQ.Text = "Hoa"; 
                }
            }
            else if (radBao.Checked == true)
            {
                if ( i == 1)
                {
                    lblKQ.Text = "Ban Thang";
                }
                else if (i == 3 )
                {
                    lblKQ.Text = "Ban Thua";
                }
                else
                {
                    lblKQ.Text = "Hoa";
                }
            }
            else
            {
                if (i == 2)
                {
                    lblKQ.Text = "Ban Thang";
                }
                else if (i == 1) 
                {
                    lblKQ.Text = "Ban Thua";
                }
                else
                {
                    lblKQ.Text = "Hoa";
                }
            }
        }
    }
}
