using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_form_using_combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            if (Subject.Text != "Maths" && Subject.Text != "Computer")
            MessageBox.Show("Please select a course","Warning",MessageBoxButtons.OKCancel);
            if (Subject.Text == "Maths")
            {
                false_true_all();
                Q1.Text = "What is 10th prime number";
                Q1O1.Text = "17"; Q1O2.Text = "23"; Q1O3.Text = "29";
                Q2.Text = "How many even numbers in set of 1st 10 prime numbers";
                Q2O1.Text = "1"; Q2O2.Text = "2"; Q2O3.Text = "3";
                Q3.Text = "Correct Spellings are";
                Q3O1.Text = "Math"; Q3O2.Text = "Maths"; Q3O3.Text = "Mathematic";
            }
            else if (Subject.Text == "Computer")
            {
                false_true_all();
                Q1.Text = "How many bits in 1 byte";
                Q1O1.Text = "4"; Q1O2.Text = "2"; Q1O3.Text = "8";
                Q2.Text = "How many bits in 1 nibble";
                Q2O1.Text = "2"; Q2O2.Text = "4"; Q2O3.Text = "3";
                Q3.Text = "Computer is";
                Q3O1.Text = "Synchronous"; Q3O2.Text = "Asynchronous"; Q3O3.Text = "non of them";
            }
            
            
        }

        private void false_true_all()
        {
            Q1O1.Checked = false; Q1O2.Checked = false; Q1O3.Checked = false;
            Q2O1.Checked = false; Q2O2.Checked = false; Q2O3.Checked = false;
            Q3O1.Checked = false; Q3O2.Checked = false; Q3O3.Checked = false;
            Selection.Enabled = false;
            Questions.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int marks = 0;
            if (Subject.Text == "Maths")
            {
                if (Q1O3.Checked == true)
                    marks++;
                if (Q2O1.Checked == true)
                    marks++;
                if (Q3O2.Checked == true)
                    marks++;
            }
            else if (Subject.Text == "Computer")
            {
                if (Q1O3.Checked == true)
                    marks++;
                if (Q2O2.Checked == true)
                    marks++;
                if (Q3O2.Checked == true)
                    marks++;
            }
            if (marks1.Text == "")
                marks1.Text = "0";
            marks = marks + Convert.ToInt16(marks1.Text);
            marks1.Text = Convert.ToString(marks);
            false_true_all1();
            if (Subject.Items.Count == 2)
            {
                if (Subject.Text == "Maths")
                    Subject.Items.Remove("Maths");
                else
                    Subject.Items.Remove("Computer");
            }
            else
                Subject.Items.RemoveAt(0);
            Subject.Text = "";
                if (Subject.Items.Count == 0)
                {
                    MessageBox.Show("your score is " + marks1.Text);
                    Application.Exit();
                }
        }

        private void false_true_all1()
        {
            Q1O1.Checked = false; Q1O2.Checked = false; Q1O3.Checked = false;
            Q2O1.Checked = false; Q2O2.Checked = false; Q2O3.Checked = false;
            Q3O1.Checked = false; Q3O2.Checked = false; Q3O3.Checked = false;
            Selection.Enabled = true;
            Questions.Enabled = false;
            button1.Enabled = false;
        }
    }
}
