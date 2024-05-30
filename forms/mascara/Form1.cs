using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mascara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cb_onlyText.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = maskedTextBox1.Text;
            MessageBox.Show(msg);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                mtb_main.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtb_main.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = mtb_main.Text;
            MessageBox.Show(msg);

        }
    }
}
