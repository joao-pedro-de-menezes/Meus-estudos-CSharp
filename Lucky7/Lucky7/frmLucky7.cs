using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky7
{
    public partial class frmLucky7 : Form
    {
        int Sorteio = 0;
        int Acertos = 0;
        public frmLucky7()
        {
            InitializeComponent();
            picLucky7.Visible = false; // Oculta a imagem
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encerrando", "SAINDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random(); // Cria uma instancia para o metodo aleatorio
            
           
            int numero1 = aleatorio.Next(10); // .Next é um metodo que faz um sorteio e seleciona um numero aleatorio, nos () você coloca até onde ele vai buscar um numero aleatorio mas o Next conta 0 como inicial, no caso do (10) será do 0 ao 9 contabilizando no total 10 numeros, mas c for  (10)+1 vai ser 1 ao 10, 
            int numero2 = aleatorio.Next(10);
            int numero3 = aleatorio.Next(10);

            lblNumero1.Text = numero1.ToString();
            lblNumero2.Text = numero2.ToString();
            lblNumero3.Text = numero3.ToString();

            if (lblNumero1.Text == "7" || lblNumero2.Text == "7" || lblNumero3.Text == "7")
            {
                picLucky7.Visible = true; // Exibe a imagem
                Acertos++; // Soma mais 1 e acumula na variavel Acertos
                lblMensagem.Text = "Sorte Grande!";               
            }
            else
            {
                picLucky7.Visible = false; // Oculta a imagem
                lblMensagem.Text = "Azar!";
            }
            Sorteio++;
            txtAcertos.Text = Acertos.ToString();
            txtTentativas.Text = Sorteio.ToString();

        }
    }
}
