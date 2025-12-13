using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaSemana_IF
{
    public partial class frmDiaSemana : Form
    {


        public frmDiaSemana()
        {
            InitializeComponent();
        }

        private void frmDiaSemana_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int Dia = Convert.ToInt16(txtDia.Text);

            txtExibir.Clear();
            try
            {



                if (Dia == 1)
                {
                    txtExibir.Text = "Segunda";
                }
                else if (Dia == 2)
                {
                    txtExibir.Text = "Terça";
                }
                else if (Dia == 3)
                {
                    txtExibir.Text = "Quarta";
                }
                else if (Dia == 4)
                {
                    txtExibir.Text = "Quinta";
                }
                else if (Dia == 5)
                {
                    txtExibir.Text = "Sexta";
                }
                else if (Dia == 6)
                {
                    txtExibir.Text = "Sábado";
                }
                else if (Dia == 7)
                {
                    txtExibir.Text = "Domingo";
                }
                else
                {
                    MessageBox.Show("Número inválido");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Informe um número entre 1 a 7");
            }
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExibirSwitch_Click(object sender, EventArgs e)
        {
            try
            {

                int Dia = Convert.ToInt16(txtDia.Text);
                switch (Dia)
                {
                    case 1:
                        txtExibir.Text = "Segunda";
                        break;

                    case 2:
                        txtExibir.Text = "Terça";
                        break;

                    case 3:
                        txtExibir.Text = "Quarta";
                        break;

                    case 4:
                        txtExibir.Text = "Quinta";
                        break;

                    case 5:
                        txtExibir.Text = "Sexta";
                        break;

                    case 6:
                        txtExibir.Text = "Sábado";
                        break;

                    case 7:
                        txtExibir.Text = "Domingo";
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Número inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
