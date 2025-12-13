using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tchauzinho, Pegou a referencia?");
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            numVenda.Value = 0; // Esse é o modo para limpar NumericUpDown
            txtExibir.Clear();
            txtComissao.Clear();
            numVenda.Focus(); // Coloca o foco da escrita para o numVenda, que está localizado na primeira caixa de numero
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Verifica se a venda é maior ou igual que 500
            double venda = 0;
            double comissao = 0;
            try // Tenta executar a codificação
            {
                venda = (double)numVenda.Value; //!! Primeira forma para converção de dados
                comissao = Convert.ToDouble(txtComissao.Text); //!! Segunda forma para converção de dados

                if (venda >= 500)
                {
                    comissao = 100;
                    venda += comissao; // Armazena na variável venda, a soma da venda + a comissão
                    txtExibir.Text = string.Format("{0:C}", venda); // Exibe o valor formato como moeda
                }
                else
                {
                    comissao = 10;
                    txtExibir.Text = "R$" + (venda + comissao).ToString("F2"); 
                }
            }
            catch (Exception ex) // Senão conseguir, exibe o conteúdo dentro do catch
            {

                MessageBox.Show(ex.Message + "\n" + "Erro catastrófico... informe o valor da comissão!"); // O "ex" mostra o erro que o sistema identifica
            }
            finally
            {
                MessageBox.Show("Processo solicitado foi executado"); // É sempre executado idependente se o código esta correto ou não, é como se fosse uma valvula de escape
            }
           
        }
    }
}
