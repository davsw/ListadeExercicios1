using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace robo_tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o grid no eixo X: ");
            int posicaoGridX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o grid no eixo Y: ");
            int posicaoGridY = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Insira a posição inical no eixo X: ");
            int posicaoInicialX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a posição inicial no eixo Y");
            int posicaoInicialY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a direção do robô em N (Norte), S (Sul), L (Leste), O (Oeste): ");
            char direcao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Insira o comando para o robô: ");
            string comando = Console.ReadLine();

            char[] comandoChar = comando.ToCharArray();

            for (int i = 0; i < comandoChar.Length; i++)
            {
                if (comandoChar[i] == 'M')
                {
                    if (direcao == 'N')
                    {
                        posicaoInicialY++;
                    }

                    else if (direcao == 'S')
                    {
                        posicaoInicialY--;
                    }

                    else if (direcao == 'L')
                    {
                        posicaoInicialX++;
                    }

                    else if (direcao == 'O')
                    {
                        posicaoInicialX--;
                    }
                    

                }
                else if (comandoChar[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'N';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }


                  else if (comandoChar[i] == 'D')
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'L')
                        {
                            direcao = 'S';
                        }
                        else if (direcao == 'S')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'N';
                        }
                       
                    }

                }

            }
            Console.WriteLine("A atual localização do robô é: " + posicaoInicialX + " " + " " + posicaoInicialY + " " + " " + direcao);
            Console.ReadLine();
        }
    }
}
