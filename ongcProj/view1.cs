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
    public partial class view1 : Form
    {
        public view1()
        {
            InitializeComponent();
        }

        private void view1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ongcProjectdBDataSet.field' table. You can move, or remove it, as needed.
            this.fieldTableAdapter.Fill(this.ongcProjectdBDataSet.field);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations o = new Operations("field");
            o.Show();
            this.Hide();

        }
    }
}
