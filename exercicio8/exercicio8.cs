using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal raio;
            decimal pi = 3.14m;
            decimal altura;
            decimal volume;

            Console.WriteLine("Insira aqui o valor do raio: ");
            raio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira aqui o valor da altura: ");
            altura = Convert.ToInt32(Console.ReadLine());  

            volume = pi * raio * raio * altura;


            Console.WriteLine("O volume da lata de óleo é: " + volume + " centimentros.");
            Console.ReadLine();




        }
    }
}
