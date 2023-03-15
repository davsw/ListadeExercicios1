using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir a área do terreno.\n");

            Console.WriteLine("Qual o comprimento do lado A?\n");
            decimal ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o comprimento do lado B?\n");
            decimal ladoB = Convert.ToInt32(Console.ReadLine());

            decimal area = ladoA * ladoB;

            Console.WriteLine("A área do terreno é: " + area);

            Console.ReadLine();
        }
    }
}
