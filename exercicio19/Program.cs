using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso em kg: ");
            decimal peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite sua altura em metros: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine()); 

            decimal imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc);   

            if(imc < 18.5m)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
                {
                Console.WriteLine("Acima do peso");
            }
            else 
            {
                Console.WriteLine("Obeso");
                    }
            Console.ReadLine();
        }

       
    }
}
