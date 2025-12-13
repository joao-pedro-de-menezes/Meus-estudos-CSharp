using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Pessoais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome, Cidade, Contato; //O tipo de variavel deve ser sempre colocada primeiro
            Console.WriteLine("Dados Pessoais"); //Escreve no console oque esta entre "()"
            Console.Write("Diga seu nome: ");
            Nome = Console.ReadLine(); //Faz com que o usuario possa escrever

            Console.Write("Cidade: ");
            Cidade = Console.ReadLine(); //Para chamar a variavel deve colocar desse jeito

            Console.Write("Contato: ");
            Contato = Console.ReadLine();

            Console.WriteLine(Nome);
            Console.WriteLine(Cidade);
            Console.WriteLine(Contato);

            Console.WriteLine(Nome + " mora em " + Cidade + " e o contato dele é " + Contato); //Para concatenar variavel com string é desse jeito

            Console.Write("Pressione quealquer tecla");
            Console.ReadKey(); //Pausa                
        }
    }
}
