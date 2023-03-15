using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisor = 0;

            Console.WriteLine("Insira aqui o número para saber se é primo: ");
            decimal numEscolhido = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numEscolhido; i++)
            { 

                if (numEscolhido % i == 0) 
                    divisor++;
            }

            if (divisor == 2)
            {
                Console.WriteLine("É um numero primo!");

                Console.ReadLine();
            }


            else
            {
                Console.WriteLine("Não é um número primo.");

                Console.ReadLine();

            }

        }

    }
}
