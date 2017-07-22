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
    public partial class view3 : Form
    {
        public view3()
        {
            InitializeComponent();
        }

        private void view3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ongcProjectdBDataSet.basin' table. You can move, or remove it, as needed.
            this.basinTableAdapter.Fill(this.ongcProjectdBDataSet.basin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations o = new Operations("basin");
            o.Show();
            this.Hide();

        }
    }
}
