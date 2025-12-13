using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecoPorCor
{
    public partial class frmPrecosPorCor : Form
    {
        public frmPrecosPorCor()
        {
            InitializeComponent();
        }

        private void cmbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnExibir_Click(object sender, EventArgs e)
        { // Em if, else e else if
            if (cmbCor.Text == "Verde")
            {
                txtMostrar.Text = "R$ 10,00";
                txtMostrar.ForeColor = Color.Green;
            }
            else if (cmbCor.Text == "Azul")
            {
                txtMostrar.Text = "R$ 20,00";
                txtMostrar.ForeColor = Color.Blue;
            }
            else if (cmbCor.Text == "Amarelo")
            {
                txtMostrar.Text = "R$ 30,00";
                txtMostrar.ForeColor = Color.Yellow;
            }
            else if (cmbCor.Text == "Vermelho")
            {
                txtMostrar.Text = "R$ 40,00";
                txtMostrar.ForeColor = Color.Red;
            }
            else
            {
                txtMostrar.Text = "Selecione uma cor válida";
            }

            // Em swith
            switch (cmbCor.Text)
            {
                case "Verde":

                    txtMostrar.Text = "R$ 10,00";
                    txtMostrar.ForeColor = Color.Green;
                    break;

                case "Azul":

                    txtMostrar.Text = "R$ 20,00";
                    txtMostrar.ForeColor = Color.Blue;
                    break;

                case "Amarelo":

                    txtMostrar.Text = "R$ 30,00";
                    txtMostrar.ForeColor = Color.Yellow;
                    break;

                case "Vermelho":

                    txtMostrar.Text = "R$ 40,00";
                    txtMostrar.ForeColor = Color.Red;
                    break;

                default:
                    txtMostrar.Text = "Selecione uma cor válida";
                    break;

            }
        }
    }
}
