namespace aprendendo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicicletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hRVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosToolStripMenuItem,
            this.motosToolStripMenuItem,
            this.naviosToolStripMenuItem,
            this.bicicletasToolStripMenuItem});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.veículosToolStripMenuItem.Text = "Veículos";
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hRVToolStripMenuItem});
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carrosToolStripMenuItem.Text = "Carros";
            // 
            // motosToolStripMenuItem
            // 
            this.motosToolStripMenuItem.Name = "motosToolStripMenuItem";
            this.motosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motosToolStripMenuItem.Text = "Motos";
            // 
            // naviosToolStripMenuItem
            // 
            this.naviosToolStripMenuItem.Name = "naviosToolStripMenuItem";
            this.naviosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.naviosToolStripMenuItem.Text = "Navios";
            // 
            // bicicletasToolStripMenuItem
            // 
            this.bicicletasToolStripMenuItem.Name = "bicicletasToolStripMenuItem";
            this.bicicletasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bicicletasToolStripMenuItem.Text = "Bicicletas";
            // 
            // hRVToolStripMenuItem
            // 
            this.hRVToolStripMenuItem.Name = "hRVToolStripMenuItem";
            this.hRVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hRVToolStripMenuItem.Text = "HRV";
            this.hRVToolStripMenuItem.Click += new System.EventHandler(this.hRVToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 415);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hRVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naviosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicicletasToolStripMenuItem;
    }
}

