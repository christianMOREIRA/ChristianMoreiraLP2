using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace aula220915
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            string sobrenome = Console.ReadLine(); 
            string strConnection = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConnection);

            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = String.Format("Insert into Pessoa(Nome, Sobrenome) Values ('{0}','{1}')", nome, sobrenome);           
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
