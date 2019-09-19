using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sessional1Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_item_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear(); 
        }
        private void Count_items_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(comboBox1.Items.Count));
        }

        private void Remove_item_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.Text);
        }
    }
}
