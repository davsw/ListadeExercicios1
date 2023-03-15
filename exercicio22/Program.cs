using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 101; i <= 199; i += 2) ; 
            {
                int numeroImpar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numeroImpar);
            }

            Console.ReadLine();
        }
    }
}
