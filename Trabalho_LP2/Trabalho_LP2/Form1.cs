using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_LP2
{
    public partial class Form1 : Form
    {
        List<Carro> carros;
        public Form1()
        {
            InitializeComponent();
            carros = new List<Carro>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            if (textmodelo.Text != "" && textmarca.Text != "" && textplaca.Text != "" && textcapacidade.Text != "0")
            {
                int capacidade;         
                try
                {
                    capacidade = int.Parse(textcapacidade.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Capacidade deve ser inteira");
                    return;
                }
                carro.id = carros.Count + 1;
                carro.capacidade = capacidade;
                carro.modelo = textmodelo.Text;
                carro.marca = textmarca.Text;
                carro.placa = textplaca.Text;
                carros.Add(carro);

                textmarca.Clear();
                textmodelo.Clear();
                textplaca.Clear();
                textcapacidade.Clear();
                MessageBox.Show(string.Format("Carro adicionado, Dados: \n Capacidade {0}\n Modelo {1}\n Marca {2}\n Placa {3}\n Identificador {4}", carro.capacidade, carro.modelo, carro.marca, carro.placa, carro.id));
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var passageiro = new Passageiros(carros);
            passageiro.ShowDialog();

        }
    }

}
    
