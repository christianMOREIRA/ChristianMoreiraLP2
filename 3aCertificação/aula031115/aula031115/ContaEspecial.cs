using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula031115
{
    class ContaEspecial : ContaBancaria
    {
        public double limite { get; set; }

        public void Sacar(double valor)
        {

            if (Saldo + limite < valor)
            {
                Saldo = Saldo - valor;
            }
        }
        public override void Transferencia(double valor, ContaBancaria conta)
        {
            
            if (Saldo + limite < valor)
            {
                conta.Saldo = conta.Saldo + valor;
            }
        }

    }
}
