using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saketha_Hotel_System_Try_1.Logistic_Manager
{
    public partial class Lmanager_home : Form
    {
        public Lmanager_home()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void guna2GroupBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void supplier(object sender, EventArgs e)
        {
            Add_Suppliers hi = new Add_Suppliers();
            this.Hide();
            hi.Show();

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stock(object sender, EventArgs e)
        {
            Kitchen_items hi = new Kitchen_items();
            this.Hide();
            hi.Show();
        }

        private void alert(object sender, EventArgs e)
        {
            Kitchen_item_requests kir = new Kitchen_item_requests();
            this.Hide();
            kir.Show();
        }
    }
}
