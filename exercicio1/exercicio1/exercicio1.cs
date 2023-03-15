using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class exercicio1
    {
        static void Main(string[] args)
        {

            decimal altura;
            decimal largura;
            decimal comprimento;
            decimal volume;

            Console.WriteLine("Insira aqui a altura da sua caixa retangular: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira aqui a largura da sua caixa retangular: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira aqui o comprimento da sua caixa retangular: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            volume = altura * largura * comprimento;

            Console.WriteLine("O volume da caixa retangular é: " + volume);
            Console.ReadLine();
        }
    }
}
