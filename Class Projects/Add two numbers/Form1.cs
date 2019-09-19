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
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //textBox1.Text=textBox1.Text + textBox2.Text;
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            int c = a + b;
            result.Text = Convert.ToString(c);
        }
    }
}
