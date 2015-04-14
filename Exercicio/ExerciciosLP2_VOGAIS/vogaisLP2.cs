using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            char[] vogais = {'a','e','i','o','u'};
            int numvogal = 0;


            Console.WriteLine("Digita uma mensagem");
            texto = Console.ReadLine();

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a')
                {
                    numvogal++;
                }
                if (texto[i] == 'e')
                {
                    numvogal++;
                }

                if (texto[i] == 'i')
                {
                    numvogal++;
                }

                if (texto[i] == 'o')
                {
                    numvogal++;
                }

                if (texto[i] == 'u')
                {
                    numvogal++;
                }

            }
            Console.WriteLine("O número de vogais é {0}", numvogal); 
         
            
        }
    }
}
