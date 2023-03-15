using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal celsius;
            decimal fahrenheit;

            Console.WriteLine("Insira aqui a temperatura em graus Celsius: ");
            celsius = Convert.ToDecimal(Console.ReadLine());

            fahrenheit = celsius * 1.8m + 32;

            Console.WriteLine("A temperatura em graus Fahrenheit é: ");
            Console.WriteLine(fahrenheit);
            Console.ReadLine();
        }
    }
}
