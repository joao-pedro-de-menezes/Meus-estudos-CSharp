using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_Logico_E_Viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TemCombustivel = "", EhFeriado = "";
            Console.Write("\n Verifica se tem combustivel e é Feriado SIM/NÃO: ");
            Console.Write("\n Carro tem combustivel? SIM/NÃO: ");
            TemCombustivel = Console.ReadLine();
            Console.Write(" Hoje é feriado? SIM/NÃO: ");
            EhFeriado = Console.ReadLine();

            // Converte as variaveis para maiusculo
            TemCombustivel = TemCombustivel.ToUpper();
            EhFeriado = EhFeriado.ToUpper();

            // Verifica se pode viajar
            if (TemCombustivel == "SIM" && EhFeriado == "SIM")
            {
                Console.Write("\nMuito bem... você pode viajar");
            }
            else
            {
                Console.Write("\nLamento... você não pode viajar");
            }
            Console.ReadKey(); // Dá uma pausa para ler a mensagem
            {

            }
        }
    }
}
