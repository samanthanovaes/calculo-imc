using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double peso = Convert.ToDouble(text_peso.Text);
            double altura = Convert.ToDouble(text_altura.Text);
            double idade = Convert.ToDouble(text_idade.Text);
            Pessoa p = new Pessoa(text_nome.Text, text_cpf.Text, cb_sexo.Text, peso, idade, altura);
            (double resultado, string categoria, string grau) = p.CalcularIMC();
            lb_resul.Text = ($"O IMC é {resultado.ToString("0.00")}\nA categoria é {categoria}\nO grau é {grau}");
            MessageBox.Show(Validacoes.CalculoCpf(text_cpf.Text).ToString());
            
            
        }

        private void text_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void idade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
