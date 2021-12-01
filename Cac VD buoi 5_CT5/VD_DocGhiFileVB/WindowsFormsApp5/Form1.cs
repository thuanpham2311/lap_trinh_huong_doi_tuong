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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string DocTapTin(string tentaptin)
        {
            string noidung = "";
            try
            {
                StreamReader sr = new StreamReader(tentaptin);
                noidung = sr.ReadToEnd();
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Khong doc duoc tap tin.");
            }
            return noidung;
        }
        public static bool GhiTapTin(string tentaptin, string noidung)
        {
            try
            {
                StreamWriter sr = new StreamWriter(tentaptin);
                sr.Write(noidung);
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Khong ghi duoc tap tin.");
                return false;
            }
            return true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            ofd1.FilterIndex = 2;
            if(ofd1.ShowDialog()==DialogResult.OK)
            {
                //MessageBox.Show(ofd1.FileName);
                txtData.Text = DocTapTin(ofd1.FileName);
            }

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            sfd1.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            sfd1.FilterIndex = 2;
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(sfd1.FileName);
                GhiTapTin(sfd1.FileName, txtData.Text);
            }
        }
    }
}
