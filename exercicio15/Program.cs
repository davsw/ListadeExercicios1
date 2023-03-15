using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira aqui a temperatura em celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal fahrenheit = (celsius * 9)/5 + 32;

            Console.WriteLine("A temperatura de " + celsius + " graus celsius em fahrenheit é: " + fahrenheit);
            Console.ReadLine();
        }
    }
}
