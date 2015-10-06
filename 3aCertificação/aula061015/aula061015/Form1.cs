using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace aula061015
{
    public partial class Form1 : Form
    {
        List<Amigo> Status = new List<Amigo>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Amigo a = new Amigo();
            a.Nome = txtNome.Text;
            a.Sobrenome = txtSobrenome.Text;
            a.Presente1 = txtPresente1.Text;
            a.Presente2 = txtPresente2.Text;
            a.Presente3 = txtPresente3.Text;
            Salvar();

            string q = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection cnn = new MySqlConnection(q);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            string j = String.Format("INSERT INTO amigo_oculto (Nome,Sobrenome,Presente1,Presente2,Presente3) VALUES ('{0}','{1}','{2}','{3}','{4}')", a.Nome, a.Sobrenome, a.Presente1, a.Presente2, a.Presente3);
            cmd.CommandText = j;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtPresente1.Text = "";
            txtPresente2.Text = "";
            txtPresente3.Text = "";

          
        }

        private void bntStatus_Click(object sender, EventArgs e)
        {
            Amigo a = new Amigo();
            MessageBox.Show( "" + Status.Count); 
        }

        public void Salvar()
        {
            Amigo a = new Amigo();
            Status.Add(a);
        }
    }
}
