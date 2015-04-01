using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulalp2_31032015
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int potencia = 0;
            Console.WriteLine("digite o valo de x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                potencia += x * y;
                
            }
            Console.WriteLine(potencia);

        }
    }
}
