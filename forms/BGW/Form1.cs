using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGW
{
    public partial class Form1 : Form
    {
        int count = 0;
        int max = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < max; i++)
            {
                count++;
                UpdateLabel3Text(count.ToString());
                Thread.Sleep(10);
            }
        }

        private void UpdateLabel3Text(string text)
        {
            if (label3.InvokeRequired)
            {
                label3.Invoke(new Action<string>(UpdateLabel3Text), text);
            }
            else
            {
                label3.Text = text;
            }
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Trabalho terminado!");
            label2.Text = ("Trabalho terminado!");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = "trabalhando...";
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
