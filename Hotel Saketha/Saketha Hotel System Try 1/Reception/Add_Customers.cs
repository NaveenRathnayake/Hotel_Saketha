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

namespace Saketha_Hotel_System_Try_1.Reception
{

    public partial class Add_Customers : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempid;

        public Add_Customers()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_customer", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            nametxt.Clear();
            addresstxt.Clear();
            nictxt.Clear();
            phonetxt.Clear();
            emailtxt.Clear();
            search.Clear();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void foodname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                addresstxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                nictxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                phonetxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                emailtxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Reception_Home rh = new Reception_Home();
            this.Hide();
            rh.Show();
        }

        private void add_customer_btn_Click(object sender, EventArgs e)
        {
            Event_Booking ac = new Event_Booking();
            this.Hide();
            ac.Show();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (validateCustomer())
            {
                conn.Open();
                cmd = new MySqlCommand("insert into add_customer values ('' , '" + nametxt.Text + "' ,'" + addresstxt.Text + "' , '" + nictxt.Text + "','" + phonetxt.Text + "','" + emailtxt.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Customer details Saved... ");
                conn.Close();
                
                display();
                clearFeilds();
            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update add_customer set name = '" + nametxt.Text + "' ,address = '" + addresstxt.Text + "' , NIC = '" + nictxt.Text + "', phone = '" + phonetxt.Text + "' , email = '" + emailtxt.Text + "' where customer_ID = '" + tempid + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Customer details Updated... ");
            conn.Close();
            display();
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
                    String sqlQuery = "Delete from add_customer where customer_ID = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
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
                string selectQuary = "Select * from add_customer where customer_ID = " + int.Parse(search.Text);
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    nametxt.Text = mdr.GetString("name");
                    addresstxt.Text = mdr.GetString("address");
                    nictxt.Text = mdr.GetString("NIC");
                    phonetxt.Text = mdr.GetInt32("phone").ToString();
                    emailtxt.Text = mdr.GetString("email");
                }
                else
                {
                    MessageBox.Show("Search Valid Customer ID...");
                    clearFeilds();
                }
            }

            conn.Close();
        }

        private void offers_btn_Click(object sender, EventArgs e)
        {
            Offers o = new Offers();
            this.Hide();
            o.Show();
        }

        private void name_txt_Click(object sender, EventArgs e)
        {

        }

        //validation method
        public Boolean validateCustomer()
        {
            Boolean flag = true;
            String ErrorMessage = "";

            //required fields
            if (string.IsNullOrEmpty(emailtxt.Text) || string.IsNullOrEmpty(phonetxt.Text) || string.IsNullOrEmpty(nametxt.Text) || string.IsNullOrEmpty(addresstxt.Text) || string.IsNullOrEmpty(nictxt.Text))
            {
                ErrorMessage = ErrorMessage + "\n All the Fields are required";
                flag = false;
            }

            if (nictxt.Text.EndsWith("V"))
            {
                if (nictxt.Text.Length != 10)
                {
                    ErrorMessage = ErrorMessage + "\n Old Nic Should have 10 digits";
                    flag = false;
                }
            }
            else
            {
                if (nictxt.Text.Length != 12)
                {
                    ErrorMessage = ErrorMessage + "\n New Nic Should have 12 digits";
                    flag = false;
                }
            }

            //checking the nic number
            

            //mobile number validation
            if (phonetxt.Text.Length != 10)
            {
                ErrorMessage = ErrorMessage + "\n Mobile Number Should have 10 digit";
                flag = false;
               
            }

            //email validation
            if(!emailtxt.Text.Contains('@'))
            {
                ErrorMessage = ErrorMessage + "\n Invalid Email address - should contain @";
                flag = false;
              
            }

            if (emailtxt.Text.Any(Char.IsUpper))
            {
                ErrorMessage = ErrorMessage + "\n All the letters should be  in lowercase in email";
                flag = false;
               
            }


            if (!flag)
            {
                MessageBox.Show(ErrorMessage);
            }
             return flag;
        }

        private void Add_Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
