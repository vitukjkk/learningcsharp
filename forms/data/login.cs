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
    public partial class form_Login : Form
    {
        main form1;
        DataTable dt = new DataTable();
        public form_Login(Form f)
        {
            InitializeComponent();
            form1 = (main)f;
            defTabs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getLogin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {
            
        }

        internal void defTabs()
        {
            tb_User.TabIndex = 0;
            tb_Senha.TabIndex = 1;
            btnContinue.TabIndex = 2;
            btnCancelar.TabIndex = 3;
        }

        internal void getLogin()
        {
            string user = tb_User.Text;
            string senha = tb_Senha.Text;

            if (user == "" || senha == "")
            {
                MessageBox.Show("Você precisa digitar um usuário e senha!");
                tb_User.Focus();
                return;
            }

            string sql = $"SELECT * FROM users WHERE name = '{user}' AND senha = '{senha}'";
            dt = banco.query(sql);
            if (dt.Rows.Count != 0)
            {
                form1.label2.Text = dt.Rows[0].ItemArray[4].ToString();
                form1.pictureBox1.Image = data.Properties.Resources.lampada;
                form1.label4.Text = user;
                globais.name = user;
                globais.logado = true;
                globais.nivel = Convert.ToInt32(dt.Rows[0].ItemArray[4]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
                tb_User.Focus();
            }
        }
    }
}
