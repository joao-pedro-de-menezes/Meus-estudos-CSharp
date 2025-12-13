namespace Preco_Vendas
{
    partial class Form1
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
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.numCusto = new System.Windows.Forms.NumericUpDown();
            this.lblPercentualLucro = new System.Windows.Forms.Label();
            this.numPercentualLucro = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblValorAumento = new System.Windows.Forms.Label();
            this.txtValorAumento = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentualLucro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(42, 37);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(45, 53);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(215, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(42, 113);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(34, 13);
            this.lblCusto.TabIndex = 2;
            this.lblCusto.Text = "Custo";
            this.lblCusto.Click += new System.EventHandler(this.label1_Click);
            // 
            // numCusto
            // 
            this.numCusto.DecimalPlaces = 2;
            this.numCusto.Location = new System.Drawing.Point(45, 129);
            this.numCusto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCusto.Name = "numCusto";
            this.numCusto.Size = new System.Drawing.Size(120, 20);
            this.numCusto.TabIndex = 3;
            // 
            // lblPercentualLucro
            // 
            this.lblPercentualLucro.AutoSize = true;
            this.lblPercentualLucro.Location = new System.Drawing.Point(209, 113);
            this.lblPercentualLucro.Name = "lblPercentualLucro";
            this.lblPercentualLucro.Size = new System.Drawing.Size(65, 13);
            this.lblPercentualLucro.TabIndex = 4;
            this.lblPercentualLucro.Text = "% de Lucros";
            // 
            // numPercentualLucro
            // 
            this.numPercentualLucro.DecimalPlaces = 2;
            this.numPercentualLucro.Location = new System.Drawing.Point(212, 129);
            this.numPercentualLucro.Name = "numPercentualLucro";
            this.numPercentualLucro.Size = new System.Drawing.Size(68, 20);
            this.numPercentualLucro.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(45, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 43);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpar.Location = new System.Drawing.Point(126, 206);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 43);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.Location = new System.Drawing.Point(207, 206);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 43);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblValorAumento
            // 
            this.lblValorAumento.AutoSize = true;
            this.lblValorAumento.Location = new System.Drawing.Point(42, 285);
            this.lblValorAumento.Name = "lblValorAumento";
            this.lblValorAumento.Size = new System.Drawing.Size(91, 13);
            this.lblValorAumento.TabIndex = 9;
            this.lblValorAumento.Text = "Valor do Aumento";
            // 
            // txtValorAumento
            // 
            this.txtValorAumento.Location = new System.Drawing.Point(45, 301);
            this.txtValorAumento.Name = "txtValorAumento";
            this.txtValorAumento.Size = new System.Drawing.Size(100, 20);
            this.txtValorAumento.TabIndex = 10;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(209, 285);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoVenda.TabIndex = 11;
            this.lblPrecoVenda.Text = "Preço da Venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(212, 301);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.ReadOnly = true;
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtValorAumento);
            this.Controls.Add(this.lblValorAumento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.numPercentualLucro);
            this.Controls.Add(this.lblPercentualLucro);
            this.Controls.Add(this.numCusto);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblProduto);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcula preço final de venda do produto";
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentualLucro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.NumericUpDown numCusto;
        private System.Windows.Forms.Label lblPercentualLucro;
        private System.Windows.Forms.NumericUpDown numPercentualLucro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblValorAumento;
        private System.Windows.Forms.TextBox txtValorAumento;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
    }
}

