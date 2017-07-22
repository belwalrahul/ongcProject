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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operations O = new Operations("reservoir");
            O.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operations O = new Operations("basin");
            O.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operations O = new Operations("subbasin");
            O.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operations O = new Operations("field");
            O.Show();
        }
    }
}
