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

namespace calc
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);

            txtresultado.Text = "";
            operacao = "PORC";
            lbloperacao.Text = "%";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "." ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);

            txtresultado.Text = "";
            operacao = "SOMA";
            lbloperacao.Text = "+"; 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtresultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            { 
                txtresultado.Text = Convert.ToString(valor1 - valor2); 
            
            }
            else if (operacao == "MULTI")
            { 
                txtresultado.Text = Convert.ToString(valor1 * valor2);  
            
            }  
            else if (operacao == "DIVI")
            {
                txtresultado.Text = Convert.ToString(valor1 / valor2);

            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);

            txtresultado.Text = "";
            operacao = "SUB";
            lbloperacao.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);

            txtresultado.Text = "";
            operacao = "MULTI";
            lbloperacao.Text = "x";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);

            txtresultado.Text = "";
            operacao = "DIVI";
            lbloperacao.Text = "/";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            



        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
