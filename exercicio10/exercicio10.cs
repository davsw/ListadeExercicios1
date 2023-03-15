using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua primeira nota: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da nota do primeiro bimestre: ");
            decimal peso1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda nota: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da segunda nota: ");
            decimal peso2 = int.Parse(Console.ReadLine());

            // Para calcular a média ponderada de um conjunto de valores, calculamos o produto de cada valor pelo seu peso,
            // somamos os produtos encontrados, e dividimos a soma pela soma dos pesos.

            decimal produtoPeso = (peso1 * nota1) + (peso2 * nota2);
            decimal mp = produtoPeso / peso1 + peso2;

            // media para passar = 7

            if (mp >= 7) 
            {
                Console.WriteLine("Parabéns! Você passou de ano.");
            }

            // Se a media ficar acima de 4 e abaixo de 7 = recuperaçao

            else if (mp >= 4 && mp < 7) 
            {
                Console.WriteLine("Você ficou em recuperação");
            }

            // se ficar abaixo disso = reprovaçao

            else
            {
                Console.WriteLine("Você foi reprovado.");
            }

            Console.ReadLine();
        }
    }
}
