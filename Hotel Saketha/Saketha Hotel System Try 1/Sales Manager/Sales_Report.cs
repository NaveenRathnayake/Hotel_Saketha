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
using DGVPrinterHelper;

namespace Saketha_Hotel_System_Try_1.Sales_Manager
{
    public partial class Sales_Report : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempid;

        public Sales_Report()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from sales_report ", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            tot_restau_salestxt.Clear();
            packagetottxt.Clear();
            roomtottxt.Clear();
            eventstottxt.Clear();
            datepick.Refresh();
            totaltxt.Clear();
            search.Clear();


        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            totaltxt.Text = Convert.ToString(double.Parse(tot_restau_salestxt.Text) + double.Parse(roomtottxt.Text) + double.Parse(eventstottxt.Text) + double.Parse(packagetottxt.Text));


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                tot_restau_salestxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                packagetottxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                datepick.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                totaltxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (validateSales())
            {
                conn.Open();
                cmd = new MySqlCommand("insert into sales_report values ('' , '" + tot_restau_salestxt.Text + "' ,'" + roomtottxt.Text + "' ,'" + eventstottxt.Text + "' ,'" + packagetottxt.Text + "' , '"+datepick.Value.ToShortDateString()+"' ,'" + totaltxt.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Sales Report details Saved... ");
                conn.Close();
                display();
                clearFeilds();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView1.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from sales_report where sales_Report_ID = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    clearFeilds();
                    display();
                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (search.Text == null)
            {
                MessageBox.Show("Please Enter Customer ID...");
            }
            else
            {
                string selectQuary = "Select * from sales_report where sales_Report_ID = " + int.Parse(search.Text);
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    tot_restau_salestxt.Text = mdr.GetInt32("restaurant_Total_Sales").ToString();
                    packagetottxt.Text = mdr.GetInt32("reception_Total_Sales").ToString();
                    datepick.Text = mdr.GetString("date");
                    totaltxt.Text = mdr.GetInt32("total_Sales").ToString();

                }
                else
                {
                    MessageBox.Show("Search Valid sales Report ID...");
                    clearFeilds();
                }
            }

            conn.Close();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {

        }

        private void tot_restau_salestxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sales Report"; //header
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Hotel Saketha"; //footer
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        public Boolean validateSales()
        {
            Boolean flag = true;
            string error_message = "";

            if (string.IsNullOrEmpty(tot_restau_salestxt.Text) || string.IsNullOrEmpty(packagetottxt.Text))
            {
                error_message = error_message + "\n All the fields are required";
                flag = false;
            }

            if(!flag)
            {
                MessageBox.Show(error_message);
            }
            return flag;
        }

        private void searchdate_Click(object sender, EventArgs e)
        {
            if (datepick.Value.ToString() == null)
            {
                MessageBox.Show("Please Select Date...");
                display();
            }
            else
            {
              
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from orders where Date = '" + datepick.Value.ToString("yyyy/MM/dd") + "'  ", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView2.DataSource = dt;

                tot_restau_salestxt.Text = "0";
                dataGridView2.AllowUserToAddRows = false;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    tot_restau_salestxt.Text = Convert.ToString(int.Parse(tot_restau_salestxt.Text) + int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString()));
                }
                ////
                MySqlDataAdapter sqlAdapter2 = new MySqlDataAdapter("Select * from room_booking where date = '" + datepick.Value.ToShortDateString() + "'  ", conn);
                DataTable dt2 = new DataTable();
                sqlAdapter2.Fill(dt2);
                dataGridView3.DataSource = dt2;

                roomtottxt.Text = "0";
                dataGridView3.AllowUserToAddRows = false;
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    roomtottxt.Text = Convert.ToString(int.Parse(roomtottxt.Text) + int.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString()));
                }
                ////
                MySqlDataAdapter sqlAdapter3 = new MySqlDataAdapter("Select * from event_booking where  date = '" + datepick.Value.ToShortDateString() + "'  ", conn);
                DataTable dt3 = new DataTable();
                sqlAdapter3.Fill(dt3);
                dataGridView4.DataSource = dt3;

                eventstottxt.Text = "0";
                dataGridView4.AllowUserToAddRows = false;
                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    eventstottxt.Text = Convert.ToString(int.Parse(eventstottxt.Text) + int.Parse(dataGridView4.Rows[i].Cells[7].Value.ToString()));
                }
                ////
                MySqlDataAdapter sqlAdapter4 = new MySqlDataAdapter("Select * from package_booking where  date = '" + datepick.Value.ToShortDateString() + "'  ", conn);
                DataTable dt4 = new DataTable();
                sqlAdapter4.Fill(dt4);
                dataGridView5.DataSource = dt4;

                packagetottxt.Text = "0";
                dataGridView5.AllowUserToAddRows = false;
                for (int i = 0; i < dataGridView5.Rows.Count; i++)
                {
                    packagetottxt.Text = Convert.ToString(int.Parse(packagetottxt.Text) + int.Parse(dataGridView5.Rows[i].Cells[3].Value.ToString()));
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
