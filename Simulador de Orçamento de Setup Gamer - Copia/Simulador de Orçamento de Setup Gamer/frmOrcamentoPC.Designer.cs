namespace Simulador_de_Orçamento_de_Setup_Gamer
{
    partial class frmOrcamento
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
            this.lblProcessador = new System.Windows.Forms.Label();
            this.lblPlacaDeVideo = new System.Windows.Forms.Label();
            this.lblMemoriaRam = new System.Windows.Forms.Label();
            this.cmbProcessador = new System.Windows.Forms.ComboBox();
            this.cmbPlacaDeVideo = new System.Windows.Forms.ComboBox();
            this.cmbMemoriaRam = new System.Windows.Forms.ComboBox();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.chkMontagem = new System.Windows.Forms.CheckBox();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessador
            // 
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.Location = new System.Drawing.Point(47, 46);
            this.lblProcessador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(96, 16);
            this.lblProcessador.TabIndex = 0;
            this.lblProcessador.Text = "Processador";
            // 
            // lblPlacaDeVideo
            // 
            this.lblPlacaDeVideo.AutoSize = true;
            this.lblPlacaDeVideo.Location = new System.Drawing.Point(47, 74);
            this.lblPlacaDeVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacaDeVideo.Name = "lblPlacaDeVideo";
            this.lblPlacaDeVideo.Size = new System.Drawing.Size(114, 16);
            this.lblPlacaDeVideo.TabIndex = 0;
            this.lblPlacaDeVideo.Text = "Placa de Video";
            // 
            // lblMemoriaRam
            // 
            this.lblMemoriaRam.AutoSize = true;
            this.lblMemoriaRam.Location = new System.Drawing.Point(47, 102);
            this.lblMemoriaRam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemoriaRam.Name = "lblMemoriaRam";
            this.lblMemoriaRam.Size = new System.Drawing.Size(103, 16);
            this.lblMemoriaRam.TabIndex = 0;
            this.lblMemoriaRam.Text = "Memória Ram";
            // 
            // cmbProcessador
            // 
            this.cmbProcessador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcessador.FormattingEnabled = true;
            this.cmbProcessador.Location = new System.Drawing.Point(14, 19);
            this.cmbProcessador.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProcessador.MaxDropDownItems = 100;
            this.cmbProcessador.Name = "cmbProcessador";
            this.cmbProcessador.Size = new System.Drawing.Size(269, 24);
            this.cmbProcessador.TabIndex = 1;
            // 
            // cmbPlacaDeVideo
            // 
            this.cmbPlacaDeVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlacaDeVideo.FormattingEnabled = true;
            this.cmbPlacaDeVideo.Location = new System.Drawing.Point(14, 47);
            this.cmbPlacaDeVideo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlacaDeVideo.MaxDropDownItems = 100;
            this.cmbPlacaDeVideo.Name = "cmbPlacaDeVideo";
            this.cmbPlacaDeVideo.Size = new System.Drawing.Size(269, 24);
            this.cmbPlacaDeVideo.TabIndex = 2;
            // 
            // cmbMemoriaRam
            // 
            this.cmbMemoriaRam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoriaRam.FormattingEnabled = true;
            this.cmbMemoriaRam.Location = new System.Drawing.Point(14, 75);
            this.cmbMemoriaRam.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMemoriaRam.MaxDropDownItems = 100;
            this.cmbMemoriaRam.Name = "cmbMemoriaRam";
            this.cmbMemoriaRam.Size = new System.Drawing.Size(269, 24);
            this.cmbMemoriaRam.TabIndex = 4;
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.cmbMemoriaRam);
            this.grbOpcoes.Controls.Add(this.cmbPlacaDeVideo);
            this.grbOpcoes.Controls.Add(this.cmbProcessador);
            this.grbOpcoes.Location = new System.Drawing.Point(199, 27);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(290, 116);
            this.grbOpcoes.TabIndex = 4;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::Simulador_de_Orçamento_de_Setup_Gamer.Properties.Resources.Calc;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(162, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 60);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrcamento.Location = new System.Drawing.Point(82, 283);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.ReadOnly = true;
            this.txtOrcamento.Size = new System.Drawing.Size(270, 22);
            this.txtOrcamento.TabIndex = 0;
            // 
            // chkMontagem
            // 
            this.chkMontagem.AutoSize = true;
            this.chkMontagem.Location = new System.Drawing.Point(63, 329);
            this.chkMontagem.Name = "chkMontagem";
            this.chkMontagem.Size = new System.Drawing.Size(336, 20);
            this.chkMontagem.TabIndex = 6;
            this.chkMontagem.Text = "Incluir Montagem e Formatação (+ R$ 150,00)";
            this.chkMontagem.UseVisualStyleBackColor = true;
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 361);
            this.Controls.Add(this.chkMontagem);
            this.Controls.Add(this.txtOrcamento);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.lblMemoriaRam);
            this.Controls.Add(this.lblPlacaDeVideo);
            this.Controls.Add(this.lblProcessador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monte seu PC e descubra o preço!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessador;
        private System.Windows.Forms.Label lblPlacaDeVideo;
        private System.Windows.Forms.Label lblMemoriaRam;
        private System.Windows.Forms.ComboBox cmbProcessador;
        private System.Windows.Forms.ComboBox cmbPlacaDeVideo;
        private System.Windows.Forms.ComboBox cmbMemoriaRam;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.CheckBox chkMontagem;
    }
}

