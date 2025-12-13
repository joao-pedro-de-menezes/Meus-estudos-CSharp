namespace Media_de_4Nota
{
    partial class frmMedia4Notas
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
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.grbResultado.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grbDados.Controls.Add(this.txtNota4);
            this.grbDados.Controls.Add(this.lblNota4);
            this.grbDados.Controls.Add(this.txtNota3);
            this.grbDados.Controls.Add(this.lblNota3);
            this.grbDados.Controls.Add(this.txtNota2);
            this.grbDados.Controls.Add(this.lblNota2);
            this.grbDados.Controls.Add(this.txtNota1);
            this.grbDados.Controls.Add(this.lblNota1);
            this.grbDados.Controls.Add(this.cmbDisciplina);
            this.grbDados.Controls.Add(this.lblDisciplina);
            this.grbDados.Controls.Add(this.txtAluno);
            this.grbDados.Controls.Add(this.lblAluno);
            this.grbDados.Location = new System.Drawing.Point(45, 12);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(281, 215);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            this.grbDados.Enter += new System.EventHandler(this.grbDados_Enter);
            // 
            // grbResultado
            // 
            this.grbResultado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grbResultado.Controls.Add(this.txtResultado);
            this.grbResultado.Controls.Add(this.txtMedia);
            this.grbResultado.Controls.Add(this.lblResultado);
            this.grbResultado.Controls.Add(this.lblMedia);
            this.grbResultado.Location = new System.Drawing.Point(363, 121);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(269, 87);
            this.grbResultado.TabIndex = 16;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(67, 54);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(48, 23);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(6, 57);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMedia.ForeColor = System.Drawing.Color.Red;
            this.lblMedia.Location = new System.Drawing.Point(6, 26);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Média";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnLimpar);
            this.grbOpcoes.Controls.Add(this.btnMedia);
            this.grbOpcoes.Location = new System.Drawing.Point(186, 278);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(276, 75);
            this.grbOpcoes.TabIndex = 15;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.Location = new System.Drawing.Point(186, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 40);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.Location = new System.Drawing.Point(95, 21);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 40);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMedia.Location = new System.Drawing.Point(6, 21);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(83, 40);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(76, 176);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 12;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.ForeColor = System.Drawing.Color.Lime;
            this.lblNota4.Location = new System.Drawing.Point(34, 179);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(36, 13);
            this.lblNota4.TabIndex = 11;
            this.lblNota4.Text = "Nota4";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(76, 150);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 10;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.ForeColor = System.Drawing.Color.Lime;
            this.lblNota3.Location = new System.Drawing.Point(34, 153);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(36, 13);
            this.lblNota3.TabIndex = 9;
            this.lblNota3.Text = "Nota3";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(76, 124);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 8;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.ForeColor = System.Drawing.Color.Lime;
            this.lblNota2.Location = new System.Drawing.Point(34, 127);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(36, 13);
            this.lblNota2.TabIndex = 7;
            this.lblNota2.Text = "Nota2";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(76, 98);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 6;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.ForeColor = System.Drawing.Color.Lime;
            this.lblNota1.Location = new System.Drawing.Point(34, 101);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(36, 13);
            this.lblNota1.TabIndex = 5;
            this.lblNota1.Text = "Nota1";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(86, 56);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(146, 21);
            this.cmbDisciplina.TabIndex = 4;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(28, 59);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 2;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(68, 30);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(196, 20);
            this.txtAluno.TabIndex = 1;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(28, 33);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(34, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno";
            this.lblAluno.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMedia4Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 423);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.grbOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMedia4Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média de 4 Notas";
            this.Load += new System.EventHandler(this.frmMedia4Notas_Load);
            this.Leave += new System.EventHandler(this.frmMedia4Notas_Leave);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblResultado;
    }
}

