using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_для_дяди_Димы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        int Factorial(int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 0;

            return n * Factorial(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат: {a+b}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат: {a - b}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат: {a * b}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат: {a / b}";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //bool a = false, b = false;
            bool a = Convert.ToBoolean(Convert.ToInt32(textBox1.Text));
            bool b = Convert.ToBoolean(Convert.ToInt32(textBox2.Text));
            label2.Text = $"Результат: {a & b}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool a = Convert.ToBoolean(Convert.ToInt32(textBox1.Text));
            bool b = Convert.ToBoolean(Convert.ToInt32(textBox2.Text));
            label2.Text = $"Результат: {a | b}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат: {a % b}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            label2.Text = $"Результат: {Convert.ToDouble(a / b)}";
        }

        void chekingText() 
        {
            if(textBox1.Text == "" || textBox2.Text == "") panel1.Enabled= false;
            else if (textBox1.Text.All(char.IsDigit) && textBox2.Text.All(char.IsDigit)) panel1.Enabled= true;
            else panel1.Enabled = false;

            if (!((textBox1.Text == "0" || textBox1.Text == "1") && (textBox2.Text == "0" || textBox2.Text == "1")))
            {
                panel2.Enabled = false;
            }
            else
            {
                panel2.Enabled= true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chekingText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            chekingText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат:\na! = {Factorial(a)}\nb! = {Factorial(b)}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool a = Convert.ToBoolean(Convert.ToInt32(textBox1.Text));
            bool b = Convert.ToBoolean(Convert.ToInt32(textBox2.Text));
            label2.Text = $"Результат: {a ^ b}";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат: \n√a = {Math.Sqrt(a)}\n√b = {Math.Sqrt(b)}";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label2.Text = $"Результат: \na² = {a*a}\nb² = {b*b}";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = a;
            for (int i = 1; i < b; i++)
            {
                c *= a;
            }
            label2.Text = $"Результат: a^b = {c}";
        }
    }
}
