namespace While_Numero_Par
{
    partial class frmWhileNumero_Par
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
            this.numLimite = new System.Windows.Forms.NumericUpDown();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // numLimite
            // 
            this.numLimite.Location = new System.Drawing.Point(165, 23);
            this.numLimite.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLimite.Name = "numLimite";
            this.numLimite.Size = new System.Drawing.Size(120, 20);
            this.numLimite.TabIndex = 7;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(65, 23);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(81, 13);
            this.lblLimite.TabIndex = 6;
            this.lblLimite.Text = "Informe o Limite";
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(65, 148);
            this.txtExibir.Multiline = true;
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExibir.Size = new System.Drawing.Size(215, 179);
            this.txtExibir.TabIndex = 5;
            // 
            // btnExibir
            // 
            this.btnExibir.Image = global::While_Numero_Par.Properties.Resources.Start;
            this.btnExibir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExibir.Location = new System.Drawing.Point(65, 78);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(73, 50);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // frmWhileNumero_Par
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 367);
            this.Controls.Add(this.numLimite);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.btnExibir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWhileNumero_Par";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox txtExibir;
        private System.Windows.Forms.Button btnExibir;
    }
}

