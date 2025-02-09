using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 7");

            int dia;

            if (!int.TryParse(Console.ReadLine(), out dia))
            {
                Console.WriteLine("Número inválido");
                return;
            }
            else
            {
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Segunda-feira");
                        break;
                    case 3:
                        Console.WriteLine("Terça-feira");
                        break;
                    case 4:
                        Console.WriteLine("Quarta-feira");
                        break;
                    case 5:
                        Console.WriteLine("Quinta-feira");
                        break;
                    case 6:
                        Console.WriteLine("Sexta-feira");
                        break;
                    case 7:
                        Console.WriteLine("Sábado");
                        break;
                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
