using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Digite três valores inteiros e diferentes");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + ", " + b + ", " + c);
                }
                else
                {
                    Console.WriteLine(a + ", " + c + ", " + b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(b + ", " + a + ", " + c);
                }
                else
                {
                    Console.WriteLine(b + ", " + c + ", " + a);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(c + ", " + a + ", " + b);
                }
                else
                {
                    Console.WriteLine(c + ", " + b + ", " + a);
                }
                Console.ReadLine();
            }
            }


            }
        }
    

