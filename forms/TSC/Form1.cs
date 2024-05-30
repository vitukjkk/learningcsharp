using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<ToolStrip> bf = new List<ToolStrip>();
            int num = toolStripContainer1.TopToolStripPanel.Controls.Count;

            for (int i = 0; i < num; i++)
            {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i].Name);
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void toolStripContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
