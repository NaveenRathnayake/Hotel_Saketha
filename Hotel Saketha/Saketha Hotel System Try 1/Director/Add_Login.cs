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

namespace Saketha_Hotel_System_Try_1.Director
{
    public partial class Add_Login : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
        MySqlCommand cmd;

        private int tempid;

        public Add_Login()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from login", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            username.Clear();
            password.Clear();
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

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("insert into login values ('' , '" + username.Text + "' ,'" + password.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Login details Saved... ");
            conn.Close();
            display();
            clearFeilds();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update login set user_Name = '" + username.Text + "' , password = '" + password.Text + "' where login_Id = '" + tempid + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Login details Updated... ");
            conn.Close();
            display();
            clearFeilds();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                username.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                password.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
                    String sqlQuery = "Delete from login where login_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    display();
                }
            }
        }


        private void homebtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
