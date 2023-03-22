using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculadoraCsharp
{
    public partial class Form1 : Form
    {
        // Variaveis
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Botão 07
            lblOperacao.Text = lblOperacao.Text += "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Botão 00
            lblOperacao.Text = lblOperacao.Text +=  "0"; 

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Botão 01
            lblOperacao.Text = lblOperacao.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Botão 02
            lblOperacao.Text = lblOperacao.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Botão 03
            lblOperacao.Text = lblOperacao.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Botão 04
            lblOperacao.Text = lblOperacao.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Botão 05
            lblOperacao.Text = lblOperacao.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Botão 06
            lblOperacao.Text = lblOperacao.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Botão 08
            lblOperacao.Text = lblOperacao.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Botão 09
            lblOperacao.Text = lblOperacao.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Botão . (Valor decimal)
            lblOperacao.Text = lblOperacao.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Botão de igual e calculos
            valor2 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA") // Calculo somar
            {
               lblOperacao.Text = Convert.ToString(valor1 + valor2);
                
            }
            else if (operacao == "DIV") // Calculo divisão
            {
                lblOperacao.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "SUB") // Calculo subtração
            {
                lblOperacao.Text = Convert.ToString(valor1 - valor2);
            }
            else // Calculo multiplicação
            {
                lblOperacao.Text = Convert.ToString(valor1 * valor2);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Botão de subtração
            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            lblOperacao.Text = "";
            operacao = "SUB";
            }
            else
            {
                // Aviso
                MessageBox.Show("Informe um valor para efetuar a subtração.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Botão de multiplicação
            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            lblOperacao.Text = "";
            operacao = "MULT";
            }
            else
            {
                // Aviso
                MessageBox.Show("Informe um valor para efetuar a multiplicação. ");
            }
}

        private void button18_Click(object sender, EventArgs e)
        {
            // Botão de divisão
            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            lblOperacao.Text = "";
            operacao = "DIV";
            }
            else
            {
                // Aviso
                MessageBox.Show("Informe um valor para efetuar a divisão. ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão de limpar tudo
            lblOperacao.Text = ""; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Botão de limpar
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botão de somar
            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

                lblOperacao.Text = "";
                operacao = "SOMA";

            }
            else
            {
                // Aviso
                MessageBox.Show("Informe um valor para efetuar a soma. ");
            }

        }
    }
}
