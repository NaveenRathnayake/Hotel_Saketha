using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Saketha_Hotel_System_Try_1.Logistic_Manager
{
    public partial class Low_quality_alerts : Form
    {
        //make the connection with MySql Database
        MySqlConnection Con = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand Cmd;
        MySqlDataReader Mdr;

        DataTable dt1 = new DataTable();

       private string alertid, itemid, itemname, descrp, date, status;


        public Low_quality_alerts()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Alert_Id, Item_Id, Item_Name, Alert_Description, Date, Status from low_quality_alerts", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        //make as read
        private void read_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do You Really want to Update ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow dv = dataGridView1.Rows[i];
                        if (dv.Selected == true)
                        {
                            Cmd = new MySqlCommand("update low_quality_alerts set Status = 'Read' where Alert_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'", Con);
                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Marked Successfully....");
                            Con.Close();

                            if (alertid == null)
                            {
                                display();
                            }
                            else
                            {
                                status = "Read";
                                dt1.Rows.Add(alertid, itemid, itemname, descrp, date, status);
                                this.dataGridView1.DataSource = dt1;
                            }
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

        private void clear_Click(object sender, EventArgs e)
        {
            clearFeilds();
            display();
            dt1.Clear();
        }

        private void Low_quality_alerts_Load(object sender, EventArgs e)
        {
            dt1.Columns.AddRange(new DataColumn[6]{
                new DataColumn("Alert Id", typeof(string)),
                new DataColumn("Item Id", typeof(string)),
                new DataColumn("Item Name", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Date", typeof(string)),
                new DataColumn("Status", typeof(string))
            });
        }

        private void search2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string selectQuary = "Select * from low_quality_alerts where Status = 'Unread' ";
            Cmd = new MySqlCommand(selectQuary, Con);
            Mdr = Cmd.ExecuteReader();
            if (Mdr.Read())
            {
                Con.Close();
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Alert_Id, Item_Id, Item_Name, Alert_Description, Date, Status from low_quality_alerts where Status = 'Unread' ", Con);
                DataTable dt3 = new DataTable();
                sqlAdapter.Fill(dt3);
                dataGridView1.DataSource = dt3;
            }
            else
            {
                Con.Close();
                MessageBox.Show("All Alerts are Read.");
                display();
            }
        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            alert_id.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Kitchen_item_requests kir = new Kitchen_item_requests();
            this.Hide();
            kir.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Sure want to Exit ?", "info", MessageBoxButtons.YesNo);
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            Lmanager_home hi = new Lmanager_home();
            this.Hide();
            hi.Show();
        }

        private void searchalert_Click(object sender, EventArgs e)
        {
            Con.Open();
            string selectQuary = "Select * from low_quality_alerts where Alert_Id = '" + alert_id.Text + "' ";
            Cmd = new MySqlCommand(selectQuary, Con);
            Mdr = Cmd.ExecuteReader();
            if (Mdr.Read())
            {
                Con.Close();
                if (alert_id.Text == null)
                {
                    MessageBox.Show("Please Enter Alert ID...");
                    display();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Alert_Id, Item_Id, Item_Name, Alert_Description, Date, Status from low_quality_alerts where Alert_Id = '" + alert_id.Text + "' ", Con);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            else
            {
                Con.Close();
                MessageBox.Show("Please Enter Valid Alert ID...");
                display();
                clearFeilds();
            }
        }




    }
}
