using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula031115
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria c = new ContaBancaria();
            Console.WriteLine("Nome do cliente:");
            c.Cliente = Console.ReadLine();
            Console.WriteLine("Numeor da conta:");
            c.NumConta = int.Parse(Console.ReadLine());
            Console.WriteLine("O saldo do cliente: ");
            c.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual valor deseja sacar");
            double saque = double.Parse(Console.ReadLine());
            c.Sacar(saque);
            Console.WriteLine("O saldo da sua conta é de {0}", c.Saldo);

            Console.WriteLine("Depositar: ");
            double depositar = double.Parse(Console.ReadLine());
            c.Depositar(depositar);
            Console.WriteLine("Nome do cliente: {0}", c.Cliente);
            Console.WriteLine("Numero da conta : {0}", c.NumConta);
            Console.WriteLine("O saldo atual é de {0}", c.Saldo);
            

        
        }
    }
}
