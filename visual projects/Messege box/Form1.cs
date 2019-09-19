using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Messege_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C#", "Welcome",MessageBoxButtons.YesNoCancel);
        }
        //private void show()
        //{ 

        //}
    }
}
