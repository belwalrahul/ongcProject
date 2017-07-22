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
    public partial class reservoirUpdateP3 : Form
    {
        string p1 = "";
        string p2 = "";
        string p3 = "";
        string p4 = "";
        string p5 = "";
        string p6 = "";
        string p7 = "";
        string p8 = "";
        string p9 = "";
        string p10 = "";
        string p11 = "";
        string p12 = "";
        string p13 = "";
        string p14 = "";
        string p15 = "";

        public reservoirUpdateP3(string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10, string a11, string a12, string a13, string a14, string a15)
        {
            InitializeComponent();

            p1 = a1;
            p2 = a2;
            p3 = a3;
            p4 = a4;
            p5 = a5;
            p6 = a6;
            p7 = a7;
            p8 = a8;
            p9 = a9;
            p10 = a10;
            p11 = a11;
            p12 = a12;
            p13 = a13;
            p14 = a14;
            p15 = a15;
        }

        public string conString = "Data Source=DESKTOP-U5GTQB1;Initial Catalog=ongcProjectdB;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            reservoirUpdateP2 rup2 = new reservoirUpdateP2(p1, p2, p3, p4, p5, p6, p7, p8);
            rup2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "update reservoir set Field_ID='" + p2 + "', [Name of Asset/Basin/Institute/CoD]='" + p3 + "', Field='" + p4 + "', Sand='" + p5 + "', [Project Title]='" + p6 + "', [EOR Method]='" + p7 + "', [EOR Sub-Method]='" + p8 + "', [Group Name]='" + p9 + "', Stages='" + p10 + "', [Year/Duration]='" + p11 + "', [Reported Issue On]='" + p12 + "', Highlights='" + p13 + "', Remarks='" + p14 + "', [Additional Data]='" + p15 + "', [Update Date]='" + textBox1.Text.ToString() + "', [Update User]='" + textBox2.Text.ToString() + "' where r_ID = '" + p1 + "'";
                SqlCommand comm = new SqlCommand(q, con);
                int rows = comm.ExecuteNonQuery();

                if (rows != -1)
                {
                    confirmation c = new confirmation("ru");
                    c.Show();
                    this.Hide();
                }
            }
            con.Close();
        }
    }
}
