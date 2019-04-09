using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    
    public partial class Form1 : Form
    {
        public double SalarioD;
        public double DiasTrabajados;
        public double SalarioF;
        public double AFP;
        public double ISSS;
        public double Salario;
        public double DesAFP;
        public double DesIsss;

        public Form1()
        {
            
            InitializeComponent();

            SalarioD = 0;
            DiasTrabajados=0;
            SalarioF=0;
            AFP=0.12;
            ISSS = 0.06;
            Salario = 0;
            DesAFP = 0;
            DesIsss = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalarioD = double.Parse(textBox2.Text);
            DiasTrabajados = double.Parse(textBox3.Text);


            Salario = SalarioD * DiasTrabajados;
            DesAFP = Salario * AFP;
            DesIsss = Salario * ISSS;

            SalarioF = (Salario - DesAFP) - (DesIsss);

            label2.Text = SalarioF.ToString();


        }
    }
}
