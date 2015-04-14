using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_140415_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double tempo;
            int dd = 1;
            int gg = 0;

            string[] nadadores = new string[5];
            double[ , ] provas = new double[5,3];

            for (int j = 0; j < 5; j++)
                {
                    
                    Console.WriteLine("Digite o nome do {0} participante", dd);
                    nadadores[j] = Console.ReadLine();
                    dd++;
                    

                }
            for (int p = 0; p < 3; p++)
            {
                gg++;
                for (int t = 0; t < 5; t++)
                {
                    Console.WriteLine("Escreva o tempo do participante {0} em segundos, na {1} prova", nadadores[t], gg);
                    tempo = double.Parse(Console.ReadLine());
                    provas[t, p] = tempo;

                }
            }
            string campeao = nadadores[1];
                for (int k = 1; k < 5; k++)
                {
                                
                    
                }
            
            Console.WriteLine("O campeão foi {0}", nadadores);
                        
                    
        }
    }
}
