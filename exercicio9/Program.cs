using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numNotas = 3;
            decimal nota1;
            decimal nota2;
            decimal nota3;
            decimal mediaH;
            decimal notasDivididas;

            Console.WriteLine("Vamos fazer sua média harmônica com 3 notas.");

            Console.WriteLine("Insira aqui a nota 1");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira aqui a nota 2");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira aqui a nota 3");
            nota3 = Convert.ToInt32(Console.ReadLine());

            notasDivididas = 1/nota1 + 1/nota2 + 1/nota3;

            mediaH = numNotas / notasDivididas;


            Console.WriteLine("A sua média é: " + mediaH);

            Console.ReadLine();
        }
    }
}
