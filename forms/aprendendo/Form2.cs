using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aprendendo
{
    public partial class Form2 : Form
    {
        public string txt = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked == true)
            {
                txt += checkBox2.Text + ", ";
            }
            if (checkBox3.Checked == true)
            {
                txt += checkBox3.Text + ", ";
            }
            if (checkBox4.Checked == true)
            {
                txt += checkBox4.Text + ", ";
            }
            if (checkBox5.Checked == true)
            {
                txt += checkBox5.Text + ", ";
            }
            if (checkBox6.Checked == true)
            {
                txt += checkBox6.Text + ", ";
            }
            if (checkBox7.Checked == true)
            {
                txt += checkBox7.Text + ", ";
            }

            MessageBox.Show(txt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
