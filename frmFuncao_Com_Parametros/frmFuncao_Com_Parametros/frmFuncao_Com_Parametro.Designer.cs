namespace frmFuncao_Com_Parametros
{
    partial class frmFuncao_Com_Parametro
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblExibir = new System.Windows.Forms.Label();
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.lblTeclas = new System.Windows.Forms.Label();
            this.grbOpcoes.SuspendLayout();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnSalvar);
            this.grbOpcoes.Controls.Add(this.btnNovo);
            this.grbOpcoes.Location = new System.Drawing.Point(39, 28);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(220, 111);
            this.grbOpcoes.TabIndex = 0;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.txtEmail);
            this.grbDados.Controls.Add(this.txtCidade);
            this.grbDados.Controls.Add(this.txtNome);
            this.grbDados.Controls.Add(this.lblEmail);
            this.grbDados.Controls.Add(this.lblCidade);
            this.grbDados.Controls.Add(this.lblNome);
            this.grbDados.Location = new System.Drawing.Point(39, 183);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(392, 127);
            this.grbDados.TabIndex = 1;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::frmFuncao_Com_Parametros.Properties.Resources.Salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(111, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 59);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::frmFuncao_Com_Parametros.Properties.Resources.Novo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(19, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(86, 59);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(30, 57);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(75, 54);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(280, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(55, 356);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(32, 13);
            this.lblExibir.TabIndex = 2;
            this.lblExibir.Text = "Exibir";
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(93, 353);
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.Size = new System.Drawing.Size(301, 20);
            this.txtExibir.TabIndex = 3;
            // 
            // lblTeclas
            // 
            this.lblTeclas.AutoSize = true;
            this.lblTeclas.Location = new System.Drawing.Point(55, 391);
            this.lblTeclas.Name = "lblTeclas";
            this.lblTeclas.Size = new System.Drawing.Size(110, 13);
            this.lblTeclas.TabIndex = 4;
            this.lblTeclas.Text = "F2 - Limpa os campos";
            // 
            // frmFuncao_Com_Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.lblTeclas);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.grbOpcoes);
            this.Name = "frmFuncao_Com_Parametro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Função com Parâmetro";
            this.grbOpcoes.ResumeLayout(false);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.TextBox txtExibir;
        private System.Windows.Forms.Label lblTeclas;
    }
}

