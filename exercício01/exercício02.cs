using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício02
    {
        static void Main(string[] args)
        {
            var dataPassada = new DateTime(2025, 02, 02);
            var dataFutura = new DateTime(2025, 02, 18);

            var dataDifereanca = dataFutura - dataPassada;
            Console.WriteLine($"A diferança entre as datas é {dataDifereanca.Days}");


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();  
        }
    }
}
