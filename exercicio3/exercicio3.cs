using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class exercicio3
    {
        private const double V = 3.14;

        static void Main(string[] args)
        {
            double volume;
            double raio;
            double altura;

            Console.WriteLine("Vamos calcular o volume de um cilindro. Insira aqui o valor do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira aqui a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio, 2) * altura;
                
            Console.WriteLine("O volume do cilindro é: ");
            Console.WriteLine(volume);

            Console.ReadLine();
        }
    }
}
