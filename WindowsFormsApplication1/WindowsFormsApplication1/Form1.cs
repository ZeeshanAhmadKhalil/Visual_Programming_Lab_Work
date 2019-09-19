using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void emp_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emp_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet1.Emp_info' table. You can move, or remove it, as needed.
            this.emp_infoTableAdapter.Fill(this.employeeDataSet1.Emp_info);

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_infoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.emp_infoBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emp_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.emp_infoBindingSource.RemoveCurrent();
        }
    }
}
