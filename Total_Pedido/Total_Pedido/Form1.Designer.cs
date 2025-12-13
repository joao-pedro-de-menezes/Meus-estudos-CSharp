namespace Total_Pedido
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
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.numQtdeVenda = new System.Windows.Forms.NumericUpDown();
            this.lblQtdeVenda = new System.Windows.Forms.Label();
            this.numPrecoUnitario = new System.Windows.Forms.NumericUpDown();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.numQtdeEstoque = new System.Windows.Forms.NumericUpDown();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblQtdeEstoque = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.grbOpcoes.SuspendLayout();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnCancelar);
            this.grbOpcoes.Controls.Add(this.btnLimpar);
            this.grbOpcoes.Controls.Add(this.btnCalcular);
            this.grbOpcoes.Controls.Add(this.btnNovo);
            this.grbOpcoes.Location = new System.Drawing.Point(12, 40);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(536, 91);
            this.grbOpcoes.TabIndex = 0;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Total_Pedido.Properties.Resources.Close;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(442, 30);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 55);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Total_Pedido.Properties.Resources.Sair;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(333, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 55);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::Total_Pedido.Properties.Resources.Cancelar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(224, 30);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 55);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = global::Total_Pedido.Properties.Resources.calculator_icon;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(115, 30);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 55);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::Total_Pedido.Properties.Resources.Novo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(6, 30);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 55);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.txtMensagem);
            this.grbDados.Controls.Add(this.lblMensagem);
            this.grbDados.Controls.Add(this.txtTotalPedido);
            this.grbDados.Controls.Add(this.lblTotalPedido);
            this.grbDados.Controls.Add(this.numQtdeVenda);
            this.grbDados.Controls.Add(this.lblQtdeVenda);
            this.grbDados.Controls.Add(this.numPrecoUnitario);
            this.grbDados.Controls.Add(this.lblPrecoUnitario);
            this.grbDados.Controls.Add(this.numQtdeEstoque);
            this.grbDados.Controls.Add(this.cmbMarca);
            this.grbDados.Controls.Add(this.txtProduto);
            this.grbDados.Controls.Add(this.lblQtdeEstoque);
            this.grbDados.Controls.Add(this.lblMarca);
            this.grbDados.Controls.Add(this.lblProduto);
            this.grbDados.Location = new System.Drawing.Point(25, 177);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(525, 282);
            this.grbDados.TabIndex = 1;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            this.grbDados.Enter += new System.EventHandler(this.grbDados_Enter);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(253, 241);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(189, 20);
            this.txtMensagem.TabIndex = 11;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(146, 244);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(71, 13);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.Location = new System.Drawing.Point(253, 204);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.ReadOnly = true;
            this.txtTotalPedido.Size = new System.Drawing.Size(189, 20);
            this.txtTotalPedido.TabIndex = 9;
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(146, 207);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(101, 13);
            this.lblTotalPedido.TabIndex = 8;
            this.lblTotalPedido.Text = "Total do Pedido:";
            // 
            // numQtdeVenda
            // 
            this.numQtdeVenda.Location = new System.Drawing.Point(300, 130);
            this.numQtdeVenda.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQtdeVenda.Name = "numQtdeVenda";
            this.numQtdeVenda.Size = new System.Drawing.Size(77, 20);
            this.numQtdeVenda.TabIndex = 7;
            // 
            // lblQtdeVenda
            // 
            this.lblQtdeVenda.AutoSize = true;
            this.lblQtdeVenda.Location = new System.Drawing.Point(205, 130);
            this.lblQtdeVenda.Name = "lblQtdeVenda";
            this.lblQtdeVenda.Size = new System.Drawing.Size(82, 13);
            this.lblQtdeVenda.TabIndex = 6;
            this.lblQtdeVenda.Text = "Qtde da Venda:";
            // 
            // numPrecoUnitario
            // 
            this.numPrecoUnitario.DecimalPlaces = 2;
            this.numPrecoUnitario.Location = new System.Drawing.Point(101, 128);
            this.numPrecoUnitario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecoUnitario.Name = "numPrecoUnitario";
            this.numPrecoUnitario.Size = new System.Drawing.Size(77, 20);
            this.numPrecoUnitario.TabIndex = 5;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(6, 130);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoUnitario.TabIndex = 4;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // numQtdeEstoque
            // 
            this.numQtdeEstoque.Location = new System.Drawing.Point(101, 93);
            this.numQtdeEstoque.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQtdeEstoque.Name = "numQtdeEstoque";
            this.numQtdeEstoque.Size = new System.Drawing.Size(77, 20);
            this.numQtdeEstoque.TabIndex = 3;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(101, 59);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(139, 21);
            this.cmbMarca.TabIndex = 2;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(101, 26);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(139, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // lblQtdeEstoque
            // 
            this.lblQtdeEstoque.AutoSize = true;
            this.lblQtdeEstoque.Location = new System.Drawing.Point(6, 95);
            this.lblQtdeEstoque.Name = "lblQtdeEstoque";
            this.lblQtdeEstoque.Size = new System.Drawing.Size(92, 13);
            this.lblQtdeEstoque.TabIndex = 0;
            this.lblQtdeEstoque.Text = "Qtde em Estoque:";
            this.lblQtdeEstoque.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(25, 62);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(25, 29);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(581, 494);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.grbOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular o total do Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOpcoes.ResumeLayout(false);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdeEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.NumericUpDown numQtdeEstoque;
        private System.Windows.Forms.Label lblQtdeEstoque;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.NumericUpDown numPrecoUnitario;
        private System.Windows.Forms.NumericUpDown numQtdeVenda;
        private System.Windows.Forms.Label lblQtdeVenda;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtTotalPedido;
    }
}

