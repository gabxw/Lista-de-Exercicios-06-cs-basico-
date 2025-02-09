using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício05
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar) // Loop principal
            {
                int entradaSistema;

                // Exibir o menu
                Console.WriteLine("====================================");
                Console.WriteLine("1 - Consultar");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("3 - Alterar");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("====================================\n");

                // Solicitar a entrada do usuário
                Console.WriteLine("Digite uma opção de entrada:");
                if (!int.TryParse(Console.ReadLine(), out entradaSistema))
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    Console.ReadKey();
                    continue; // Volta ao início do loop
                }

                // Processar a entrada
                switch (entradaSistema)
                {
                    case 1:
                        ProcessarOpcao("consultar");
                        break;
                    case 2:
                        ProcessarOpcao("cadastrar");
                        break;
                    case 3:
                        ProcessarOpcao("alterar");
                        break;
                    case 4:
                        continuar = false; // Sai do loop
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Erro. Caractere não disponível.");
                        break;
                }

                if (continuar) // Se não estiver saindo, aguarda uma tecla para continuar
                {
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                    Console.Clear(); // Limpa a tela antes de exibir o menu novamente
                }
            }

            Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        // Método para processar as opções (evita repetição de código)
        static void ProcessarOpcao(string opcao)
        {
            Console.Clear();
            Console.WriteLine($"Você está na parte de {opcao}.");

            Console.WriteLine("Deseja voltar ao menu? (sim/não)");
            string voltar = Console.ReadLine();

            if (voltar.ToLower() == "sim")
            {
                Console.WriteLine("Voltando ao menu...");
            }
            else
            {
                Console.WriteLine("Saindo...");
                Environment.Exit(0); // Encerra o programa
            }
        }
    }
}