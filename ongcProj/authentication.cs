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
    public partial class authentication : Form
    {
        string msg1 = "";
        public authentication(string msg)
        {
            InitializeComponent();
            msg1 = msg;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "prachi" && textBox2.Text == "puchu")
            {
                if (msg1 == "bi")
                {
                    basinInsert bi = new basinInsert();
                    bi.Show();
                    this.Hide();
                }
                else if (msg1 == "bu")
                {
                    basinUpdate bi = new basinUpdate();
                    bi.Show();
                    this.Hide();
                }
                else if (msg1 == "bd")
                {
                    basinDelete bi = new basinDelete();
                    bi.Show();
                    this.Hide();
                }

                else if (msg1 == "ri")
                {
                    reservoirInsertP1 rip1 = new reservoirInsertP1();
                    rip1.Show();
                    this.Hide();
                }


                else if (msg1 == "ru")
                {
                    reservoirUpdateP1 rip1 = new reservoirUpdateP1();
                    rip1.Show();
                    this.Hide();

                }

                else if (msg1 == "rd")
                {
                    reservoirDelete rip1 = new reservoirDelete();
                    rip1.Show();
                    this.Hide();
                }

                else if (msg1 == "su")
                {
                    SubbasinUpdate rip1 = new SubbasinUpdate();
                    rip1.Show();
                    this.Hide();

                }

                else if (msg1 == "si")
                {
                    subbasinInsert rip1 = new subbasinInsert();
                    rip1.Show();
                    this.Hide();
                }

                else if (msg1 == "sd")
                {
                    subbasinDelete rip1 = new subbasinDelete();
                    rip1.Show();
                    this.Hide();
                }
                else if (msg1 == "fi")
                {
                    Fieldinsert rip1 = new Fieldinsert();
                    rip1.Show();
                    this.Hide();
                }

                else if (msg1 == "fu")
                {
                    FieldUpdate rip1 = new FieldUpdate();
                    rip1.Show();
                    this.Hide();

                }

                else if (msg1 == "fd")
                {
                    fieldDelete rip1 = new fieldDelete();
                    rip1.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Invalid username or password...!");
            }
        }
    }
}
