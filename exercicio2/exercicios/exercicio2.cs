using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class exercicio2
    {
        static void Main(string[] args)
        {

            double celsius;
            double fahrenheit;

            Console.WriteLine("Vamos converter a temperatura de Fahrenheit em graus Celsius. Insira aqui a temperatura em Fahrenheit: ");
            fahrenheit = Convert.ToInt32(Console.ReadLine()); 


            celsius = (fahrenheit - 32) / 1.8;
            

            Console.WriteLine("A temperatura em celsius é: ");
            Console.WriteLine(celsius);
            Console.ReadLine();
        }
    }
}
