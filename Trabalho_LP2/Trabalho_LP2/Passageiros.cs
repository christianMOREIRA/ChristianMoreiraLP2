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
    public partial class Passageiros : Form
    {
        private List<Carro> _carros;
        public Passageiros(List<Carro> carros)
        {
            InitializeComponent();         
            _carros = carros;
            relatorio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var carro in _carros)
            {
                if (carro.id == Convert.ToInt32(numericUpDown1.Value))
                {
                    if (carro.capacidade > carro.passageiros)
                    {
                        carro.passageiros++;
                        relatorio();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Carro lotado!");
                        return;
                    }
                }
            }

            MessageBox.Show("ID inválido!");
        }

        private void relatorio()
        {
            listBox1.Items.Clear();

            foreach (var carro in _carros)
            {
                listBox1.Items.Add("Carro " + carro.id + " (" + carro.placa + ")");
                listBox1.Items.Add("Marca: " + carro.marca);
                listBox1.Items.Add("Modelo: " + carro.modelo);
                listBox1.Items.Add("Vagas: " + (carro.capacidade - carro.passageiros).ToString());
                listBox1.Items.Add("-------------------------------------------------");
            }
        }
    }
}
