using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace mini_calculadora
{
    public partial class form_base : Form
    {
        List<int> values = new List<int>();


        public int sum(params int[] n)
        {
            int sum = 0;

            foreach(int value in values)
            {
                sum += value;
            }

            return sum;
        }

        public form_base()
        {
            InitializeComponent();
            tela.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e) // BOTÃO DE IGUAL
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }

            values.Add(int.Parse(tela.Text));
            tela.Text = sum().ToString();
            values.Clear();
        }

        private void tela_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            if(tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }

            values.Add(int.Parse(tela.Text));
            tela.Text = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }
            if(values.Sum() != 0)
            {
                values.RemoveLast();
                tela.Text = tela.Text.Substring(0, tela.TextLength - 1);
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }

            tela.Text = string.Empty;
            values[0].Clear();
            MessageBox.Show("Limpado com sucesso!");
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                MessageBox.Show("Você precisa inserir um número primeiro!");
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(1);
            tela.Text += "1";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(0);
            tela.Text += "0";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(3);
            tela.Text += "3";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(2);
            tela.Text += "2";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(4);
            tela.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(5);
            tela.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(6);
            tela.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(7);
            tela.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(8);
            tela.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            values[values.Count - 1].AddLast(9);
            tela.Text += "9";
        }
    }
}
