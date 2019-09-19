using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multi_Converter_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            double value = double.Parse(Input.Text),ans=0;
            if (Temp.Checked == true)
            {
                if (Temp_c_f.Checked == true)
                {
                    ans = value * 9 / 5 + 32;
                }
                else if (Temp_f_k.Checked == true)
                {
                    ans = (value - 32) * 5 / 9 + 273.15;
                }
                else if (Temp_k_c.Checked == true)
                {
                    ans = value + 273.15;
                }
            }
            else if (Currency.Checked == true)
            {
                if (Currency_p_u.Checked == true)
                {
                    ans = (1/110.65)*value;
                }
                else if (Currency_u_i.Checked == true)
                {
                    ans = value * 65;
                }
                else if (Currency_u_p.Checked == true)
                {
                    ans = value * 110.65;
                }
            }
            else if (Weight.Checked == true)
            {
                if (Weight_k_o.Checked == true)
                {
                    ans = value * 35.274;
                }
                else if (Weight_k_p.Checked == true)
                {
                    ans = value * 2.20462;
                }
                else if (Weight_p_k.Checked == true)
                {
                    ans = (1 / 2.20462) * value;
                }
            }
            else if (Length.Checked == true)
            {
                if (Length_f_m.Checked == true)
                {
                    ans = value * 0.3048;
                }
                else if (Length_m_f.Checked == true)
                {
                    ans = value * 3.28084;
                }
                else if (Length_m_i.Checked == true)
                {
                    ans = value * 39.3701;
                }
            }

            Result.Text = ans.ToString();
        }

        private void Temp_CheckedChanged(object sender, EventArgs e)
        {
            temp_box.Visible = true;
            Currency_box.Visible = false;
            Length_box.Visible = false;
            Weight_box.Visible = false;
            Result.Clear();
            Input.Clear();
            unit1.Text = "";
            unit2.Text = "";
            Temp_c_f.Checked = false;
            Temp_f_k.Checked = false;
            Temp_k_c.Checked = false;
        }

        private void Currency_CheckedChanged(object sender, EventArgs e)
        {
            temp_box.Visible = false;
            Currency_box.Visible = true;
            Length_box.Visible = false;
            Weight_box.Visible = false;
            Result.Clear();
            Input.Clear();
            unit1.Text = "";
            unit2.Text = "";
            Currency_p_u.Checked = false;
            Currency_u_i.Checked = false;
            Currency_u_p.Checked = false;
        }

        private void Weight_CheckedChanged(object sender, EventArgs e)
        {
            temp_box.Visible = false;
            Currency_box.Visible = false;
            Length_box.Visible = false;
            Weight_box.Visible = true;
            Result.Clear();
            Input.Clear();
            unit1.Text = "";
            unit2.Text = "";
            Weight_k_o.Checked = false;
            Weight_k_p.Checked = false;
            Weight_p_k.Checked = false;
        }

        private void Length_CheckedChanged(object sender, EventArgs e)
        {
            temp_box.Visible = false;
            Currency_box.Visible = false;
            Length_box.Visible = true;
            Weight_box.Visible = false;
            Result.Clear();
            Input.Clear();
            unit1.Text = "";
            unit2.Text = "";
            Length_f_m.Checked = false;
            Length_m_i.Checked = false;
            Length_m_f.Checked = false;
        }

        private void Temp_c_f_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Celcius";
            unit2.Text = "Farenhite";
            Result.Clear();
            Input.Clear();
        }

        private void Temp_f_k_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Farenhite";
            unit2.Text = "Kelvin";
            Result.Clear();
            Input.Clear();
        }

        private void Temp_k_c_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Kelvin";
            unit2.Text = "Celcius";
            Result.Clear();
            Input.Clear();
        }

        private void Currency_u_p_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "US Dollars";
            unit2.Text = "Pak Rupees";
            Result.Clear();
            Input.Clear();
        }

        private void Currency_u_i_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "US Dollars";
            unit2.Text = "Ind Rupees";
            Result.Clear();
            Input.Clear();
        }

        private void Currency_p_u_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Pak Rupees";
            unit2.Text = "US Dollars";
            Result.Clear();
            Input.Clear();
        }

        private void Weight_k_p_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Kilogram";
            unit2.Text = "Pounds";
            Result.Clear();
            Input.Clear();
        }

        private void Weight_p_k_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Pounds";
            unit2.Text = "Kilogram";
            Result.Clear();
            Input.Clear();
        }

        private void Weight_k_o_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Kiligram";
            unit2.Text = "Ounce";
            Result.Clear();
            Input.Clear();
        }

        private void Length_m_f_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Metre";
            unit2.Text = "Feet";
            Result.Clear();
            Input.Clear();
        }

        private void Length_f_m_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Feet";
            unit2.Text = "Metre";
            Result.Clear();
            Input.Clear();
        }

        private void Length_m_i_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Metre";
            unit2.Text = "Inches";
            Result.Clear();
            Input.Clear();
        }


    }
}
