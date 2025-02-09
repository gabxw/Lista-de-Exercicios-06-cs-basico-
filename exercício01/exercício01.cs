using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade06
{
    internal class Exercício01
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;
            Console.WriteLine($"A data e horario de hoje é {data}");


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();  
        }
    }
}
