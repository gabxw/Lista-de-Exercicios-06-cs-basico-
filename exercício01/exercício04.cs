using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício04
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma data no formato dd/MM/yyyy:");
            DateTime dataFeriado;
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataFeriado))
            {

                int dia = dataFeriado.Day;
                int mes = dataFeriado.Month;


                switch (mes)
                {
                    case 1:
                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine("A data é um feriado: Ano Novo.");
                                break;
                            default:
                                Console.WriteLine("A data não é um feriado.");
                                break;
                        }
                        break;

                    case 4:
                        switch (dia)
                        {
                            case 21:
                                Console.WriteLine("A data é um feriado: Tiradentes.");
                                break;
                            default:
                                Console.WriteLine("A data não é um feriado.");
                                break;
                        }
                        break;

                    case 5:
                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine("A data é um feriado: Dia do Trabalhador.");
                                break;
                            default:
                                Console.WriteLine("A data não é um feriado.");
                                break;
                        }
                        break;

                    case 9:
                        switch (dia)
                        {
                            case 7:
                                Console.WriteLine("A data é um feriado: Independência do Brasil.");
                                break;
                            default:
                                Console.WriteLine("A data não é um feriado.");
                                break;
                        }
                        break;

                    case 10:
                        switch (dia)
                        {
                            case 12:
                                Console.WriteLine("A data é um feriado: Nossa Senhora Aparecida.");
                                break;
                            default:
                                Console.WriteLine("A data não é um feriado.");
                                break;
                        }
                        break;

                    case 11:
                        switch (dia)
                        {
                            case 2:
                                Console.WriteLine("A data é um feriado: Finados.");
                                break;
                            case 15:
                                Console.WriteLine("A data é um feriado: Proclamação da República.");
                                break;
                            default:
                                Console.WriteLine("A data não é um feriado.");
                                break;
                        }
                        break;

                    case 12:
                        switch (dia)
                        {
                            case 25:
                                Console.WriteLine("A data é um feriado: Natal.");
                                break;
                            default:
                                Console.WriteLine("A data não é um feriado.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("A data não é um feriado.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Data inválida. Certifique-se de usar o formato dd/MM/yyyy.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}