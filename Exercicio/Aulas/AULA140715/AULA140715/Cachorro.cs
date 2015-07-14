using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA140715
{
    class Cachorro
    {
       
        double RacaoDiariaKg;
        private double _tamanhoCm;
        private string _nome;
        private double _peso;

        public void SetPeso(double peso)
        {
            _peso = peso;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
             
        }
        public void SettamanhoCm (double tamanhocm)
        {
            _tamanhoCm = tamanhocm;
        }
        public double RacaoDiariaKg(double Racao)
        {
            return Racao = (_peso / _tamanhoCm) / 10;
            
        }

        public string GetNome(string nome)
        {
           return _nome;
        }
        public double GetPeso(int peso)
        {
            return _peso;
        }
        public double GetRacaoDiariaKg(double RacaoDiariaKg)
        {
            return RacaoDiariaKg;
        }
        public double GettamanhoCm (double tamanhoCm )
        {
            return _tamanhoCm;
        }
        }
        
    }
}
