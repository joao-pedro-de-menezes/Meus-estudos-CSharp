using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_2_Numeros
{
    public partial class frmSoma2Numeros : Form
    {
        public frmSoma2Numeros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int Numero1 = 0; // Váriavel do tipo inteiro
            int Numero2 = 0;

            Numero1 = Convert.ToInt16(txtNumero1.Text); // Para converter texto para numero
            Numero2 = Convert.ToInt16(txtNumero2.Text);

            int Soma = Numero1 + Numero2;
            txtResultado.Text = Convert.ToString(Soma); // Para converter numero para texto
        }

        private void textNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero2_Click(object sender, EventArgs e)
        {

        }

        private void textNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fim do App", "Sair");
            Application.Exit();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
