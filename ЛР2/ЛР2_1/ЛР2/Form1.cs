using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C;
            string a, b, c;
            a = richTextBox1.Text;
            int.TryParse(a,out A);
            b = richTextBox2.Text;
            int.TryParse(b, out B);
            c = richTextBox3.Text;
            int.TryParse(c, out C);

            if ((A > B) && (B > C))
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
            }
            else
            {
                A = A - 1;
                B = B - 1;
                C = C - 1;
            }
            a = A.ToString();
            b = B.ToString();
            c = C.ToString();
            label4.Text = a;
            label5.Text = b;
            label6.Text = c;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
