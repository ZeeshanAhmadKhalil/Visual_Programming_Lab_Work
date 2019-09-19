using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace User_methos
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void show(int num)
        {
            //if (button1.Click) ;
            MessageBox.Show("This is a method showing number "+num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show(3);
        }
        
    }
}
