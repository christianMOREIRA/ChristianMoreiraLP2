using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_230615
{
    class Funcionario
    {
        public string nome;
        public string cpf;
        public DateTime dataNascimento;
        public DateTime dataAdmissao;
        public decimal salario;

        public decimal CalculaAumento()
        {
            decimal aumento = 0;
            if (dataAdmissao.Year <= 2014)
            {
                aumento += 423.45M;
            }

            else if (dataAdmissao.Year >= 2010 || dataAdmissao.Year <= 2013)
            {
                aumento = (salario * 9.84M) / 100;
            }

            else if (dataAdmissao.Year >= 2000 || dataAdmissao.Year <= 2009)
            {
                aumento = (salario * 16.4M) / 100;
            }

            else if (dataAdmissao.Year <= 1999)
            {
                aumento = (salario * 22.6M) / 100;
            }

            return aumento;
        }

    }
}