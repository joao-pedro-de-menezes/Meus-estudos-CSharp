using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Frutas
{
    internal class Program
    {
        static void Main(string[] args) // Array
        {
            string[] frutas =
            {
                "Maçã", "Pera", "Goiaba", "Uva", "Laranja", "Ameixa"
            };

            Console.WriteLine("Lista de Frutas");
            //Console.WriteLine(frutas[0]);
            //Console.WriteLine(frutas[1]);

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            List<string> produtos = new List<string>(); // List

            produtos.Add("Mouse");
            produtos.Add("Teclado");
            produtos.Add("Impressora");

            Console.WriteLine("Lista de Produtos de Informática");
            foreach (var List_produtos in produtos)
            {
                Console.WriteLine(List_produtos);
            }
        }
    }
}
