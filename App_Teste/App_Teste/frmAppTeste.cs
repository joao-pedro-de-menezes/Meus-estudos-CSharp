using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Teste
{
    public partial class frmAppTeste : Form
    {
        public frmAppTeste()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtbCpfFuncionario.Clear();
            txtSenha.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo do Aplicativo");
            Application.Exit();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double CpfFun = (12345678900);
            string senha = "Lulu";
            CpfFun = Convert.ToDouble(mtbCpfFuncionario);

            if (CpfFun == 12345678900 && senha == "Lulu") 
            {
                MessageBox.Show("Bem-Vindo");
            }
            else
            {
                MessageBox.Show("VAZA");
            }
        }
    }
}
