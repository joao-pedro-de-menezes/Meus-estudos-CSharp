namespace PrecoPorCor
{
    partial class frmPrecosPorCor
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
            this.lblCor = new System.Windows.Forms.Label();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(12, 29);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(81, 13);
            this.lblCor.TabIndex = 0;
            this.lblCor.Text = "Selecione a cor";
            // 
            // cmbCor
            // 
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Items.AddRange(new object[] {
            "Verde",
            "Azul",
            "Amarelo",
            "Vermelho"});
            this.cmbCor.Location = new System.Drawing.Point(99, 26);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(121, 21);
            this.cmbCor.TabIndex = 1;
            this.cmbCor.SelectedIndexChanged += new System.EventHandler(this.cmbCor_SelectedIndexChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExibir.Location = new System.Drawing.Point(99, 71);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 36);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(12, 177);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(42, 13);
            this.lblMostrar.TabIndex = 3;
            this.lblMostrar.Text = "Mostrar";
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(12, 193);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(385, 20);
            this.txtMostrar.TabIndex = 4;
            // 
            // frmPrecosPorCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 254);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.cmbCor);
            this.Controls.Add(this.lblCor);
            this.MaximizeBox = false;
            this.Name = "frmPrecosPorCor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preços por cor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.TextBox txtMostrar;
    }
}

