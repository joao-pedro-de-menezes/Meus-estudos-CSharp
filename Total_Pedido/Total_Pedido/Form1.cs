using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Pedido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e); // Sender vai até o local especificado e o "e" executa oque o sender tenha pedido, no caso o botão Cancelar

            // Preenchimento (popular) do combo da marca
            cmbMarca.Items.Add("Sony");
            cmbMarca.Items.Add("Nintendo");
            cmbMarca.Items.Add("Microsoft");
            cmbMarca.Items.Add("Xbox");
            cmbMarca.Items.Add("Playstation");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo"); // Mostra a mensagem antes de encerrar
            Application.Exit(); // Para fechar o app
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMensagem.Clear();
            txtProduto.Clear();
            txtTotalPedido.Clear();
            numPrecoUnitario.Value = 0; // Jeito para fazer o valor voltar a ser 0 em numericUpDown
            numQtdeEstoque.Value = 0;
            numQtdeVenda.Value = 0;
            cmbMarca.SelectedIndex = -1; // jeito para fazer o valor voltar a ser nada em combobox
            txtProduto.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false; // Desabilita o botão Novo
            btnCalcular.Enabled = true; // Habilita o botão Calcular
            grbDados.Enabled = true; // Habilita o groupbox Dados
            txtProduto.Focus(); // Coloca o foco na caixa do produto
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se a caixa do nome do produto está preenchida
            if (string.IsNullOrEmpty(txtProduto.Text)) // Se estiver vazio ou nulo
            {
                MessageBox.Show("Informe o nome do produto!");
                txtProduto.Focus();
                return;
            }

            // Verifica se a marca foi selecionada
            if (cmbMarca.SelectedIndex == -1) // Senão foi selecionado nenhuma marca
            {
                MessageBox.Show("Selecione uma marca!");
                cmbMarca.Focus();
                return;
            }

            txtTotalPedido.Clear();
            txtMensagem.Clear();

            double QtdeEstoque = 0; // zera a variavel
            double PrecoUnitario = 0;
            double QtdeVenda = 0;

            QtdeEstoque = (double)numQtdeEstoque.Value;
            PrecoUnitario = (double)numPrecoUnitario.Value;
            QtdeVenda = (double)numQtdeVenda.Value;

            if (QtdeVenda > QtdeEstoque)
            {
                txtMensagem.Text = ("Qtde em estoque indisponível!");

            }
            else
            {
                // Cálculo do total do pedido
                txtMensagem.Clear(); // Para a mensagem ser limpa no proximo click no botão calcular
                double TotalPedido = PrecoUnitario * QtdeVenda;
                txtTotalPedido.Text = TotalPedido.ToString("F2");
                txtMensagem.Text = ("Compra Bem-sucedida");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false; // Desabilita o botão calcular
            btnNovo.Enabled = true; // Habilita o botão Novo
            grbDados.Enabled = false; // Desabilita o groupbox Dados
        }

        private void grbDados_Enter(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
