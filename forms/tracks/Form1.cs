using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tracks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int track = int.Parse(textBox1.Text);
            if(track < trackBar1.Minimum | track > trackBar1.Maximum)
            {
                MessageBox.Show("Os valores devem estar entre 0-100!");
                return;
            }
            trackBar1.Value = track;
            label1.Text = textBox1.Text;
        }
    }
}
