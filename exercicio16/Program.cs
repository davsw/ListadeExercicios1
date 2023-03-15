using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira aqui seu salário: ");
            decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

            decimal salarioAumento = salarioInicial * 15 / 100;

            Console.WriteLine("Com um aumento de 15%, este é seu salário: ");
            Console.WriteLine(salarioAumento);

            decimal salarioDesconto = salarioInicial * 8;
            decimal salarioDescontoOito = salarioInicial - salarioDesconto;

            Console.WriteLine("Seu salário final após um desconto de 8% é: " + salarioDescontoOito);

            Console.ReadLine();
        }
    }
}
