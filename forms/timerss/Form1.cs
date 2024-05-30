using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerss
{
    public partial class Form1 : Form
    {
        int num = 0;

        int px, py = 0;

        public Form1()
        {
            InitializeComponent();
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;
        }

        private void timer1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            label1.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = "0";
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Location.X >= 566)
            {
                pictureBox1.Location = new Point(px, py);
            }
            px += 10;
            pictureBox1.Location = new Point(px, py);
            px = pictureBox1.Location.X;
        }
    }
}
