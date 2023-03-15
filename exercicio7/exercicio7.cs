using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase;
            decimal totalVendas;
            decimal comissao;
            decimal salarioTotal;
            decimal percentualComissao;

            Console.WriteLine("Insira aqui seu salario base: ");
            salarioBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira aqui o valor do total de vendas: ");
            totalVendas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira aqui o percentual da sua comissao sob vendas: ");
            percentualComissao = Convert.ToInt32(Console.ReadLine());

            comissao = percentualComissao / 100;
            salarioTotal = salarioBase + totalVendas * comissao;


            Console.WriteLine("O seu salario total é: " + salarioTotal);
           
            Console.ReadLine();

        }
    }
}
