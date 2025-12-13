namespace Semaforo
{
    partial class frmSemaforo
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
            this.components = new System.ComponentModel.Container();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.picSemaforoDesligado = new System.Windows.Forms.PictureBox();
            this.tmrSemaforo = new System.Windows.Forms.Timer(this.components);
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.picSemaforoVerde = new System.Windows.Forms.PictureBox();
            this.picSemaforoAmarelo = new System.Windows.Forms.PictureBox();
            this.picSemaforoVermelho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoDesligado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoVermelho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLigar
            // 
            this.btnLigar.Image = global::Semaforo.Properties.Resources.Start;
            this.btnLigar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLigar.Location = new System.Drawing.Point(203, 7);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(96, 56);
            this.btnLigar.TabIndex = 0;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Image = global::Semaforo.Properties.Resources.switch_turn_off;
            this.btnDesligar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesligar.Location = new System.Drawing.Point(305, 7);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(96, 56);
            this.btnDesligar.TabIndex = 0;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(142, 88);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(0, 39);
            this.lblSegundos.TabIndex = 1;
            // 
            // lblSituacao
            // 
            this.lblSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblSituacao.Location = new System.Drawing.Point(191, 90);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(104, 37);
            this.lblSituacao.TabIndex = 2;
            this.lblSituacao.Click += new System.EventHandler(this.lblSituacao_Click);
            // 
            // picSemaforoDesligado
            // 
            this.picSemaforoDesligado.Image = global::Semaforo.Properties.Resources.TRFFC09;
            this.picSemaforoDesligado.Location = new System.Drawing.Point(110, 132);
            this.picSemaforoDesligado.Name = "picSemaforoDesligado";
            this.picSemaforoDesligado.Size = new System.Drawing.Size(32, 40);
            this.picSemaforoDesligado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemaforoDesligado.TabIndex = 3;
            this.picSemaforoDesligado.TabStop = false;
            // 
            // tmrSemaforo
            // 
            this.tmrSemaforo.Interval = 5000;
            this.tmrSemaforo.Tick += new System.EventHandler(this.tmrSemaforo_Tick);
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // picSemaforoVerde
            // 
            this.picSemaforoVerde.Image = global::Semaforo.Properties.Resources.TRFFC10A;
            this.picSemaforoVerde.Location = new System.Drawing.Point(110, 132);
            this.picSemaforoVerde.Name = "picSemaforoVerde";
            this.picSemaforoVerde.Size = new System.Drawing.Size(32, 39);
            this.picSemaforoVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemaforoVerde.TabIndex = 4;
            this.picSemaforoVerde.TabStop = false;
            // 
            // picSemaforoAmarelo
            // 
            this.picSemaforoAmarelo.Image = global::Semaforo.Properties.Resources.TRFFC10B;
            this.picSemaforoAmarelo.Location = new System.Drawing.Point(110, 132);
            this.picSemaforoAmarelo.Name = "picSemaforoAmarelo";
            this.picSemaforoAmarelo.Size = new System.Drawing.Size(32, 39);
            this.picSemaforoAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemaforoAmarelo.TabIndex = 4;
            this.picSemaforoAmarelo.TabStop = false;
            // 
            // picSemaforoVermelho
            // 
            this.picSemaforoVermelho.Image = global::Semaforo.Properties.Resources.TRFFC10C;
            this.picSemaforoVermelho.Location = new System.Drawing.Point(110, 133);
            this.picSemaforoVermelho.Name = "picSemaforoVermelho";
            this.picSemaforoVermelho.Size = new System.Drawing.Size(32, 39);
            this.picSemaforoVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSemaforoVermelho.TabIndex = 4;
            this.picSemaforoVermelho.TabStop = false;
            // 
            // frmSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Semaforo.Properties.Resources.paulistafp9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 492);
            this.Controls.Add(this.picSemaforoVermelho);
            this.Controls.Add(this.picSemaforoAmarelo);
            this.Controls.Add(this.picSemaforoVerde);
            this.Controls.Add(this.picSemaforoDesligado);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.MaximizeBox = false;
            this.Name = "frmSemaforo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semáforo";
            this.Load += new System.EventHandler(this.frmSemaforo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoDesligado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoVermelho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.PictureBox picSemaforoDesligado;
        private System.Windows.Forms.Timer tmrSemaforo;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.PictureBox picSemaforoVerde;
        private System.Windows.Forms.PictureBox picSemaforoAmarelo;
        private System.Windows.Forms.PictureBox picSemaforoVermelho;
    }
}

