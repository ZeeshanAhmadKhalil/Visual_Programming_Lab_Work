using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Travel_Instruction_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            decimal Base_insurance = 50.5m;
            Base_insurance = age_fun(Base_insurance);
            Base_insurance = pi_fun(Base_insurance);
            Base_insurance = ncd_fun(Base_insurance);
            Base_insurance = sc_fun(Base_insurance);
            Base_insurance = countary_fun(Base_insurance);
            total.Text = Convert.ToString(Base_insurance);
        }

        private decimal countary_fun(decimal Base_insurance)
        {
            if (country.SelectedIndex == 1)
                Base_insurance = Base_insurance + 40;
            else
                Base_insurance = Base_insurance + 50;
            return Base_insurance;
        }

        private decimal sc_fun(decimal Base_insurance)
        {
            if (sc_1.Checked == true)
                Base_insurance = Base_insurance + 50;
            return Base_insurance;
        }

        private decimal ncd_fun(decimal Base_insurance)
        {
            if (ncd_1.Checked == true)
                Base_insurance = Base_insurance - 25;
            else
                Base_insurance = Base_insurance + 50;
            return Base_insurance;
        }

        private decimal pi_fun(decimal Base_insurance)
        {
            if (pi_1.Checked == true)
                Base_insurance = Base_insurance + 100;
            return Base_insurance;
        }

        private decimal age_fun(decimal Base_insurance)
        {
            if (Convert.ToInt16(age.Text) > 30)
                Base_insurance += 50;
            else
                Base_insurance += 100;
            return Base_insurance;
        }
    }
}
