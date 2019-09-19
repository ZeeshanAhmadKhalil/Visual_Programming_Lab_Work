using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            ans.Clear();
            num1.Focus();
            addition.Checked = true;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            if (addition.Checked == true)
            {
                int result = a + b;
                ans.Text = Convert.ToString(result);
            }
            else if (substraction.Checked == true)
            {
                int result = a - b;
                ans.Text = Convert.ToString(result);
            }
        }

    }
}
