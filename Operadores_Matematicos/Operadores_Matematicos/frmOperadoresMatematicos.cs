using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores_Matematicos
{
    public partial class frmOperadoresMatematicos : Form
    {
        double num1 = 0;
        double num2 = 0;
        double resultado = 0;

        public frmOperadoresMatematicos()
        {
            InitializeComponent();
        }

        private void numNumero1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmOperadoresMatematicos_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Confirmação ou negação de algo
            if (MessageBox.Show("Você realmente deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("Bye Bye");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ótima escolha");
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Converte as caixas para as váriaveis do tipo double
            num1 = Convert.ToDouble(numNumero1.Value);
            num2 = Convert.ToDouble(numNumero2.Value);

            // Calcula a soma de dois numeros
            resultado = num1 + num2;

            // Exibe o resultado
            txtResultado.Text = resultado.ToString("F2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            numNumero1.Value = 0;
            numNumero2.Value = 0;
            txtResultado.Clear();
            numNumero1.Focus();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(numNumero1.Value);
            num2 = Convert.ToDouble(numNumero2.Value);

            // Calcula a subtração de dois numeros
            resultado = num1 - num2;

            // double soma = Math.Abs(num1 - num2); //<-- Método abs retorna valor positivo, se trocar o "-" por "+" retorna o valor negativo

            txtResultado.Text = resultado.ToString("F2");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(numNumero1.Value);
            num2 = Convert.ToDouble(numNumero2.Value);

            // Calcula a multiplicação de dois numeros
            resultado = num1 * num2;

            txtResultado.Text = resultado.ToString("F2");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(numNumero1.Value);
            num2 = Convert.ToDouble(numNumero2.Value);

            // Calcula a divisão de dois numeros
            resultado = num1 / num2;

            txtResultado.Text = resultado.ToString("F2");
        }

        private void btbRaizQuadrada_Click(object sender, EventArgs e)
        {
            // Calcula a Raiz Quadrada de um numero
            num1 = Convert.ToDouble(numNumero1.Value);

            resultado = Math.Sqrt(num1);

            txtResultado.Text = resultado.ToString();
        }
    }
}
