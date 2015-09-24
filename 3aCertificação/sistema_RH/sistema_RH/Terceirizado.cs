using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_RH
{
    class Terceirizado : Funcionario
    {
        private string cnpj;

        //Propriedades

        public string Cnpj { get; set; }
    }
}
