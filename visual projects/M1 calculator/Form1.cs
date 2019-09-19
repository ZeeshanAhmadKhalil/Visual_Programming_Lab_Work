using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M1_calculator
{
    public partial class Form1 : Form
    {
        private double num1 = 0, num2 = 0;
        string Operator="";
        public Form1()
        {
            InitializeComponent();
        }
        private void num_buttons(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            if (textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "%")
                textBox1.Text = b.Text;
            else
                textBox1.Text =textBox1.Text+b.Text;
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text != "0" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*" && textBox1.Text != "%")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = b.Text;
                Operator = b.Text;
            } 
        }
        private void equalbtn_Click(object sender, EventArgs e)
        {
            if (num1 != 0 && Operator != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*" && textBox1.Text != "%")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                //MessageBox.Show("num1=" + num1 + "num2=" + num2+"op="+Operator);
                exec();
            }
        }
        private void exec()
        {
            double result = 0; ;
            switch (Operator)
            {
                case "+":
                result = num1 + num2;
                break;
                case "-":
                result = num1 - num2;
                break;
                case "/":
                result = num1 / num2;
                break;
                case "*":
                result = num1 * num2;
                break;
                case "%":
                result = num1 % num2;
                break;
            }
            textBox1.Text = Convert.ToString(result);
            num1 = 0;
            num2 = 0;
            Operator = "";
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            Operator = "";
        }
        private void pointbtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text =  textBox1.Text+".";
        }
        private void plusMinusbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "/" && textBox1.Text != "*" && textBox1.Text != "%")
            {
                if (textBox1.Text.Contains("-"))
                    textBox1.Text=textBox1.Text.Trim('-');
                else
                    textBox1.Text = "-" + textBox1.Text;
            }
        }
    }
}
