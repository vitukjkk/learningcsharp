using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defMax();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_addTab.Text != "")
            {
                TabPage page = new TabPage();
                page.Text = tb_addTab.Text;
                page.Name = tb_addTab.Text;
                page.TabIndex = tabControl.TabPages.Count;
                tabControl.TabPages.Add(page);
                tb_addTab.Text = "";
                defMax();
            }
            else MessageBox.Show("Digite o nome da nova página!"); tb_addTab.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < tabControl.TabPages.Count)
            {
                tabControl.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
            }
        }

        private void defMax()
        {
            numericUpDown1.Maximum = tabControl.TabPages.Count - 1;
        }
    }
}
