using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace aula131015
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            string valor = "";
            MySqlConnection conn = new MySqlConnection("Server=Localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            while (valor != "0")
            {
                Console.WriteLine("inserir ou consultar (Digite 0 para sair)");
                valor = Console.ReadLine();

                Pessoa x = new Pessoa();
                if (valor == "inserir")
                {
                    Console.WriteLine("Nome:  ");
                    x.Nome = Console.ReadLine();
                    Console.WriteLine("Sobrenome: ");
                    x.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Peso: ");
                    x.Peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura");
                    x.Altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Telefone:  ");
                    x.Telefone = int.Parse(Console.ReadLine());
                    pessoas.Add(x);
cmd.CommandText = String.Format(new CultureInfo("en"), "INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone) Values('{0}','{1}','{2}','{3}','{4}')", x.Nome, x.Sobrenome, x.Peso, x.Altura, x.Telefone);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                }
                if (valor == "consultar")
                {
                    cmd.CommandText = String.Format("Select * From Pessoa");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {}

                }
            }
        }
    }
}
