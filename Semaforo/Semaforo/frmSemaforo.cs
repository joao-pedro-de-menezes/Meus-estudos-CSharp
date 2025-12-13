using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class frmSemaforo : Form
    {
        int segundos = 0;
        public frmSemaforo()
        {
            InitializeComponent();
        }

        private void frmSemaforo_Load(object sender, EventArgs e)
        {
            lblSituacao.Text = "Desligado";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            tmrSemaforo.Interval = 5000;    
            tmrSemaforo.Enabled = true; // ativando o timer
            picSemaforoDesligado.Visible = false; // Deixando o picture invisivel
            picSemaforoVermelho.Visible = false;
            picSemaforoAmarelo.Visible = false;
            picSemaforoVerde.Visible = true;
            lblSituacao.Text = "Verde";
            tmrTempo.Enabled = true;
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            tmrSemaforo.Enabled = false;
            tmrTempo.Enabled = false;
            picSemaforoVerde.Visible = false;
            picSemaforoAmarelo.Visible = false;
            picSemaforoVermelho.Visible = false;
            picSemaforoDesligado.Visible = true;
            segundos = 0;
            lblSituacao.Text = "Desligado";
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            lblSegundos.Text = segundos.ToString();
            segundos += 1;
            if (segundos > 4)
            {
                segundos = 0;
            }
        }

        private void tmrSemaforo_Tick(object sender, EventArgs e)
        {
            if (picSemaforoVerde.Visible)
            {
                picSemaforoVermelho.Visible = false;
                picSemaforoVerde.Visible = false;
                picSemaforoAmarelo.Visible = true;
                lblSituacao.Text = "Amarelo";
            }
            else if (picSemaforoAmarelo.Visible)
            {
                picSemaforoVerde.Visible = false;
                picSemaforoAmarelo.Visible = false;
                picSemaforoVermelho.Visible = true;
                lblSituacao.Text = "Vermelho";
            }
            else
            {
                picSemaforoVermelho.Visible = false;
                picSemaforoAmarelo.Visible = false;
                picSemaforoVerde.Visible = true;
                lblSituacao.Text = "Verde";                
            }
            string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString(); // Caminho para buscar alguma coisa, esse caminho é o mais comum
            SoundPlayer som = new SoundPlayer(caminho + @"\26f8b9_sonic_ring_sound_effect.wav"); //Jeito para ativar o som
            som.Play();
        }

        private void lblSituacao_Click(object sender, EventArgs e)
        {

        }
    }
}
