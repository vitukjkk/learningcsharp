using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_Data.Text = dtp_01.Text;

            tb_Dia.Text = dtp_01.Value.Day.ToString();
            tb_Mes.Text = dtp_01.Value.Month.ToString();
            tb_Ano.Text = dtp_01.Value.Year.ToString();

            MessageBox.Show("Data obtida com sucesso!");
        }
        private void tb_Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_setarData_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = m = a = 0;

            d = Convert.ToInt32(tb_Dia.Text);
            m = Convert.ToInt32(tb_Mes.Text);
            a = Convert.ToInt32(tb_Ano.Text);

            DateTime dt = new DateTime(a, m, d);

            dtp_01.Value = dt;
        }

        private void btn_Today_Click(object sender, EventArgs e)
        {
            dtp_01.Value = DateTime.Now;
        }
    }
}

