using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_Logico_Ou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sexo = "";
            Console.Write("\nVerifica se sexo informado é M ou F");
            Console.Write("\nDigite o sexo M ou F: ");
            Sexo = Console.ReadLine();

            Sexo = Sexo.ToUpper(); // Converte minusculas para maiusculas
            if (Sexo == "M" || Sexo == "F")
            {
                Console.Write("\nSexo Válido");


                if (Sexo == "M")
                {
                    Console.Write("\nSeu sexo é masculino");
                }
                if (Sexo == "F")
                {
                    Console.Write("\nSeu sexo é feminino");
                }

            }
            else
            {

                Console.Write("\nSexo Inválido");
            }
            Console.ReadKey();
        }


    }
}
