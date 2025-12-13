using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_de_4Nota
{
    public partial class frmMedia4Notas : Form
    {
        public frmMedia4Notas()
        {
            InitializeComponent();
        }

        private void frmMedia4Notas_Load(object sender, EventArgs e)
        {
            cmbDisciplina.Items.Add("Português");
            cmbDisciplina.Items.Add("Matemática");
            cmbDisciplina.Items.Add("Geografia");
            cmbDisciplina.Items.Add("História");
            cmbDisciplina.Items.Add("Inglês");

            // Zera as variavais
            txtNota1.Text = "0";
            txtNota2.Text = "0";
            txtNota3.Text = "0";
            txtNota4.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grbDados_Enter(object sender, EventArgs e)
        {

        }

        private void frmMedia4Notas_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tchau, Vá com Deus!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fim do App!", "Sair", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAluno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtMedia.Clear();
            txtResultado.Clear();
            cmbDisciplina.SelectedIndex = -1; // Para limpar o grupBox mas manter as opções lá
            txtAluno.Focus(); // Faz voltar a barrinha de escrever para o local desejado
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double Nota1 = 0;
            double Nota2 = 0;
            double Nota3 = 0;
            double Nota4 = 0;

            Nota1 = Convert.ToDouble(txtNota1.Text); // Converte texto para Numero
            Nota2 = Convert.ToDouble(txtNota2.Text);
            Nota3 = Convert.ToDouble(txtNota3.Text);
            Nota4 = Convert.ToDouble(txtNota4.Text);

            double Media = Nota1 + Nota2 + Nota3 + Nota4 / 4;
            txtMedia.Text = Media.ToString("F2"); // F2 exibe com duas casa decimais
            if (Media >= 5) 
            {
                txtResultado.Text = "Aprovado";
                txtResultado.ForeColor = Color.Blue;
            } 
            else
            {
                txtResultado.Text = "Reprovado";
                txtResultado.ForeColor = Color.Red;
            }
                

        }
    }
}
