using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_4_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1 = 0, Nota2 = 0, Nota3 = 0, Nota4 = 0, Media = 0;
            string Aluno = "", Disciplina = "";
            Console.Write("\nCalcula e exibe a média de 4 notas");
            Console.Write("\n==================================");

            Console.Write("\nDigite o nome do aluno: ");
            Aluno = Console.ReadLine();

            Console.Write("\nDigite a Disciplina: ");
            Disciplina = Console.ReadLine();

            Console.Write("\nNota 1: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNota 2: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNota 3: ");
            Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nNota 4: ");
            Nota4 = Convert.ToDouble(Console.ReadLine());

            // Calcula a média
            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            Console.Write("\nA média do aluno " + Aluno + " da disciplina: " + Disciplina + " é " + Media);

            if (Media >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nParabéns, Você está aprovado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nInfelizmente você foi reprovado");
            }
            Console.ReadKey();
        }
    }
}
