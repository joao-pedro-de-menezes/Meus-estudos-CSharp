namespace While_Numeros
{
    partial class frmLoopingWhile
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
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.numLimite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExibir
            // 
            this.btnExibir.Image = global::While_Numeros.Properties.Resources.Start;
            this.btnExibir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExibir.Location = new System.Drawing.Point(71, 82);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(73, 50);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(71, 152);
            this.txtExibir.Multiline = true;
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExibir.Size = new System.Drawing.Size(215, 179);
            this.txtExibir.TabIndex = 1;
            this.txtExibir.TextChanged += new System.EventHandler(this.txtExibir_TextChanged);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(71, 27);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(81, 13);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Informe o Limite";
            // 
            // numLimite
            // 
            this.numLimite.Location = new System.Drawing.Point(171, 27);
            this.numLimite.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLimite.Name = "numLimite";
            this.numLimite.Size = new System.Drawing.Size(120, 20);
            this.numLimite.TabIndex = 3;
            // 
            // frmLoopingWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 357);
            this.Controls.Add(this.numLimite);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.btnExibir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmLoopingWhile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de números com looping While";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtExibir;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.NumericUpDown numLimite;
    }
}

