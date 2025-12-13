using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping_ForEach
{
    public partial class frmLoopForEach : Form
    {
        public frmLoopForEach()
        {
            InitializeComponent();
        }

        private void frmLoopForEach_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnConfirmar.Enabled = false;
            grbDados.Enabled = false;

            List<string> produtos = new List<string> // Criação de uma variavel e uma lista no comboBox, de um jeito mais pratico
            {
                "Mouse",
                "Teclado",
                "Monitor",
                "Placa mãe",
                "Placa de video",
                "Memoria Ram",
                "SSD",
                "Fonte",
                "Gabinete",
                "Water Cooler",
                "Processador"
            };

            foreach (string produto in produtos) // Para Validar a criação dos produtos e adicionar no comboBox
            {
                cmbProduto.Items.Add(produto);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo", "FIM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtPrecoVenda.Clear();
            numPercentualAumento.Value = 0;
            numPrecoCusto.Value = 0;
            cmbProduto.SelectedIndex = -1;
            btnCancelar.Enabled = false;
            btnConfirmar.Enabled = false;
            btnNovo.Enabled = true;
            grbDados.Enabled = false;
            btnNovo.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            grbDados.Enabled = true;
            txtCodigo.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double PrecoCusto = Convert.ToDouble(numPrecoCusto.Value);
            double PercentualCusto = Convert.ToDouble(numPercentualAumento.Value);
            double ValorAumento = (PrecoCusto * PercentualCusto) / 100;
            double PrecoVenda = PrecoCusto + ValorAumento;

            
            txtPrecoVenda.Text = PrecoVenda.ToString("F2");

            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Porfavor informe o código", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbProduto.Text.Length == 0)
            {
                MessageBox.Show("Porfavor informar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
        }
    }
}
