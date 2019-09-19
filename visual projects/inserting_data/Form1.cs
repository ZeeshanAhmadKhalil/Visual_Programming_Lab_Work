using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inserting_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=.;Initial Catalog=Shop2;Integrated Security=True";
            string query = "Set identity_insert salesman ON;insert into salesman([ID],[Name],[Address]) values(@ID,@Name,@Address)";
            SqlConnection connection = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            connection.Open();
            cmd.Parameters.AddWithValue("@ID",textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
