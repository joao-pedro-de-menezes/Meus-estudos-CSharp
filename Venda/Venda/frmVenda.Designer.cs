namespace Venda
{
    partial class frmVenda
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.numVenda = new System.Windows.Forms.NumericUpDown();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblExibir = new System.Windows.Forms.Label();
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.lblComissao = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).BeginInit();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.lblComissao);
            this.grbDados.Controls.Add(this.txtComissao);
            this.grbDados.Controls.Add(this.numVenda);
            this.grbDados.Controls.Add(this.lblVenda);
            this.grbDados.Location = new System.Drawing.Point(12, 2);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(204, 79);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Location = new System.Drawing.Point(6, 25);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(120, 13);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "Digite o valor da venda:";
            this.lblVenda.Click += new System.EventHandler(this.label1_Click);
            // 
            // numVenda
            // 
            this.numVenda.DecimalPlaces = 2;
            this.numVenda.Location = new System.Drawing.Point(132, 23);
            this.numVenda.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numVenda.Name = "numVenda";
            this.numVenda.Size = new System.Drawing.Size(61, 20);
            this.numVenda.TabIndex = 1;
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnLimpar);
            this.grbOpcoes.Controls.Add(this.btnCalcular);
            this.grbOpcoes.Location = new System.Drawing.Point(12, 97);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(385, 124);
            this.grbOpcoes.TabIndex = 1;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.Image = global::Venda.Properties.Resources.Close;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSair.Location = new System.Drawing.Point(281, 31);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 81);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpar.Image = global::Venda.Properties.Resources.Novo;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLimpar.Location = new System.Drawing.Point(152, 31);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 81);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCalcular.Image = global::Venda.Properties.Resources.calculator_icon;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCalcular.Location = new System.Drawing.Point(25, 31);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 81);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(18, 241);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(32, 13);
            this.lblExibir.TabIndex = 2;
            this.lblExibir.Text = "Exibir";
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(56, 238);
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.ReadOnly = true;
            this.txtExibir.Size = new System.Drawing.Size(111, 20);
            this.txtExibir.TabIndex = 3;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(64, 49);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(100, 20);
            this.txtComissao.TabIndex = 4;
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Location = new System.Drawing.Point(6, 52);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(52, 13);
            this.lblComissao.TabIndex = 5;
            this.lblComissao.Text = "Comissão";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(409, 277);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.grbDados);
            this.MaximizeBox = false;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda - Comissão";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).EndInit();
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.NumericUpDown numVenda;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.TextBox txtExibir;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.TextBox txtComissao;
    }
}

