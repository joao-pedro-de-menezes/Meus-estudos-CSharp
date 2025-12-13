namespace Operadores_Matematicos_Funcao
{
    partial class frmOperadoresMatematicos
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
            this.numNumero2 = new System.Windows.Forms.NumericUpDown();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.numNumero1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.labelSinal = new System.Windows.Forms.Label();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btbRaizQuadrada = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero1)).BeginInit();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.numNumero2);
            this.grbDados.Controls.Add(this.lblNumero2);
            this.grbDados.Controls.Add(this.numNumero1);
            this.grbDados.Controls.Add(this.lblNumero1);
            this.grbDados.Location = new System.Drawing.Point(21, 18);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(159, 100);
            this.grbDados.TabIndex = 9;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // numNumero2
            // 
            this.numNumero2.DecimalPlaces = 2;
            this.numNumero2.Location = new System.Drawing.Point(68, 54);
            this.numNumero2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNumero2.Name = "numNumero2";
            this.numNumero2.Size = new System.Drawing.Size(58, 20);
            this.numNumero2.TabIndex = 3;
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(12, 56);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(50, 13);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Número2";
            // 
            // numNumero1
            // 
            this.numNumero1.DecimalPlaces = 2;
            this.numNumero1.Location = new System.Drawing.Point(68, 26);
            this.numNumero1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNumero1.Name = "numNumero1";
            this.numNumero1.Size = new System.Drawing.Size(58, 20);
            this.numNumero1.TabIndex = 1;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(12, 28);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(50, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número1";
            // 
            // labelSinal
            // 
            this.labelSinal.AutoSize = true;
            this.labelSinal.Location = new System.Drawing.Point(186, 66);
            this.labelSinal.Name = "labelSinal";
            this.labelSinal.Size = new System.Drawing.Size(19, 13);
            this.labelSinal.TabIndex = 12;
            this.labelSinal.Text = "==";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnResultado);
            this.grbOpcoes.Controls.Add(this.btbRaizQuadrada);
            this.grbOpcoes.Controls.Add(this.btnSair);
            this.grbOpcoes.Controls.Add(this.btnLimpar);
            this.grbOpcoes.Controls.Add(this.btnSomar);
            this.grbOpcoes.Controls.Add(this.btnSubtrair);
            this.grbOpcoes.Controls.Add(this.btnDividir);
            this.grbOpcoes.Controls.Add(this.btnMultiplicar);
            this.grbOpcoes.Location = new System.Drawing.Point(21, 132);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(416, 168);
            this.grbOpcoes.TabIndex = 11;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Text = "Opções";
            // 
            // btbRaizQuadrada
            // 
            this.btbRaizQuadrada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbRaizQuadrada.Location = new System.Drawing.Point(330, 19);
            this.btbRaizQuadrada.Name = "btbRaizQuadrada";
            this.btbRaizQuadrada.Size = new System.Drawing.Size(75, 62);
            this.btbRaizQuadrada.TabIndex = 8;
            this.btbRaizQuadrada.Text = "SQRT";
            this.btbRaizQuadrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btbRaizQuadrada.UseVisualStyleBackColor = true;
            this.btbRaizQuadrada.Click += new System.EventHandler(this.btbRaizQuadrada_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(111, 99);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 49);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(6, 99);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 49);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSomar.Location = new System.Drawing.Point(6, 19);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 62);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "Somar";
            this.btnSomar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubtrair.Location = new System.Drawing.Point(87, 19);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 62);
            this.btnSubtrair.TabIndex = 5;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDividir.Location = new System.Drawing.Point(249, 19);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 62);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultiplicar.Location = new System.Drawing.Point(168, 19);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 62);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(211, 63);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 10;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(216, 99);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(99, 49);
            this.btnResultado.TabIndex = 9;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // frmOperadoresMatematicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 318);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.labelSinal);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.txtResultado);
            this.Name = "frmOperadoresMatematicos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmOperadoresMatematicos_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero1)).EndInit();
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.NumericUpDown numNumero2;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.NumericUpDown numNumero1;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label labelSinal;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btbRaizQuadrada;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnResultado;
    }
}

