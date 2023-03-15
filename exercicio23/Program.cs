using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;  

            for (int i = 1; i <= 500; i++) 
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("A soma dos números é: " + soma);
            Console.ReadLine();
        }
    }
}
