using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sessional2Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            enable_disable_buttons(true);
        }
        private void enable_disable_buttons(bool p)
        {
            button1.Enabled = p;
            button2.Enabled = p;
            button3.Enabled = p;
            button4.Enabled = p;
            button5.Enabled = p;
            button6.Enabled = p;
            button7.Enabled = p;
            button8.Enabled = p;
            button9.Enabled = p;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            enable_disable_buttons(false);
        }
    }
}
