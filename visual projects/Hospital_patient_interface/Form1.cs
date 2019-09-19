using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hospital_patient_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Press button to reveal data";
            Modify_Data_box.Visible = false;
            delete_data_box.Visible = false;
            insert_data_box.Visible = false;
            Show_data_box.Visible = true;
            go_back.Visible = true;
        }

        private void show_data_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connection_string = @"Data Source=.;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connection_string);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT*from Patient where ID=@ID";
            connection.Open();
            command.Parameters.AddWithValue("@ID", ID_search.Text);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                listView1.Items.Add(item);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter the information to insert";
            Show_data_box.Visible = false;
            insert_data_box.Visible = true;
            delete_data_box.Visible = false;
            Modify_Data_box.Visible = false;
            go_back.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=.;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connection_string);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Set identity_insert Patient ON;insert into Patient([ID],[Name],[Disease]) values(@ID,@Name,@Disease)";
            connection.Open();
            command.Parameters.AddWithValue("@ID", ID.Text);
            command.Parameters.AddWithValue("@Name", Name.Text);
            command.Parameters.AddWithValue("@Disease", Disease.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter Patient ID to delete record";
            Show_data_box.Visible = false;
            insert_data_box.Visible = false;
            delete_data_box.Visible = true;
            Modify_Data_box.Visible = false;
            go_back.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter Patient ID to modify record";
            Show_data_box.Visible = false;
            insert_data_box.Visible = false;
            delete_data_box.Visible = false;
            Modify_Data_box.Visible = true;
            go_back.Visible = true;
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            label1.Text = "Select the transaction you want to perform";
            Show_data_box.Visible = false;
            insert_data_box.Visible = false;
            delete_data_box.Visible = false;
            Modify_Data_box.Visible = false;
            go_back.Visible = false;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=.;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connection_string);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Delete from Patient where ID=" + id_to_delete.Text;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=.;Initial Catalog=Hospital;Integrated security=True";
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(connection_string);
            command.Connection = connection;
            command.CommandText = "Update Patient Set Name=@Name,Disease=@Disease Where ID=@ID";
            connection.Open();
            command.Parameters.AddWithValue("@ID", ID_modify.Text);
            command.Parameters.AddWithValue("@Name", Name_Modify.Text);
            command.Parameters.AddWithValue("@Disease", Disease_Modify.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Show_all_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connection_string = @"Data Source=.;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connection_string);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT*from Patient";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
