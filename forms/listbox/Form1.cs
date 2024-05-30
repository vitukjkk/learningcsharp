using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string n in clista.CheckedItems)
            {
                txt += n + ", ";
            }

            MessageBox.Show(txt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clista.Items.Clear();
            MessageBox.Show("Limpado com sucesso!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ADICIONANDO UM POR UM
            /*
            clista.Items.Add("Carro", false);
            clista.Items.Add("Avião", false);
            clista.Items.Add("Navio", false);
            clista.Items.Add("Trem", false);
            */

            List<string> elements = new List<string>();

            elements.Add("Carro");
            elements.Add("Ônibus");
            elements.Add("Avião");
            elements.Add("Trem");
            elements.Add("Navio");

            clista.Items.AddRange(elements.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cx_add.Text == null)
            {
                MessageBox.Show("Você precisa digitar algo!");

            }
            else
            {
                clista.Items.Add(cx_add.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
