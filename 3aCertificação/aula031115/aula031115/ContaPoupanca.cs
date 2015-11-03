using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula031115
{
    class ContaPoupanca : ContaBancaria
    {
        int diadorendimento;
        public void CaucularNovoSaldo(double rendimento, int diadorendimento)
        {
            double percentualtotal = rendimento * diadorendimento;
            Saldo = Saldo * (1 + percentualtotal / 100);
        }
    }
}
