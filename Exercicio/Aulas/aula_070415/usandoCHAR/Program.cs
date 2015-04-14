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
            

        }

        static void Resposta()
        {

            string texto = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string tmp = Console.ReadLine();
            char c = tmp[0];
            for (int i = 0; i < texto.Length; i += n)
            {
                if (i + n > texto.Length)
                {
                    Console.WriteLine(texto.Substring(i));
                }

                else
                {
                    Console.WriteLine(texto.Substring(i, n));
                }
            }
            string[] palavras = texto.Split(' ');
            int qtd = 0;

            for (int i = 0; i < palavras.Length; i++) //Transformar em foreach
            {                                         //Maiusculo e minusculo, na minha solucao
                if (palavras[i][0] == 5)
                {
                    qtd++;
                }
            }
            Console.WriteLine(qtd);

          
        
        }

        static void minhaSolucao()
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
                    contador++;
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

