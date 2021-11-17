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
using System.Globalization;

namespace Saketha_Hotel_System_Try_1.Logistic_Manager
{
    public partial class Household_items : Form
    {

        //connetion with database
        MySqlConnection Con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel_saketha");
        MySqlCommand Cmd;
        MySqlDataReader Mdr;
        MySqlDataAdapter Mda;
        MySqlDataAdapter Mda1;
        DataTable Dt = new DataTable();
        DataTable Dt1 = new DataTable();
        DateTime dat = new DateTime();

        private int tempid;

        public Household_items()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from household_items", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            itemname.Clear();
            itemqunty.Clear();
            itemprice.Clear();
            itemexpdate.Value = DateTime.Now;
            itemstotype.SelectedIndex = -1;
            supid.Clear();
            orderid.Clear();
            item_id.Clear();
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

        private void kitchenitembtn_Click(object sender, EventArgs e)
        {
            Kitchen_items hi = new Kitchen_items();
            this.Hide();
            hi.Show();
        }

        private void addsupbtn_Click(object sender, EventArgs e)
        {
            //textfiled validation
            if (itemname.Text == "" || itemqunty.Text == "" || itemprice.Text == "" || itemexpdate.Text == "" || itemstotype.Text == "" || supid.Text == "" || orderid.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = supid;
            }

            else
            {
                //Validate expire date                
                if (itemexpdate.Value > DateTime.Today)
                { 


                //supplier ID validation
                MySqlDataAdapter Mda = new MySqlDataAdapter("SELECT * FROM sup_details WHERE sup_id = '" + supid.Text + "'", Con);
                Mda.Fill(Dt);

                if (Dt.Rows.Count >= 1)
                {

                    //Order ID validation
                    MySqlDataAdapter Mda1 = new MySqlDataAdapter("SELECT * FROM order_stock WHERE order_id = '" + orderid.Text + "'", Con);
                    Mda1.Fill(Dt1);

                    if (Dt1.Rows.Count >= 1)
                    {
                        //Insert data to database 
                        DialogResult dialogResult = MessageBox.Show("Do You Sure want to Add Data to Database ?", "info", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Insert data to datbase
                            Con.Open();
                            Cmd = new MySqlCommand("insert into household_items values(0,'" + itemname.Text + "','" + itemqunty.Text + "','" + itemprice.Text + "','" + itemexpdate.Text + "','" + itemstotype.Text + "','" + supid.Text + "','" + orderid.Text + "') ", Con);
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
                        MessageBox.Show("Entered Order ID does not Exist!", "Error!");
                        orderid.Clear();
                        this.ActiveControl = orderid;
                    }

                }

                else
                {
                    MessageBox.Show("Entered Supplier ID does not Exist!", "Error!");
                    supid.Clear();
                    this.ActiveControl = supid;
                }


                }

                else
                {
                    MessageBox.Show("Entered Expire Date Is Already Expired", "Warning!");
                    itemexpdate.Value = DateTime.Now;
                    this.ActiveControl = itemexpdate;
                }

            }
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //clear button
            clearFeilds();
        }

        private void updatesupbtn_Click(object sender, EventArgs e)
        {
            //textfiled validation
            if (itemname.Text == "" || itemqunty.Text == "" || itemprice.Text == "" || itemexpdate.Text == "" || itemstotype.Text == "" || supid.Text == "" || orderid.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = supid;
            }

            else
            {
                /* //Validate expire date
                DateTime enteredDate = DateTime.Parse(inputDate);
                DateTime dat = DateTime.ParseExact(enteredDate.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (itemexpdate.Value != "" && dat > DateTime.Today)
                { */


                //supplier ID validation
                MySqlDataAdapter Mda = new MySqlDataAdapter("SELECT * FROM sup_details WHERE sup_id = '" + supid.Text + "'", Con);
                Mda.Fill(Dt);

                if (Dt.Rows.Count >= 1)
                {

                    //Order ID validation
                    MySqlDataAdapter Mda1 = new MySqlDataAdapter("SELECT * FROM order_stock WHERE order_id = '" + orderid.Text + "'", Con);
                    Mda1.Fill(Dt1);

                    if (Dt1.Rows.Count >= 1)
                    {
                        //update data in database
                        DialogResult dialogResult = MessageBox.Show("Do You Sure want to Update Database ?", "info", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //update item details from database
                            Con.Open();
                            Cmd = new MySqlCommand("update household_items set item_name = '" + itemname.Text + "' , item_qunty = '" + itemqunty.Text + "' , item_price = '" + itemprice.Text + "' , item_expdate = '" + itemexpdate.Text + "' , item_stotype = '" + itemstotype.Text + "' , sup_id = '" + supid.Text + "' , order_id = '" + orderid.Text + "'where item_id = '" + tempid + "'", Con);
                            Cmd.ExecuteNonQuery();
                            MessageBox.Show(" Item Details Updated!");
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
                        MessageBox.Show("Entered Order ID does not Exist!", "Error!");
                        orderid.Clear();
                        this.ActiveControl = orderid;
                    }

                }

                else
                {
                    MessageBox.Show("Entered Supplier ID does not Exist!", "Error!");
                    supid.Clear();
                    this.ActiveControl = supid;
                }


                /*}

                else
                {
                    MessageBox.Show("Entered Expire Date Is Already Expired", "Warning!");
                    itemexpdate.Value = DateTime.Now;
                    this.ActiveControl = itemexpdate;
                }*/

            }


            
        }

        private void deletesupbtn_Click(object sender, EventArgs e)
        {

            //delete kitchen item details from databse
            DialogResult dialogResult = MessageBox.Show("Do You Sure want to Delete ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //delete item details in databse
                Con.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow dv = dataGridView1.Rows[i];
                    if (dv.Selected == true)
                    {
                        String sqlQuery = "Delete from household_items where item_id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                        MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, Con);
                        sqlcmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(i);
                        MessageBox.Show("Delete Selected item Details Sucessfully!");
                        Con.Close();
                        display();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void searchitem(object sender, EventArgs e)
        {
            //serch item details using item ID
            Con.Open();

            String selectQuery = "SELECT *  FROM  hotel_saketha.household_items WHERE item_id=" + int.Parse(item_id.Text);
            Cmd = new MySqlCommand(selectQuery, Con);

            Mdr = Cmd.ExecuteReader();

            if (Mdr.Read())
            {
                itemname.Text = Mdr.GetString("item_name");
                itemqunty.Text = Mdr.GetString("item_qunty");
                itemprice.Text = Mdr.GetString("item_price");
                itemexpdate.Text = Mdr.GetString("item_expdate");
                itemstotype.Text = Mdr.GetString("item_stotype");
                supid.Text = Mdr.GetString("sup_id");
                orderid.Text = Mdr.GetString("order_id");
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                itemname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                itemqunty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                itemprice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                itemexpdate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                itemstotype.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                supid.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                orderid.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Lmanager_home hi = new Lmanager_home();
            this.Hide();
            hi.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Order_stock os = new Order_stock();
            this.Hide();
            os.Show();
        }
    }
}
