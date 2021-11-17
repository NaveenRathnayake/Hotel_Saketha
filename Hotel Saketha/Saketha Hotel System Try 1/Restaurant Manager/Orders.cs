using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace Saketha_Hotel_System_Try_1.Restaurant_Manager
{

    public partial class Orders : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;
        MySqlDataReader mdr;


        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        ReportDataSource rs = new ReportDataSource();
        ReportDataSource rs2 = new ReportDataSource();

        public Orders()
        {
            InitializeComponent();
            display();

        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food", conn); 
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeildsall()
        {
            foodnametxt.Clear();
            pricetxt.Clear();
            quantitytxt.Clear();
            totaltxt.Clear();
            ordertottxt.Clear();
            paidtxt.Clear();
            balancetxt.Clear();
            cusname.Clear();
            cusphone.Clear();
            orderidtxt.Clear();

        }
        //method for clear the text feilds
        public void clearFeilds()
        {
            foodnametxt.Clear();
            pricetxt.Clear();
            quantitytxt.Clear();
            totaltxt.Clear();
            ordertottxt.Clear();
            paidtxt.Clear();
            balancetxt.Clear();
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

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            this.Hide();
            or.Show();
        }

        private void addticketsbtn_Click(object sender, EventArgs e)
        {
            Order_Reports at = new Order_Reports();
            this.Hide();
            at.Show();
        }

        private void addfoodsbtn_Click(object sender, EventArgs e)
        {
            Add_foods af = new Add_foods();
            this.Hide();
            af.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        //validation 1
        public Boolean validate1()
        {
            Boolean flag = true;
            if (cusname.Text == "")
            {
                MessageBox.Show("Please Enter Name");
                flag = false;
                cusname.Clear();
            }
            if (cusphone.Text.Length != 9)
            {
                MessageBox.Show("Please Enter Valid Phone");
                flag = false;
                cusphone.Clear();
            }
            if (!cusphone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Phone nuber must be numbers");
                flag = false;
                cusphone.Clear();
            }

            return flag;
        }

        //search customer details
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (validate1())
            {
                try
                {
                    conn.Open();
                    string selectQuary = "Select * from add_customer where phone = '" + cusphone.Text + "' ";
                    cmd = new MySqlCommand(selectQuary, conn);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        conn.Close();
                        panel3.Show();
                        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select name, address, NIC, phone, email from add_customer where phone = '" + cusphone.Text + "' ", conn);
                        DataTable dt = new DataTable();
                        sqlAdapter.Fill(dt);
                        dataGridView4.DataSource = dt;

                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("This name has no records please enter details...");
                        panel3.Show();
                        custname.Text = cusname.Text;
                        phone.Text = cusphone.Text;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went Wrong...", "Error...");
                }
            }

        }

        //clear customer search
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Clear ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cusname.Clear();
                cusphone.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        



        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //get customer details to update
        private void dataGridView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView4.Rows.Count > 0)
            {
                custname.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
                address.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                nic.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
                phone.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
                mail.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        //validation 2
        public Boolean validate2()
        {
            Boolean flag = true;
            if (custname.Text == "")
            {
                MessageBox.Show("Please Enter Name");
                flag = false;
                custname.Clear();
            }
            if (address.Text == "")
            {
                MessageBox.Show("Please Enter Address");
                flag = false;
                address.Clear();
            }

            if (nic.Text.EndsWith("V") || nic.Text.EndsWith("v"))
            {
                if (nic.Text.Length != 10)
                {
                    MessageBox.Show(" Old Nic Should have 10 digits");
                    flag = false;
                    nic.Clear();                    
                }
            }
            else if (nic.Text.Length != 12)
            {
                MessageBox.Show("New Nic Should have 12 digits");
                flag = false;
                nic.Clear();
            }

            if (phone.Text.Length != 9)
            {
                MessageBox.Show("Please Enter Valid Phone");
                flag = false;
                phone.Clear();
            }
            if (!phone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Phone nuber must be numbers");
                flag = false;
                phone.Clear();
            }
            if (!mail.Text.Contains('@'))
            {
                MessageBox.Show("Invalid Email address - should contain @");
                flag = false;
                mail.Clear();             

            }

            if (mail.Text.Any(Char.IsUpper))
            {
                MessageBox.Show(" All the letters should be  in lowercase in email");
                flag = false;
                mail.Clear();
            }
            return flag;
        }

        //save customer details
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (validate2())
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into add_customer values ('' , '" + custname.Text + "' ,'" + address.Text + "' , '" + nic.Text + "','" + phone.Text + "','" + mail.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Customer details Saved... ");
                    conn.Close();
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select name, address, NIC, phone, email from add_customer where phone = '" + phone.Text + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView4.DataSource = dt;
                    custname.Clear();
                    address.Clear();
                    nic.Clear();
                    phone.Clear();
                    mail.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went Wrong...", "Error...");
                }
            }


        }

        //update customer details
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (validate2())
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("update add_customer set name = '" + custname.Text + "' ,address = '" + address.Text + "' , NIC = '" + nic.Text + "', phone = '" + phone.Text + "' , email = '" + mail.Text + "' where phone = '" + cusphone.Text + "' ", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Customer details Updated... ");
                    conn.Close();
                    MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select name, address, NIC, phone, email from add_customer where phone = '" + phone.Text + "' ", conn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    dataGridView4.DataSource = dt;
                    custname.Clear();
                    address.Clear();
                    nic.Clear();
                    phone.Clear();
                    mail.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went Wrong...", "Error...");
                }
            }

        }

        //clear customer details adding text feilds  
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            custname.Clear();
            address.Clear();
            nic.Clear();
            phone.Clear();
            mail.Clear();
        }

        //start the order
        private void startorderbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Start ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into orders values ( 0,'" + cusname.Text + "', 0.0, now()) ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Open();
                    string selectQuary = "Select Order_Id from orders where Customer_Name = '" + cusname.Text + "'";
                    cmd = new MySqlCommand(selectQuary, conn);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        orderidtxt.Text = mdr.GetInt32("Order_Id").ToString();
                        dt2.Rows.Add(orderidtxt.Text, cusname.Text);
                        this.dataGridView3.DataSource = dt2;
                    }
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Error... ");
                    clearFeilds();
                }
                panel4.Hide();
                textBox2.Text = cusname.Text;
                textBox1.Text = cusphone.Text;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        

        //close order
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Close ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    String sqlQuery = "Delete from orders where Order_Id = '" + orderidtxt.Text + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    Orders at = new Orders();
                    this.Hide();
                    at.Show();

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

        //add ordered food details
        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Add ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into add_tickets values ('', '" + orderidtxt.Text + "' ,'" + foodnametxt.Text + "','" + pricetxt.Text + "','" + quantitytxt.Text + "','" + totaltxt.Text + "', 'Not Complete', now() )", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dt1.Rows.Add(foodnametxt.Text, pricetxt.Text, quantitytxt.Text, totaltxt.Text);
                    this.dataGridView1.DataSource = dt1;
                    clearFeilds();
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void foodnametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        //add data to gridviews
        private void Orders_Load_1(object sender, EventArgs e)
        {
            panel3.Hide();
            dt2.Columns.AddRange(new DataColumn[]{
                new DataColumn("Order_Id", typeof(string)),
                new DataColumn("Cus_Name", typeof(string)),
            });

            dt1.Columns.AddRange(new DataColumn[4]{
                new DataColumn("Food_Name", typeof(string)),
                new DataColumn("Unit_Price(Rs)", typeof(double)),
                new DataColumn("Quantity", typeof(double)),
                new DataColumn("Total(Rs)", typeof(double)),
            });

            dt3.Columns.AddRange(new DataColumn[5]{
                new DataColumn("Order_Id", typeof(string)),
                new DataColumn("Cus_Name", typeof(string)),
                new DataColumn("Order_Total(Rs)", typeof(double)),
                new DataColumn("Paid(Rs)", typeof(double)),
                new DataColumn("Balance(Rs)", typeof(double)),
            });

            
        }

        private void foodnametxt_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        //condition to add valid food name
        private void foodnametxt_Leave(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("Select * from add_food where Food_Name = '"+ foodnametxt.Text+"' ", conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                pricetxt.Text = mdr.GetInt32("Price").ToString();               
            }
            else
            {
                MessageBox.Show("Type Available Food Name...");
                clearFeilds();
            }
            conn.Close();
        }

        //search by food catagory
        private void search_DropDownClosed(object sender, EventArgs e)
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
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Starters' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Main_Courses")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Main_Courses' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Desserts")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Desserts' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Drinks")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Drinks' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                        else if (search.SelectedItem.ToString() == "Shorts")
                        {
                            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Shorts' ", conn);
                            DataTable dt = new DataTable();
                            sqlAdapter.Fill(dt);
                            dataGridView2.DataSource = dt;
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
        }

        //get food details
        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (dataGridView2.Rows.Count > 0)
            {
                foodnametxt.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                pricetxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            }
        }


        //update food details
        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                foodnametxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pricetxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                quantitytxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow dv = dataGridView1.Rows[i];
                    if (dv.Selected == true)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
           
        }

        private void pricetxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cant Edit...");
        }

        private void totaltxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cant Edit...");
            
        }

        private void balancetxt_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cant Edit...");
        }

        //calculate order total
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                ordertottxt.Text = "0";
                dataGridView1.AllowUserToAddRows = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ordertottxt.Text = Convert.ToString(double.Parse(ordertottxt.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Error... ");
                clearFeilds();
            }
            
           
        }

        private void paidtxt_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void quantitytxt_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                totaltxt.Text = (double.Parse(pricetxt.Text) * double.Parse(quantitytxt.Text)).ToString();
            }
            catch
            {

            }
        }

        private void paidtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                balancetxt.Text = (double.Parse(paidtxt.Text) - double.Parse(ordertottxt.Text)).ToString();

            }
            catch
            {

            }
        }


        //print order invoice
        private void printbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Print ?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //save order details
                    conn.Open();
                    cmd = new MySqlCommand("update orders set Order_Total = '" + ordertottxt.Text + "' where Order_Id = '" + orderidtxt.Text + "' ", conn);
                    cmd.ExecuteNonQuery();
                    dt3.Rows.Add(orderidtxt.Text, cusname.Text, ordertottxt.Text, paidtxt.Text, balancetxt.Text);
                    this.dataGridView3.DataSource = dt3;
                    conn.Close();

                    //start print
                    printDialog1.Document = printDocument1;
                    DialogResult result = printDialog1.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        printDocument1.Print();
                        
                    }
                    

                    clearFeildsall();
                }
                catch (Exception)
                {
                    MessageBox.Show(" Error... ");
                    clearFeildsall();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 14);
            float fontHeight = font.GetHeight();
            int start;
            int startx = 190;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("Welcome to Hotel Saketha Restaurant", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startx, starty);
            string top = "Date :" + DateTime.Today.ToString("yyyy-MM-dd");
            start = 345;
            graphics.DrawString(top, font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + (int)FontHeight;
            offset = offset + 20;
            start = 150;
            graphics.DrawString("Order ID:  " + orderidtxt.Text, font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 20;
            start = 150;
            graphics.DrawString("------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 30;
            start = 150;
            graphics.DrawString("Food Name", font, new SolidBrush(Color.Black), start, starty + offset);
            start = 380; 
            graphics.DrawString("Price", font, new SolidBrush(Color.Black), start, starty + offset);
            start = 480;
            graphics.DrawString("Quantity", font, new SolidBrush(Color.Black), start, starty + offset);
            start = 620;
            graphics.DrawString("Total", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 30;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                start = 150;
                graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Times New Roman", 12), new SolidBrush(Color.Black), start, starty +offset);
                start = 380;
                graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Times New Roman", 12), new SolidBrush(Color.Black), start, starty + offset);
                start = 510;
                graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Times New Roman", 12), new SolidBrush(Color.Black), start, starty + offset);
                start = 620;
                graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Times New Roman", 12), new SolidBrush(Color.Black), start, starty + offset);
                offset = offset + 20;
            }
            start = 150;
            offset = offset + (int)FontHeight+5;
            graphics.DrawString("------------------------------------", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 15;

            offset = offset + (int)FontHeight + 5;
            graphics.DrawString("Order Total (Rs) :  "+ordertottxt.Text+".00", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 25;
            graphics.DrawString("Paid (Rs) :  " + paidtxt.Text + ".00", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 25;
            graphics.DrawString("Balance (Rs) :  " + balancetxt.Text + ".00", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 25;

            graphics.DrawString("------------------------------------", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 35;
            start = 320;
            graphics.DrawString("Thank You For Visit....!", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 20;

            MessageBox.Show("Order Receipt Printed Successfully...");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void orderidtxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cant Edit...");
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
                      
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }

}
