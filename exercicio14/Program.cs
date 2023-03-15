using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Olá, qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome + " insira aqui sua idade (em anos): ");
            idade = Convert.ToInt32(Console.ReadLine());

            int diasVividos = idade * 365;

            Console.WriteLine(nome + ", você viveu " + diasVividos + " dias.");

            Console.ReadLine();
        }
    }
}
