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

namespace Saketha_Hotel_System_Try_1.Head_Chef
{
    public partial class Kitchen_Items_Request : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;
        MySqlDataReader mdr;


        ReportDataSource rs = new ReportDataSource();
        private int tempid;

        public Kitchen_Items_Request()
        {
            InitializeComponent();
            display();
            display1();
        }

        //method for display kitchen item table
        public void display1()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select item_id, item_name from kitchen_items", conn);
            DataTable dt1 = new DataTable();
            sqlAdapter.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }

        //method for display kitchen item request table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from kitchen_item_requests", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            itemid.Clear();
            itemname.Clear();
            itemquantity.Clear();
            search.Clear();
            datepick.ResetText();
            
        }

        //go to Tickets page
        private void ticketsbtn_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets();
            this.Hide();
            t.Show();
        }

        //Refresh the page
        private void reqkitchenitemsbtn_Click(object sender, EventArgs e)
        {
            Kitchen_Items_Request kir = new Kitchen_Items_Request();
            this.Hide();
            kir.Show();
        }

        //Go to Low quality food alert table
        private void alertbtn_Click(object sender, EventArgs e)
        {
            Low_Quality_Alerts lqa = new Low_Quality_Alerts();
            this.Hide();
            lqa.Show();
        }

        //go to login page
        private void logoutbtn_Click_1(object sender, EventArgs e)
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

        //Exit from application
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

        //add deatils to text feailds by clicking on table
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                itemid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                itemname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                itemquantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        //make request
        private void requestbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Make a Request ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into kitchen_item_requests values ('' , '" + itemid.Text + "' ,'" + itemname.Text + "', '" + itemquantity.Text + "', now(), 'Not Completed') ", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Request Send Successfully... ");
                    conn.Close();
                    display();
                    clearFeilds();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Cant Overrite Item Id.. Please try to Update... ");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        //Clear text feilds
        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
            display();
        }

        //update Request
        private void updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Update data ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("update kitchen_item_requests set Item_Id = '" + itemid.Text + "' ,Item_Name = '" + itemname.Text + "' , Quantity = '" + itemquantity.Text + "' , Date = now() where Request_Id = '" + tempid + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Request details Updated... ");
                    conn.Close();
                    display();
                    clearFeilds();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Error while Updating... ", "Error");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        //search by Request Id
        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string selectQuary = "Select * from kitchen_item_requests where Item_Id = '" + search.Text + "' ";
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    conn.Close();
                    if (search.Text == null)
                    {
                        MessageBox.Show("Please Enter Item ID...");
                        display();
                    }
                    else
                    {
                        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from kitchen_item_requests where Item_Id = '" + search.Text + "' ", conn);
                        DataTable dt = new DataTable();
                        sqlAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("There are no record for Entered ID...");
                    display();
                    clearFeilds();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Error while Searching... ", "Error");
                clearFeilds();
            }
            
            
        }

        //delete data
        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Delete ?", "info", MessageBoxButtons.YesNo);
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
                            String sqlQuery = "Delete from kitchen_item_requests where Request_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                            MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                            sqlcmd.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(i);
                            MessageBox.Show("Deleted Successfully....");
                            conn.Close();
                            display();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(" Error while Deleting... ", "Error");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            

        }

        //get data by mouse double click
        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            itemid.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            itemname.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void itemid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        

        //print current showing table
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Print ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<Class1> c1 = new List<Class1>();
                c1.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    c1.Add(new Class1
                    {
                        prequest_Id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                        pitem_Id = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()),
                        pitem_Name = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        pquantity = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        status = dataGridView1.Rows[i].Cells[5].Value.ToString(),

                    });
                }
                    rs.Name = "DataSet1";
                    rs.Value = c1;
                    Item_Request_Report rp = new Item_Request_Report();
                    rp.reportViewer1.LocalReport.DataSources.Clear();
                    rp.reportViewer1.LocalReport.DataSources.Add(rs);
                    rp.reportViewer1.LocalReport.ReportEmbeddedResource = "Saketha_Hotel_System_Try_1.Head_Chef.Report1.rdlc";

                    rp.Show();
                
                /*
                DGVPrinter printer = new DGVPrinter();

                ///
                printer.Title = "Hotel Saketha Kitchen - Kitchen Items Request Report";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintPreviewDataGridView(dataGridView1);
                */
                MessageBox.Show("Succefully pdf created...!!!");
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void itemname_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void Kitchen_Items_Request_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void datepick_ValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from  kitchen_item_requests where Date = '" + datepick.Value.ToString("yyyy/MM/dd") + "' ";
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
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from  kitchen_item_requests  where Date = '" + datepick.Value.ToString("yyyy/MM/dd") + "' ", conn);
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
                datepick.ResetText();
                display();
            }
        }
    }
}
