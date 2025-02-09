using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício08
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma letra: ");
            var letra = Console.ReadLine();

            if (string.IsNullOrEmpty(letra))
            {
                Console.WriteLine("Entrada inválida. Digite uma letra.");
            }
            else
            {
                switch (letra.ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.Clear();
                        Console.WriteLine("A letra escolhida é vogal");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("A letra escolhida é consoante");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            }
        }
    }
}
