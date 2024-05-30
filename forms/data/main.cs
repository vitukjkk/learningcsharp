using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            form_Login form_Login = new form_Login(this);
            form_Login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {

                }
                else MessageBox.Show("Você não tem permissão!");
            }
            else MessageBox.Show("Você precisa estar logado!");
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {
                    gestao gu = new gestao();
                    gu.ShowDialog();
                }
                else MessageBox.Show("Você não tem permissão!");
            }
            else MessageBox.Show("Você precisa estar logado!");
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {
                    newuser nu = new newuser();
                    nu.ShowDialog();
                }
                else MessageBox.Show("Você não tem permissão!");
            }
            else MessageBox.Show("Você precisa estar logado!");
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {

                }
                else MessageBox.Show("Você não tem permissão!");
            }
            else MessageBox.Show("Você precisa estar logado!");
        }

        // LOGIN

        private void novoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == false)
            {
                form_Login log = new form_Login(this);
                log.getLogin();
            }
            else MessageBox.Show("ERRO: você já está logado! É preciso sair primeiro.");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                globais.name = "";
                globais.nivel = 0;
                globais.logado = false;

                label2.Text = 0.ToString();
                pictureBox1.Image = data.Properties.Resources.circulo;
                label4.Text = "---";
            }
            else MessageBox.Show("Você precisa estar logado!");
        }
    }
}
