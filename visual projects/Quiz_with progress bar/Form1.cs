using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz_with_progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correct = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 4;
            progressBar1.Step = 1;
            //MessageBox.Show(Convert.ToString(progressBar1.Value));
            if (radioButton1.Checked == true)
                correct++;
            if (radioButton6.Checked == true)
                correct++;
            if (radioButton9.Checked == true)
                correct++;
            if (radioButton12.Checked == true)
                correct++;
            progressBar1.Value = correct;
            //if (progressBar1.Value == 0)
            //    progressBar1.
            progressBar1.PerformStep();
        }
    }
}
