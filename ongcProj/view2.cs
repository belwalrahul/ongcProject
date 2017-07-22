using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ongcProj
{
    public partial class view2 : Form
    {
        public view2()
        {
            InitializeComponent();
        }

        private void view2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ongcProjectdBDataSet.subbasin' table. You can move, or remove it, as needed.
            this.subbasinTableAdapter.Fill(this.ongcProjectdBDataSet.subbasin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations o = new Operations("subbasin");
            o.Show();
            this.Hide();
        }
    }
}
