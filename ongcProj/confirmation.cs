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
    public partial class confirmation : Form
    {

        public confirmation(string msg)
        {
            InitializeComponent();

            if (msg == "bi")
                label1.Text = "Record Inserted into Basin!";

            else if (msg == "bu")
                label1.Text = "Basin Successfully Updated!";

            else if (msg == "bd")
                label1.Text = "Basin Deleted Successfully !";

            else if (msg == "ri")
                label1.Text = "Record Inserted into Reservoir!";

            else if (msg == "ru")
                label1.Text = "Reservoir Successfully Updated!";

            else if (msg == "rd")
                label1.Text = "Reservoir Deleted Successfully !";

            else if (msg == "su")
                label1.Text = "Subbasin Successfully Updated!";

            else if (msg == "si")
                label1.Text = "Record Inserted into Subbasin!";

            else if (msg == "sd")
                label1.Text = "Subbasin Deleted Successfully !";

            else if (msg == "fi")
                label1.Text = "Record Inserted into Field!";

            else if (msg == "fu")
                label1.Text = "Field Successfully Updated!";

            else if (msg == "fd")
                label1.Text = "Field Deleted Successfully !";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
