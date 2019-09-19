using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class MainForm : Form
    {
        private string HomePage = "http://www.youtube.com.pk";
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zeeshan Browser", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            navigateToAdress(HomePage);
            AddresstoolStripComboBox.Text = HomePage;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            navigateToAdress("http://www.google.co.uk");
            AddresstoolStripComboBox.Text = "http://www.google.co.uk";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            navigateToAdress(AddresstoolStripComboBox.Text);
        }

        private void AddresstoolStripComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navigateToAdress(AddresstoolStripComboBox.Text);
            }
        }
        private void navigateToAdress(string address)
        {
            PIUwebBrowser.Navigate(address);
        }

    }
}
