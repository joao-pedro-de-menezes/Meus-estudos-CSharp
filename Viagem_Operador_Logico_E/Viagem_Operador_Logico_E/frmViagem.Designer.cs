namespace Viagem_Operador_Logico_E
{
    partial class frmViagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemCombustivelTXT = new System.Windows.Forms.Label();
            this.txtTemCombustivel = new System.Windows.Forms.TextBox();
            this.lblEhFeriadoTXT = new System.Windows.Forms.Label();
            this.txtEhFeriado = new System.Windows.Forms.TextBox();
            this.btnConfirmaTXT = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTemCombustivelCMB = new System.Windows.Forms.Label();
            this.lblEhFeriadoCMB = new System.Windows.Forms.Label();
            this.cmbTemCombustivel = new System.Windows.Forms.ComboBox();
            this.cmbEhFeriado = new System.Windows.Forms.ComboBox();
            this.btnConfirmarCMB = new System.Windows.Forms.Button();
            this.lblTemCombustivelLST = new System.Windows.Forms.Label();
            this.lblEhFeriadoLST = new System.Windows.Forms.Label();
            this.lstTemCombustivel = new System.Windows.Forms.ListBox();
            this.lstEhFeriado = new System.Windows.Forms.ListBox();
            this.btnConfirmarLST = new System.Windows.Forms.Button();
            this.chkTemCombustivel = new System.Windows.Forms.CheckBox();
            this.chkEhFeriado = new System.Windows.Forms.CheckBox();
            this.btnConfirmarCHK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblTemCombustivelTXT
            // 
            this.lblTemCombustivelTXT.AutoSize = true;
            this.lblTemCombustivelTXT.Location = new System.Drawing.Point(20, 32);
            this.lblTemCombustivelTXT.Name = "lblTemCombustivelTXT";
            this.lblTemCombustivelTXT.Size = new System.Drawing.Size(177, 13);
            this.lblTemCombustivelTXT.TabIndex = 1;
            this.lblTemCombustivelTXT.Text = "Carro Tem Combustível? SIM/NÃO:";
            // 
            // txtTemCombustivel
            // 
            this.txtTemCombustivel.Location = new System.Drawing.Point(203, 29);
            this.txtTemCombustivel.Name = "txtTemCombustivel";
            this.txtTemCombustivel.Size = new System.Drawing.Size(55, 20);
            this.txtTemCombustivel.TabIndex = 2;
            // 
            // lblEhFeriadoTXT
            // 
            this.lblEhFeriadoTXT.AutoSize = true;
            this.lblEhFeriadoTXT.Location = new System.Drawing.Point(28, 74);
            this.lblEhFeriadoTXT.Name = "lblEhFeriadoTXT";
            this.lblEhFeriadoTXT.Size = new System.Drawing.Size(117, 13);
            this.lblEhFeriadoTXT.TabIndex = 3;
            this.lblEhFeriadoTXT.Text = "Eh Feriado? SIM/NÃO:";
            // 
            // txtEhFeriado
            // 
            this.txtEhFeriado.Location = new System.Drawing.Point(151, 71);
            this.txtEhFeriado.Name = "txtEhFeriado";
            this.txtEhFeriado.Size = new System.Drawing.Size(55, 20);
            this.txtEhFeriado.TabIndex = 4;
            this.txtEhFeriado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConfirmaTXT
            // 
            this.btnConfirmaTXT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmaTXT.Location = new System.Drawing.Point(98, 110);
            this.btnConfirmaTXT.Name = "btnConfirmaTXT";
            this.btnConfirmaTXT.Size = new System.Drawing.Size(81, 54);
            this.btnConfirmaTXT.TabIndex = 5;
            this.btnConfirmaTXT.Text = "Confirmar";
            this.btnConfirmaTXT.UseVisualStyleBackColor = false;
            this.btnConfirmaTXT.Click += new System.EventHandler(this.btnConfirmaTXT_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.Location = new System.Drawing.Point(321, 231);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 54);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpar.Location = new System.Drawing.Point(321, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 54);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTemCombustivelCMB
            // 
            this.lblTemCombustivelCMB.AutoSize = true;
            this.lblTemCombustivelCMB.Location = new System.Drawing.Point(2, 188);
            this.lblTemCombustivelCMB.Name = "lblTemCombustivelCMB";
            this.lblTemCombustivelCMB.Size = new System.Drawing.Size(177, 13);
            this.lblTemCombustivelCMB.TabIndex = 8;
            this.lblTemCombustivelCMB.Text = "Carro Tem Combustível? SIM/NÃO:";
            // 
            // lblEhFeriadoCMB
            // 
            this.lblEhFeriadoCMB.AutoSize = true;
            this.lblEhFeriadoCMB.Location = new System.Drawing.Point(2, 212);
            this.lblEhFeriadoCMB.Name = "lblEhFeriadoCMB";
            this.lblEhFeriadoCMB.Size = new System.Drawing.Size(117, 13);
            this.lblEhFeriadoCMB.TabIndex = 9;
            this.lblEhFeriadoCMB.Text = "Eh Feriado? SIM/NÃO:";
            // 
            // cmbTemCombustivel
            // 
            this.cmbTemCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemCombustivel.FormattingEnabled = true;
            this.cmbTemCombustivel.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cmbTemCombustivel.Location = new System.Drawing.Point(185, 185);
            this.cmbTemCombustivel.Name = "cmbTemCombustivel";
            this.cmbTemCombustivel.Size = new System.Drawing.Size(73, 21);
            this.cmbTemCombustivel.TabIndex = 10;
            // 
            // cmbEhFeriado
            // 
            this.cmbEhFeriado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEhFeriado.FormattingEnabled = true;
            this.cmbEhFeriado.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cmbEhFeriado.Location = new System.Drawing.Point(185, 209);
            this.cmbEhFeriado.Name = "cmbEhFeriado";
            this.cmbEhFeriado.Size = new System.Drawing.Size(73, 21);
            this.cmbEhFeriado.TabIndex = 11;
            // 
            // btnConfirmarCMB
            // 
            this.btnConfirmarCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirmarCMB.Location = new System.Drawing.Point(98, 255);
            this.btnConfirmarCMB.Name = "btnConfirmarCMB";
            this.btnConfirmarCMB.Size = new System.Drawing.Size(81, 52);
            this.btnConfirmarCMB.TabIndex = 12;
            this.btnConfirmarCMB.Text = "Confirmar";
            this.btnConfirmarCMB.UseVisualStyleBackColor = false;
            this.btnConfirmarCMB.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTemCombustivelLST
            // 
            this.lblTemCombustivelLST.AutoSize = true;
            this.lblTemCombustivelLST.Location = new System.Drawing.Point(2, 336);
            this.lblTemCombustivelLST.Name = "lblTemCombustivelLST";
            this.lblTemCombustivelLST.Size = new System.Drawing.Size(177, 13);
            this.lblTemCombustivelLST.TabIndex = 13;
            this.lblTemCombustivelLST.Text = "Carro Tem Combustível? SIM/NÃO:";
            // 
            // lblEhFeriadoLST
            // 
            this.lblEhFeriadoLST.AutoSize = true;
            this.lblEhFeriadoLST.Location = new System.Drawing.Point(2, 361);
            this.lblEhFeriadoLST.Name = "lblEhFeriadoLST";
            this.lblEhFeriadoLST.Size = new System.Drawing.Size(117, 13);
            this.lblEhFeriadoLST.TabIndex = 14;
            this.lblEhFeriadoLST.Text = "Eh Feriado? SIM/NÃO:";
            // 
            // lstTemCombustivel
            // 
            this.lstTemCombustivel.FormattingEnabled = true;
            this.lstTemCombustivel.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.lstTemCombustivel.Location = new System.Drawing.Point(185, 319);
            this.lstTemCombustivel.Name = "lstTemCombustivel";
            this.lstTemCombustivel.Size = new System.Drawing.Size(55, 30);
            this.lstTemCombustivel.TabIndex = 15;
            // 
            // lstEhFeriado
            // 
            this.lstEhFeriado.FormattingEnabled = true;
            this.lstEhFeriado.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.lstEhFeriado.Location = new System.Drawing.Point(125, 361);
            this.lstEhFeriado.Name = "lstEhFeriado";
            this.lstEhFeriado.Size = new System.Drawing.Size(55, 30);
            this.lstEhFeriado.TabIndex = 16;
            // 
            // btnConfirmarLST
            // 
            this.btnConfirmarLST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmarLST.Location = new System.Drawing.Point(99, 415);
            this.btnConfirmarLST.Name = "btnConfirmarLST";
            this.btnConfirmarLST.Size = new System.Drawing.Size(81, 52);
            this.btnConfirmarLST.TabIndex = 17;
            this.btnConfirmarLST.Text = "Confirmar";
            this.btnConfirmarLST.UseVisualStyleBackColor = false;
            this.btnConfirmarLST.Click += new System.EventHandler(this.btnConfirmarLST_Click);
            // 
            // chkTemCombustivel
            // 
            this.chkTemCombustivel.AutoSize = true;
            this.chkTemCombustivel.Location = new System.Drawing.Point(5, 498);
            this.chkTemCombustivel.Name = "chkTemCombustivel";
            this.chkTemCombustivel.Size = new System.Drawing.Size(143, 17);
            this.chkTemCombustivel.TabIndex = 20;
            this.chkTemCombustivel.Text = "Carro Tem Combustível?";
            this.chkTemCombustivel.UseVisualStyleBackColor = true;
            // 
            // chkEhFeriado
            // 
            this.chkEhFeriado.AutoSize = true;
            this.chkEhFeriado.Location = new System.Drawing.Point(5, 521);
            this.chkEhFeriado.Name = "chkEhFeriado";
            this.chkEhFeriado.Size = new System.Drawing.Size(83, 17);
            this.chkEhFeriado.TabIndex = 21;
            this.chkEhFeriado.Text = "Eh Feriado?";
            this.chkEhFeriado.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarCHK
            // 
            this.btnConfirmarCHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarCHK.Location = new System.Drawing.Point(100, 550);
            this.btnConfirmarCHK.Name = "btnConfirmarCHK";
            this.btnConfirmarCHK.Size = new System.Drawing.Size(80, 52);
            this.btnConfirmarCHK.TabIndex = 22;
            this.btnConfirmarCHK.Text = "Confirmar";
            this.btnConfirmarCHK.UseVisualStyleBackColor = false;
            this.btnConfirmarCHK.Click += new System.EventHandler(this.btnConfirmarCHK_Click);
            // 
            // frmViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 641);
            this.Controls.Add(this.btnConfirmarCHK);
            this.Controls.Add(this.chkEhFeriado);
            this.Controls.Add(this.chkTemCombustivel);
            this.Controls.Add(this.btnConfirmarLST);
            this.Controls.Add(this.lstEhFeriado);
            this.Controls.Add(this.lstTemCombustivel);
            this.Controls.Add(this.lblEhFeriadoLST);
            this.Controls.Add(this.lblTemCombustivelLST);
            this.Controls.Add(this.btnConfirmarCMB);
            this.Controls.Add(this.cmbEhFeriado);
            this.Controls.Add(this.cmbTemCombustivel);
            this.Controls.Add(this.lblEhFeriadoCMB);
            this.Controls.Add(this.lblTemCombustivelCMB);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmaTXT);
            this.Controls.Add(this.txtEhFeriado);
            this.Controls.Add(this.lblEhFeriadoTXT);
            this.Controls.Add(this.txtTemCombustivel);
            this.Controls.Add(this.lblTemCombustivelTXT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viagem - Operador Lógico E";
            this.Load += new System.EventHandler(this.frmViagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemCombustivelTXT;
        private System.Windows.Forms.TextBox txtTemCombustivel;
        private System.Windows.Forms.Label lblEhFeriadoTXT;
        private System.Windows.Forms.TextBox txtEhFeriado;
        private System.Windows.Forms.Button btnConfirmaTXT;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTemCombustivelCMB;
        private System.Windows.Forms.Label lblEhFeriadoCMB;
        private System.Windows.Forms.ComboBox cmbTemCombustivel;
        private System.Windows.Forms.ComboBox cmbEhFeriado;
        private System.Windows.Forms.Button btnConfirmarCMB;
        private System.Windows.Forms.Label lblTemCombustivelLST;
        private System.Windows.Forms.Label lblEhFeriadoLST;
        private System.Windows.Forms.ListBox lstTemCombustivel;
        private System.Windows.Forms.ListBox lstEhFeriado;
        private System.Windows.Forms.Button btnConfirmarLST;
        private System.Windows.Forms.CheckBox chkTemCombustivel;
        private System.Windows.Forms.CheckBox chkEhFeriado;
        private System.Windows.Forms.Button btnConfirmarCHK;
    }
}

