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

namespace Saketha_Hotel_System_Try_1.Reception
{
    public partial class Maintain : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempId;

        public Maintain()

        {
            InitializeComponent();
            display();
        }


        //method for display data in databse as a table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from room", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dgvMaintaindetails.DataSource = dt;
        }

        private void addfoodbtn_Click(object sender, EventArgs e)
        {
            if(validateMaintain()){
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into room values ('' , '" + txtRoomNumber.Text + "' ,'" + txtRoomtype.Text + "' , '" + textPrice.Text + "','" +0+ "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Room details Saved... ");
                    conn.Close();
                    display();
                    // clearFeilds();
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Add_Customers ac = new Add_Customers();
            this.Hide();
            ac.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            display();
        }

        private void dgvMaintaindetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvMaintaindetails.Rows.Count > 0)
            {
                tempId = Int32.Parse(dgvMaintaindetails.SelectedRows[0].Cells[0].Value.ToString());
                txtRoomNumber.Text = dgvMaintaindetails.SelectedRows[0].Cells[1].Value.ToString();
                txtRoomtype.Text = dgvMaintaindetails.SelectedRows[0].Cells[2].Value.ToString();
                textPrice.Text = dgvMaintaindetails.SelectedRows[0].Cells[4].Value.ToString();
               
            }
        }

        private void updatefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update room set room_Num = '" + txtRoomNumber.Text + "' ,room_Type = '" + txtRoomtype.Text + "', price_per_hour = '" + textPrice.Text + "' where room_ID  = '" + tempId + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Customer details Updated... ");
            conn.Close();
            display();
            //clearFeilds();
        }

        private void deletefoodbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dgvMaintaindetails.Rows.Count; i++)
            {
                DataGridViewRow dv = dgvMaintaindetails.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from room where room_ID  = '" + dgvMaintaindetails.Rows[i].Cells[0].Value + "'";
                    MySqlCommand sqlcmd = new MySqlCommand(sqlQuery, conn);
                    sqlcmd.ExecuteNonQuery();
                    dgvMaintaindetails.Rows.RemoveAt(i);
                    MessageBox.Show("Deleted Successfully....");
                    conn.Close();
                    display();
                }
            }
        }

        private void dgvMaintaindetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            //clearFeilds();
        }

        //validation
        public Boolean validateMaintain()
        {
            Boolean flag = true;
            string error_message = "";


            if (!textPrice.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Price  should be a number";
                flag = false;
            }

            if (!flag)
            {
                MessageBox.Show(error_message);
            }
            return flag;

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Reception_Home rh = new Reception_Home();
            this.Hide();
            rh.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Package_Details pd = new Package_Details();
            this.Hide();
            pd.Show();
        }
    }
}
