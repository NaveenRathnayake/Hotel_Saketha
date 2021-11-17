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
    public partial class Low_Quality_Alerts : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        ReportDataSource rs = new ReportDataSource();

        private int tempid;

        public Low_Quality_Alerts()
        {
            InitializeComponent();
            display();
            display1();
        }

        //method for display data in databse as a table
        public void display1()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select item_id, item_name from kitchen_items", conn);
            DataTable dt1 = new DataTable();
            sqlAdapter.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from low_quality_alerts", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            itemid.Clear();
            itemname.Clear();
            alertdescription.Clear();
            search.Clear();
            datepick.ResetText();
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

        //get data to textfeilds by double clicking row in the table
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                itemid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                itemname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                alertdescription.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        
        //Search by alert Id
        private void searchbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuary = "Select * from low_quality_alerts where Item_Id = '" + search.Text + "' ";
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
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from low_quality_alerts where Item_Id = '" + search.Text + "' ", conn);
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

        //clear text feilds
        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
            display();
        }

        //add low quality alert
        private void addbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Create Alert ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into low_quality_alerts values ('' , '" + itemid.Text + "' ,'" + itemname.Text + "', '" + alertdescription.Text + "', now(), 'Unread')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Alert Add Successfully... ");
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

        //update alert
        private void updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Update ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("update low_quality_alerts set Item_Id = '" + itemid.Text + "' ,Item_Name = '" + itemname.Text + "' , Alert_Description = '" + alertdescription.Text + "', Date = now() where Alert_Id = '" + tempid + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Alert details Updated... ");
                    conn.Close();
                    display();
                    clearFeilds();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Error while updating... ");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
           
        }

        //delet Alert
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
                            String sqlQuery = "Delete from low_quality_alerts where Alert_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
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
                    MessageBox.Show(" Error while deleting... ");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                itemid.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                itemname.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void itemid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void itemname_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void printbtn_Click(object sender, EventArgs e)
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
                        zalert_id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                        zitem_id = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()),
                        zitem_name = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        zdescrip = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        zstatus = dataGridView1.Rows[i].Cells[5].Value.ToString(),

                    });
                }
                rs.Name = "DataSet2";
                rs.Value = c1;
                Alert_report rp = new Alert_report();
                
                rp.reportViewer2.LocalReport.DataSources.Clear();
                rp.reportViewer2.LocalReport.DataSources.Add(rs);
                rp.reportViewer2.LocalReport.ReportEmbeddedResource = "Saketha_Hotel_System_Try_1.Head_Chef.Report2.rdlc";

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
            string selectQuary = "Select * from   low_quality_alerts  where Date = '" + datepick.Value.ToString("yyyy/MM/dd") + "' ";
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
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from   low_quality_alerts   where Date = '" + datepick.Value.ToString("yyyy/MM/dd") + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("There are no record for Entered Date...");
                datepick.ResetText();
                display();
                clearFeilds();
            }
        }

        private void datepick_MouseLeave(object sender, EventArgs e)
        {
           
        }
    }
}
