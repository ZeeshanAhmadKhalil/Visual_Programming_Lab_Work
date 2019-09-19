using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Addition_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            double value1 = float.Parse(Box1.Text), value2;
            if (tempreture.Checked == true)
            {
                value2 = (value1 - 32)*5/9;
                Box2.Text=value2.ToString();
            }
            else if (length.Checked == true)
            {
                value2 = value1 * 39.37;
                Box2.Text = value2.ToString();
            }
            else if (currency.Checked == true)
            {
                value2 = value1 * 110.58;
                Box2.Text = value2.ToString();
            }
            else if (weight.Checked == true)
            {
                value2 = value1 * 2.20462;
                Box2.Text = value2.ToString();
            }
            else if (temprature1.Checked == true)
            {
                value2 = value1*9/5+32;
                Box2.Text = value2.ToString();
            }
            else if (currency1.Checked == true)
            {
                value2 = value1 * 65.09;
                Box2.Text = value2.ToString();
            }
        }

        private void tempreture_CheckedChanged(object sender, EventArgs e)
        {
            Text1.Text = "Farenhite";
            Text2.Text = "Celcius";
            Box1.Clear();
            Box2.Clear();
        }
        private void length_CheckedChanged_1(object sender, EventArgs e)
        {
            Text1.Text = "Meters";
            Text2.Text = "Inches";
            Box1.Clear();
            Box2.Clear();
        }

        private void currency_CheckedChanged_1(object sender, EventArgs e)
        {
            Text1.Text = "US Dollars";
            Text2.Text = "Pak Rupees";
            Box1.Clear();
            Box2.Clear();
        }

        private void weight_CheckedChanged_1(object sender, EventArgs e)
        {
            Text1.Text = "Kilograms";
            Text2.Text = "Pounds";
            Box1.Clear();
            Box2.Clear();
        }

        private void temprature1_CheckedChanged(object sender, EventArgs e)
        {
            Text1.Text = "Celcius";
            Text2.Text = "Farenhite";
            Box1.Clear();
            Box2.Clear();
        }

        private void currency1_CheckedChanged(object sender, EventArgs e)
        {
            Text1.Text = "US Dollars";
            Text2.Text = "Ind Rupees";
            Box1.Clear();
            Box2.Clear();
        }

    }
}
