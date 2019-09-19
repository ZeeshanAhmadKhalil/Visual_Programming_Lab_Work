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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HomePage=homePagetextBox.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings are saved successfully","succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
           homePagetextBox.Text= Properties.Settings.Default.HomePage;
        }

        
    }
}
