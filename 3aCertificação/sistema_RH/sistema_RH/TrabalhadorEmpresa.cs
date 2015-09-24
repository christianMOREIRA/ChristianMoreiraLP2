using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_RH
{
    class TrabalhadorEmpresa : Funcionario
    {
        private double _salario = 5000;

        public virtual double Salario()
        {
            return _salario;
        }

        public virtual double vale_alimentacao()
        {
            double vale_alimentacao = this._salario * (6.5 / 100);

            if (vale_alimentacao > 750)
            {
                vale_alimentacao = 750;
            }

            return vale_alimentacao;
        }
    }
}
