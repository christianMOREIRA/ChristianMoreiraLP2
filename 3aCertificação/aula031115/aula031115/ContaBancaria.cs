using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula031115
{
    class ContaBancaria
    {
        public string Cliente { get; set; }
        public int NumConta { get; set; }
        public double Saldo { get; set; }
        

        
        public void Sacar(double valor)
        {
            if (Saldo > 0 && Saldo >= valor)
            {
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        public void Depositar(double valor2)
        {
            Saldo = Saldo + valor2;
        }

        public void Transferencia(double valor, ContaBancaria conta)
        {
            if (Saldo - valor >= 0)
            {
              
            }
        }
    }
}
