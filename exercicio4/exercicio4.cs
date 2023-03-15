using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicios
{
    internal class exercicio4
    {
        static void Main(string[] args)
        {
            int kmInicial;
            int kmFinal;
            int consumoCombustivel;
            int gastoLitro;
            int kmTotal;

            Console.WriteLine("Insira aqui sua quilometragem antes do trajeto: ");
            kmInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantos quilometros seu carro faz por litro? ");
            gastoLitro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a quilometragem apos o trajeto");
            kmFinal = Convert.ToInt32(Console.ReadLine());

            kmTotal = kmFinal - kmInicial;

            consumoCombustivel = kmTotal / gastoLitro;

             
            Console.WriteLine("Voce andou " + kmTotal + "km"); 
            Console.WriteLine("Você gastou " +  consumoCombustivel + "litros no seu percurso");

            Console.ReadLine();
        }
    }
}
