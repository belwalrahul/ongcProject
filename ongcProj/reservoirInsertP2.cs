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
    public partial class reservoirInsertP2 : Form
    {
        string p1 = "";
        string p2 = "";
        string p3 = "";
        string p4 = "";
        string p5 = "";
        string p6 = "";
        string p7 = "";
        string p8 = "";

        public reservoirInsertP2(string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservoirInsertP1 rip1 = new  reservoirInsertP1();
            rip1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string p9  = textBox1.Text;
            string p10 = textBox2.Text;
            string p11 = textBox3.Text;
            string p12 = textBox4.Text;
            string p13 = textBox5.Text;
            string p14 = textBox6.Text;
            string p15 = textBox7.Text;

            reservoirInsertP3 rip3 = new reservoirInsertP3(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            rip3.Show();
            this.Hide();
        }

        private void reservoirInsertP2_Load(object sender, EventArgs e)
        {

        }
    }
}
