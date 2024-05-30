namespace learning
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
            this.tb_01 = new System.Windows.Forms.TextBox();
            this.bt_01 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_03 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_01
            // 
            this.tb_01.Location = new System.Drawing.Point(15, 64);
            this.tb_01.Multiline = true;
            this.tb_01.Name = "tb_01";
            this.tb_01.Size = new System.Drawing.Size(249, 247);
            this.tb_01.TabIndex = 3;
            this.tb_01.TextChanged += new System.EventHandler(this.tb_01_TextChanged);
            // 
            // bt_01
            // 
            this.bt_01.BackColor = System.Drawing.Color.Purple;
            this.bt_01.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_01.Location = new System.Drawing.Point(162, 39);
            this.bt_01.Name = "bt_01";
            this.bt_01.Size = new System.Drawing.Size(102, 24);
            this.bt_01.TabIndex = 5;
            this.bt_01.Text = "Adicionar";
            this.bt_01.UseVisualStyleBackColor = false;
            this.bt_01.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite um veículo";
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.Color.Black;
            this.btn_02.Location = new System.Drawing.Point(15, 317);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(249, 23);
            this.btn_02.TabIndex = 9;
            this.btn_02.Text = "Limpar";
            this.btn_02.UseVisualStyleBackColor = false;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // btn_03
            // 
            this.btn_03.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_03.Location = new System.Drawing.Point(15, 346);
            this.btn_03.Name = "btn_03";
            this.btn_03.Size = new System.Drawing.Size(249, 21);
            this.btn_03.TabIndex = 10;
            this.btn_03.Text = "Mostrar veículos";
            this.btn_03.UseVisualStyleBackColor = false;
            this.btn_03.Click += new System.EventHandler(this.btn_03_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(15, 66);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(80, 17);
            this.cb.TabIndex = 12;
            this.cb.Text = "checkBox1";
            this.cb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 448);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.btn_03);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_01);
            this.Controls.Add(this.tb_01);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "ola mundo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_01;
        private System.Windows.Forms.Button bt_01;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_03;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox cb;
    }
}

