using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Primero;
        double Segundo;
        double Resultado;
        string Operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text +"0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Operacion = "√";
            Primero = double.Parse(Pantalla.Text);
            Resultado = Primero;
            Pantalla.Text = Math.Sqrt(Primero).ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            Primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Segundo = double.Parse(Pantalla.Text);

            switch (Operacion)
            {
                case "+":
                    Resultado = Primero + Segundo;
                    Pantalla.Text = Resultado.ToString();

                break;

                case "-":
                    Resultado = Primero - Segundo;
                    Pantalla.Text = Resultado.ToString();
                    break;
                case "*":
                    Resultado = Primero * Segundo;
                    Pantalla.Text = Resultado.ToString();
                    break;

                case "/":
                    Resultado = Primero / Segundo;
                    Pantalla.Text = Resultado.ToString();
                    break;
                    
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
    }
}
