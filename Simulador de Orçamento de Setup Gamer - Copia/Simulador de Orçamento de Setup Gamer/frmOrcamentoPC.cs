using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_Orçamento_de_Setup_Gamer
{
    public partial class frmOrcamento : Form
    {
        public frmOrcamento()
        {
            InitializeComponent();
        }

        public class Peca // Criação de uma Classe
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }

            // Construtor para facilitar a criação
            public Peca(string nome, decimal preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Criando a lista de Processadores
            List<Peca> processadores = new List<Peca>();
            processadores.Add(new Peca("", 0));
            processadores.Add(new Peca("Intel Core i5 12400F", 900.00m));
            processadores.Add(new Peca("AMD Ryzen 5 5600", 850.00m));
            processadores.Add(new Peca("AMD Ryzen 7 5700X", 1100.00m));

            // Configurando o ComboBox de CPU 
            cmbProcessador.DataSource = processadores;
            cmbProcessador.DisplayMember = "Nome"; // O que aparece escrito
            cmbProcessador.ValueMember = "Preco";  // O valor que está "escondido" 
            

            List<Peca> placasDeVideos = new List<Peca>();
            placasDeVideos.Add(new Peca("", 0));
            placasDeVideos.Add(new Peca("RTX 5060", 2100.00m));
            placasDeVideos.Add(new Peca("RX 7600", 1600.00m));
            placasDeVideos.Add(new Peca("RTX 5060Ti", 2500.00m));

            cmbPlacaDeVideo.DataSource = placasDeVideos;
            cmbPlacaDeVideo.DisplayMember = "Nome";
            cmbPlacaDeVideo.ValueMember = "Preco";


            List<Peca> memoriaRam = new List<Peca>();
            memoriaRam.Add(new Peca("", 0));
            memoriaRam.Add(new Peca("Kingston Fury Beast DDR4 8gb", 250.00m));
            memoriaRam.Add(new Peca("XPG Gamixx DDR4 8gb", 200.00m));
            memoriaRam.Add(new Peca("Vengeance RGB Pro DDR4 8gb", 321.03m));

            cmbMemoriaRam.DataSource = memoriaRam;
            cmbMemoriaRam.DisplayMember = "Nome";
            cmbMemoriaRam.ValueMember = "Preco";           
        }
        
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbProcessador.Text))
            {
                MessageBox.Show("Escolha um Processador", "CPU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbProcessador.Focus();
                return;   
            }
            if (string.IsNullOrEmpty(cmbPlacaDeVideo.Text))
            {
                MessageBox.Show("Escolha uma Placa de Video", "GPU", MessageBoxButtons.OK, MessageBoxIcon.Information);               
               cmbPlacaDeVideo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbMemoriaRam.Text))
            {
                MessageBox.Show("Escolha uma Memoria Ram", "RAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMemoriaRam.Focus();
                return;
            }
          
            // PASSO 1: Recuperar os itens selecionados e converter (Cast)
            // O "(Peca)" na frente serve para transformar o 'object' genérico na sua classe 'Peca'
            Peca cpuSelecionada = (Peca)cmbProcessador.SelectedItem;
            Peca gpuSelecionada = (Peca)cmbPlacaDeVideo.SelectedItem;
            Peca ramSelecionada = (Peca)cmbMemoriaRam.SelectedItem;

            // PASSO 2: Fazer a matemática
            // Agora que o C# sabe que são peças, ele deixa você acessar o .Preco
            decimal total = cpuSelecionada.Preco + gpuSelecionada.Preco + ramSelecionada.Preco;


            if (chkMontagem.Checked)
            {
                total = total+150;
            }
            // PASSO 3: Exibir o resultado formatado
            // O "C2" formata automaticamente para moeda (Currency com 2 casas decimais -> R$ 1.000,00)
            txtOrcamento.Text = total.ToString("C2");


            // Montando o texto do resumo
            string resumo = $"Configuração Selecionada:\n" +
                            $"- {cpuSelecionada.Nome}\n" +
                            $"- {gpuSelecionada.Nome}\n" +
                            $"- {ramSelecionada.Nome}\n" +
                            $"- {(chkMontagem.Checked ? "Com Montagem e Formatação" : "Sem Montagem")}\n\n" +
                            $"Total a Pagar: {total.ToString("C2")}";
                           
            MessageBox.Show(resumo, "Resumo do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtOrcamento.Text = total.ToString("C2");
        }


    }
    }

