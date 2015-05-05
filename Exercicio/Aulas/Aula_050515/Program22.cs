using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_050515
{
    class Program
    {
        static void Main(string[] args)
        
{
            int posicao = 0;
            double hipo = 0; 
            double maior = double.MinValue;
            int baze = 0;
            int altura = 0;
            Console.Write("Digite quantos vetores     ");
            int n = int.Parse(Console.ReadLine());
            int[] x1 = new int[n];
            int[] y1 = new int[n];
            int[] x2 = new int[n];
            int[] y2 = new int[n];
            for (int j = 0; j < n; j++)
            {
                    
                Console.WriteLine("Digite o valor de x1");
                x1[j] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de y1");
                y1[j] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de x2 ");
                x2[j] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de y2 ");
                y2[j] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                 altura = y2[i] - y1[i];
                 baze = x2[i] - x1[i];
                 hipo = ((altura * altura) + (baze * baze));
                 hipo = Math.Sqrt(hipo);
                 if (hipo > maior)
                 {
                     maior = hipo;
                     posicao = i;
                 }
            }
            Console.WriteLine("Maior módulo no {0} vetor, com a hipotenusa valendo {1} com as cordenadas de {2},{3}  {4},{5}", posicao + 1, maior, x1[posicao], y1[posicao], x2[posicao], y2[posicao]);
        }
    }
}
