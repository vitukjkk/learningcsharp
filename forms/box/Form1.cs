using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace box
{
    public partial class Form1 : Form
    {
        List<string> carros = new List<string>();

        public Form1()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            listBox1.DataSource = carros;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                carros.Add(textBox1.Text);
                listBox1.DataSource = null;
                listBox1.DataSource = carros;
            }
            else MessageBox.Show("Digite um carro!"); textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = carros;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = carros[listBox1.SelectedIndex];
        }
    }
}
