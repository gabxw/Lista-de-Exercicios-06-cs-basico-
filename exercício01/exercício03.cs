using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício01
{
    internal class Exercício03
    {
        static void Main(string[] args)
        {
            DateTime dataAniversario;
            var dataAtual = DateTime.Now;

            TimeSpan dataDifereanca;
            Console.WriteLine("Digite a data do seu aniversario no formato dd/mm/aaaa");
            dataAniversario = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            dataDifereanca = dataAtual - dataAniversario;
            Console.WriteLine($"A diferança entre as datas é {dataDifereanca.Days} dias");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
