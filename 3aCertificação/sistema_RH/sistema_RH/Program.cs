using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sistema_RH
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdFuncionarios = 0;
            string tipo = "";
            double despesa_Empresa = 0;

            Console.WriteLine("Qual a quantidade de funcionários? ");
            qtdFuncionarios = int.Parse(Console.ReadLine());

            Terceirizado terceirizado = new Terceirizado();
            TrabalhadorEmpresa trabEmpresa = new TrabalhadorEmpresa();
            GerenteEmpresa gerente = new GerenteEmpresa();

            List<Terceirizado> terceirizados = new List<Terceirizado>();
            List<TrabalhadorEmpresa> trabalhadores = new List<TrabalhadorEmpresa>();
            List<GerenteEmpresa> gerentes = new List<GerenteEmpresa>();

            int j = 0; int k = 0; int l = 0;
            for (int i = 0; i < qtdFuncionarios; i++)
            {
                Console.WriteLine("O funciónario é  trabalhador , terceirizado ou gerente? ");
                tipo = Console.ReadLine();

                if (tipo == "terceirizado")
                {
                    Console.Write("Nome  ");
                    terceirizado.Nome = Console.ReadLine();

                    Console.WriteLine("Matrícula  ");
                    terceirizado.Matricula = Console.ReadLine();

                    Console.Write("Data De Nascimento  ");
                    terceirizado.Data_nascimento = Console.ReadLine();

                    Console.Write("CPF  ");
                    terceirizado.Cpf = Console.ReadLine();

                    Console.Write("CNPJ  ");
                    terceirizado.Cnpj = Console.ReadLine();

                    terceirizados.Add(terceirizado);
                    k++;
                }
                else if (tipo == "gerente")
                {
                    Console.Write("Nome  ");
                    gerente.Nome = Console.ReadLine();

                    Console.Write("Matrícula  ");
                    gerente.Matricula = Console.ReadLine();

                    Console.Write("Data de Nascimento  ");
                    gerente.Data_nascimento = Console.ReadLine();

                    Console.Write("CPF  ");
                    gerente.Cpf = Console.ReadLine();

                    Console.Write("Área de Atuação  ");
                    gerente.Area = Console.ReadLine();

                    gerentes.Add(gerente);
                    l++;
                }

                else if (tipo == "trabalhador")
                {
                    double valeAlimentacaoTrabalhador = trabEmpresa.vale_alimentacao();

                    Console.Write("Nome  ");
                    trabEmpresa.Nome = Console.ReadLine();

                    Console.Write("Matrícula  ");
                    trabEmpresa.Matricula = Console.ReadLine();

                    Console.Write("Data de Nascimento  ");
                    trabEmpresa.Data_nascimento = Console.ReadLine();

                    Console.Write("CPF  ");
                    trabEmpresa.Cpf = Console.ReadLine();

                    trabalhadores.Add(trabEmpresa);
                    j++;
                }

            }

            if (terceirizados.Count > 0)
            {
                Console.WriteLine("Terceirizados");

                for (int m = 0; m < terceirizados.Count; m++)
                {
                    Console.WriteLine("Nome: {0}", terceirizados[m].Nome);
                    Console.WriteLine("Matricula: {0}", terceirizados[m].Matricula);
                    Console.WriteLine("Data de Nascimento: {0}", terceirizados[m].Data_nascimento);
                    Console.WriteLine("CPF: {0}", terceirizados[m].Cpf);
                    Console.WriteLine("CNPJ: {0}", terceirizados[m].Cnpj);
                }
            }

            if (gerentes.Count > 0)
            {
                Console.WriteLine("Gerentes");

                for (int n = 0; n < gerentes.Count; n++)
                {
                    double valeAlimentacaoGerente = gerentes[n].vale_alimentacao();

                    Console.WriteLine("Nome: {0}", gerentes[n].Nome);
                    Console.WriteLine("Matrícula: {0}", gerentes[n].Matricula);
                    Console.WriteLine("Data de Nascimento: {0}", gerentes[n].Data_nascimento);
                    Console.WriteLine("CPF: {0}", gerentes[n].Cpf);
                    Console.WriteLine("Salário: {0}", gerentes[n].Salario());
                    Console.WriteLine("Local na empresa: {0}", gerentes[n].Area);
                    Console.WriteLine("Vale Alimentação: {0}", valeAlimentacaoGerente);
                    despesa_Empresa += gerentes[n].Salario() + valeAlimentacaoGerente;
                }
            }

            if (trabalhadores.Count > 0)
            {
                Console.WriteLine("Trabalhadores");
                for (int o = 0; o < trabalhadores.Count; o++)
                {
                    double valeAlimentacaoTrabalhador = trabalhadores[o].vale_alimentacao();
                    Console.WriteLine("Nome: {0}", trabalhadores[o].Nome);
                    Console.WriteLine("Matrícula: {0}", trabalhadores[o].Matricula);
                    Console.WriteLine("Data de Nascimento: {0}", trabalhadores[o].Data_nascimento);
                    Console.WriteLine("CPF: {0}", trabalhadores[o].Cpf);
                    Console.WriteLine("Salário: {0}", trabalhadores[o].Salario());
                    Console.WriteLine("Vale Alimentação: {0}", valeAlimentacaoTrabalhador);

                    despesa_Empresa += trabalhadores[o].Salario() + trabalhadores[o].vale_alimentacao();
                }
            }
            Console.WriteLine("Despesa total da empresa: {0}", despesa_Empresa);
        }
    }
}

