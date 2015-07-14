using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA140715
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro fido = new Cachorro();
            fido.SetTamanhoCm(95);
            fido.SetNome("fido");
            fido.SetPeso(42.3);

            Console.WriteLine("Nome: {0}", fido.GetNome());
            Console.WriteLine("Peso: {0}", );
            Console.WriteLine("Tamanho (m): {0}", );
            Console.WriteLine("Quantidade diária de ração: {0}", fido.RacaoDiariaKg());


        }
    }
}
