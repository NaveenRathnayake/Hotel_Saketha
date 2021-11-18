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
    public partial class Event_Booking : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempid;

        public Event_Booking()
        {
            InitializeComponent();
            display();
            panel3.Hide();
            fillMenu();
        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from event_booking", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            cusIDtext.Clear();
            paticipationstext.Clear();
            halltext.ResetText();
            menutext.ResetText();
            eventtext.Refresh();
            othertext.ResetText();
            pricetext.Clear();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Reception_Home rh1 = new Reception_Home();
            this.Hide();
            rh1.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void Event_Booking_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {
         // string date =  eventtext.Value.Date.ToString();
           //date.ToString();


            if (validateEvent())
            {
                string date = eventtext.Value.ToString("yyyy-MM-dd");
                DateTime today = DateTime.Today;
                conn.Open();
                cmd = new MySqlCommand("insert into event_booking values ('' , '" + cusIDtext.Text + "' ,'" + paticipationstext.Text + "' , '" + halltext.Text + "','" + menutext.Text + "', '" + date + "', '" + othertext.Text + "', '" + pricetext.Text + "','" + today.ToShortDateString() + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" event Booking details Saved... ");
                conn.Close();
                display();
                clearFeilds();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void updatefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update event_booking set customer_ID = '" + cusIDtext.Text + "' ,no_Participations = '" + paticipationstext.Text + "' , hall_Number = '" + halltext.Text + "', menu = '" + menutext.Text + "' , event_Date = '" + eventtext.Text + "', other_Services = '" + othertext.Text + "', price = '" + pricetext.Text + "' where sales_ID = '" + tempid + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Event Booking details Updated... ");
            conn.Close();
            display();
            clearFeilds();

        }

        private void deletefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView1.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from event_booking where sales_ID = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
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
                string selectQuary = "Select * from event_booking where sales_ID = " + int.Parse(search.Text);
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    cusIDtext.Text = mdr.GetInt32("customer_ID").ToString();
                    paticipationstext.Text = mdr.GetInt32("no_Participations").ToString();
                    halltext.Text = mdr.GetInt32("hall_Number").ToString();
                    menutext.Text = mdr.GetString("menu");
                    eventtext.Text = mdr.GetString("event_date");
                    othertext.Text = mdr.GetString("other_Services");
                    pricetext.Text = mdr.GetString("price");
                }
                else
                {
                    MessageBox.Show("Search Valid sales ID...");
                    clearFeilds();
                }
            }

            conn.Close();
        }
        //Method to calculate the total amount to pay for a particular event based on menu type ans  no of plates
        public void calculateEventTotal(string menutype)
        {
            

            string plates_count = paticipationstext.Text;
            float total_price = 0;
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from menu", conn); //this should be fixed
            
            DataTable dt_menu_price = new DataTable();
            sqlAdapter.Fill(dt_menu_price);
            foreach (DataRow row in dt_menu_price.Rows)
            {
                total_price = float.Parse(row["price"].ToString());

                if (!string.IsNullOrEmpty(plates_count))
                {
                    float total = total_price * Int32.Parse(plates_count);

                    pricetext.Text = total.ToString();    
                }

            }

        }





        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                cusIDtext.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                paticipationstext.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                halltext.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                menutext.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                eventtext.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                othertext.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pricetext.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();               
            }
        }

        public Boolean validateEvent()
        {
            Boolean flag = true;
            string ErrorMessage = "";

            if(string.IsNullOrEmpty(cusIDtext.Text) || string.IsNullOrEmpty(paticipationstext.Text) || string.IsNullOrEmpty(cusIDtext.Text) || string.IsNullOrEmpty(pricetext.Text))
            {
                ErrorMessage = ErrorMessage + "All the fields are required";
                flag = false;
            }
            else
            {
                if (!cusIDtext.Text.All(Char.IsDigit))
                {
                    ErrorMessage = ErrorMessage + "\n Customer Id should Containms only Digits";
                    flag = false;
                }

                if (!paticipationstext.Text.All(Char.IsDigit))
                {
                    ErrorMessage = ErrorMessage + "\n No of Participants should be an integer";
                    flag = false;
                }

                if (!pricetext.Text.All(Char.IsDigit))
                {
                    ErrorMessage = ErrorMessage + "\n Price cannot contains Chars";
                    flag = false;
                }
            }

            if (!flag)
            {
                MessageBox.Show(ErrorMessage);
            } 

            return flag;
        }

        //when the menu type value changes 
        private void menutext_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(menutext.Text))
            {
                calculateEventTotal(menutext.Text);
            }
          
        }

        //method to auto fill the event menus drop down list
        public void fillMenu()
        {
            List<String> list = new List<string>();
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select name from menu", conn);
            DataTable dt_menus = new DataTable();
            sqlAdapter.Fill(dt_menus);

            for (int i = 0; i < dt_menus.Rows.Count; i++)
            {
                list.Add(dt_menus.Rows[i]["name"].ToString());
            }
            menutext.DataSource = list;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();

            }



            clearFeilds();
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
            start = 190;
            graphics.DrawString("Hotel Saketha - Event Booking Receipt", new Font("Times New Roman", 20), new SolidBrush(Color.Black), start, starty);
            string top = "Date :" + DateTime.Today.ToString("yyyy-MM-dd");
            start = 190;
            graphics.DrawString(top, font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + (int)FontHeight;
            offset = offset + 50;
            graphics.DrawString("Hall Number: " + halltext.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("----------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 40;
            graphics.DrawString("Customer ID : " + cusIDtext.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Number of Participants : " + paticipationstext.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Menu : " + menutext.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Event Date : " + eventtext.Value.ToString("dd/MM/yyyy") , font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Other Services : " + othertext.Text , font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Price(Rs) : " + pricetext.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;



            offset = offset + (int)FontHeight + 5;
            graphics.DrawString("----------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 35;
            start = 180;
            graphics.DrawString("Thank You for Visit Hotel Saketha...!", font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + 20;





            MessageBox.Show("Receipt Printed Successfully...");
        }

        /// <summary>
        /// ///////////****************************************
        /// </summary>
        /// 

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        public void display1()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_customer where phone = '" + phonetxt.Text + "'", conn);
            DataTable dt = new DataTable();

            sqlAdapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        public void clearFeilds1()
        {
            nametxt.Clear();
            addresstxt.Clear();
            nictxt.Clear();
            phonetxt.Clear();
            emailtxt.Clear();
            search.Clear();
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
            if (!emailtxt.Text.Contains('@'))
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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {


            conn.Open();
            string selectQuary = "Select * from add_customer where phone = '" + serach.Text + "'";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                cusIDtext.Text = mdr.GetInt32("customer_Id").ToString();
                conn.Close();
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_customer where phone = '" + serach.Text + "'", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            else
            {
                conn.Close();
                MessageBox.Show("This Number Has no Records");
                phonetxt.Text = serach.Text;
            }
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            clearFeilds1();
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
                conn.Open();
                string selectQuary = "Select * from add_customer where phone = '" + phonetxt.Text + "'";
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    cusIDtext.Text = mdr.GetInt32("customer_Id").ToString();

                }
                conn.Close();

                display1();
                clearFeilds1();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update add_customer set name = '" + nametxt.Text + "' ,address = '" + addresstxt.Text + "' , NIC = '" + nictxt.Text + "', phone = '" + phonetxt.Text + "' , email = '" + emailtxt.Text + "' where customer_ID = '" + tempid + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Customer details Updated... ");
            conn.Close();
            display1();
            clearFeilds1();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView2.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from add_customer where customer_ID = '" + dataGridView2.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dataGridView2.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                }
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                nametxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                addresstxt.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                nictxt.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                phonetxt.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                emailtxt.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }
    }
}
