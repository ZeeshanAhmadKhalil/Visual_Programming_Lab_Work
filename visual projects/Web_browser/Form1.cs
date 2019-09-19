using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string home_page = "http://www.google.co.uk";
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Zeeshan Browser", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nevigate_to_address(home_page);
            AddresstoolStripComboBox1.Text = home_page;
        }

        private void HometoolStripButton1_Click(object sender, EventArgs e)
        {
            nevigate_to_address(home_page);
            AddresstoolStripComboBox1.Text = home_page;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            nevigate_to_address(AddresstoolStripComboBox1.Text);
        }

        private void AddresstoolStripComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(AddresstoolStripComboBox1.Text);
            }
        }
        private void nevigate_to_address(string address)
        {
            webBrowser1.Navigate(address);
        }
        
    }
}
