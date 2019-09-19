using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace addition_by_messege_bax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void addition(int num1, int num2)
        {
            MessageBox.Show("sum=" + (num1 + num2));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            addition(num1, num2);
        }
    }
}
