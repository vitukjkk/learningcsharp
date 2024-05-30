using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newDocument()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            newDocument();
            MessageBox.Show("Novo documento criado!");
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDocument();
            MessageBox.Show("Novo documento criado!");
        }

        private void save()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arq = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter stw = new StreamWriter(arq);
                    saveFileDialog1.InitialDirectory = @"C:\\Users\\vitto\\Downloads\\PC#\\TextEditor\\arquivos";
                    stw.Flush();
                    stw.BaseStream.Seek(0, SeekOrigin.Begin);
                    stw.Write(this.richTextBox1.Text);
                    stw.Flush();
                    stw.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void open()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\vitto\\Downloads\\PC#\\TextEditor\\arquivos";
            openFileDialog1.Filter = "(*.dby)|*.dby";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arq = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader str = new StreamReader(arq);
                    str.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Clear();
                    string line = str.ReadLine();
                    while(line != null)
                    {
                        this.richTextBox1.Text += line + "\n";
                        line = str.ReadLine();
                    }
                    str.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"ERRO: {ex.Message}", "Erro ao ler o arquivo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void copy()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void paste()
        {
            richTextBox1.Paste();
        }

        private void cut()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void negrito()
        {
            string fontname = richTextBox1.Font.Name;
            float fontsize = richTextBox1.Font.Size;

            bool b = richTextBox1.SelectionFont.Bold;
            bool i = richTextBox1.SelectionFont.Italic;
            bool s = richTextBox1.SelectionFont.Underline;

            if (b == false)
            {
                if(i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if(i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Italic);
                }
                else if(i == false  & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Underline);
                }
                else if(i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Italic);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Underline);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Regular);
                }
            }
        }
        private void italico()
        {
            string fontname = richTextBox1.Font.Name;
            float fontsize = richTextBox1.Font.Size;

            bool b = richTextBox1.SelectionFont.Bold;
            bool i = richTextBox1.SelectionFont.Italic;
            bool s = richTextBox1.SelectionFont.Underline;

            if (i == false)
            {
                if (b == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (b == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Italic);
                }
                else if (b == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (b == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Italic);
                }
            }
            else
            {
                if (b == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Underline);
                }
                else if (b == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold);
                }
                else if (b == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Underline);
                }
                else if (b == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Regular);
                }
            }
        }

        private void sublinhado()
        {
            string fontname = richTextBox1.Font.Name;
            float fontsize = richTextBox1.Font.Size;

            bool b = richTextBox1.SelectionFont.Bold;
            bool i = richTextBox1.SelectionFont.Italic;
            bool s = richTextBox1.SelectionFont.Underline;

            if (s == false)
            {
                if (b == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (b == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Underline);
                }
                else if (b == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (b == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Underline);
                }
            }
            else
            {
                if (b == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold | FontStyle.Italic);
                }
                else if (b == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Bold);
                }
                else if (b == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Italic);
                }
                else if (b == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(fontname, fontsize, FontStyle.Regular);
                }
            }
        }

        private void left()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void right()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void center()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }   

        private void btn_open_Click(object sender, EventArgs e)
        {
            open();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paste();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void btn_Italico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            left();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            left();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            right();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            right();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            center();
        }

        private void btn_centro_Click(object sender, EventArgs e)
        {
            center();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            string txt = this.richTextBox1.Text;
            StringReader leitura = new StringReader(txt);
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float pagesline = 0;
            float posY = 0;
            int count = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;
            
            if(margemEsquerda < 5) { margemEsquerda = 20;  }
            if(margemSuperior < 5) { margemSuperior = 20; }
            
            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            pagesline = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            
            while(count < pagesline)
            {
                posY = (margemSuperior + (count * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, posY, new StringFormat());
                count++;
                linha = leitura.ReadLine();
            }

            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }
    }
}
