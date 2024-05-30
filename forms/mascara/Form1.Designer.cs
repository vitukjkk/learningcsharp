namespace mascara
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lb_typePass;
            this.mtb_main = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_onlyText = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_showPass = new System.Windows.Forms.CheckBox();
            lb_typePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtb_main
            // 
            this.mtb_main.Location = new System.Drawing.Point(12, 29);
            this.mtb_main.Name = "mtb_main";
            this.mtb_main.PasswordChar = '*';
            this.mtb_main.Size = new System.Drawing.Size(218, 20);
            this.mtb_main.TabIndex = 0;
            // 
            // lb_typePass
            // 
            lb_typePass.AutoSize = true;
            lb_typePass.Location = new System.Drawing.Point(13, 13);
            lb_typePass.Name = "lb_typePass";
            lb_typePass.Size = new System.Drawing.Size(86, 13);
            lb_typePass.TabIndex = 1;
            lb_typePass.Text = "Digite sua senha";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 89);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_onlyText
            // 
            this.cb_onlyText.AutoSize = true;
            this.cb_onlyText.Location = new System.Drawing.Point(106, 89);
            this.cb_onlyText.Name = "cb_onlyText";
            this.cb_onlyText.Size = new System.Drawing.Size(94, 17);
            this.cb_onlyText.TabIndex = 4;
            this.cb_onlyText.Text = "Somente texto";
            this.cb_onlyText.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "Colocar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.Location = new System.Drawing.Point(236, 29);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(51, 17);
            this.cb_showPass.TabIndex = 6;
            this.cb_showPass.Text = "Exibir";
            this.cb_showPass.UseVisualStyleBackColor = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.cb_showPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_onlyText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(lb_typePass);
            this.Controls.Add(this.mtb_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_main;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_onlyText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb_showPass;
    }
}

