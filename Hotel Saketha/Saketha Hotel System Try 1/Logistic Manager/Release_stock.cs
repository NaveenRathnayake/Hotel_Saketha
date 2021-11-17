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
using Microsoft.Reporting.WinForms;

namespace Saketha_Hotel_System_Try_1.Logistic_Manager
{
    public partial class Release_stock : Form
    {
        //connetion with database
        MySqlConnection Con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel_saketha");
        MySqlCommand Cmd;
        MySqlDataReader Mdr;
        DataTable Dt = new DataTable();
        ReportDataSource rs = new ReportDataSource();

        private int release_quanty;
        DataTable dt2 = new DataTable();

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from  release_stock", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        //method for clear the text feilds
        public void clearFeilds()
        {
            section.SelectedIndex = -1;
            releasedate.Value = DateTime.Now;
            carrierid.Clear();
            itemid.Clear();
            quanty.Clear();
            release_id.Clear();
            print_releaseid.Clear();
            dataGridView2.DataSource = null;
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT (MAX(release_id)+1) AS mid FROM release_stock", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            releaseID.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = section;
        }

        public Release_stock()
        {
            InitializeComponent();
            display();
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            Lmanager_home hi = new Lmanager_home();
            this.Hide();
            hi.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Kitchen_items ki = new Kitchen_items();
            this.Hide();
            ki.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Order_stock os = new Order_stock();
            this.Hide();
            os.Show();
        }

        private void addrelease_Click(object sender, EventArgs e)
        {
            //insert release item details to releaseitem datatable
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Con.Open();
                Cmd = new MySqlCommand("insert into release_item(releaseitem_id,release_id,item_id,item_qunty) values(0, @RELEASEID, @ITEMID, @ITEMQUNTY) ", Con);
                Cmd.Parameters.AddWithValue("@RELEASEID", releaseID.Text);
                Cmd.Parameters.AddWithValue("@ITEMID", dataGridView2.Rows[i].Cells[0].Value);
                Cmd.Parameters.AddWithValue("@ITEMQUNTY", dataGridView2.Rows[i].Cells[1].Value);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }

            //textfiled validation
            if (section.Text == "" || releasedate.Text == "" || carrierid.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = carrierid;
            }

            else
            {
                //carrier ID validation
                MySqlDataAdapter Mda = new MySqlDataAdapter("SELECT * FROM add_employee WHERE Employee_ID = '" + carrierid.Text + "'", Con);
                Mda.Fill(Dt);

                if (Dt.Rows.Count >= 1)
                {
                    //Insert data to database 
                    DialogResult dialogResult = MessageBox.Show("Do You Sure want to Add Data to Database ?", "info", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Con.Open();
                        Cmd = new MySqlCommand("insert into release_stock values('" + releaseID.Text +"','" + section.Text + "','" + releasedate.Text + "','" + carrierid.Text + "') ", Con);
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
                    MessageBox.Show("Entered Carrier ID does not Exist!", "Error!");
                    carrierid.Clear();
                    this.ActiveControl = carrierid;
                }
            }            
        }

        private void deleterelease_Click(object sender, EventArgs e)
        {
            //delete release details from databse
            DialogResult dialogResult = MessageBox.Show("Do You Sure want to Delete ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow dv = dataGridView1.Rows[i];
                    if (dv.Selected == true)
                    {
                        Con.Open();
                        //delete release item details from orderitem datatable      
                        String sqlQuery1 = "DELETE FROM release_item WHERE release_id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                        MySqlCommand sqlCmd = new MySqlCommand(sqlQuery1, Con);
                        sqlCmd.ExecuteNonQuery();
                        Con.Close();

                        Con.Open();
                        String sqlQuery = "Delete from release_stock where release_id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                        MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, Con);
                        sqlcmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(i);
                        MessageBox.Show("Delete Selected item Details Sucessfully!");
                        Con.Close();
                        display();

                        clearFeilds();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }

                  
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                if (section.Text == "Kitchen Items")
                {
                    Con.Open();
                    string selectQuary = "Select * from kitchen_items where item_id = '" + itemid.Text + "' ";
                    Cmd = new MySqlCommand(selectQuary, Con);
                    Mdr = Cmd.ExecuteReader();

                    if (Mdr.Read())
                    {
                        Con.Close();
                        if (itemid.Text == "" || quanty.Text == "")
                        {
                            MessageBox.Show("Please Fill All Textboxes!");
                            display();
                        }
                        else
                        {
                            Con.Open();
                            Cmd = new MySqlCommand("Select * from kitchen_items where item_id = '" + itemid.Text + "' ", Con);
                            Mdr = Cmd.ExecuteReader();
                            if (Mdr.Read())
                            {
                                release_quanty = Mdr.GetInt32("item_qunty");
                            }

                            Con.Close();

                            release_quanty -= int.Parse(quanty.Text);

                            if (release_quanty <= 0)
                            {
                                MessageBox.Show("Invalid Input!");
                            }
                            else
                            {
                                Con.Open();
                                Cmd = new MySqlCommand("update kitchen_items set item_qunty = '" + release_quanty + "' where item_Id = '" + itemid.Text + "'", Con);
                                Cmd.ExecuteNonQuery();
                                Con.Close();

                                dt2.Rows.Add(itemid.Text, quanty.Text);
                                this.dataGridView2.DataSource = dt2;
                                itemid.Clear();
                                quanty.Clear();
                            }
                        }
                    }

                }


                else if (section.Text == "Household Items")
                {
                    Con.Open();
                    string selectQuary = "Select * from household_items where item_id = '" + itemid.Text + "' ";
                    Cmd = new MySqlCommand(selectQuary, Con);
                    Mdr = Cmd.ExecuteReader();

                    if (Mdr.Read())
                    {
                        Con.Close();
                        if (itemid.Text == "" || quanty.Text == "")
                        {
                            MessageBox.Show("Please Fill All Textboxes!");
                            display();
                        }
                        else
                        {
                            Con.Open();
                            Cmd = new MySqlCommand("Select * from household_items where item_id = '" + itemid.Text + "' ", Con);
                            Mdr = Cmd.ExecuteReader();
                            if (Mdr.Read())
                            {
                                release_quanty = Mdr.GetInt32("item_qunty");
                            }

                            Con.Close();

                            release_quanty -= int.Parse(quanty.Text);

                            if (release_quanty <= 0)
                            {
                                MessageBox.Show("Invalid Input!");
                            }
                            else
                            {
                                Con.Open();
                                Cmd = new MySqlCommand("update household_items set item_qunty = '" + release_quanty + "' where item_Id = '" + itemid.Text + "'", Con);
                                Cmd.ExecuteNonQuery();
                                Con.Close();

                                dt2.Rows.Add(itemid.Text, quanty.Text);
                                this.dataGridView2.DataSource = dt2;
                                itemid.Clear();
                                quanty.Clear();
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Section.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Input Item Id Does Not Exist.", " Error Message!!!");
            }

        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                //added remove item quantity to related section
                if (section.Text == "Kitchen Items")
                {
                    Con.Open();
                    Cmd = new MySqlCommand("Select * from kitchen_items where item_id = '" + this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "' ", Con);
                    Mdr = Cmd.ExecuteReader();
                    if (Mdr.Read())
                    {
                        release_quanty = Mdr.GetInt32("item_qunty");
                    }

                    Con.Close();

                    release_quanty = release_quanty + int.Parse(this.dataGridView2.SelectedRows[0].Cells[1].Value.ToString());

                    Con.Open();
                    Cmd = new MySqlCommand("update kitchen_items set item_qunty = '" + release_quanty + "' where item_Id = '" + this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'", Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();

                    dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);

                }


                else if (section.Text == "Household Items")
                {
                    Con.Open();
                    Cmd = new MySqlCommand("Select * from household_items where item_id = '" + this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "' ", Con);
                    Mdr = Cmd.ExecuteReader();
                    if (Mdr.Read())
                    {
                        release_quanty = Mdr.GetInt32("item_qunty");
                    }

                    Con.Close();

                    release_quanty = release_quanty + int.Parse(this.dataGridView2.SelectedRows[0].Cells[1].Value.ToString());

                    Con.Open();
                    Cmd = new MySqlCommand("update household_items set item_qunty = '" + release_quanty + "' where item_Id = '" + this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'", Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();

                    dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Please Select Section.");

                }
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                itemid.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                quanty.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void Release_stock_Load(object sender, EventArgs e)
        {
            {
                //auto genarate primary-key
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT (MAX(release_id)+1) AS mid FROM release_stock", Con);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                releaseID.Text = dt.Rows[0][0].ToString();
                this.ActiveControl = section;

                display();

            }

            dt2.Columns.AddRange(new DataColumn[2]{
                new DataColumn("Item ID", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
            });
        }

        private void quanty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void clearrelease_Click(object sender, EventArgs e)
        {
            //clear button
            clearFeilds();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //select releaseitem datatable for related order id
            Con.Open();

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT item_id,item_qunty  FROM  hotel_saketha.release_item WHERE release_id=" + int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Con);
            DataTable dt1 = new DataTable();
            sqlAdapter.Fill(dt1);
            dataGridView2.DataSource = dt1;
            Con.Close();

            if (dataGridView1.Rows.Count > 0)
            {
                releaseID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                section.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                releasedate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                carrierid.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
        }
   

        private void updaterelease_Click(object sender, EventArgs e)
        {
            //textfiled validation
            if (section.Text == "" || releasedate.Text == "" || carrierid.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = carrierid;
            }

            else
            {
                //carrier ID validation
                MySqlDataAdapter Mda = new MySqlDataAdapter("SELECT * FROM add_employee WHERE Employee_ID = '" + carrierid.Text + "'", Con);
                Mda.Fill(Dt);

                if (Dt.Rows.Count >= 1)
                {
                    //update release details from database 
                    DialogResult dialogResult = MessageBox.Show("Do You Sure want to Add Data to Database ?", "info", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Con.Open();
                        Cmd = new MySqlCommand("update release_stock set section = '" + section.Text + "' , release_date = '" + releasedate.Text + "' , carrier_id = '" + carrierid.Text + "'", Con);
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
                    MessageBox.Show("Entered Carrier ID does not Exist!", "Error!");
                    carrierid.Clear();
                    this.ActiveControl = carrierid;
                }
            }            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Sure want to Print ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<Class2> c2 = new List<Class2>();
                c2.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    c2.Add(new Class2
                    {
                        release_id = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        section = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        release_date = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        carrier_id = dataGridView1.Rows[i].Cells[3].Value.ToString(),



                    });
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    c2.Add(new Class2
                    {
                        item_id = dataGridView2.Rows[i].Cells[0].Value.ToString(),
                        item_qunty = dataGridView2.Rows[i].Cells[1].Value.ToString(),
                    });
                }

                rs.Name = "DataSet1";
                rs.Value = c2;
                release_invoice rp = new release_invoice();

                rp.reportViewer2.LocalReport.DataSources.Clear();
                rp.reportViewer2.LocalReport.DataSources.Add(rs);
                rp.reportViewer2.LocalReport.ReportEmbeddedResource = "Saketha_Hotel_System_Try_1.Logistic_Manager.Report2.rdlc";



                rp.Show();

                MessageBox.Show("Succefully pdf created!");
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void searchrelease_Click(object sender, EventArgs e)
        {
            //serch item details using release ID
            Con.Open();

            String selectQuery = "SELECT *  FROM  hotel_saketha.release_stock WHERE release_id=" + int.Parse(release_id.Text);
            Cmd = new MySqlCommand(selectQuery, Con);

            Mdr = Cmd.ExecuteReader();

            if (Mdr.Read())
            {
                releaseID.Text = Mdr.GetString("release_id");
                section.Text = Mdr.GetString("section");
                releasedate.Text = Mdr.GetString("release_date");
                carrierid.Text = Mdr.GetString("carrier_id");
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }

            Con.Close();

            //select releaseitem datatable for searched release id
            Con.Open();

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT item_id,item_qunty  FROM  hotel_saketha.release_item WHERE release_id=" + int.Parse(release_id.Text), Con);
            DataTable dt1 = new DataTable();
            sqlAdapter.Fill(dt1);
            dataGridView2.DataSource = dt1;
            Con.Close();
        }

        private void print_releaseid_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            string selectQuary = "Select * from release_stock where release_id = '" + print_releaseid.Text + "' ";
            Cmd = new MySqlCommand(selectQuary, Con);
            Mdr = Cmd.ExecuteReader();
            if (Mdr.Read())
            {
                Con.Close();
                if (print_releaseid.Text == null)
                {
                    MessageBox.Show("Please Enter Release ID!");
                    display();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from release_stock where release_id = '" + print_releaseid.Text + "' ", Con);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MySqlDataAdapter sqlAdapter1 = new MySqlDataAdapter("SELECT item_id,item_qunty  FROM  hotel_saketha.release_item WHERE release_id = '" + print_releaseid.Text + "' ", Con);
                    DataTable dt1 = new DataTable();
                    sqlAdapter1.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }
            }
            else
            {
                Con.Close();
                display();
            }
            Con.Close();
        }
    }
}
