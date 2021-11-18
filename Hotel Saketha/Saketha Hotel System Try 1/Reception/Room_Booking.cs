using DGVPrinterHelper;
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
    public partial class Room_Booking : Form
    {
        
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;


        private int tempid;

        public Room_Booking()
        {
            InitializeComponent();
            display();
            panel1.Hide();
            fillRoomNumber();
        }
        

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select sales_ID ,customer_ID,users_Count,room_Number,room_Type,number_Of_Hours,price from room_booking", conn);
            DataTable dt = new DataTable();
          
            sqlAdapter.Fill(dt);
            dgvRoomBooking.DataSource = dt;

        }

        public void generateRoomBill()
        {

            DataTable dtbill = new DataTable();
            dtbill.Columns.Add(new DataColumn("Room_Booking", typeof(string)));
            dtbill.Columns.Add(new DataColumn("Bill", typeof(string)));

            int customerid = Int32.Parse(textCustomerID.Text);
            int userCount = Int32.Parse(textUserCount.Text);
            string roomTYPE = textRoomType.Text;
            float price = float.Parse(textPrice.Text);

            DataRow dr = dtbill.NewRow();
            dr[0] = "Customer ";
            dr[1] = "Yasini ";
            dtbill.Rows.Add(dr);

            DataRow dr1 = dtbill.NewRow();
            dr1[0] = " User Counts ";
            dr1[1] = userCount;
            dtbill.Rows.Add(dr1);

            DataRow dr2 = dtbill.NewRow();
            dr2[0] = "Room Type ";
            dr2[1] = roomTYPE;
            dtbill.Rows.Add(dr2);

            DataRow dr3= dtbill.NewRow();
            dr3[0] = "Total  ";
            dr3[1] = price;
            dtbill.Rows.Add(dr3);
            dgvroomBill.DataSource = dtbill;

            //generate bill
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Room Bill "; //header
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Hotel Saketha"; //footer
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dgvroomBill);


        }
        //method to auto fill the room numbers drop down list
        public void fillRoomNumber()
        {
            List<String> list = new List<string>();
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select room_Num from room", conn);
            DataTable dt_rooms = new DataTable();
            sqlAdapter.Fill(dt_rooms);

            for (int i = 0; i < dt_rooms.Rows.Count; i++)
            {
                list.Add(dt_rooms.Rows[i]["room_Num"].ToString());
            }
            textRoomNumber.DataSource = list; 

        }

        public void fill_room_type(string room_number)
        {
            string type;
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select room_Type from room where room_Num="+Int32.Parse(room_number), conn);
            DataTable dt_roomtype = new DataTable();
            sqlAdapter.Fill(dt_roomtype);
            foreach(DataRow row in dt_roomtype.Rows)
            {
                type = row["room_Type"].ToString();
                textRoomType.Text = type;
            }
           
        }

        public void calc_total_price(string number_of_hours)
        {
            int current_room = Int32.Parse(textRoomNumber.Text);
            float price = 0;
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select price_per_hour from room where room_Num=" + current_room, conn);
            DataTable dt_roomtype = new DataTable();
            sqlAdapter.Fill(dt_roomtype);
            foreach (DataRow row in dt_roomtype.Rows)
            {
                price = float.Parse(row["price_per_hour"].ToString());

                if (!string.IsNullOrEmpty(number_of_hours))
                {
                    float total = price * Int32.Parse(number_of_hours);
                    String pricetext = "Price Per hour :-" + price + "\n Number of Hours = " + number_of_hours + "\n Amount to Pay = " + price + " X " + number_of_hours;
                    textPrice.Text = total.ToString();
                    lblPrice.Text = pricetext;
                }       
               
            }
        }


        //method for clear the text feilds
        public void clearFeilds()
        {
            textCustomerID.Clear();
            textUserCount.Clear();
            textRoomNumber.ResetText();
            textRoomType.ResetText();
            textNumberOfhours.Refresh();
            textPrice.ResetText();
        
        }
        //Form Load Event
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void Room_Booking_Load(object sender, EventArgs e)
        {

          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //call method
            calc_total_price(textNumberOfhours.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
      
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Reception_Home rh = new Reception_Home();
            this.Hide();
            rh.Show();
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            if (validateRoomBooking())
            {
               DateTime today = DateTime.Today;
               // MessageBox.Show(today.ToShortDateString());
                    conn.Open();
                    cmd = new MySqlCommand("insert into room_booking values ('' , '" + textCustomerID.Text + "' ,'" + textUserCount.Text + "' , '" + textUserCount.Text + "' , '" + textRoomType.Text + "' ,'" + textNumberOfhours.Text + "' , '" + textPrice.Text + "','" + today.ToShortDateString()+ "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" room booking details Saved... ");
                    conn.Close();
                display();
                    
                
            }

            

        }

        //validation
        public Boolean validateRoomBooking()
        {
            Boolean flag = true;
            string error_message = "";

            if (string.IsNullOrEmpty(textCustomerID.Text) || string.IsNullOrEmpty(textUserCount.Text) || string.IsNullOrEmpty(textNumberOfhours.Text) || string.IsNullOrEmpty(textRoomNumber.Text) || string.IsNullOrEmpty(textPrice.Text))
            {
                error_message = error_message + "\n All the Fields are Required";
                flag = false;
                MessageBox.Show(error_message);
            }
            else
            {

            }

         
            return flag;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            clearFeilds();
        }

        private void deletefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dgvRoomBooking.Rows.Count; i++)
            {
                DataGridViewRow dv = dgvRoomBooking.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from room_booking where sales_ID = '" + dgvRoomBooking.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dgvRoomBooking.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    display();
                }

            }
        }

        private void dgvRoomBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRoomBooking_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvRoomBooking.Rows.Count > 0)
            {
                tempid = int.Parse(dgvRoomBooking.SelectedRows[0].Cells[0].Value.ToString());
                textCustomerID.Text = dgvRoomBooking.SelectedRows[0].Cells[1].Value.ToString();
                textUserCount.Text = dgvRoomBooking.SelectedRows[0].Cells[2].Value.ToString();
                textRoomNumber.Text = dgvRoomBooking.SelectedRows[0].Cells[3].Value.ToString();
                textRoomType.Text = dgvRoomBooking.SelectedRows[0].Cells[4].Value.ToString();
                textNumberOfhours.Text = dgvRoomBooking.SelectedRows[0].Cells[5].Value.ToString();
                textPrice.Text = dgvRoomBooking.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sales Report"; //header
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Hotel Saketha"; //footer
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dgvRoomBooking);

            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //generateRoomBill();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();

            }



            clearFeilds();
        }

        private void textRoomType_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            fill_room_type(textRoomNumber.Text);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

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
            graphics.DrawString("Hotel Saketha - Room Booking Receipt", new Font("Times New Roman", 20), new SolidBrush(Color.Black), start, starty);
            string top = "Date :" + DateTime.Today.ToString("yyyy-MM-dd");
            start = 190;
            graphics.DrawString(top, font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + (int)FontHeight;
            offset = offset + 50;
            graphics.DrawString("Room Number: " + textRoomNumber.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("----------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 40;
            graphics.DrawString("Customer ID : " + textCustomerID.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("User Counts : " + textUserCount.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Room Type : " + textRoomType.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Number of Hours : " + textNumberOfhours.Text + " Hours", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Price(Rs) : " + textPrice.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
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
        /// ////////////////*************************************************************************************
        /// </summary>
        //method for display data in databse as a table
        public void display1()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_customer where phone = '" + phonetxt.Text + "'", conn);
            DataTable dt = new DataTable();

            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void textCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCustomerID_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void clearbtn_Click(object sender, EventArgs e)
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
                    textCustomerID.Text = mdr.GetInt32("customer_Id").ToString();
                    
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

        //method for clear the text feilds
        public void clearFeilds1()
        {
            nametxt.Clear();
            addresstxt.Clear();
            nictxt.Clear();
            phonetxt.Clear();
            emailtxt.Clear();
            search.Clear();
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
                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            

            conn.Open();
            string selectQuary = "Select * from add_customer where phone = '" + search.Text + "'";
            cmd = new MySqlCommand(selectQuary, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                textCustomerID.Text = mdr.GetInt32("customer_Id").ToString();
                conn.Close();
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_customer where phone = '" + search.Text + "'", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            else
            {
                conn.Close();
                MessageBox.Show("This Number Has no Records");
                phonetxt.Text = search.Text;
            }
            
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            clearFeilds1();
        }
    }
}

