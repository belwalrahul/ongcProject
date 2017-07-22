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
    public partial class reservoirDelete : Form
    {
        public reservoirDelete()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-U5GTQB1;Initial Catalog=ongcProjectdB;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "delete from reservoir where r_ID='" + textBox1.Text + "'";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand comm = new SqlCommand(query, con);
                int rows = comm.ExecuteNonQuery();

                if (rows != -1)
                {
                    confirmation c = new confirmation("rd");
                    c.Show();
                    this.Hide();
                }
            }
            con.Close();
        }
    }
}
