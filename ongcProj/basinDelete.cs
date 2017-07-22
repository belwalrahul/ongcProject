using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ongcProj
{
    public partial class basinDelete : Form
    {
        public basinDelete()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-U5GTQB1;Initial Catalog=ongcProjectdB;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "delete from basin where bid='" + textBox1.Text + "'";
                SqlCommand comm = new SqlCommand(query, con);
                int rows = comm.ExecuteNonQuery();

                if (rows != -1)
                {
                    confirmation c = new confirmation("bd");
                    c.Show();
                    this.Hide();
                }
            }
            con.Close();
            
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
