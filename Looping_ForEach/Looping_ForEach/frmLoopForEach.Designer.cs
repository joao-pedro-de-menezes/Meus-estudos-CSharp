namespace Looping_ForEach
{
    partial class frmLoopForEach
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
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.numPrecoCusto = new System.Windows.Forms.NumericUpDown();
            this.lblPercentualAumento = new System.Windows.Forms.Label();
            this.numPercentualAumento = new System.Windows.Forms.NumericUpDown();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.grbOpcoes.SuspendLayout();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentualAumento)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnNovo);
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnCancelar);
            this.grbOpcoes.Controls.Add(this.btnConfirmar);
            this.grbOpcoes.Location = new System.Drawing.Point(12, 12);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(444, 132);
            this.grbOpcoes.TabIndex = 0;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Looping_ForEach.Properties.Resources.Novo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(24, 38);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 51);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Looping_ForEach.Properties.Resources.Sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(330, 38);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 51);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Looping_ForEach.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(228, 38);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 51);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Looping_ForEach.Properties.Resources.Confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(126, 38);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 51);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.numPrecoCusto);
            this.grbDados.Controls.Add(this.lblCusto);
            this.grbDados.Controls.Add(this.numPercentualAumento);
            this.grbDados.Controls.Add(this.lblPercentualAumento);
            this.grbDados.Controls.Add(this.cmbProduto);
            this.grbDados.Controls.Add(this.lblProduto);
            this.grbDados.Controls.Add(this.txtCodigo);
            this.grbDados.Controls.Add(this.lblCodigo);
            this.grbDados.Location = new System.Drawing.Point(12, 181);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(444, 138);
            this.grbDados.TabIndex = 1;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(70, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(21, 66);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(70, 63);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(217, 21);
            this.cmbProduto.TabIndex = 3;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(21, 99);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(37, 13);
            this.lblCusto.TabIndex = 4;
            this.lblCusto.Text = "Custo:";
            // 
            // numPrecoCusto
            // 
            this.numPrecoCusto.DecimalPlaces = 2;
            this.numPrecoCusto.Location = new System.Drawing.Point(70, 97);
            this.numPrecoCusto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecoCusto.Name = "numPrecoCusto";
            this.numPrecoCusto.Size = new System.Drawing.Size(86, 20);
            this.numPrecoCusto.TabIndex = 5;
            // 
            // lblPercentualAumento
            // 
            this.lblPercentualAumento.AutoSize = true;
            this.lblPercentualAumento.Location = new System.Drawing.Point(187, 99);
            this.lblPercentualAumento.Name = "lblPercentualAumento";
            this.lblPercentualAumento.Size = new System.Drawing.Size(77, 13);
            this.lblPercentualAumento.TabIndex = 2;
            this.lblPercentualAumento.Text = "% de aumento:";
            // 
            // numPercentualAumento
            // 
            this.numPercentualAumento.DecimalPlaces = 2;
            this.numPercentualAumento.Location = new System.Drawing.Point(270, 97);
            this.numPercentualAumento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPercentualAumento.Name = "numPercentualAumento";
            this.numPercentualAumento.Size = new System.Drawing.Size(54, 20);
            this.numPercentualAumento.TabIndex = 3;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(109, 360);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(86, 13);
            this.lblPrecoVenda.TabIndex = 4;
            this.lblPrecoVenda.Text = "Preço da venda:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(202, 360);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.ReadOnly = true;
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda.TabIndex = 5;
            // 
            // frmLoopForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(480, 404);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.grbOpcoes);
            this.MinimizeBox = false;
            this.Name = "frmLoopForEach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Looping com ForEach";
            this.Load += new System.EventHandler(this.frmLoopForEach_Load);
            this.grbOpcoes.ResumeLayout(false);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentualAumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.NumericUpDown numPrecoCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPercentualAumento;
        private System.Windows.Forms.NumericUpDown numPercentualAumento;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
    }
}

