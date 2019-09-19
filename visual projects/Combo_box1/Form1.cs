using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Combo_box1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                
                if (comboBox1.Items.Count >= 1 && comboBox1.Items.Count <= 10)
                {
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    progressBar1.Maximum = 10;
                    progressBar1.Minimum = 1;
                    progressBar1.Step = 1;
                    progressBar1.Value = comboBox1.Items.Count;
                    progressBar1.PerformStep();
                }
                else
                {
                    MessageBox.Show("You have reached maximum cities");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = comboBox1.Items.Count;
            MessageBox.Show(Convert.ToString(a));
        }
    }
}
