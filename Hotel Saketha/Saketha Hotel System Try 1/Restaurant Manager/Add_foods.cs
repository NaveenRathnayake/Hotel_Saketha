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
    public partial class Add_foods : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempid;

        public Add_foods()
        {
            
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_food", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            selectbox.SelectedIndex = -1;
            foodname.Clear();
            foodprice.Clear();
            search.SelectedIndex = -1;
            
        }

        private void foodname_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        private void foodprice_TextChanged(object sender, EventArgs e)
        {

        }

     
        //exit from the application
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

        //logout from the application
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //go to the order page
        private void ordersbtn_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            this.Hide();
            or.Show();
        }

        //go to the add ticket page
        private void addticketsbtn_Click(object sender, EventArgs e)
        {
            Order_Reports at = new Order_Reports();
            this.Hide();
            at.Show();
        }

        //go to the add ticket pahe (refresh)
        private void addfoodsbtn_Click(object sender, EventArgs e)
        {
            Add_foods af = new Add_foods();
            this.Hide();
            af.Show();
        }

        //insert data
        private void addfoodbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Add ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {                  
                    conn.Open();
                    cmd = new MySqlCommand("insert into add_food values ('' , '" + selectbox.SelectedItem.ToString() + "', '" + foodname.Text + "' ,'" + foodprice.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Food details Saved... ");
                    conn.Close();
                    display();
                    clearFeilds();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Error while adding... ");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        //Clear text in text boxes from button
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            clearFeilds();
            display();
        }

        //delete data
        private void deletefoodbtn_Click(object sender, EventArgs e)
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
                            String sqlQuery = "Delete from add_food where Food_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
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
                    MessageBox.Show(" Error While Deleting... ");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        //get data to the text feilds by double clicking the rows in the table
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                selectbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                foodname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                foodprice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        

        //update data
        private void updatefoodbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Update ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("update add_food set Catagory = '" + selectbox.SelectedItem.ToString() + "' , Food_Name = '" + foodname.Text + "' , Price = '" + foodprice.Text + "' where Food_Id = '" + tempid + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Food details Updated... ");
                    conn.Close();
                    display();
                    clearFeilds();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while Updating... ");
                    clearFeilds();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        //search by catagory
        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string selectQuary = "Select * from add_food where Catagory = '" + search.SelectedItem.ToString() + "' ";
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    conn.Close();
                    if (search.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("Please Select...");
                        display();
                    }
                    else
                    {
                        if (search.SelectedItem.ToString() == "Starters")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_food where Catagory = 'Starters' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Main_Courses")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_food where Catagory = 'Main_Courses' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Desserts")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_food where Catagory = 'Desserts' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Drinks")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_food where Catagory = 'Drinks' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Shorts")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_food where Catagory = 'Shorts' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("There is no Foods in under this catagory...", "Info");
                    display();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went Wrong...", "Error...");
            }
            clearFeilds();
        }

        private void foodname_TextChanged_1(object sender, EventArgs e)
        {

        }

        //show the foods details
        private void fdpreviewbtn_Click(object sender, EventArgs e)
        {
            Show_Foods sf = new Show_Foods();
            sf.Show();
        }
    }
}
