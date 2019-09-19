using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace combo_box3
{
    public partial class Form1 : Form
    {
        //int progress = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 5;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            string a=comboBox1.Text;
            if (a == "A")
            {
                label1.Text = "A for Apple";
                progressBar1.Value = 1;
            }
            else if (a == "B")
            {
                label1.Text = "B for Bat";
                progressBar1.Value = 2;
            }
            else if (a == "C")
            {
                label1.Text = "C for Cat";
                progressBar1.Value = 3;
            }
            else if (a == "D")
            {
                label1.Text = "D for Dog";
                progressBar1.Value = 4;
            }
            else if (a == "E")
            {
                label1.Text = "E for Electron";
                progressBar1.Value = 5;
            }
            // Not effecting any step
            //progress++;
            //progressBar1.Value = progress;
            if(progressBar1.Value>0)
            progressBar1.PerformStep();
        }
    }
}
