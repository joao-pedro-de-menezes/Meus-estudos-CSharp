using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viagem_Operador_Logico_E
{
    public partial class frmViagem : Form
    {
        public frmViagem()
        {
            InitializeComponent();
        }

        private void frmViagem_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecusaTXT_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaTXT_Click(object sender, EventArgs e)
        {
            if (txtTemCombustivel.Text.ToUpper() =="SIM" && txtEhFeriado.Text.ToUpper() =="SIM")   
            {
                MessageBox.Show("Muito Bem... Você pode viajar");
            }
            else
            {
                MessageBox.Show("Sinto muito, mas não poderas viajar kkkk");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADEUS");
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTemCombustivel.Clear();
            txtEhFeriado.Clear();
            cmbTemCombustivel.SelectedIndex = -1;
            cmbEhFeriado.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTemCombustivel.Text == "SIM" && cmbEhFeriado.Text == "SIM") 
            {
                MessageBox.Show("Você pode viajar, Vamos lá");
            }
            else
            {
                MessageBox.Show("Você não pode viajar kkkkk, até a proxima");
            }
        }

        private void btnConfirmarLST_Click(object sender, EventArgs e)
        {
            if (lstTemCombustivel.Text =="SIM" && lstEhFeriado.Text =="SIM")
            {
                MessageBox.Show("Agora sim, pé na estrada");
            }
            else
            {
                MessageBox.Show("Vai ter que ficar em casa mesmo kkkkk");
            }
        }

        private void btnConfirmarCHK_Click(object sender, EventArgs e)
        {
            if (chkTemCombustivel.Checked && chkEhFeriado.Checked)
            {
                MessageBox.Show("Arrume suas malas e vamos logo!");
            }
            else
            {
                MessageBox.Show("Desse jeito não tem jeito, vá durmi kkkkk");
            }
        }
    }
}
