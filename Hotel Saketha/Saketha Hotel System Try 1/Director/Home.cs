using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saketha_Hotel_System_Try_1.Director
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void profrepbtn_Click(object sender, EventArgs e)
        {
            View_Profit_Report pr = new View_Profit_Report();
            this.Hide();
            pr.Show();
        }

        private void salesrepbtn_Click(object sender, EventArgs e)
        {
            View_Sales_Reports sp = new View_Sales_Reports();
            this.Hide();
            sp.Show();
        }

        private void logindetailsbtn_Click(object sender, EventArgs e)
        {
            Add_Login ld = new Add_Login();
            this.Hide();
            ld.Show();
        }
    }
}
