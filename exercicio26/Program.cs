using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int fatorial = 1;

            Console.WriteLine("Digite um valor para A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + "! = ");

            for(int i = a; i >= 1; i--) 
            { 
                Console.WriteLine(i + " ");
                fatorial *= i;

                if (i > 1) 
                {
                    Console.WriteLine("X ");
                }
            }
        }
    }
}
