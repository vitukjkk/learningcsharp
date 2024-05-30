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
    public partial class newuser : Form
    {
        public newuser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            if (banco.usersExists(tb_Name.Text) == true)
            {
                MessageBox.Show("Usuario já existe!");
                return;
            }
            else
            {
                user usuario = new user();

                usuario.name = tb_Name.Text;
                usuario.senha = tb_Senha.Text;
                usuario.status = cb_Status.SelectedIndex.ToString();
                usuario.level = Convert.ToInt32(Math.Round(n_Level.Value, 0));

                banco.newuser(usuario);

                tb_Name.Clear();
                tb_Senha.Clear();
                cb_Status.Text = "";
                n_Level.Value = 0;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Senha.Clear();
            cb_Status.Text = "";
            n_Level.Value = 0;
            this.Close();
        }

        private void newuser_Load(object sender, EventArgs e)
        {

        }
    }
}
