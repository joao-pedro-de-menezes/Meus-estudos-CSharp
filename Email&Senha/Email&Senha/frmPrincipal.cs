using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Senha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           // this.Close(); // fecha o formulario atual
            this.Dispose(); // fecha e descarrega o formulario atual economizando memoria
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //DateTime DataAtual = DateTime.Now; // para mostrar a data atual
            //MessageBox.Show(DataAtual.ToString("dd/MM/yy"));

            // Calculo de idade
            int DataAtual = DateTime.Today.Year;
            int DataNascimento = dtpDataNascimento.Value.Year;
            int idade = DataAtual - DataNascimento;

            MessageBox.Show(idade.ToString());

            
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
