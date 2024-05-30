namespace data
{
    partial class form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_User = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(21, 20);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(43, 13);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "Usuário";
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(24, 36);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(132, 20);
            this.tb_User.TabIndex = 1;
            this.tb_User.TextChanged += new System.EventHandler(this.tb_User_TextChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(24, 111);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(132, 23);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continuar";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Location = new System.Drawing.Point(21, 69);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(38, 13);
            this.lb_Senha.TabIndex = 3;
            this.lb_Senha.Text = "Senha";
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(24, 85);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.PasswordChar = '*';
            this.tb_Senha.Size = new System.Drawing.Size(132, 20);
            this.tb_Senha.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(24, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 186);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.lb_User);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lb_Senha;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.Button btnCancelar;
    }
}