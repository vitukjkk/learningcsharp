using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_produtos.SelectedItems.Count > 0)
            {
                get();
            }
        }

        private void get()
        {
            textBox1.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "")
            {
                MessageBox.Show("Insira valores em todos os campos para poder adicionar!");
                textBox1.Focus();
                return;
            }

            string[] pr = new string[4];

            pr[0] = textBox1.Text;
            pr[1] = textBox2.Text;
            pr[2] = textBox3.Text;
            pr[3] = textBox4.Text;

            ListViewItem l = new ListViewItem(pr);

            lv_produtos.Items.Add(l);
            clear();
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
