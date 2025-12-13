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
    public partial class frmEmailESenha : Form
    {
        int contador = 0;
        public frmEmailESenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fim do App", "FIM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "LupitaFofinha@gmail.com" && txtSenha.Text == "Salsicha")
            {
                this.Hide(); // Oculta o formulario
                frmPrincipal form = new frmPrincipal(); // Instancia
                form.Show(); // Permite alterar entre as paginas abertas
              // - form.ShowDialog(); - // Não permite alterar entre as paginas abertas 
            }
            else
            {
                contador += 1;
                if (contador >3)
                {
                    MessageBox.Show("Você não tem permissão para acessar esse sistema!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                MessageBox.Show("E-mail ou Senha Inválida!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void lblSenha_DoubleClick(object sender, EventArgs e) // {Segredo} para acessar direto sem precisar ficar colocando senha
        {
            txtEmail.Text = "LupitaFofinha@gmail.com";
            txtSenha.Text = "Salsicha";
            btnAcessar_Click(sender, e);
        }
    }
}
