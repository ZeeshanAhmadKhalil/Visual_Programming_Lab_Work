using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M1_web_browser
{
    public partial class Form1 : Form
    {
        private string home_page = "http://www.google.com.pk";
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The is Microsoft Edge","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            navigate_address(home_page);
            link_toolStripComboBox1.Text = home_page;
        }

        private void home_toolStripButton1_Click(object sender, EventArgs e)
        {
            navigate_address(home_page);
            link_toolStripComboBox1.Text = home_page;
        }

        private void go_toolStripButton2_Click(object sender, EventArgs e)
        {
            navigate_address(link_toolStripComboBox1.Text);
        }

        private void link_toolStripComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navigate_address(link_toolStripComboBox1.Text);
            }
        }
        private void navigate_address(string address)
        {
            webBrowser1.Navigate(address);
        }
    }
}
