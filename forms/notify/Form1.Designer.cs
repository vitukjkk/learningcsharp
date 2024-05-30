namespace notify
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menunotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Message = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.menunotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.menunotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menunotificacoes
            // 
            this.menunotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Restaurar,
            this.tsmi_Message,
            this.tsmi_Close});
            this.menunotificacoes.Name = "menunotificacoes";
            this.menunotificacoes.Size = new System.Drawing.Size(181, 92);
            this.menunotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menunotificacoes_ItemClicked);
            // 
            // tsmi_Restaurar
            // 
            this.tsmi_Restaurar.Name = "tsmi_Restaurar";
            this.tsmi_Restaurar.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Restaurar.Text = "Restaurar";
            // 
            // tsmi_Message
            // 
            this.tsmi_Message.Name = "tsmi_Message";
            this.tsmi_Message.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Message.Text = "Mensagem";
            // 
            // tsmi_Close
            // 
            this.tsmi_Close.Name = "tsmi_Close";
            this.tsmi_Close.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Close.Text = "Fechar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Menu notificações";
            this.menunotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip menunotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Message;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Close;
    }
}

