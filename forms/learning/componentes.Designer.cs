namespace learning
{
    partial class vehiclelist
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
            this.tb_02 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_02
            // 
            this.tb_02.Location = new System.Drawing.Point(13, 13);
            this.tb_02.Multiline = true;
            this.tb_02.Name = "tb_02";
            this.tb_02.Size = new System.Drawing.Size(757, 404);
            this.tb_02.TabIndex = 0;
            this.tb_02.TextChanged += new System.EventHandler(this.tb_02_TextChanged);
            // 
            // vehiclelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_02);
            this.Name = "vehiclelist";
            this.Text = "componentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.vehiclelist_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_02;
    }
}