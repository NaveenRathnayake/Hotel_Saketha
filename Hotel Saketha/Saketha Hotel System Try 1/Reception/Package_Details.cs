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
    public partial class Package_Details : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempId;

        public Package_Details()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from package_details", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempId = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textPackageName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textDescription.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textAvailability.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            }
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {

            {
                conn.Open();
                cmd = new MySqlCommand("insert into package_details values ('' , '" + textPackageName.Text + "' ,'" + textDescription.Text + "' , '" + textPrice.Text + "' , '" + textAvailability.Text + "'  )", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Package details details Saved... ");
                conn.Close();
                display();
                //clearFeilds();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            textPackageName.Clear();
            textDescription.Clear();
            textPrice.Clear();
            textAvailability.ResetText();
            
        }

        private void updatefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update package_details set package_Name = '" + textPackageName.Text + "' , Description = '" + textDescription.Text + "', price = '" + textPrice.Text + "', availability = '" + textAvailability.Text + "' where package_ID  = '" + tempId + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Details Updated... ");
            conn.Close();
            
            display();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Reception_Home rh = new Reception_Home();
            this.Hide();
            rh.Show();
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

        private void Package_Details_Load(object sender, EventArgs e)
        {

        }

        private void deletefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView1.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from package_details where package_ID  = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    display();
                }
            }
        }
    }
}
