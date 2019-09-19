using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Calculator
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

        
    }
}
