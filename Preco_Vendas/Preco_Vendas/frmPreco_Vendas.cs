using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preco_Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até Mais");
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtPrecoVenda.Clear();
            txtValorAumento.Clear();
            numCusto.Value = 0;
            numPercentualLucro.Value = 0;
            txtProduto.Focus();        // coloca o foco na caixa de produto
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                MessageBox.Show("Impossivel continuar sem o nome do produto!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostra mensagem de erro
                txtProduto.Focus(); // Coloca o foco na caixa de produto
                return; // Não executa as linhas abaixo
            }
            if (numPercentualLucro.Value == 0)
            {
                MessageBox.Show("Por favor, informe o % de Lucro");
                numPercentualLucro.Focus();
                return;
            }

            // Converte o tipo decimal para double
            double custo = (double)numCusto.Value;
            double Percentual_Aumento = (double)numPercentualLucro.Value;

            // Cálculo do Valor do Aumento
            double ValorAumento = (custo * Percentual_Aumento) / 100;
            txtValorAumento.Text = ValorAumento.ToString("F2"); // F2 é para formatar com 2 casas decimais

            // Cálculo do Preço da Venda
            double PrecoVenda = custo + ValorAumento;
            txtPrecoVenda.Text = PrecoVenda.ToString("F2");
        }
    }
}
