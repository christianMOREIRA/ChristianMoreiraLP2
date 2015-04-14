using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            string operacao;
            string cont = "s";
            double resultado = 0;

            Console.WriteLine("CAUCULADORA: ");
            try
            {
                Console.WriteLine("Digite o valor: ");
                x = double.Parse(Console.ReadLine());
                while (cont == "s")
                {
                
                Console.WriteLine("Digite o valor: ");
                y = double.Parse(Console.ReadLine());


               


                    Console.WriteLine("Escolha a operação, + , -  , / , *   :");
                    operacao = Console.ReadLine();
                    if (operacao == "+")
                    {
                        resultado = x + y;
                    }
                    else if (operacao == "-")
                    {
                        resultado = x + y;
                    }
                    else if (operacao == "/")
                    {
                        resultado = x / y;
                    }
                    else if (operacao == "*")
                    {
                        resultado = x * y;
                    }
                    else
                    {
                        Console.WriteLine("A operação não foi identificada");
                    }

                    Console.WriteLine("O resultado é : {0}", resultado);
                    Console.WriteLine("Deseja continuar o mesmo cáuculo ? S para continuar :");
                    cont = Console.ReadLine();
                    x = resultado;
                }
                Console.WriteLine("O resultado final foi {0}", resultado);

            }
            catch (Exception)
            {

                Console.WriteLine("Os valores digitados não são reais");
            
            }

        }


    }
}
