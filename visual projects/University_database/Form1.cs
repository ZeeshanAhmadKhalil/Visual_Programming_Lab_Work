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

namespace University_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=.;Initial Catalog=University;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT*from Student";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem itm = new ListViewItem(Convert.ToString(reader[0]));
                itm.SubItems.Add(Convert.ToString(reader[1]));
                itm.SubItems.Add(Convert.ToString(reader[2]));
                itm.SubItems.Add(Convert.ToString(reader[3]));
                listView1.Items.Add(itm);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DataSet1TableAdapters.StudentTableAdapter ds=new DataSet1TableAdapters.StudentTableAdapter())
            { 
                DataTable dt=ds.GetData();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem itm = new ListViewItem(Convert.ToString(dt.Rows[i][0]));
                    itm.SubItems.Add(Convert.ToString(dt.Rows[i][1]));
                    itm.SubItems.Add(Convert.ToString(dt.Rows[i][2]));
                    itm.SubItems.Add(Convert.ToString(dt.Rows[i][3]));
                    listView1.Items.Add(itm);
                }
            }
        }
    }
}
