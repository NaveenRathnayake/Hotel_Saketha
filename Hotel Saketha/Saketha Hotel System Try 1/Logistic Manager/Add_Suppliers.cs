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
    public partial class Add_Suppliers : Form
    {
        //connetion with database
        MySqlConnection Con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel_saketha");
        MySqlCommand Cmd;
        MySqlDataReader Mdr;

        private int tempid;
        

        public Add_Suppliers()
        {
            InitializeComponent();
            //display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from sup_details", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            supname.Clear();
            supnic.Clear();
            supphone.Clear();
            supmail.Clear();
            supaddress.Clear();
            supplier_id.Clear();
            supstatus.SelectedIndex = -1;
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
            Login l = new Login();
            l.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Searchlbl_Click(object sender, EventArgs e)
        {

        }

        

        private void Supplier_ID(object sender, EventArgs e)
        {

        }

        private void addsupplierbtn_Click(object sender, EventArgs e)
        {
            //Insert data to datbase
            if (supname.Text == "" || supnic.Text == "" || supphone.Text == "" || supmail.Text == "" || supaddress.Text == "" || supstatus.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = supmail;
            }

            else
            {
                if (supnic.Text.Length == 12)
                {

                    if (supphone.Text.Length == 10)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do You Sure want to Add Data to Database ?", "info", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Con.Open();
                            Cmd = new MySqlCommand("insert into sup_details values(0,'" + supname.Text + "','" + supnic.Text + "','" + supphone.Text + "','" + supmail.Text + "','" + supaddress.Text + "','" + supstatus.Text + "') ", Con);
                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Input to database Succesfully.");
                            Con.Close();
                            display();
                            clearFeilds();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter 10 Digit For Supplier Phone");
                        supphone.Clear();
                        this.ActiveControl = supphone;
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter 12 Numbers For Supplier NIC");
                    supnic.Clear();
                    this.ActiveControl = supnic;
                }


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void supplier_nic(object sender, EventArgs e)
        {

        }

        private void supplier_phone(object sender, EventArgs e)
        {

        }

        private void supplier_mail(object sender, EventArgs e)
        {

        }

        private void supplier_address(object sender, EventArgs e)
        {

        }

        private void supplier_name(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //clear button
            clearFeilds();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            //serch supplier details using supplier ID
            Con.Open();

            String selectQuery = "SELECT *  FROM  hotel_saketha.sup_details WHERE sup_id=" + int.Parse(supplier_id.Text);
            Cmd = new MySqlCommand(selectQuery, Con);

            Mdr = Cmd.ExecuteReader();

            if(Mdr.Read())
            {
                supname.Text = Mdr.GetString("sup_name");
                supnic.Text = Mdr.GetString("sup_nic");
                supphone.Text = Mdr.GetString("sup_phone");
                supmail.Text = Mdr.GetString("sup_mail");
                supaddress.Text = Mdr.GetString("sup_address");
                supstatus.Text = Mdr.GetString("sup_status");
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }

            Con.Close();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void deletesupbtn_Click(object sender, EventArgs e)
        {
            //delete supplier details from databse
            DialogResult dialogResult = MessageBox.Show("Do You Sure want to Delete ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Con.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow dv = dataGridView1.Rows[i];
                    if (dv.Selected == true)
                    {
                        String sqlQuery = "Delete from sup_details where sup_id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                        MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, Con);
                        sqlcmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(i);
                        MessageBox.Show("Delete Selected Supplier Details Sucessfully!");
                        Con.Close();
                        display();
                    }
                }

            }

            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                supname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                supnic.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                supphone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                supmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                supaddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                supstatus.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Lmanager_home hi = new Lmanager_home();
            this.Hide();
            hi.Show();
        }

        private void updatesupbtn_Click(object sender, EventArgs e)
        {
            //update data from database
            if (supname.Text == "" || supnic.Text == "" || supphone.Text == "" || supmail.Text == "" || supaddress.Text == "" || supstatus.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = supmail;
            }

            else
            {
                if (supnic.Text.Length == 12)
                {

                    if (supphone.Text.Length == 10)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do You Sure want to Update Database ?", "info", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {  
                            Con.Open();
                            Cmd = new MySqlCommand("update sup_details set sup_name = '" + supname.Text + "' , sup_nic = '" + supnic.Text + "' , sup_phone = '" + supphone.Text + "' , sup_mail = '" + supmail.Text + "' , sup_address = '" + supaddress.Text + "' , sup_status = '" + supstatus.Text + "' where sup_id = '" + tempid + "'", Con);
                            Cmd.ExecuteNonQuery();
                            MessageBox.Show(" Supplier Details Updated!");
                            Con.Close();
                            display();
                            clearFeilds();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter 10 Digit For Supplier Phone", "info");
                        supphone.Clear();
                        this.ActiveControl = supphone;
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter 12 Numbers For Supplier NIC","info");
                    supnic.Clear();
                    this.ActiveControl = supnic;
                }


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
