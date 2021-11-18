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
using DGVPrinterHelper;

namespace Saketha_Hotel_System_Try_1.Reception
{
    public partial class Package_Booking : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int packageprice;

        public Package_Booking()
        {
            InitializeComponent();
            display();
            display1();
        }

        //method for display data in databse as a table
        public void display1()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from package_details ", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from package_booking ", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            textCustomerID.Clear();
            txtpackage.Refresh();
            textPrice.Clear();           
            search.Clear();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime today = DateTime.Today;
            //  cmd = new MySqlCommand("insert into package_booking values ('' , '" + textCustomerID.Text + "' ,'" + textPackageType.Text + "' , '" + textPrice.Text + " ' " , conn);
            cmd = new MySqlCommand("insert into package_booking values ('' , '" + textCustomerID.Text + "' ,'" + txtpackage.Text + "' , '" + textPrice.Text + "','" + today.ToShortDateString() + "')", conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show(" Customer details Saved... ");
            conn.Close();
            display();
            clearFeilds();
        }

        private void updatefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update package_Bookings set sales_ID = '" + textCustomerID.Text + "' ,package_Type = '" + txtpackage.Text + "' , Price = '" + textPrice.Text + "',  + ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Customer details Updated... ");
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
                    String sqlQuery = "Delete from package_booking where sales_ID = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
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
                MessageBox.Show("Please Enter Sales ID...");
            }
            else
            {
                string selectQuary = "Select * from package_booking where sales_ID = " + int.Parse(search.Text);
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    textCustomerID.Text = mdr.GetString("customer_ID");
                    txtpackage.Text = mdr.GetString("package_Type");
                    textPrice.Text = mdr.GetString("price");
                }
                else
                {
                    MessageBox.Show("Search Valid Sales ID...");
                    clearFeilds();
                }
            }

            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            display(); 
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Reception_Home rh = new Reception_Home();
            this.Hide();
            rh.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        public void calc_total_package_prie()
        {
            
        }


        private void Package_Booking_Load(object sender, EventArgs e)
        {

        }

 
        private void guna2Button1_report_Click(object sender, EventArgs e)
        {
        }

        private void txtpackage_SelectedValueChanged(object sender, EventArgs e)
        {
            //calc_total_package_prie();
        }

        private void txtpackage_SelectedIndexChanged(object sender, EventArgs e)
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
            graphics.DrawString("Hotel Saketha - Package Booking Receipt", new Font("Times New Roman", 20), new SolidBrush(Color.Black), start, starty);
            string top = "Date :" + DateTime.Today.ToString("yyyy-MM-dd");
            start = 190;
            graphics.DrawString(top, font, new SolidBrush(Color.Black), start, starty + offset);
            offset = offset + (int)FontHeight;
            offset = offset + 50;
            graphics.DrawString("Package Type: " + txtpackage.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;
            graphics.DrawString("----------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 40;
            graphics.DrawString("Number of Customer : " + textCustomerID.Text, font, new SolidBrush(Color.Black), startx, starty + offset);
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

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
               
                txtpackage.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                packageprice = Int32.Parse(dataGridView2.SelectedRows[0].Cells[3].Value.ToString());


            }
        }

        private void textCustomerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textPrice.Text = Convert.ToString(packageprice * double.Parse(textCustomerID.Text));
            }
            catch
            {
                textCustomerID.Clear();
                textPrice.Clear();
            }
           
        }
    }
    
}

