using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=123123");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            bool entrar = false;
            while (entrar == false)
                {
                conn.Open();            
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                command.CommandText = String.Format("SELECT * from usuario WHERE Login = '{0}' AND Senha = '{1}'", login, senha);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) 
                    {
                        usuario.Id = reader.GetInt32(0); 
                        usuario.Nome = reader.GetString(1);
                        usuario.UltimoAcesso = DateTime.Now; 
                        entrar = true;
                    }
                }


                else
                {
                    Console.WriteLine("Login/Senha está incorreto."); 
                }


                if (entrar == true)
                {
                    reader.Close();
                    Console.WriteLine("Bem vindo, {0}.", usuario.Nome);
                    command.CommandText = String.Format("UPDATE usuario SET DataUltimoAcesso = {0} WHERE Id = {1}", usuario.UltimoAcesso, usuario.Id);
                    command.ExecuteNonQuery();

                    string sair = "";

                    while (sair != "s")
                    {
                        Console.WriteLine("Deseja sair? (s ou n)");
                        sair = Console.ReadLine();
                    }
                        Console.WriteLine("O usúario {0} saiu.", usuario.Nome);
                        entrar = false;                    
                }
                conn.Close();
            }
            Console.ReadKey();

        }
    }
}