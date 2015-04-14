using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite numeros inteiros positivos para calcular a media, ao teminar digite 0:");

            int quantidade = 0;
            int soma = 0;
            var numero = int.Parse(Console.ReadLine());
            double media = 0; 
            

            while (numero > 0)
            {
                quantidade++;
                soma += numero;
                numero = int.Parse(Console.ReadLine());
            }

            media = soma / quantidade;

            Console.WriteLine("A media é: {0}", media);

        }
    }
}
