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

namespace Saketha_Hotel_System_Try_1.Director
{
    public partial class View_Profit_Report : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        public View_Profit_Report()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from profit_report", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

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

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from profit_report where Date = '" + datepick.Value.ToShortDateString() + "' ";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                conn.Close();
                if (datepick.Value.ToString() == null)
                {
                    MessageBox.Show("Please Select Date...");
                    display();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from profit_report where Date = '" + datepick.Value.ToShortDateString() + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("There are no record for Entered Date...");
                display();
                Refresh();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            datepick.ResetText();
            display();
        }
    }
}
