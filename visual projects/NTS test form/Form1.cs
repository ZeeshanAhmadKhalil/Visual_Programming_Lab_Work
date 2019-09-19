using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTS_test_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CCN_CheckedChanged(object sender, EventArgs e)
        {
            //CCN.ForeColor = Color.Green;
            
            CCN.Visible = false;
            DIP.Visible = false;
            SProb.Visible = false;
            VP.Visible = false;
            next.Visible = true;
            label_select.Text = "Computer Communication and Networking";
            Questions.Visible = true;
            Q1.Text = "Q1)IP with range 193 belongs to.";
            Q1O1.Text = "Class A"; Q1O2.Text = "Class B"; Q1O3.Text = "Class C";
            Q2.Text = "Q2)How many network parts in IP of Class A.";
            Q2O1.Text = "1"; Q2O2.Text = "2"; Q2O3.Text = "3";
            Q3.Text = "Q3)Class D is used for.";
            Q3O1.Text = "Multicasting"; Q3O2.Text = "Research"; Q3O3.Text = "Non of these";
            Q4.Text = "Q4)What is Broadcast.";
            Q4O1.Text = "1 to 1"; Q4O2.Text = "1 to many"; Q4O3.Text = "1 to all";
            Q5.Text = "Q5)What is half duplex.";
            Q5O1.Text = "One way"; Q5O2.Text = "two way"; Q5O3.Text = "three way";
        }

        private void DIP_CheckedChanged(object sender, EventArgs e)
        {
            //DIP.Enabled = false;
            CCN.Visible = false;
            DIP.Visible = false;
            SProb.Visible = false;
            VP.Visible = false;
            next.Visible = true;
            label_select.Text = "Digital Image Processing";
            Questions.Visible = true;
            Q1.Text = "Q1)What is BPP in black and white image";
            Q1O1.Text = "1"; Q1O2.Text = "8"; Q1O3.Text = "24";
            Q2.Text = "Q2)What is BPP in gray scale image.";
            Q2O1.Text = "1"; Q2O2.Text = "8"; Q2O3.Text = "24";
            Q3.Text = "Q3)What is BPP in colourd image.";
            Q3O1.Text = "1"; Q3O2.Text = "8"; Q3O3.Text = "24";
            Q4.Text = "Q4)What Spital resolution Shows.";
            Q4O1.Text = "pixles"; Q4O2.Text = "colour depth"; Q4O3.Text = "non of these";
            Q5.Text = "Q5)What Intensity Resolution Shows.";
            Q5O1.Text = "pixels"; Q5O2.Text = "colour depth"; Q5O3.Text = "non of these";
        }

        private void SProb_CheckedChanged(object sender, EventArgs e)
        {
            //SProb.Enabled = false;
            CCN.Visible = false;
            DIP.Visible = false;
            SProb.Visible = false;
            VP.Visible = false;
            next.Visible = true;
            label_select.Text = "Statistics and probability theory";
            Questions.Visible = true;
            Q1.Text = "Q1)What is greatest mean";
            Q1O1.Text = "A.M"; Q1O2.Text = "G.M"; Q1O3.Text = "H.M";
            Q2.Text = "Q2)What is smallest mean.";
            Q2O1.Text = "A.M"; Q2O2.Text = "G.M"; Q2O3.Text = "H.M";
            Q3.Text = "Q3)What is intermediate mean.";
            Q3O1.Text = "A.M"; Q3O2.Text = "G.M"; Q3O3.Text = "H.M";
            Q4.Text = "Q4)Qualitative Data is also called";
            Q4O1.Text = "User Data"; Q4O2.Text = "Categorical Data"; Q4O3.Text = "Named Data";
            Q5.Text = "Q5)Qualitative Data is representes by.";
            Q5O1.Text = "Pi chart"; Q5O2.Text = "Bar chart"; Q5O3.Text = "Both of these";
        }

        private void VP_CheckedChanged(object sender, EventArgs e)
        {
            //VP.Enabled = false;
            CCN.Visible = false;
            DIP.Visible = false;
            SProb.Visible = false;
            VP.Visible = false;
            next.Visible = true;
            label_select.Text = "Visual programing";
            Questions.Visible = true;
            Q1.Text = "Q1)Cout<<a<<endl is C++ ____ im C#";
            Q1O1.Text = "Console.WriteLine(a)"; Q1O2.Text = "Console.Write(a)"; Q1O3.Text = "non of these";
            Q2.Text = "Q2)How to convert string to int.";
            Q2O1.Text = "int.parse()"; Q2O2.Text = "Convert.ToInt32()"; Q2O3.Text = "both of these";
            Q3.Text = "Q3)The library for time and date in C# is.";
            Q3O1.Text = "TimeDate"; Q3O2.Text = "DateTime"; Q3O3.Text = "non of these";
            Q4.Text = "Q4)C# was Developed in";
            Q4O1.Text = "1981"; Q4O2.Text = "1982"; Q4O3.Text = "non of these";
            Q5.Text = "Q5)What would give bug.";
            Q5O1.Text = "value*24/100"; Q5O2.Text = "24/100*value"; Q5O3.Text = "non of these";

        }

        
        public void next_Click(object sender, EventArgs e)
        {
            int Marks=0;
            int adder;

            if (CCN.Enabled == true && DIP.Enabled == true && SProb.Enabled == true && VP.Enabled == true)
                Score.Text = "0";
            Questions.Visible = false;
            CCN.Visible = true;
            DIP.Visible = true;
            SProb.Visible = true;
            VP.Visible = true;
            next.Visible = false;
            label_select.Text = "Select Any Option to Begin Test.";
            
            if (CCN.Checked == true)
            {
                CCN.Enabled = false;
                if (Q1O3.Checked == true)
                    Marks++;
                if (Q2O1.Checked == true)
                    Marks++;
                if (Q3O1.Checked == true)
                    Marks++;
                if (Q4O3.Checked == true)
                    Marks++;
                if (Q5O1.Checked == true)
                    Marks++;
                adder = Convert.ToInt32(Score.Text);
                Marks = adder + Marks;
                Score.Text = Marks.ToString();
            }
            else if (DIP.Checked == true)
            {
                DIP.Enabled = false;
                if (Q1O1.Checked == true)
                    Marks++;
                if (Q2O2.Checked == true)
                    Marks++;
                if (Q3O3.Checked == true)
                    Marks++;
                if (Q4O1.Checked == true)
                    Marks++;
                if (Q5O2.Checked == true)
                    Marks++;
                adder = Convert.ToInt32(Score.Text);
                Marks = adder + Marks;
                Score.Text = Marks.ToString();
            }
            else if (SProb.Checked == true)
            {
                SProb.Enabled = false;
                if (Q1O1.Checked == true)
                    Marks++;
                if (Q2O3.Checked == true)
                    Marks++;
                if (Q3O2.Checked == true)
                    Marks++;
                if (Q4O2.Checked == true)
                    Marks++;
                if (Q5O3.Checked == true)
                    Marks++;
                adder = Convert.ToInt32(Score.Text);
                Marks = adder + Marks;
                Score.Text = Marks.ToString();
            }
            else if (VP.Checked == true)
            {
                VP.Enabled = false;
                if (Q1O1.Checked == true)
                    Marks++;
                if (Q2O3.Checked == true)
                    Marks++;
                if (Q3O2.Checked == true)
                    Marks++;
                if (Q4O3.Checked == true)
                    Marks++;
                if (Q5O1.Checked == true)
                    Marks++;
                adder = Convert.ToInt32(Score.Text);
                Marks = adder + Marks;
                Score.Text = Marks.ToString();
            }
            Q1O1.Checked = false; Q1O2.Checked = false; Q1O3.Checked = false;
            Q2O1.Checked = false; Q2O2.Checked = false; Q2O3.Checked = false;
            Q3O1.Checked = false; Q3O2.Checked = false; Q3O3.Checked = false;
            Q4O1.Checked = false; Q4O2.Checked = false; Q4O3.Checked = false;
            Q5O1.Checked = false; Q5O2.Checked = false; Q5O3.Checked = false;
            if (CCN.Enabled == false && DIP.Enabled == false && SProb.Enabled == false && VP.Enabled == false)
            {
                Questions.Visible = false;
                CCN.Visible = false;
                DIP.Visible = false;
                SProb.Visible = false;
                VP.Visible = false;
                next.Visible = false;
                label_select.Text = "Your Marks are " + Marks + " out of 20.";
                //label_select.Font.Size = 25;
                if (CCN.Enabled == false && DIP.Enabled == false && SProb.Enabled == false && VP.Enabled == false)
                {
                    reset.Visible = true;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            CCN.Checked = false;
            DIP.Checked = false;
            SProb.Checked = false;
            VP.Checked = false;
            Q1O1.Checked = false; Q1O2.Checked = false; Q1O3.Checked = false;
            Q2O1.Checked = false; Q2O2.Checked = false; Q2O3.Checked = false;
            Q3O1.Checked = false; Q3O2.Checked = false; Q3O3.Checked = false;
            Q4O1.Checked = false; Q4O2.Checked = false; Q4O3.Checked = false;
            Q5O1.Checked = false; Q5O2.Checked = false; Q5O3.Checked = false;
            reset.Visible = false;
            Questions.Visible = false;
            label_select.Text = "Select Any Option to Begin Test.";
            CCN.Enabled = true;
            DIP.Enabled = true;
            SProb.Enabled = true;
            VP.Enabled = true;
            CCN.Visible = true;
            DIP.Visible = true;
            SProb.Visible = true;
            VP.Visible = true;
            Score.Text = "";
        }


       
        

        
    }
}
