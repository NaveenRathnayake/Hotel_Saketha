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

namespace Saketha_Hotel_System_Try_1.Accountant
{
    public partial class Profit_Report : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;


        public Profit_Report()
        {
            InitializeComponent();
            display();
            display1();
            display2();
            display3();
            display4();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from profit_report", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for display data in databse as a table
        public void display1()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from sales_report", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }
        //method for display data in databse as a table
        public void display2()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from order_stock", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView3.DataSource = dt;

        }
        //method for display data in databse as a table
        public void display3()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from salary", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView4.DataSource = dt;

        }

        //method for display data in databse as a table
        public void display4()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from maintenance", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView5.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            totalsalesofhotaltxt.Clear();
            itemordercosttxt.Clear();
            totalemployeesalarycosttxt.Clear();
            totalmaintanancecosttxt.Clear();
            totalprofittxt.Clear();
            datepick1.ResetText();
            //search2.Clear();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Logout?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Profit_Report_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ProRepBtn_Click(object sender, EventArgs e)
        {
            Profit_Report pr = new Profit_Report();
            this.Hide();
            pr.Show();
        }

        private void SalRepBtn_Click(object sender, EventArgs e)
        {
            Maintanance sr = new Maintanance();
            this.Hide();
            sr.Show();
        }

        private void closebtn_Click_1(object sender, EventArgs e)
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("insert into profit_report values ('' ,'" + totalsalesofhotaltxt.Text + "', '" + itemordercosttxt.Text + "','" + totalemployeesalarycosttxt.Text + "', '" + totalmaintanancecosttxt.Text + "',now() , '" + totalprofittxt.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Profit details added Successfully... ");
                conn.Close();
                display();
                clearFeilds();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView1.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from profit_report where Profit_Report_ID = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    display();
                }
            }
        }



       

        private void totalprofittxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            totalprofittxt.Text = Convert.ToString(double.Parse(totalsalesofhotaltxt.Text) - (double.Parse(itemordercosttxt.Text) + double.Parse(totalemployeesalarycosttxt.Text) + double.Parse(totalmaintanancecosttxt.Text)));
        }



        private void totalsalesofhotaltxt_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void datetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalemployeesalarycosttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
           
                if (datepick1.Value.ToString() == null && datepick2.Value.ToString() == null)
                {
                    MessageBox.Show("Please Select Date...");
                    display4();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from maintenance where Date between '" + datepick1.Value.ToString("yyyy/MM/dd") + "' AND '" + datepick2.Value.ToString("yyyy/MM/dd") + "'  ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView5.DataSource = dt;

                    totalmaintanancecosttxt.Text = "0";
                    dataGridView5.AllowUserToAddRows = false;
                    for (int i = 0; i < dataGridView5.Rows.Count; i++)
                    {
                        totalmaintanancecosttxt.Text = Convert.ToString(int.Parse(totalmaintanancecosttxt.Text) + int.Parse(dataGridView5.Rows[i].Cells[2].Value.ToString()));
                    }
                    ////
                    MySqlDataAdapter sqlAdapter2 = new MySqlDataAdapter("Select * from sales_report where Date between '" + datepick1.Value.ToString("yyyy/MM/dd") + "' AND '" + datepick2.Value.ToString("yyyy/MM/dd") + "'  ", conn);
                    DataTable dt2 = new DataTable();
                    sqlAdapter2.Fill(dt2);
                    dataGridView2.DataSource = dt2;

                    totalsalesofhotaltxt.Text = "0";
                    dataGridView2.AllowUserToAddRows = false;
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        totalsalesofhotaltxt.Text = Convert.ToString(int.Parse(totalsalesofhotaltxt.Text) + int.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString()));
                    }
                    ////
                    MySqlDataAdapter sqlAdapter3 = new MySqlDataAdapter("Select * from order_stock where order_date between '" + datepick1.Value.ToString("yyyy/MM/dd") + "' AND '" + datepick2.Value.ToString("yyyy/MM/dd") + "'  ", conn);
                    DataTable dt3 = new DataTable();
                    sqlAdapter3.Fill(dt3);
                    dataGridView3.DataSource = dt3;

                    itemordercosttxt.Text = "0";
                    dataGridView3.AllowUserToAddRows = false;
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        itemordercosttxt.Text = Convert.ToString(int.Parse(itemordercosttxt.Text) + int.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString()));
                    }
                    ////
                    MySqlDataAdapter sqlAdapter4 = new MySqlDataAdapter("Select * from salary where Date between '" + datepick1.Value.ToString("yyyy/MM/dd") + "' AND '" + datepick2.Value.ToString("yyyy/MM/dd") + "'  ", conn);
                    DataTable dt4 = new DataTable();
                    sqlAdapter4.Fill(dt4);
                    dataGridView4.DataSource = dt4;

                    totalemployeesalarycosttxt.Text = "0";
                    dataGridView4.AllowUserToAddRows = false;
                    for (int i = 0; i < dataGridView4.Rows.Count; i++)
                    {
                        totalemployeesalarycosttxt.Text = Convert.ToString(int.Parse(totalemployeesalarycosttxt.Text) + int.Parse(dataGridView4.Rows[i].Cells[8].Value.ToString()));
                    }

                }

            
           

            ////////////////////
        }

        /*
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer1 = new DGVPrinter();
            printer1.Title = "Employee Salary Pasheet";
            printer1.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer1.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer1.PageNumbers = true;
            printer1.PageNumberInHeader = false;
            printer1.PrintPreviewDataGridView(dataGridView1);
            printer1.HeaderCellAlignment = StringAlignment.Near;
            printer1.Footer = "By Accountant";
            printer1.FooterSpacing = 5;
        }
        */

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}