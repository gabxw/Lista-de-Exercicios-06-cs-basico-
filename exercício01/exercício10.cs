using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da sua camisa. 'p', 'm' ou 'g'");

            char tamanho;

            if(char.TryParse(Console.ReadLine(), out tamanho))
            {
                switch (tamanho)
                {
                    case 'p':
                        Console.WriteLine("Tamanho pequeno");
                        break;
                    case 'm':
                        Console.WriteLine("Tamanho médio");
                        break;
                    case 'g':
                        Console.WriteLine("Tamanho grande");
                        break;
                    default:
                        Console.WriteLine("Tamanho inválido");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tamanho inválido");
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
