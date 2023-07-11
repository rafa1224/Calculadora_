using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public double Calcula(String escolha)
        {
            if(escolha == "multiplica")
            {
                return x * y;
            }
            else if (escolha == "divide")
            {
                return x / y;
            }
            else if (escolha == "soma")
            {
                return x + y;
            }
            else if (escolha == "subtrai")
            {
                return x - y;
            }

            return x;
        }

        double x = 0;
        double y = 0;
        double resultado;
        String escolha = String.Empty;

        String atualizar = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "1";
            textBox2.Text = atualizar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "3";
            textBox2.Text = atualizar;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "2";
            textBox2.Text = atualizar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "4";
            textBox2.Text = atualizar;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "5";
            textBox2.Text = atualizar;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "6";
            textBox2.Text = atualizar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "7";
            textBox2.Text = atualizar;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "8";
            textBox2.Text = atualizar;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "9";
            textBox2.Text = atualizar;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            atualizar = atualizar + "0";
            textBox2.Text = atualizar;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            atualizar = String.Empty;
            escolha = "multiplica";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            atualizar = String.Empty;
            escolha = "divide";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            atualizar = String.Empty;
            escolha = "soma";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            atualizar = String.Empty;
            escolha = "subtrai";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox2.Text);
            resultado = Calcula(escolha);
            textBox2.Text = Convert.ToString(resultado);
            y = 0;
            x = 0;
            atualizar = String.Empty;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
