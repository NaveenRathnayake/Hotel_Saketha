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
    public partial class Order_stock : Form
    {
        //connetion with database
        MySqlConnection Con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel_saketha");
        MySqlCommand Cmd;
        MySqlDataReader Mdr;
        DataTable Dt = new DataTable();
        


        private String totalprice;

        private String order_quanty;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        ReportDataSource rs = new ReportDataSource();


        public Order_stock()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from order_stock", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }


            //method for clear the text feilds
            public void clearFeilds()
        {
            supid.Clear();
            orderdate.Value = DateTime.Now;
            section.SelectedIndex = -1;
            itemid.Clear();
            quanty.Clear();
            itemprice.Clear();
            totalorder.Clear();
            order_id.Clear();
            print_orderid.Clear();
            dataGridView2.DataSource = null;
            Con.Close();
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT (MAX(order_id)+1) AS mid FROM order_stock", Con);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            orderid.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = supid;
            display();
        }


        private void homebtn_Click(object sender, EventArgs e)
        {
            Lmanager_home hi = new Lmanager_home();
            this.Hide();
            hi.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
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

        private void foodname_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void Order_stock_Load(object sender, EventArgs e)
        {
            {
                //auto genarate primary-key
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT (MAX(order_id)+1) AS mid FROM order_stock", Con);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                orderid.Text = dt.Rows[0][0].ToString();
                this.ActiveControl = supid;

                display();

            }

            dt2.Columns.AddRange(new DataColumn[4]{
                new DataColumn("Item ID", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
                new DataColumn("Iteam Price", typeof(double)),
                new DataColumn("Total Price", typeof(double)),
            });
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Kitchen_items ki = new Kitchen_items();
            this.Hide();
            ki.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void additem_Click(object sender, EventArgs e)
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
                        if (itemid.Text == "" || quanty.Text == "" || itemprice.Text == "")
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
                                order_quanty = Mdr.GetInt32("item_qunty").ToString();
                            }

                            Con.Close();

                            order_quanty = Convert.ToString(double.Parse(order_quanty) + double.Parse(quanty.Text));

                            Con.Open();
                            Cmd = new MySqlCommand("update kitchen_items set order_id = '" + orderid.Text + "' , sup_id = '" + supid.Text + "' , item_price = '" + itemprice.Text + "' , item_qunty = '" + order_quanty + "' where item_Id = '" + itemid.Text + "'", Con);
                            Cmd.ExecuteNonQuery();
                            Con.Close();

                            totalprice = Convert.ToString(double.Parse(quanty.Text) * double.Parse(itemprice.Text));

                            dt2.Rows.Add(itemid.Text, quanty.Text, itemprice.Text, totalprice);
                            this.dataGridView2.DataSource = dt2;
                            itemid.Clear();
                            quanty.Clear();
                            itemprice.Clear();                            
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
                        if (itemid.Text == "" || quanty.Text == "" || itemprice.Text == "")
                        {
                            MessageBox.Show("Please Fill All Textboxes.");
                            display();
                        }
                        else
                        {
                            Con.Open();
                            Cmd = new MySqlCommand("Select * from household_items where item_id = '" + itemid.Text + "' ", Con);
                            Mdr = Cmd.ExecuteReader();
                            if (Mdr.Read())
                            {
                                order_quanty = Mdr.GetInt32("item_qunty").ToString();
                            }

                            Con.Close();

                            order_quanty = Convert.ToString(double.Parse(order_quanty) + double.Parse(quanty.Text));

                            Con.Open();
                            Cmd = new MySqlCommand("update household_items set order_id = '" + orderid.Text + "' , sup_id = '" + supid.Text + "' , item_price = '" + itemprice.Text + "' , item_qunty = '" + order_quanty + "' where item_Id = '" + itemid.Text + "'", Con);
                            Cmd.ExecuteNonQuery();
                            Con.Close();

                            totalprice = Convert.ToString(double.Parse(quanty.Text) * double.Parse(itemprice.Text));

                            dt2.Rows.Add(itemid.Text, quanty.Text, itemprice.Text, totalprice);
                            this.dataGridView2.DataSource = dt2;
                            itemid.Clear();
                            quanty.Clear();
                            itemprice.Clear();
                            
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



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Release_stock rs = new Release_stock();
            this.Hide();
            rs.Show();
        }

        private void removeitem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                    //remove added item quantity from related section
                    if (section.Text == "Kitchen Items")
                    {
                        Con.Open();
                        Cmd = new MySqlCommand("Select * from kitchen_items where item_id = '" + this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "' ", Con);
                        Mdr = Cmd.ExecuteReader();
                        if (Mdr.Read())
                        {
                           order_quanty = Mdr.GetInt32("item_qunty").ToString();
                        }

                        Con.Close();

                        order_quanty = Convert.ToString(double.Parse(order_quanty) - double.Parse(this.dataGridView2.SelectedRows[0].Cells[1].Value.ToString()));

                        Con.Open();
                        Cmd = new MySqlCommand("update kitchen_items set item_qunty = '" + order_quanty + "' where item_Id = '" + this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'", Con);
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
                            order_quanty = Mdr.GetInt32("item_qunty").ToString();
                        }

                        Con.Close();

                        order_quanty = Convert.ToString(double.Parse(order_quanty) - double.Parse(this.dataGridView2.SelectedRows[0].Cells[1].Value.ToString()));

                        Con.Open();
                        Cmd = new MySqlCommand("update household_items set item_qunty = '" + order_quanty + "' where item_Id = '" + this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'", Con);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                itemid.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                quanty.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                itemprice.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                totalprice =  dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clear button
            clearFeilds();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
               


        }

        private void calculate_Click(object sender, EventArgs e)
        {
            totalorder.Text = "0";
            dataGridView2.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                totalorder.Text =  Convert.ToString(double.Parse(totalorder.Text) + double.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()));
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addorder_Click(object sender, EventArgs e)
        {

            //insert order item details to orderitem datatable
            
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Con.Open();
                Cmd = new MySqlCommand("insert into order_item(orderitem_id,order_id,item_id,item_qunty,item_price,total_price) values(0, @ORDERID, @ITEMID, @ITEMQUNTY, @ITEMPRICE, @TOTALPRICE) ", Con);
                Cmd.Parameters.AddWithValue("@ORDERID", orderid.Text);
                Cmd.Parameters.AddWithValue("@ITEMID", dataGridView2.Rows[i].Cells[0].Value);
                Cmd.Parameters.AddWithValue("@ITEMQUNTY", dataGridView2.Rows[i].Cells[1].Value);
                Cmd.Parameters.AddWithValue("@ITEMPRICE", dataGridView2.Rows[i].Cells[2].Value);
                Cmd.Parameters.AddWithValue("@TOTALPRICE", dataGridView2.Rows[i].Cells[3].Value);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }

            //textfiled validation
            if (orderdate.Text == "" || supid.Text == "" || section.Text == "" || totalorder.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = supid;
            }

            else
            {
                //supplier ID validation
                MySqlDataAdapter Mda = new MySqlDataAdapter("SELECT * FROM sup_details WHERE sup_id = '" + supid.Text + "'", Con);
                Mda.Fill(Dt);

                if (Dt.Rows.Count >= 1)
                {
                    //Insert data to database 
                    DialogResult dialogResult = MessageBox.Show("Do You Sure want to Add Data to Database ?", "info", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Con.Open();
                        Cmd = new MySqlCommand("insert into order_stock values('" + orderid.Text + "','" + supid.Text + "','" + orderdate.Text + "','" + section.Text + "','" + totalorder.Text + "') ", Con);
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
                    MessageBox.Show("Entered Supplier ID does not Exist!", "Error!");
                    supid.Clear();
                    this.ActiveControl = supid;
                }
            }
        }

        private void updateorder_Click(object sender, EventArgs e)
        {
            //textfiled validation
            if (orderdate.Text == "" || supid.Text == "" || section.Text == "" || totalorder.Text == "")
            {
                MessageBox.Show("Please Fill All Text Filed");
                this.ActiveControl = supid;
            }

            else
            {
                //supplier ID validation
                MySqlDataAdapter Mda = new MySqlDataAdapter("SELECT * FROM sup_details WHERE sup_id = '" + supid.Text + "'", Con);
                Mda.Fill(Dt);

                if (Dt.Rows.Count >= 1)
                {
                    //update item details from database
                    DialogResult dialogResult = MessageBox.Show("Do You Sure want to Update Database ?", "info", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {                       
                        Con.Open();
                        Cmd = new MySqlCommand("update order_stock set order_date = '" + orderdate.Text + "' ,  sup_id = '" + supid.Text + "' , section = '" + section.Text + "' , total_order = '" + totalorder.Text + "'where order_id = '" + orderid.Text + "'", Con);
                        Cmd.ExecuteNonQuery();
                        MessageBox.Show(" Order Details Updated!");
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
                    MessageBox.Show("Entered Supplier ID does not Exist!", "Error!");
                    supid.Clear();
                    this.ActiveControl = supid;
                }
            }          
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //select orderitem datatable for related order id
            Con.Open();

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT item_id,item_qunty,item_price,total_price  FROM  hotel_saketha.order_item WHERE order_id=" + int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), Con);
            DataTable dt1 = new DataTable();
            sqlAdapter.Fill(dt1);
            dataGridView2.DataSource = dt1;
            Con.Close();

            if (dataGridView1.Rows.Count > 0)
            {
                orderid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                supid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                orderdate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                section.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                totalorder.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
               
            }
        }

        private void deleteorder_Click(object sender, EventArgs e)
        {
            //delete Order details from databse
            DialogResult dialogResult = MessageBox.Show("Do You Sure want to Delete ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow dv = dataGridView1.Rows[i];
                    if (dv.Selected == true)
                    {
                        Con.Open();
                        //delete order item details to orderitem datatable                          
                        String sqlQuery1 = "DELETE FROM order_item WHERE order_id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                        MySqlCommand sqlCmd = new MySqlCommand(sqlQuery1, Con);
                        sqlCmd.ExecuteNonQuery();                       
                        Con.Close();

                        Con.Open();
                        String sqlQuery = "Delete from order_stock where order_id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                        MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, Con);
                        sqlcmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(i);
                        MessageBox.Show("Delete Selected item Details Sucessfully!");
                        Con.Close();
                        
                        display();
                        clearFeilds();
                        clearFeilds();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }            
        }

        private void searchorder_Click(object sender, EventArgs e)
        {
            //serch item details using order ID
            Con.Open();

            String selectQuery = "SELECT *  FROM  hotel_saketha.order_stock WHERE order_id=" + int.Parse(order_id.Text);
            Cmd = new MySqlCommand(selectQuery, Con);

            Mdr = Cmd.ExecuteReader();

            if (Mdr.Read())
            {
                orderid.Text = Mdr.GetString("order_id");
                supid.Text = Mdr.GetString("sup_id");
                orderdate.Text = Mdr.GetString("order_date");
                section.Text = Mdr.GetString("section");
                totalorder.Text = Mdr.GetString("total_order");                
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }

            Con.Close();

            //select orderitem datatable for searched order id
            Con.Open();

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("SELECT item_id,item_qunty,item_price,total_price  FROM  hotel_saketha.order_item WHERE order_id=" + int.Parse(order_id.Text), Con);
            DataTable dt1 = new DataTable();
            sqlAdapter.Fill(dt1);
            dataGridView2.DataSource = dt1;
            Con.Close();

        }

        private void print_Click(object sender, EventArgs e)
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
                        order_id = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        sup_id = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        section = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        total_order = dataGridView1.Rows[i].Cells[4].Value.ToString(),                        



                    });
                }
                for (int i = 0; i < dataGridView2.Rows.Count ; i++)
                {
                    c1.Add(new Class1
                    {
                        item_id = dataGridView2.Rows[i].Cells[0].Value.ToString(),
                        item_qunty = dataGridView2.Rows[i].Cells[1].Value.ToString(),
                        item_price = dataGridView2.Rows[i].Cells[2].Value.ToString(),
                        total_price = dataGridView2.Rows[i].Cells[3].Value.ToString(),
                    });
                }

                rs.Name = "DataSet1";
                rs.Value = c1;
                order_invoice rp = new order_invoice();

                rp.reportViewer1.LocalReport.DataSources.Clear();
                rp.reportViewer1.LocalReport.DataSources.Add(rs);
                rp.reportViewer1.LocalReport.ReportEmbeddedResource = "Saketha_Hotel_System_Try_1.Logistic_Manager.Report1.rdlc";



                rp.Show();

                MessageBox.Show("Succefully pdf created!");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }
        

        private void itemprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void print_orderid_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void print_orderid_TextChanged(object sender, EventArgs e)
        {
            Con.Open();
            string selectQuary = "Select * from order_stock where order_id = '" + print_orderid.Text + "' ";
            Cmd = new MySqlCommand(selectQuary, Con);
            Mdr = Cmd.ExecuteReader();
            if (Mdr.Read())
            {
                Con.Close();
                if (print_orderid.Text == null)
                {
                    MessageBox.Show("Please Enter Order ID.");
                    display();
                }
                else
                {
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from order_stock where order_id = '" + print_orderid.Text + "' ", Con);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MySqlDataAdapter sqlAdapter1 = new MySqlDataAdapter("SELECT item_id,item_qunty,item_price,total_price  FROM  hotel_saketha.order_item WHERE order_id = '" + print_orderid.Text + "' ", Con);
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

        private void print_orderid_Enter(object sender, EventArgs e)
        {

        }
    }
}
