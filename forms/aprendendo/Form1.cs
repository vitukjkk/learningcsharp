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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ms_02_Click(object sender, EventArgs e)
        {

        }

        private void cb_01_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hRVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 form = new Form2();
           form.ShowDialog();
        }
    }
}
