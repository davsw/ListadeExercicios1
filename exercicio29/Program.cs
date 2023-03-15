using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int i;

            do
            {
                Console.WriteLine("Digite um valor maior que zero: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x <= 0);

            for (i = 0; i <= 10; i++) 
            {
                Console.WriteLine(x + " * " + i + " = " + x * i + "\n");
            }
            Console.ReadLine();
        }
    }
}
