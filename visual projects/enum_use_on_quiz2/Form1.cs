using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace enum_use_on_quiz2
{
    public partial class Form1 : Form
    {
        int result=0;
        int opt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opt = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opt = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opt = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opt = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (opt)
            {
                case 1:
                    result=Convert.ToInt16(textBox1.Text)+Convert.ToInt16(textBox2.Text);
                    break;
                case 2:
                    result=Convert.ToInt16(textBox1.Text)-Convert.ToInt16(textBox2.Text);
                    break;
                case 3:
                    result=Convert.ToInt16(textBox1.Text)*Convert.ToInt16(textBox2.Text);
                    break;
                case 4:
                    result=Convert.ToInt16(textBox1.Text)/Convert.ToInt16(textBox2.Text);
                    break;
            }
            MessageBox.Show("Result is " + result);
        }
    }
}
