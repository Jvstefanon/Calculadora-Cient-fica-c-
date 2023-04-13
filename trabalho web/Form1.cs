using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cientific_calulator
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResult.Text == "0")
                txtResult.Text = "";

            txtResult.Text += boton.Text;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResult.Text);

            if (Operador == '+')
            {
                txtResult.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResult.Text);
            }
            else if (Operador == '-')
            {
                txtResult.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResult.Text);
            }
            else if (Operador == 'X')
            {
                txtResult.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResult.Text);
            }
            else if (Operador == '/')
            {
                if (txtResult.Text != "0")
                    txtResult.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResult.Text);
            }
            else
            {
                MessageBox.Show("Não pode dividir por zero!!");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResult.Text = "0";
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
        }

        private void btn_masmen_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResult.Text);
            Numero1 *= -1;
            txtResult.Text = Numero1.ToString();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(txtResult.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResult.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                txtResult.Text = Numero1.ToString();
            }
            else
            {
               
                txtResult.Text = "0";


            }

            txtResult.Text = "0";
        }

    }
}
