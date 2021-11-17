using Microsoft.Reporting.WinForms;
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

namespace Saketha_Hotel_System_Try_1.Restaurant_Manager
{
    public partial class Order_Reports : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        ReportDataSource rs = new ReportDataSource();

        public string porderid;

        public Order_Reports()
        {
            InitializeComponent();
            display1();
            display2();
        }

        //method for display data in databse as a table
        public void display1()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from orders", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for display data in databse as a table
        public void display2()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Ticket_Id, Food_Name,Unit_Price, Quantity, Total from add_tickets", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            search1.Clear();
            search3.Clear();
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

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            this.Hide();
            or.Show();
        }

        private void addticketsbtn_Click(object sender, EventArgs e)
        {
            Order_Reports at = new Order_Reports();
            this.Hide();
            at.Show();
        }

        private void addfoodsbtn_Click(object sender, EventArgs e)
        {
            Add_foods af = new Add_foods();
            this.Hide();
            af.Show();
        }




        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void ticketstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchlbl_Click(object sender, EventArgs e)
        {

        }

        //search by date
        private void searchbtn2_Click(object sender, EventArgs e)
        {

        }     

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            clearFeilds();
            display1();
            display2();
        }

        private void searchbtn3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from add_tickets where Order_Id = '" + search3.Text + "' ";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                conn.Close();
                if (search3.Text == null)
                {
                    MessageBox.Show("Please Enter Order ID...");
                    display2();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Ticket_Id, Food_Name, Unit_Price, Quantity, Total from add_tickets where Order_Id = '" + search3.Text + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView2.DataSource = dt;

                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("Please Enter Valid Order ID...");
                display2();
                clearFeilds();
            }
        }


        //print Report
        private void printbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from orders where Order_Id = '" + search1.Text + "' ";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                conn.Close();
                if (search1.Text == null)
                {
                    MessageBox.Show("Please Select Valid Order Id...");
                    display1();
                    display2();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from orders where  Order_Id = '" + search1.Text + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Open();
                    string selectQuary2 = "Select * from add_tickets where Order_Id = '" + search1.Text + "' ";
                    cmd = new MySqlCommand(selectQuary2, conn);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        conn.Close();
                        if (search1.Text == null)
                        {
                            MessageBox.Show("Please Enter Order ID...");
                            display2();
                        }
                        else
                        {
                            MySqlDataAdapter sqlAdapter2 = new MySqlDataAdapter("Select Ticket_Id, Food_Name, Unit_Price, Quantity, Total from add_tickets where Order_Id = '" + search1.Text + "' ", conn);
                            DataTable dt2 = new DataTable();
                            sqlAdapter2.Fill(dt2);
                            dataGridView2.DataSource = dt2;

                        }
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Please Enter Valid Order ID...");
                        display2();
                        clearFeilds();
                    }

                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("There are no record for Entered Order Id...");
                clearFeilds();
                display1();
                display2();
            }
            ///////
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Print ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                List<Class2> c2 = new List<Class2>();
                c2.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    c2.Add(new Class2
                    {
                        aorder_Id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                        acus_Name = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        aorder_total = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        aorder_date = dataGridView1.Rows[i].Cells[3].Value.ToString()

                    });
                }
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    c2.Add(new Class2
                    {
                        bticket_Id = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                        bFood_name = dataGridView2.Rows[i].Cells[1].Value.ToString(),
                        bunit_price = dataGridView2.Rows[i].Cells[2].Value.ToString(),
                        bquantity = int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()),
                        btotal = dataGridView2.Rows[i].Cells[4].Value.ToString()

                    });
                }
                rs.Name = "DataSet1";
                rs.Value = c2;
                RDLCOrder_report rp = new RDLCOrder_report();
                rp.reportViewer3.LocalReport.DataSources.Clear();
                rp.reportViewer3.LocalReport.DataSources.Add(rs);
                rp.reportViewer3.LocalReport.ReportEmbeddedResource = "Saketha_Hotel_System_Try_1.Restaurant_Manager.Report3.rdlc";

                rp.Show();

                MessageBox.Show("Succefully pdf created...!!!");

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }



        private void datepick_ValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from orders where Date = '" + datepick.Value.ToShortDateString() + "' ";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                conn.Close();
                if (datepick.Value.ToString() == null)
                {
                    MessageBox.Show("Please Select Date...");
                    display1();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from orders where Date = '" + datepick.Value.ToShortDateString() + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                   
                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("There are no record for Entered Date...");
                clearFeilds();
                display1();
            }

        }

        private void datepick_MouseLeave(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from orders where Date = '" + datepick.Value.ToShortDateString() + "' ";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                conn.Close();
                if (datepick.Value.ToString() == null)
                {
                    MessageBox.Show("Please Select Date...");
                    display1();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from orders where Date = '" + datepick.Value.ToShortDateString() + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                
                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("There are no record for Entered Date...");
                clearFeilds();
                display1();
            }
        }
    }
}
