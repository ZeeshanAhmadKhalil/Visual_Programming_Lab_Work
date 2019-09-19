using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsCalc
{
    public partial class Formcalc : Form
    {
        private decimal firstnumber = 0.0m;
        private decimal Secondnumber =0.0m;
        private string operatorstring = "+";
        private decimal resultdecimal = 0.0m;

        public Formcalc()
        {
            InitializeComponent();
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            RemoveZero(1);
        }

        private void RemoveZero(int num)
        {
            if (textBox1.Text == "0")
                textBox1.Text = num.ToString();
            else
                textBox1.Text += num.ToString();
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            RemoveZero(2);
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            RemoveZero(3);
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            RemoveZero(4);
        }
        private void fivebtn_Click(object sender, EventArgs e)
        {
            RemoveZero(5);
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            RemoveZero(6);
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            RemoveZero(7);
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            RemoveZero(8);
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            RemoveZero(9);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void pointbtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";

        }

        

        private void supliedoperator(string _operatorstring)
        {
            operatorstring = _operatorstring;
            firstnumber = decimal.Parse(textBox1.Text);
            textBox1.Text = "0";
        }
        private void plusbtn_Click(object sender, EventArgs e)
        {
            supliedoperator("+");


        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            supliedoperator("-");
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            supliedoperator("/");
        }

        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            supliedoperator("*");
        }
        private void percentbtn_Click(object sender, EventArgs e)
        {
            supliedoperator("%");
        }
        private void equalbtn_Click(object sender, EventArgs e)
        {
            Secondnumber = decimal.Parse(textBox1.Text);
            switch (operatorstring)
            {   case "+":
                    resultdecimal = firstnumber + Secondnumber;
                    break;
            case "-":
                    resultdecimal = firstnumber - Secondnumber;
                    break;
            case "*":
                    resultdecimal = firstnumber * Secondnumber;
                    break;
            case "/":
                    resultdecimal = firstnumber / Secondnumber;
                    break;
            case "%":
                    resultdecimal = firstnumber % Secondnumber;
                    break;
                default:
                    break;
            }
            textBox1.Text = resultdecimal.ToString();
        }

        private void plusMinusbtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("-"))
                textBox1.Text = "-" + textBox1.Text;
            else
                textBox1.Text=textBox1.Text.Trim('-');
        }

        

        
    }
}
