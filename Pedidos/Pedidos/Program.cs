using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TotalPedido, PrecoUnitario, Qtde, Estoque; //Double é usado para numeros inteiros ou quebrados
            string Produto, Marca;
            Console.BackgroundColor = ConsoleColor.White; //Muda a cor do fundo
            Console.ForegroundColor = ConsoleColor.Magenta; //Muda a cor das letras
            Console.Clear();
            Console.WriteLine("Calcular e exiber o total do produto");
            Console.Write("Digite o nome do produto: ");
            Produto = Console.ReadLine();

            Console.Write("Marca: ");
            Marca = Console.ReadLine();

            Console.Write("Preço Unitário: ");
            PrecoUnitario = Convert.ToDouble (Console.ReadLine());

            Console.Write("Quantidade: ");
            Qtde = Convert.ToDouble (Console.ReadLine());

            Console.Write("Estoque: ");
            Estoque = Convert.ToDouble (Console.ReadLine());

            TotalPedido = PrecoUnitario * Qtde; // Faz o cálculo

            Console.WriteLine("Total do pedido: " + TotalPedido.ToString());

            Console.ReadKey();



        }
    }
}
