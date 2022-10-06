using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result=0;
            if (checkBox2.Checked == true)
            {
                result++;
            }
            if (checkBox1.Checked == true)
            {
                result = result - 0.25;
            }
            if (checkBox3.Checked == true)
            {
                result = result - 0.25;
            }
            if (checkBox4.Checked == true)
            {
                result = result - 0.25;
            }

            if (checkBox8.Checked == true)
            {
                result++;
            }
            if (checkBox5.Checked == true)
            {
                result = result - 0.25;
            }
            if (checkBox6.Checked == true)
            {
                result = result - 0.25;
            }
            if (checkBox7.Checked == true)
            {
                result = result - 0.25;
            }

            if (checkBox9.Checked == true)
            {
                result++;
            }
            if (checkBox10.Checked == true)
            {
                result = result - 0.25;
            }
            if (checkBox11.Checked == true)
            {
                result = result - 0.25;
            }
            if (checkBox12.Checked == true)
            {
                result = result - 0.25;
            }
            label5.Text = "Вы прошли тест на " +result+ " баллов из 3 возможных.";
        }
    }
}
