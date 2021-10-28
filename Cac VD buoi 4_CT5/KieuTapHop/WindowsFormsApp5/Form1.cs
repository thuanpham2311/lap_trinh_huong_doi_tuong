using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////List<string> a = new List<string>();
            //ArrayList a = new ArrayList();
            //a.Add("a");
            //a.Add("b");
            //a.Add("c");

            //a.RemoveAt(0);

            //string s = "";
            ////for(int i=0; i < a.Count;i++)
            ////{
            ////    s += a[i] + "  ";
            ////}

            //foreach(string i in a)
            //{
            //    s += i + "  ";
            //}

            //a[0] = "aaa";
            //MessageBox.Show(s);

            //Dictionary<string, string> a = new Dictionary<string, string>();
            Hashtable a = new Hashtable();
            a.Add("one", "một");
            a.Add("two", "hai");

            //a.Remove("one");

            string s = "";
            foreach(string i in a.Values)
            {
                s += i + "  ";
            }
            MessageBox.Show(s);

            
        }
    }
}
