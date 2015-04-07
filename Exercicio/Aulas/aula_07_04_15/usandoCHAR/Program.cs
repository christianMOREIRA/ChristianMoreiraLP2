using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usandoCHAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string frase;
            char caracter;
            int contador = 0;
            

            Console.WriteLine("Digite uma frase:");
           frase = Console.ReadLine();

           Console.WriteLine("Digite o numero de caracteres: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual caracter quer acessar:");
            caracter = char.Parse(Console.ReadLine());

            var fraseEmMaisculo = frase.ToUpper();
            var caracterEmMaisculo = char.Parse(caracter.ToString().ToUpper());
            for (int i = 0; i < fraseEmMaisculo.Length; i++)
			{
                if (fraseEmMaisculo[i] == caracterEmMaisculo)
	            {
                    contador ++;
	            }
			 
			}
            for (int i = 1; i <= frase.Length; i++)
            {
                Console.Write(frase[i - 1]);
                if (i % n == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine(contador);
           


                 




























                     }

        }
    }

