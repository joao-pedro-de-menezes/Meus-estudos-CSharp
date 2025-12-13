namespace While_Barra_Progresso
{
    partial class frmWhileProgress
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
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblLimite = new System.Windows.Forms.Label();
            this.numLimite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbBarra
            // 
            this.pgbBarra.Location = new System.Drawing.Point(162, 203);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(174, 22);
            this.pgbBarra.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::While_Barra_Progresso.Properties.Resources.Fechar1;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(250, 108);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 47);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Image = global::While_Barra_Progresso.Properties.Resources.Start;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(127, 108);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 47);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(159, 58);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(34, 13);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Limite";
            // 
            // numLimite
            // 
            this.numLimite.Location = new System.Drawing.Point(199, 56);
            this.numLimite.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLimite.Name = "numLimite";
            this.numLimite.Size = new System.Drawing.Size(120, 20);
            this.numLimite.TabIndex = 4;
            // 
            // frmWhileProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 351);
            this.Controls.Add(this.numLimite);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.pgbBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWhileProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barra de Progresso com loop while";
            this.Load += new System.EventHandler(this.frmWhileProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.NumericUpDown numLimite;
    }
}

