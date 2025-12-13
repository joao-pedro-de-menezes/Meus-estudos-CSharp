using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores_Matematicos_Funcao
{
    public partial class frmOperadoresMatematicos : Form
    {
        string operador;
        double resultado;

        public frmOperadoresMatematicos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye Bye", "Saindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            numNumero1.Value = 0;
            numNumero2.Value = 0;
            txtResultado.Clear();
            numNumero1.Focus();
        }

        private void frmOperadoresMatematicos_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            operador = "+";
            btnResultado_Click(sender, e);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            operador = "-";
            btnResultado_Click(sender, e);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            btnResultado_Click(sender, e);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            btnResultado_Click(sender, e);
        }

        private void btbRaizQuadrada_Click(object sender, EventArgs e)
        {
            operador = "R";
            btnResultado_Click(sender, e);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(numNumero1.Value);
            double numero2 = Convert.ToDouble(numNumero2.Value);


            if (operador == "+")
            
                resultado = numero1 + numero2;
            
            else if (operador == "-")
            
                resultado = numero1 - numero2;
            
            else if (operador == "*")
           
                resultado = numero1 * numero2;
            
            else if (operador == "/")
            
                resultado = numero1 / numero2;
            
            else if (operador == "R")
            {
                resultado = Math.Sqrt(numero1);
                
            }
            txtResultado.Text = resultado.ToString("F2");
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
