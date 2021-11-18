using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saketha_Hotel_System_Try_1.Reception
{
    public partial class Reception_Home : Form
    {
        public Reception_Home()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Room_Booking rb = new Room_Booking();
            this.Hide();
            rb.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Add_Customers ac = new Add_Customers();
            this.Hide();
            ac.Show();
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            Event_Booking eb = new Event_Booking();
            this.Hide();
            eb.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Maintain m = new Maintain();
            this.Hide();
            m.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Offers of = new Offers();
            this.Hide();
            of.Show();
         
        }

        private void updatefoodbtn_Click(object sender, EventArgs e)
        {
            Package_Booking pb = new Package_Booking();
            this.Hide();
            pb.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Package_Details pd = new Package_Details();
            this.Hide();
            pd.Show();
        }
    }
}
