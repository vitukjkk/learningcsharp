using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using learning;

namespace learning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string text = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ola mundo");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Digite algo!");
                textBox1.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Veículo adicionado!");
                tb_01.Text += textBox1.Text + ", ";
                textBox1.Clear();
                tb_01.Focus();
            }
        }

        private void tb_01_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btn_02_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            tb_01.Clear();
            MessageBox.Show("Caixa limpada!");        
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            Vehiclelist lista = new Vehiclelist(tb_01.Text);
            lista.ShowDialog();
            text = tb_01.Text;
        }
    }
}

public partial class Vehiclelist : Form
{
    public string textoDigitado = "";

    public Vehiclelist(string v)
    {

    }

    private void tb_02_TextChanged(object sender, EventArgs e)
    {

    }

    private void Vehiclelist_FormClosed(object sender, FormClosedEventArgs e)
    {
        Form1 txtDigitado = new Form1();
    }
}
