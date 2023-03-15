using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal volume;
            decimal pi = 3.14m;
            decimal raio;

            Console.WriteLine("Insira aqui o valor do raio: ");
            raio = Convert.ToDecimal(Console.ReadLine());

            volume = 4 * pi * (raio * raio * raio)/3;

            Console.WriteLine("O volume dessa esfera é: ");
            Console.WriteLine(volume + " centimetros cubicos");
            Console.ReadLine();
        


        }
    }
}
