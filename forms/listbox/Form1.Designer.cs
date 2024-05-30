namespace listbox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clista = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            cx_add = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // clista
            // 
            clista.FormattingEnabled = true;
            clista.Items.AddRange(new object[] { "Carro", "Avião", "Ônibus", "Navio", "Trem\t\t\t" });
            clista.Location = new Point(13, 8);
            clista.Name = "clista";
            clista.Size = new Size(120, 238);
            clista.TabIndex = 0;
            clista.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(152, 8);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 1;
            button1.Text = "Mostrar selecionados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 37);
            button2.Name = "button2";
            button2.Size = new Size(141, 23);
            button2.TabIndex = 2;
            button2.Text = "Limpar lista";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(152, 66);
            button3.Name = "button3";
            button3.Size = new Size(141, 23);
            button3.TabIndex = 3;
            button3.Text = "Resetar lista";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 131);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 4;
            label1.Text = "Digite um novo transporte";
            // 
            // cx_add
            // 
            cx_add.Location = new Point(152, 149);
            cx_add.Name = "cx_add";
            cx_add.Size = new Size(141, 23);
            cx_add.TabIndex = 5;
            cx_add.TextChanged += textBox1_TextChanged_1;
            // 
            // button4
            // 
            button4.Location = new Point(152, 178);
            button4.Name = "button4";
            button4.Size = new Size(141, 23);
            button4.TabIndex = 6;
            button4.Text = "Adicionar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 260);
            Controls.Add(button4);
            Controls.Add(cx_add);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(clista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clista;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox cx_add;
        private Button button4;
    }
}
