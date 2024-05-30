using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_showSelected_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Item selecionado: {comboBox1.Text}");
        }

        private void btn_clearElements_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            MessageBox.Show("Itens excluídos!");
        }

        private void btn_resetElements_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Carro");
            comboBox1.Items.Add("Avião");
            comboBox1.Items.Add("Navio");
            comboBox1.Items.Add("Ônibus");
            comboBox1.Items.Add("Trem");

            MessageBox.Show("Itens restaurados!");
        }

        private void btn_addElements_Click(object sender, EventArgs e)
        {
            if (tb_addElements.Text != "")
            {
                if (!comboBox1.Items.Contains(tb_addElements.Text))
                {
                    comboBox1.Items.Add(tb_addElements.Text);
                    tb_addElements.Text = "";
                    MessageBox.Show("Item adicionado!");
                }
                else MessageBox.Show("Este item já existe!");
            }
            else MessageBox.Show("O item não pode ser vazio!");

        }
    }
}
