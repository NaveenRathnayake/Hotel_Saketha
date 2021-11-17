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
    public partial class Kitchen_item_requests : Form
    {
        //make the connection with MySql Database
        MySqlConnection Con = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand Cmd;
        MySqlDataReader Mdr;

        DataTable dt1 = new DataTable();

       private string requestid, itemid, itemname, quanty, date, status;

        public Kitchen_item_requests()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Request_Id, Item_Id, Item_Name, Quantity, Date, Status from kitchen_item_requests", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

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

        //method for clear the text feilds
        public void clearFeilds()
        {
            request_id.Clear();
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
        //mark as complete
        private void complete_Click(object sender, EventArgs e)
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
                            Cmd = new MySqlCommand("update kitchen_item_requests set Status = 'Completed' where Request_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'", Con);
                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Marked Successfully....");
                            Con.Close();

                            if (requestid == null)
                            {
                                display();
                            }
                            else
                            {
                                status = "Completed";
                                dt1.Rows.Add(requestid,itemid, itemname, quanty, date, status);
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Low_quality_alerts lqa = new Low_quality_alerts();
            this.Hide();
            lqa.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            clearFeilds();
            display();
            dt1.Clear();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Lmanager_home hi = new Lmanager_home();
            this.Hide();
            hi.Show();
        }

        private void Kitchen_item_requests_Load(object sender, EventArgs e)
        {
            dt1.Columns.AddRange(new DataColumn[6]{
                new DataColumn("Request Id", typeof(string)),
                new DataColumn("Item Id", typeof(string)),
                new DataColumn("Item Name", typeof(string)),
                new DataColumn("Quantity", typeof(string)),
                new DataColumn("Date", typeof(string)),
                new DataColumn("Status", typeof(string))
            });
        }

        private void search2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string selectQuary = "Select * from kitchen_item_requests where Status = 'Not Completed' ";
            Cmd = new MySqlCommand(selectQuary, Con);
            Mdr = Cmd.ExecuteReader();
            if (Mdr.Read())
            {
                Con.Close();
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Request_Id, Item_Id, Item_Name, Quantity, Date, Status from kitchen_item_requests where Status = 'Not Completed' ", Con);
                DataTable dt3 = new DataTable();
                sqlAdapter.Fill(dt3);
                dataGridView1.DataSource = dt3;
            }
            else
            {
                Con.Close();
                MessageBox.Show("All Orders are Completed");
                display();
            }
        }

        private void search_request_Click(object sender, EventArgs e)
        {
            Con.Open();
            string selectQuary = "Select * from kitchen_item_requests where Request_Id = '" + request_id.Text + "' ";
            Cmd = new MySqlCommand(selectQuary, Con);
            Mdr = Cmd.ExecuteReader();
            if (Mdr.Read())
            {
                Con.Close();
                if (request_id.Text == null)
                {
                    MessageBox.Show("Please Enter Request ID...");
                    display();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Request_Id, Item_Id, Item_Name, Quantity, Date, Status from kitchen_item_requests where Request_Id = '" + request_id.Text + "' ", Con);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            else
            {
                Con.Close();
                MessageBox.Show("Please Enter Valid Order ID...");
                display();
                clearFeilds();
            }
        }
    }

    
    }
