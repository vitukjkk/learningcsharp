namespace comboBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_addElements = new System.Windows.Forms.TextBox();
            this.btn_showSelected = new System.Windows.Forms.Button();
            this.btn_clearElements = new System.Windows.Forms.Button();
            this.btn_resetElements = new System.Windows.Forms.Button();
            this.btn_addElements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Caro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tb_addElements
            // 
            this.tb_addElements.Location = new System.Drawing.Point(282, 120);
            this.tb_addElements.Name = "tb_addElements";
            this.tb_addElements.Size = new System.Drawing.Size(219, 20);
            this.tb_addElements.TabIndex = 1;
            // 
            // btn_showSelected
            // 
            this.btn_showSelected.Location = new System.Drawing.Point(282, 13);
            this.btn_showSelected.Name = "btn_showSelected";
            this.btn_showSelected.Size = new System.Drawing.Size(219, 23);
            this.btn_showSelected.TabIndex = 2;
            this.btn_showSelected.Text = "Mostrar selecionado";
            this.btn_showSelected.UseVisualStyleBackColor = true;
            this.btn_showSelected.Click += new System.EventHandler(this.btn_showSelected_Click);
            // 
            // btn_clearElements
            // 
            this.btn_clearElements.Location = new System.Drawing.Point(282, 52);
            this.btn_clearElements.Name = "btn_clearElements";
            this.btn_clearElements.Size = new System.Drawing.Size(219, 23);
            this.btn_clearElements.TabIndex = 3;
            this.btn_clearElements.Text = "Limpar elementos";
            this.btn_clearElements.UseVisualStyleBackColor = true;
            this.btn_clearElements.Click += new System.EventHandler(this.btn_clearElements_Click);
            // 
            // btn_resetElements
            // 
            this.btn_resetElements.Location = new System.Drawing.Point(282, 91);
            this.btn_resetElements.Name = "btn_resetElements";
            this.btn_resetElements.Size = new System.Drawing.Size(219, 23);
            this.btn_resetElements.TabIndex = 4;
            this.btn_resetElements.Text = "Resetar";
            this.btn_resetElements.UseVisualStyleBackColor = true;
            this.btn_resetElements.Click += new System.EventHandler(this.btn_resetElements_Click);
            // 
            // btn_addElements
            // 
            this.btn_addElements.Location = new System.Drawing.Point(282, 146);
            this.btn_addElements.Name = "btn_addElements";
            this.btn_addElements.Size = new System.Drawing.Size(219, 23);
            this.btn_addElements.TabIndex = 5;
            this.btn_addElements.Text = "Adicionar";
            this.btn_addElements.UseVisualStyleBackColor = true;
            this.btn_addElements.Click += new System.EventHandler(this.btn_addElements_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.btn_addElements);
            this.Controls.Add(this.btn_resetElements);
            this.Controls.Add(this.btn_clearElements);
            this.Controls.Add(this.btn_showSelected);
            this.Controls.Add(this.tb_addElements);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_addElements;
        private System.Windows.Forms.Button btn_showSelected;
        private System.Windows.Forms.Button btn_clearElements;
        private System.Windows.Forms.Button btn_resetElements;
        private System.Windows.Forms.Button btn_addElements;
    }
}

