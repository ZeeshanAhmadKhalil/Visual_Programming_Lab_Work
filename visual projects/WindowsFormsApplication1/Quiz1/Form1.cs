using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz1
{
    public partial class Form1 : Form
    {
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox1.Text);
            result = a + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox1.Text);
            result = a - b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox1.Text);
            result = a / b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox1.Text);
            result = a * b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The result is " + result);
        }
    }
}
