using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção: ");

            Console.WriteLine("1 - Vermelho");
            Console.WriteLine("2 - Verde");
            Console.WriteLine("3 - Azul");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();    
                    Console.WriteLine("A cor escolhida foi Vermelho");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("A cor escolhida foi Verde");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("A cor escolhida foi Azul");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}