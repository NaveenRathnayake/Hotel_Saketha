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

namespace Saketha_Hotel_System_Try_1.Accountant
{
    public partial class Maintanance : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;

        private int tempid;

        public Maintanance()
        {
            InitializeComponent();
            //display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from maintenance", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            destxt.Clear();
            costxt.Clear();
            search.Clear();
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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really want to Logout?", "info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ProRepBtn_Click(object sender, EventArgs e)
        {
            Profit_Report cpr = new Profit_Report();
            this.Hide();
            cpr.Show();
        }

        private void SalRepBtn_Click(object sender, EventArgs e)
        {
            Maintanance sr = new Maintanance();
            this.Hide();
            sr.Show();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update maintenance  set Description = '" + destxt.Text + "' , Cost = '" + costxt.Text + "', Date = now() where mainten_Id = '" + tempid + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Maintenance details Updated Successfully... ");
            conn.Close();
            display();
            clearFeilds();
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

           
        }

        private void destext_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("insert into maintenance  values ('' ,'" + destxt.Text + "', '" + costxt.Text + "', now())", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Maintenance details added Successfully... ");
                conn.Close();
                display();
                clearFeilds();
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView1.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from maintenance where mainten_Id = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    display();
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tempid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                destxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                costxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                

            }
        }
    }
}