using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
            }
            else 
            {
                c = a * b;
            }
            Console.WriteLine("O resultado é: " + c);
            Console.ReadLine();
        }
    }
}
