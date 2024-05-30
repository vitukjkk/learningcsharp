using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labels
{
    public partial class linkLabel : Form
    {

        public linkLabel()
        {
            InitializeComponent();
            linkLabel1.Links.Add(0, 6, "https://google.com.br/");
            linkLabel1.Links.Add(9, 16, "https://youtube.com.br/");

            linkLabel1.Links[1].Enabled = false;
        }

        private void ll_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/vitukjkk");
            e.Link.Visited = true;
        }

        private void ll_calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link = "";
            link = "https://www.youtube.com/" + textBox1.Text;
            System.Diagnostics.Process.Start(link);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
