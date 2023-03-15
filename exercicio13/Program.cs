using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira aqui a quantidade de pães vendidos: ");
            decimal quantPaes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira aqui a quantidade de broa vendida: ");
            decimal quantBroa = Convert.ToInt32(Console.ReadLine());

            decimal valorPaes = quantPaes * 0.12m;
            decimal valorBroa = quantBroa * 1.50m;

            decimal quantArrecadada = valorBroa + valorPaes;

            Console.WriteLine("Você vendeu " +  quantArrecadada + " reais.");

            decimal poupanca = quantArrecadada * 10 / 100;

            Console.WriteLine("Você deve guardar " + poupanca + " reais na poupança.");
            
            Console.ReadLine();



        }
    }
}
