using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace progresso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textBox1.Text);
            if (valor > progressBar1.Minimum | valor < progressBar1.Maximum)
            {
                progressBar1.Value = valor;
            }
            else MessageBox.Show("O valor deve estar entre 0-100!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for(int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value++;
                Thread.Sleep(200);
            }
        }
    }
}
