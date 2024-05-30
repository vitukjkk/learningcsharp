namespace datetime
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
            this.dtp_01 = new System.Windows.Forms.DateTimePicker();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.tb_Mes = new System.Windows.Forms.TextBox();
            this.tb_Ano = new System.Windows.Forms.TextBox();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_Today = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_01
            // 
            this.dtp_01.Location = new System.Drawing.Point(13, 13);
            this.dtp_01.Name = "dtp_01";
            this.dtp_01.Size = new System.Drawing.Size(275, 20);
            this.dtp_01.TabIndex = 0;
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(294, 10);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(191, 23);
            this.btn_obterData.TabIndex = 1;
            this.btn_obterData.Text = "Obter data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // tb_Data
            // 
            this.tb_Data.Location = new System.Drawing.Point(13, 40);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Size = new System.Drawing.Size(275, 20);
            this.tb_Data.TabIndex = 2;
            this.tb_Data.TextChanged += new System.EventHandler(this.tb_Data_TextChanged);
            // 
            // tb_Dia
            // 
            this.tb_Dia.Location = new System.Drawing.Point(13, 66);
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(90, 20);
            this.tb_Dia.TabIndex = 3;
            // 
            // tb_Mes
            // 
            this.tb_Mes.Location = new System.Drawing.Point(109, 66);
            this.tb_Mes.Name = "tb_Mes";
            this.tb_Mes.Size = new System.Drawing.Size(90, 20);
            this.tb_Mes.TabIndex = 4;
            // 
            // tb_Ano
            // 
            this.tb_Ano.Location = new System.Drawing.Point(205, 66);
            this.tb_Ano.Name = "tb_Ano";
            this.tb_Ano.Size = new System.Drawing.Size(83, 20);
            this.tb_Ano.TabIndex = 5;
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(294, 66);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(191, 21);
            this.btn_setarData.TabIndex = 6;
            this.btn_setarData.Text = "Adicionar data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_Today
            // 
            this.btn_Today.Location = new System.Drawing.Point(294, 39);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(191, 21);
            this.btn_Today.TabIndex = 7;
            this.btn_Today.Text = "Hoje";
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 97);
            this.Controls.Add(this.btn_Today);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.tb_Ano);
            this.Controls.Add(this.tb_Mes);
            this.Controls.Add(this.tb_Dia);
            this.Controls.Add(this.tb_Data);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.dtp_01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_01;
        private System.Windows.Forms.Button btn_obterData;
        private System.Windows.Forms.TextBox tb_Data;
        private System.Windows.Forms.TextBox tb_Dia;
        private System.Windows.Forms.TextBox tb_Mes;
        private System.Windows.Forms.TextBox tb_Ano;
        private System.Windows.Forms.Button btn_setarData;
        private System.Windows.Forms.Button btn_Today;
    }
}

