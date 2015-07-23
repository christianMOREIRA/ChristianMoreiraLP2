using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_06_15LP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionário?");
            int funcionario = int.Parse(Console.ReadLine());
            string[] nome = new string[funcionario];
            string[] cpf = new string[funcionario];
            string[] datanasc = new string[funcionario];
            double[] salario = new double[funcionario];
            int[] anoadmissao = new int[funcionario];
            
            for (int i = 0; i < funcionario; i++)
            {
                
                Console.WriteLine("NOME");
                nome[i] = Console.ReadLine();

                Console.WriteLine("CPF");
                cpf[i] = Console.ReadLine();

                Console.WriteLine("Data nascimento");
                datanasc[i] = Console.ReadLine();

                Console.WriteLine("Salário");
                salario[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Data admissão");
                anoadmissao[i] = int.Parse(Console.ReadLine());

            }
            
            for (int j = 0; j < funcionario; j++)
            {
                if (anoadmissao[j] >= 2014)
	             {
                   salario[j] = salario[j] + 423.45 ;		 
	             }
                else if (anoadmissao[j] >= 2010 && anoadmissao[j] <= 2013)
                {
                    salario[j] = salario[j] + salario[j] * 984/10000;
                }
                else if (anoadmissao[j] >= 2000 && anoadmissao[j] <= 2009)
                {
                    salario[j]  = salario[j] + salario[j] * 164/1000;
                }
                else if (anoadmissao[j] <= 1999)
	            {
		            salario[j] = salario[j] + salario[j] * 226/1000;
	            }
            }
            for (int k = 0; k < funcionario; k++)
            {
                Console.WriteLine("***");
                Console.WriteLine("Nome: {0}", nome[k]);
                Console.WriteLine("CPF: {0}", cpf[k]);
                Console.WriteLine("Data de nascimento:  {0}", datanasc[k]);
                Console.WriteLine("Salário atual: {0}", salario[k]);
                Console.WriteLine("Ano de admissão: {0}", anoadmissao[k]);
                Console.WriteLine("***");
            }
        }
    }
}
