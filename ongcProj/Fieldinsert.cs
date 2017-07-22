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

namespace ongcProj
{
    public partial class Fieldinsert : Form
    {
        public Fieldinsert()
        {
            InitializeComponent();
        }

        private void Field_Load(object sender, EventArgs e)
        {

        }

        public string conString = "Data Source=DESKTOP-U5GTQB1;Initial Catalog=ongcProjectdB;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into field values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "')";
                SqlCommand comm = new SqlCommand(q, con);
                int rows = comm.ExecuteNonQuery();

                if (rows != -1)
                {
                    confirmation c = new confirmation("fi");
                    c.Show();
                    this.Hide();
                }
            }
            con.Close();
        }
    }
}
