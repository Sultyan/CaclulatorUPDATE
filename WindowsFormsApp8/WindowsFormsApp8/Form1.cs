using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "";
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text + "," +  button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            D = button.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Калькулятор";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Введите число");
            }
            else
            {
                double dn1, dn2, res;
                res = 0;
                dn1 = Convert.ToDouble(N1);
                dn2 = Convert.ToDouble(textBox1.Text);

                if (D == "+")
                {
                    res = dn1 + dn2;
                }
                if (D == "-")
                {
                    res = dn1 - dn2;
                }
                if (D == "*")
                {
                    res = dn1 * dn2;
                }
                if (D == "/")
                {
                    res = dn1 / dn2;
                }
                D = "=";
                n2 = true;
                textBox1.Text = res.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "0,";
                }
                else 
                {
                    textBox1.Text += ",";
                }
            }
        }
    }
}