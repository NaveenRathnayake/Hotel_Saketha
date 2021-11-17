using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saketha_Hotel_System_Try_1.Head_Chef
{
    public partial class Tickets : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        DataTable dt1 = new DataTable();


        public Tickets()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Ticket_Id, Order_Id, Food_Name, Quantity, Status, Time from add_tickets where Status = 'Not Complete' ", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            search.Clear();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Exit ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Logout ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void ticketsbtn_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets();
            this.Hide();
            t.Show();
        }

        private void reqkitchenitemsbtn_Click(object sender, EventArgs e)
        {
            Kitchen_Items_Request kir = new Kitchen_Items_Request();
            this.Hide();
            kir.Show();
        }

        private void alertbtn_Click(object sender, EventArgs e)
        {
            Low_Quality_Alerts lqa = new Low_Quality_Alerts();
            this.Hide();
            lqa.Show();
        }

        private void Searchlbl_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from add_tickets where Status = 'Not Complete' ";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                conn.Close();
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Ticket_Id, Order_Id, Food_Name, Quantity, Status, Time from add_tickets where Status = 'Completed' ", conn);
                DataTable dt3 = new DataTable();
                sqlAdapter.Fill(dt3);
                dataGridView1.DataSource = dt3;               
            }
            else
            {
                conn.Close();
                MessageBox.Show("All Orders are Completed");
                display();
            }
        }


        //search by Order ID
        private void searchbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from add_tickets where Order_Id = '" + search.Text + "' ";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                conn.Close();
                if (search.Text == null)
                {
                    MessageBox.Show("Please Enter Order ID...");
                    display();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Ticket_Id, Order_Id, Food_Name, Quantity, Status, Time from add_tickets where Order_Id = '" + search.Text + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("Please Enter Valid Order ID...");
                display();
                clearFeilds();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
            display();
            dt1.Clear();
        }

        //update as completed
        private void completebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Update ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow dv = dataGridView1.Rows[i];
                        if (dv.Selected == true)
                        {
                            cmd = new MySqlCommand("update add_tickets set Status = 'Completed' where Ticket_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Marked Successfully....");
                            conn.Close();
                            display();

                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(" Error... ");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
