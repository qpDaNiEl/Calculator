using System;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultado(double r)
        {
            label6.Text = $"Resultado: {string.Format("{0:N}", r)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((texto_1.Text != "") && (texto_2.Text != ""))
            {
                double valor1 = Convert.ToDouble(texto_1.Text), valor2 = Convert.ToDouble(texto_2.Text), result = 0;
                string tipo = Convert.ToString(funcao.SelectedItem);

                switch (tipo)
                {
                    case "Somar":
                        result = valor1 + valor2;
                        resultado(result);
                        break;

                    case "Subtrair":
                        result = valor1 - valor2;
                        resultado(result);
                        break;

                    case "Multiplicar":
                        result = valor1 * valor2;
                        resultado(result);
                        break;

                    case "Dividir":
                        result = valor1 / valor2;
                        resultado(result);
                        break;

                    default:
                        label6.Text = "";
                        MessageBox.Show("Selecione uma função");
                        break;
                }

            }
            else
            {

                label6.Text = "";
                MessageBox.Show("Ops!! Campo Vazio");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            funcao.Items.Add("Somar");
            funcao.Items.Add("Subtrair");
            funcao.Items.Add("Multiplicar");
            funcao.Items.Add("Dividir");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(texto_1.Text, "[^0-9]"))
            {
                MessageBox.Show("Use apenas numeros.");
                texto_1.Text = texto_1.Text.Remove(texto_1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(texto_2.Text, "[^0-9]"))
            {
                MessageBox.Show("Use apenas numeros.");
                texto_2.Text = texto_2.Text.Remove(texto_2.Text.Length - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}