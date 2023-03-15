using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int aux;

            for (int i = 0; i​​​​​​​ < 60; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
                Console.WriteLine("{0}", num2);

            }
            Console.ReadLine();
        }
    }
}
