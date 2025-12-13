namespace while_Mover_Imagem
{
    partial class frmWhileMover
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
            this.btnExibir = new System.Windows.Forms.Button();
            this.picWhileMover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWhileMover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(31, 67);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(89, 47);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // picWhileMover
            // 
            this.picWhileMover.Image = global::while_Mover_Imagem.Properties.Resources.Captura_de_tela_2025_11_07_193542;
            this.picWhileMover.Location = new System.Drawing.Point(158, 82);
            this.picWhileMover.Name = "picWhileMover";
            this.picWhileMover.Size = new System.Drawing.Size(30, 23);
            this.picWhileMover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWhileMover.TabIndex = 1;
            this.picWhileMover.TabStop = false;
            // 
            // frmWhileMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 577);
            this.Controls.Add(this.picWhileMover);
            this.Controls.Add(this.btnExibir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWhileMover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mover imagem com o looping while";
            ((System.ComponentModel.ISupportInitialize)(this.picWhileMover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.PictureBox picWhileMover;
    }
}

