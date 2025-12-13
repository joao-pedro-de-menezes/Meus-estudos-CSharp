using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursos_Array
{

    public partial class frmCursos : Form
    {
       

        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            
            // Criação de Array e preenchimento de ComboBox
            string[] softwares = new string[]
            {
                "", // outro jeito de deixar a caixa vazia
                "Word",
                "Excel",
                "PowerPoint",
                "Visual Studio",
                "SQL Server",
                "Bloco de Notas",
                "NotePad++"
            };

            // Exibindo o Array no ComboBox
            cmbCurso.DataSource = softwares;

            // Para quando iniciar, ficar com a caixa vazia
            cmbCurso.SelectedIndex = -1;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (cmbCurso.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor, selecione um dos cursos!", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCurso.Focus();
                return;
            }
            switch (cmbCurso.SelectedIndex)
            {
                case 1:
                    lblExibir.Text = "Processador de Textos";
                    break;

                case 2:
                    lblExibir.Text = "Planilha Eletrônica";
                    break;

                case 3:
                    lblExibir.Text = "Apresentação Multimídia";
                    break;

                case 4:
                    lblExibir.Text = "Programas: C#, C++, Visual Basic";
                    break;

                case 5:
                    lblExibir.Text = "Gerenciador de Banco de Dados";
                    break;

                case 6:
                    lblExibir.Text = "Editor de Texto Simples";
                    break;

                case 7:
                    lblExibir.Text = "Editor de Código Fonte";
                    break;

                default:
                    break;
            }
        }

    }
}
