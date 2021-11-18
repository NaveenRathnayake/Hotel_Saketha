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
using System.Net;
using System.Net.Mail;



namespace Saketha_Hotel_System_Try_1.Reception
{
    public partial class Offers : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempid;

        public Offers()
        {
            InitializeComponent();
         
        }

        private void foodname_TextChanged(object sender, EventArgs e)
        {

        }


        //method for display data in databse as a table
       /* public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from offers", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dgvOffers.DataSource = dt;
        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            txtofferdetails.Clear();
            textSelectOption.Refresh();
         
        }
        */

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Event_Booking ac = new Event_Booking();
            this.Hide();
            ac.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

      
        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            /* conn.Open();
           cmd = new MySqlCommand("insert into offers values ('' , '" + txtofferdetails.Text + "' ,'" + textSelectOption.Text + "')", conn);
           cmd.ExecuteNonQuery();
           MessageBox.Show(" offers details Saved... ");
           conn.Close();

          // clearFeilds();
           */
        }

        private void Offers_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //clearFeilds();
        }
       
        private void updatefoodbtn_Click(object sender, EventArgs e)
        {
            /* conn.Open();
            cmd = new MySqlCommand("update offers set offer_Details = '" + textOfferDetails.Text + "' ,select_Option = '" + textSelectOption.Text + "' where offer_ID = '" + tempid + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" offer details Updated... ");
            conn.Close();
            display();
            clearFeilds();*/
        }
       
        private void deletefoodbtn_Click(object sender, EventArgs e)
        {/*
            conn.Open();
            for (int i = 0; i < dgvOffers.Rows.Count; i++)
            {
                DataGridViewRow dv = dgvOffers.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from offers where offer_ID = '" + dgvOffers.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dgvOffers.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    display();
                }
            }
            */
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        
        private void dgvOffers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //dgvOffers
            /*
            if (dgvOffers.Rows.Count > 0)
            {
                tempid = int.Parse(dgvOffers.SelectedRows[0].Cells[0].Value.ToString());
                txtofferdetails.Text = dgvOffers.SelectedRows[0].Cells[1].Value.ToString();
                textSelectOption.Text = dgvOffers.SelectedRows[0].Cells[2].Value.ToString();
              
            }
             */
        }


        private void textSelectOption_TextChanged(object sender, EventArgs e)
       {

        }

        private void textOfferDetails_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {


            //email send - button click
            String messageBody = txtofferdetails.Text;
            String subject = textSelectOption.Text;
            String message = "";

            //obtaining the users
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select email,name from add_customer", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);

           // List<DataRow> drlist = new List<DataRow>();

            foreach (DataRow row in dt.Rows)
            {
                message = messageBody;

                //update message body
                message = "Hii "+ row[1].ToString()+"\n" + message;
                send_mail(row[0].ToString(), subject, message);
              
            }

            MessageBox.Show("Offers Sent Successfully "); ;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Reception_Home rh = new Reception_Home();
            this.Hide();
            rh.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Maintain m = new Maintain();
            this.Hide();
            m.Show();
        }

        //method to send the mails
        public void send_mail(String to,String subject, String message)
        {
            string fromMail = "yashkodi447@gmail.com";
            string password = "yasini345@";

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(fromMail);
            mail.Body = message;
            mail.Subject = subject;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromMail, password);

            try
            {
                smtp.Send(mail);
                //MessageBox.Show("Email Sent Success fully");  //send email
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);   //catch error message
            }
        }
    }
    
}
    

