using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num;

         
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
            }
            else
            {
                
                switch (Math.Sign(num)) 
                {
                    case 1:
                        Console.WriteLine("O número é positivo.");
                        break;
                    case -1:
                        Console.WriteLine("O número é negativo.");
                        break;
                    case 0:
                        Console.WriteLine("O número é zero.");
                        break;
                    default:
                        Console.WriteLine("Erro inesperado.");
                        break;
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}