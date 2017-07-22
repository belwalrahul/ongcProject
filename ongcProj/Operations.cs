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
    public partial class Operations : Form
    {
        string tt = "";
        public Operations(string tableType)
        {
            InitializeComponent();

            if (tableType != "reservoir")
                button2.Hide();

            this.tt = tableType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tt == "basin")
            {
                authentication a = new authentication("bi");
                a.Show();
                this.Hide();
            }

            else if (this.tt == "subbasin")
            {
                authentication a = new authentication("si");
                a.Show();
                this.Hide();

             
            }

            else if (this.tt == "field")
            {
                authentication a = new authentication("fi");
                a.Show();
                this.Hide();

           
            }

            else if (this.tt == "reservoir")
            {
                authentication a = new authentication("ri");
                a.Show();
                this.Hide();
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tt == "basin")
            {
                authentication a = new authentication("bd");
                a.Show();
                this.Hide();

                /*basinDelete bi = new basinDelete();
                bi.Show();
                this.Hide();
                */
            }

            else if (this.tt == "subbasin")
            {
                authentication a = new authentication("sd");
                a.Show();
                this.Hide();

                /*subbasinDelete rip1 = new subbasinDelete();
                rip1.Show();
                this.Hide();
                */
            }

            else if (this.tt == "field")
            {
                authentication a = new authentication("fd");
                a.Show();
                this.Hide();

                /*fieldDelete rip1 = new fieldDelete();
                rip1.Show();
                this.Hide();
                */
            }

            else if (this.tt == "reservoir")
            {
                authentication a = new authentication("rd");
                a.Show();
                this.Hide();

                /*reservoirDelete rip1 = new reservoirDelete();
                rip1.Show();
                this.Hide();
                */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.tt == "basin")
            {
                authentication a = new authentication("bu");
                a.Show();
                this.Hide();

                /*basinUpdate bi = new basinUpdate();
                bi.Show();
                this.Hide();
                */
            }

            else if (this.tt == "subbasin")
            {
                authentication a = new authentication("su");
                a.Show();
                this.Hide();

                /*
                 SubbasinUpdate rip1 = new SubbasinUpdate();
                rip1.Show();
                this.Hide();
                */
            }

            else if (this.tt == "field")
            {
                authentication a = new authentication("fu");
                a.Show();
                this.Hide();

                
            }

            else if (this.tt == "reservoir")
            {
                authentication a = new authentication("ru");
                a.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.tt == "basin")
            {
                view3 a = new view3();
                a.Show();
                this.Hide();
            }

            else if (this.tt == "subbasin")
            {
                view2 a = new view2();
                a.Show();
                this.Hide();

            }

            else if (this.tt == "field")
            {
                view1 a = new view1();
                a.Show();
                this.Hide();


            }

            else if (this.tt == "reservoir")
            {
                view a = new view();
                a.Show();
                this.Hide();
            }
        }
    }
}
