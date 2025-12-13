using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Numeros
{
    public partial class frmLoopingWhile : Form
    {
        public frmLoopingWhile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtExibir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int Limite = Convert.ToInt16(numLimite.Value); 

             

            // Jeito de se fazer WHILE (Enquanto)
            while (contador <= Limite) 
            {
                txtExibir.Text += contador.ToString() + " "; // (+ " ") Para colocar dar espaço entre os numeros 
                contador += 1; // Para ir aumentando de 1 em 1 

            }
        }
    }
}
