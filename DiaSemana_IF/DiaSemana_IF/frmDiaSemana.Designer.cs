namespace DiaSemana_IF
{
    partial class frmDiaSemana
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
            this.lblDia = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblExibir = new System.Windows.Forms.Label();
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.btnExibirSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(27, 38);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(133, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Informe um dia entre 1 e 7:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(166, 35);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 1;
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(100, 79);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 43);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(20, 151);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(32, 13);
            this.lblExibir.TabIndex = 3;
            this.lblExibir.Text = "Exibir";
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(58, 148);
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.ReadOnly = true;
            this.txtExibir.Size = new System.Drawing.Size(288, 20);
            this.txtExibir.TabIndex = 4;
            // 
            // btnExibirSwitch
            // 
            this.btnExibirSwitch.Location = new System.Drawing.Point(191, 79);
            this.btnExibirSwitch.Name = "btnExibirSwitch";
            this.btnExibirSwitch.Size = new System.Drawing.Size(75, 43);
            this.btnExibirSwitch.TabIndex = 5;
            this.btnExibirSwitch.Text = "Exibir Switch";
            this.btnExibirSwitch.UseVisualStyleBackColor = true;
            this.btnExibirSwitch.Click += new System.EventHandler(this.btnExibirSwitch_Click);
            // 
            // frmDiaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(358, 262);
            this.Controls.Add(this.btnExibirSwitch);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDiaSemana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dia da Semana com comando IF";
            this.Load += new System.EventHandler(this.frmDiaSemana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.TextBox txtExibir;
        private System.Windows.Forms.Button btnExibirSwitch;
    }
}

