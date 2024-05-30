using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            textBox1.Text = txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(RadioButton r in groupBox2.Controls)
            {
                if(r.Checked)
                {
                    textBox1.Text = r.Text;
                }
            }
        }
    }
}
