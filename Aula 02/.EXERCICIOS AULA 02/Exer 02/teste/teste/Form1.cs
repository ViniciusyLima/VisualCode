﻿using System;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valor = double.Parse(textBox1.Text);
            int parcela = (int)numericUpDown1.Value;

            double desconto = 0.10;
            double juros = 0.07;

            double valorParcela;
            double valorFinal;

            if (parcela <= 1)
            {
                valorFinal = valor - (valor * desconto);
                valorParcela = valorFinal;
            }
            else if (parcela <= 5)
            {
                valorParcela = valor / parcela;
                valorFinal = valor;
            }
            else
            {
                valorFinal = valor + (valor * juros);
                valorParcela = valorFinal / parcela;
            }
            label4.Text = "Valor:" + valorParcela;
            label6.Text = "Valor:" + valorFinal;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
