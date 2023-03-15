using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0) 
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é impar."); 
            }
            Console.ReadLine();
        }
    }
}
