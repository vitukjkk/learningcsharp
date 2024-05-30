using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
    public partial class Form1 : Form
    {
        public string home = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void navigate()
        {
            if (tb_url.Text != "")
            {
                webBrowser1.Navigate(tb_url.Text);
            }
            else
            {
                MessageBox.Show("Digite uma URL!");
                tb_url.Focus();
            }
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            navigate();
        }

        private void Ir_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                navigate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (home == "")
            {
                webBrowser1.GoHome();
            }
            else
            {
                webBrowser1.Navigate(home);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            button4.Enabled = webBrowser1.CanGoForward;
        }
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            button3.Enabled = webBrowser1.CanGoForward;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            home = tb_url.Text;
        }
    }
}
