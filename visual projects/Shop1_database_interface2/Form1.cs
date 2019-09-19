using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop1_database_interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DataSet1TableAdapters.salesmanTableAdapter ds=new DataSet1TableAdapters.salesmanTableAdapter())
            {
                DataTable dt = ds.GetData();
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    ListViewItem itm = new ListViewItem(dt.Rows[i][0].ToString());
                    itm.SubItems.Add(dt.Rows[i][1].ToString());
                    itm.SubItems.Add(dt.Rows[i][2].ToString());
                    listView1.Items.Add(itm);
                }

            }
        }
    }
}