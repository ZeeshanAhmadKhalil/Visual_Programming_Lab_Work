using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace show_messege
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Welcome to programming";
            Label show_messege=new Label();
            show_messege.Text="Welcome to progmming";
            show_messege.Location=new Point(50,50);
            show_messege.Font=new Font("aerial",12);
            show_messege.Width = 300;
            this.Controls.Add(show_messege);
            

        }
    }
}
