using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace addition_form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(num1.Text);
            int b = Convert.ToInt16(num2.Text);
            int c = a + b;
            Result.Text = (Convert.ToString(c));

        }
    }
}
