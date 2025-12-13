using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_Mover_Imagem
{
    public partial class frmWhileMover : Form
    {
        public frmWhileMover()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            const int ImagemMovimento = 10;
            int contador = 1;
            picWhileMover.Left = 5; // Posição inicial da imagem
            while (contador < 20)
            {
                // Move a imagem
                picWhileMover.Left += ImagemMovimento;

                Application.DoEvents();

                // Retarda a transição do movimento da imagem 
                Thread.Sleep(50);
                contador += 1;

            }
        }
    }
}
