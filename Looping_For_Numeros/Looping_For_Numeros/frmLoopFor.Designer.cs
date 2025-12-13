namespace Looping_For_Numeros
{
    partial class frmLoopFor
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
            this.lblNumeroInicial = new System.Windows.Forms.Label();
            this.txtNumeroInicial = new System.Windows.Forms.TextBox();
            this.lblNumeroFinal = new System.Windows.Forms.Label();
            this.txtNumeroFinal = new System.Windows.Forms.TextBox();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.picIniciar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroInicial
            // 
            this.lblNumeroInicial.AutoSize = true;
            this.lblNumeroInicial.Location = new System.Drawing.Point(42, 231);
            this.lblNumeroInicial.Name = "lblNumeroInicial";
            this.lblNumeroInicial.Size = new System.Drawing.Size(76, 13);
            this.lblNumeroInicial.TabIndex = 1;
            this.lblNumeroInicial.Text = "Número inicial:";
            // 
            // txtNumeroInicial
            // 
            this.txtNumeroInicial.Location = new System.Drawing.Point(124, 228);
            this.txtNumeroInicial.Name = "txtNumeroInicial";
            this.txtNumeroInicial.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroInicial.TabIndex = 2;
            this.txtNumeroInicial.TextChanged += new System.EventHandler(this.txtNumeroInicial_TextChanged);
            // 
            // lblNumeroFinal
            // 
            this.lblNumeroFinal.AutoSize = true;
            this.lblNumeroFinal.Location = new System.Drawing.Point(254, 231);
            this.lblNumeroFinal.Name = "lblNumeroFinal";
            this.lblNumeroFinal.Size = new System.Drawing.Size(69, 13);
            this.lblNumeroFinal.TabIndex = 3;
            this.lblNumeroFinal.Text = "Número final:";
            // 
            // txtNumeroFinal
            // 
            this.txtNumeroFinal.Location = new System.Drawing.Point(329, 228);
            this.txtNumeroFinal.Name = "txtNumeroFinal";
            this.txtNumeroFinal.Size = new System.Drawing.Size(87, 20);
            this.txtNumeroFinal.TabIndex = 4;
            // 
            // picSair
            // 
            this.picSair.Image = global::Looping_For_Numeros.Properties.Resources.exit;
            this.picSair.Location = new System.Drawing.Point(257, 273);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(89, 73);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSair.TabIndex = 6;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // picIniciar
            // 
            this.picIniciar.Image = global::Looping_For_Numeros.Properties.Resources.start_button;
            this.picIniciar.Location = new System.Drawing.Point(101, 273);
            this.picIniciar.Name = "picIniciar";
            this.picIniciar.Size = new System.Drawing.Size(89, 73);
            this.picIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIniciar.TabIndex = 5;
            this.picIniciar.TabStop = false;
            this.picIniciar.Click += new System.EventHandler(this.picIniciar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Looping_For_Numeros.Properties.Resources.logo_for;
            this.picLogo.Location = new System.Drawing.Point(47, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(373, 185);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(101, 371);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumeros.Size = new System.Drawing.Size(245, 118);
            this.txtNumeros.TabIndex = 7;
            // 
            // frmLoopFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 501);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.picIniciar);
            this.Controls.Add(this.txtNumeroFinal);
            this.Controls.Add(this.lblNumeroFinal);
            this.Controls.Add(this.txtNumeroInicial);
            this.Controls.Add(this.lblNumeroInicial);
            this.Controls.Add(this.picLogo);
            this.MinimizeBox = false;
            this.Name = "frmLoopFor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Looping de números com o looping for";
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNumeroInicial;
        private System.Windows.Forms.TextBox txtNumeroInicial;
        private System.Windows.Forms.Label lblNumeroFinal;
        private System.Windows.Forms.TextBox txtNumeroFinal;
        private System.Windows.Forms.PictureBox picIniciar;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.TextBox txtNumeros;
    }
}

