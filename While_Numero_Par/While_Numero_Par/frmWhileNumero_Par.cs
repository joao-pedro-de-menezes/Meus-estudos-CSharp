using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Numero_Par
{
    public partial class frmWhileNumero_Par : Form
    {
        public frmWhileNumero_Par()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            StringBuilder numeros = new StringBuilder(); // Cria a instância numeros referente a classe StringBuilder
            int limite = Convert.ToInt32(numLimite.Value);
            int contador = 0;
            while (contador <= limite)
            {
                numeros.AppendLine(contador.ToString() + " ");
                contador += 1;
            }
            txtExibir.Text += numeros.ToString();
        }
    }
}
