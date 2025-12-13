using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping_For_Numeros
{
    public partial class frmLoopFor : Form
    {
        public frmLoopFor()
        {
            InitializeComponent();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fim do App", "FIM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void txtNumeroInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void picIniciar_Click(object sender, EventArgs e)
        {
            StringBuilder numero = new StringBuilder(); // O termo Builder serve para juntar uma
            int NumeroInicial = Convert.ToInt32(txtNumeroInicial.Text);
            int NumeroFinal = Convert.ToInt32(txtNumeroFinal.Text);

            if (NumeroFinal < NumeroInicial)
            {
                MessageBox.Show("O seu número final não pode ser inferior ao inicial", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = NumeroInicial; i <= NumeroFinal; i++) // Explicação do codigo "Primeiro vc define o começo, depois define até onde ele deve ir, e adicionando o jeito que deve seguir para chegar ao resultado

                // int == Variavel
                // i = NumeroInicial == Nome da variavel que ira receber outra variavel
                // i <= NumeroFinal == Definindo até onde deve ir a variavel "i" 
                // i++ == O jeito que ela irá ate o resultado, no caso significa "de 1 em 1"
            {
                numero.AppendLine(i.ToString());
            }
            txtNumeros.Text = numero.ToString();
            
            
        }
    }
}
