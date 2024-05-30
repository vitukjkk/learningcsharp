using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aprendendo
{
    public partial class Form3 : Form
    {

        public Form2 fcb;

        public Form3()
        {
            InitializeComponent();

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
