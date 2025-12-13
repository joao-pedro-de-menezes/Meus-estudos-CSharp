using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Barra_Progresso
{
    public partial class frmWhileProgress : Form
    {
        public frmWhileProgress()
        {
            InitializeComponent();
        }

        private void frmWhileProgress_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fim do app", "FIM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int numero = Convert.ToInt32(numLimite.Value);
            pgbBarra.Maximum = numero;
            while (contador < numero) // Enquanto a variável contador for menor do que 110
            {
                pgbBarra.Value = contador; // Vai preenchendo a barra de progressos
                contador += 1; // Soma mais 1 na variável contador e armazena nela mesma
            }
        }
    }
}
