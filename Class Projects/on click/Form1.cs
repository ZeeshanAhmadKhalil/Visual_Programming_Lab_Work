using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Add_two_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //textBox1.Text=textBox1.Text + textBox2.Text;
            int num1=int.Parse(textBox1.Text);
            //int num2=Convert.ToInt32(textBox2.Text);
            //int num3=num1+num2;
            //textBox3.Text=Convert.ToString(num3);
        }
}
