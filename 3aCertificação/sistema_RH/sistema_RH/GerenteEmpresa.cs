using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_RH
{
    class GerenteEmpresa : TrabalhadorEmpresa
    {
        TrabalhadorEmpresa funci = new TrabalhadorEmpresa();

        private string _area;

        public string Area { get; set; }
        double sal;
        public override double Salario()
        {
            return sal = funci.Salario() + 4000;

        }

        public override double vale_alimentacao()
        {
            double valeAlimentacao = Salario() * 0.08;

            if (valeAlimentacao > 750)
            {
                valeAlimentacao = 750;
            }
            else
            {
                valeAlimentacao = valeAlimentacao;
            }
            return valeAlimentacao;
        }
    }
}
