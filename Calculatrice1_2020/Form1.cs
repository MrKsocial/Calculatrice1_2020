using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice1_2020
{
    public partial class Form1 : Form
    {

        String operation = "";
        double valeur = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Button button=(Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + "0";
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }*/

        private void button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0")
            {
                textBox1.Clear();
                Button button = (Button)sender;
                textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                Button button = (Button)sender;
                textBox1.Text = textBox1.Text + button.Text;
            }
            
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            if(textBox1.Text == "")
            {
                textBox1.Clear();
            }
            else
            {
                valeur = double.Parse(textBox1.Text);
                textBox1.Text = "0";
            }
            
        }

        private void calcul_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (valeur + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (valeur * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (valeur / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (valeur - Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            textBox1.Clear();
            operation = "";
            valeur = 0;
            

        }
    }
}
