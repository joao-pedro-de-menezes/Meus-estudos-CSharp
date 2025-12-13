namespace Lucky7
{
    partial class frmLucky7
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.picLucky7 = new System.Windows.Forms.PictureBox();
            this.btnFim = new System.Windows.Forms.Button();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.grbReumo = new System.Windows.Forms.GroupBox();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.txtAcertos = new System.Windows.Forms.TextBox();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.txtTentativas = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLucky7)).BeginInit();
            this.grbReumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(157, 43);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(74, 74);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "0";
            this.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero2
            // 
            this.lblNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(237, 43);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(74, 74);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "0";
            this.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero3
            // 
            this.lblNumero3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero3.Location = new System.Drawing.Point(317, 43);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(74, 74);
            this.lblNumero3.TabIndex = 1;
            this.lblNumero3.Text = "0";
            this.lblNumero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLucky7
            // 
            this.picLucky7.Image = global::Lucky7.Properties.Resources.PayCoins;
            this.picLucky7.Location = new System.Drawing.Point(157, 130);
            this.picLucky7.Name = "picLucky7";
            this.picLucky7.Size = new System.Drawing.Size(234, 206);
            this.picLucky7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLucky7.TabIndex = 2;
            this.picLucky7.TabStop = false;
            // 
            // btnFim
            // 
            this.btnFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFim.Image = global::Lucky7.Properties.Resources.Sair;
            this.btnFim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFim.Location = new System.Drawing.Point(12, 73);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(91, 55);
            this.btnFim.TabIndex = 0;
            this.btnFim.Text = "Fim";
            this.btnFim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // btnSorteio
            // 
            this.btnSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteio.Image = global::Lucky7.Properties.Resources.Order_Alt_32;
            this.btnSorteio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSorteio.Location = new System.Drawing.Point(12, 12);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(91, 55);
            this.btnSorteio.TabIndex = 0;
            this.btnSorteio.Text = "Sorteio";
            this.btnSorteio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // grbReumo
            // 
            this.grbReumo.Controls.Add(this.txtTentativas);
            this.grbReumo.Controls.Add(this.txtAcertos);
            this.grbReumo.Controls.Add(this.lblTentativas);
            this.grbReumo.Controls.Add(this.lblAcertos);
            this.grbReumo.Location = new System.Drawing.Point(199, 380);
            this.grbReumo.Name = "grbReumo";
            this.grbReumo.Size = new System.Drawing.Size(147, 120);
            this.grbReumo.TabIndex = 3;
            this.grbReumo.TabStop = false;
            this.grbReumo.Text = "Resumo";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Location = new System.Drawing.Point(14, 36);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(46, 13);
            this.lblAcertos.TabIndex = 0;
            this.lblAcertos.Text = "Acertos:";
            // 
            // txtAcertos
            // 
            this.txtAcertos.Location = new System.Drawing.Point(66, 33);
            this.txtAcertos.Name = "txtAcertos";
            this.txtAcertos.ReadOnly = true;
            this.txtAcertos.Size = new System.Drawing.Size(52, 20);
            this.txtAcertos.TabIndex = 1;
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Location = new System.Drawing.Point(6, 73);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(60, 13);
            this.lblTentativas.TabIndex = 0;
            this.lblTentativas.Text = "Tentativas:";
            // 
            // txtTentativas
            // 
            this.txtTentativas.Location = new System.Drawing.Point(66, 70);
            this.txtTentativas.Name = "txtTentativas";
            this.txtTentativas.ReadOnly = true;
            this.txtTentativas.Size = new System.Drawing.Size(52, 20);
            this.txtTentativas.TabIndex = 1;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(234, 352);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 0;
            // 
            // frmLucky7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(430, 528);
            this.Controls.Add(this.grbReumo);
            this.Controls.Add(this.picLucky7);
            this.Controls.Add(this.lblNumero3);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.btnSorteio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLucky7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Seven";
            ((System.ComponentModel.ISupportInitialize)(this.picLucky7)).EndInit();
            this.grbReumo.ResumeLayout(false);
            this.grbReumo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.Button btnFim;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblNumero3;
        private System.Windows.Forms.PictureBox picLucky7;
        private System.Windows.Forms.GroupBox grbReumo;
        private System.Windows.Forms.TextBox txtTentativas;
        private System.Windows.Forms.TextBox txtAcertos;
        private System.Windows.Forms.Label lblTentativas;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblMensagem;
    }
}

