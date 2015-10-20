using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace aula_201015
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
                    x.Telefone = Console.ReadLine();
                    pessoas.Add(x);
                    cmd.CommandText = String.Format(new CultureInfo("en"), "INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone) Values('{0}','{1}','{2}','{3}','{4}')", x.Nome, x.Sobrenome, x.Peso, x.Altura, x.Telefone);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                }
                if (valor == "consultar")
                {
                    Console.WriteLine("Consultar por nome ou id");
                    string ab = Console.ReadLine();
                    cmd.Connection.Open();
                    cmd.CommandText = String.Format("Select * FROM Pessoa");
                    MySqlDataReader reader = cmd.ExecuteReader();
                   
                    if (ab == "nome")
                    {
                        Console.WriteLine("Digite o Nome:");
                        string buscar = Console.ReadLine();
                        int aviso_nome = 1;
                      
                        while(reader.Read())
                        {
                            if (buscar == reader.GetString(1))
                            {
                                Console.WriteLine("Id:{0}  Nome:{1} Sobrenome:{2}  Peso: {3}  Altura: {4}  Telefone: {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                                aviso_nome = 2;
                            }

                        }
                        if (aviso_nome == 1)
                        {
                            Console.WriteLine("Não foi achado nenhum registro");
                        }

                    }
                    else if (ab == "id")
                    {
                        int aviso_id = 1;
                        Console.WriteLine("Digite a id");
                        int id2 = int.Parse(Console.ReadLine());
                        while (reader.Read())
                        {
                            if (id2 == reader.GetInt32(0))
                            {
                                Console.WriteLine("Id:{0}  Nome:{1} Sobrenome:{2}  Peso: {3}  Altura: {4}  Telefone: {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                                aviso_id = 2;
                            }

                        }
                        if (aviso_id == 1)
                        {
                            Console.WriteLine("Não foi achado nenhum registro");
                        }
                    }
                    reader.Close();
                    cmd.Connection.Close();
                }
            }
        }
    }
}
