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

namespace Saketha_Hotel_System_Try_1.HR_Manager 
{
    public partial class Add_Employees : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        private int tempid;

        public Add_Employees()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select * from add_employee", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            nametxt.Clear();
            agetxt.Clear();
            addresstxt.Clear();
            nictxt.Clear();
            phonetxt.Clear();
            workinghourstxt.Clear();
            othourstxt.Clear();
            basicsalarytxt.Clear();
            salarycutstxt.Clear();
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            Add_Employees ae = new Add_Employees();
            this.Hide();
            ae.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Salary_Calculate sc = new Salary_Calculate();
            this.Hide();
            sc.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (validateEmployee())
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("insert into add_employee values ('' ,'" + nametxt.Text + "', '" + agetxt.Text + "','" + addresstxt.Text + "', '" + nictxt.Text + "','" + phonetxt.Text + "', '" + workinghourstxt.Text + "','" + othourstxt.Text + "', '" + basicsalarytxt.Text + "','" + salarycutstxt.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                    display();
                    clearFeilds();
                    MessageBox.Show(" Employee details added Successfully... ");
                }
                catch(Exception)
                {
                    MessageBox.Show("Error");
                }
                
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("update add_employee set Name = '" + nametxt.Text + "' , Age = '" + agetxt.Text + "', Address = '" + addresstxt.Text + "' , NIC = '" + nictxt.Text + "', Phone = '" + phonetxt.Text + "', Working_Hour = '" + workinghourstxt.Text + "', OT_Hours = '" + othourstxt.Text + "', Basic_Salary = '" + basicsalarytxt.Text + "' , Salary_Cut = '" + salarycutstxt.Text + "'where Employee_ID = '" + tempid + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Employee details Updated... ");
            conn.Close();
            display();
            clearFeilds();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView1.Rows[i];
                if (dv.Selected == true)
                {
                    String sqlQuery = "Delete from add_employee where Employee_ID = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
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
                nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                agetxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                addresstxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                nictxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                phonetxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                workinghourstxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                othourstxt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                basicsalarytxt.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                salarycutstxt.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                
            }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (search.Text == null)
            {
                MessageBox.Show("Please Enter Employee ID...");
            }
            else
            {
                string selectQuary = "Select * from add_employee where Employee_ID = " + int.Parse(search.Text);
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    nametxt.Text = mdr.GetString("Name");
                    agetxt.Text = mdr.GetInt32("Age").ToString();
                    addresstxt.Text = mdr.GetString("Address");
                    nictxt.Text = mdr.GetString("NIC");
                    phonetxt.Text = mdr.GetInt32("Phone").ToString();
                    workinghourstxt.Text = mdr.GetInt32("Working_Hour").ToString();
                    othourstxt.Text = mdr.GetInt32("OT_Hours").ToString();
                    basicsalarytxt.Text = mdr.GetInt32("Basic_Salary").ToString();
                    salarycutstxt.Text = mdr.GetInt32("Salary_Cut").ToString();
                    
                }
                else
                {
                    MessageBox.Show("Search Valid Employee ID...");
                    clearFeilds();
                }
            }

            conn.Close();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        //validations
        public Boolean validateEmployee()
        {
            Boolean flag = true;
            string error_message = "";
            if (!agetxt.Text.All(Char.IsDigit) || string.IsNullOrEmpty(agetxt.Text))
            {
                error_message = error_message + "\n Age should be a number";
                flag = false;
                MessageBox.Show(error_message);
            }

            if (Int32.Parse(agetxt.Text) > 120 || Int32.Parse(agetxt.Text) <= 0)
            {
                error_message = error_message + "\n Invalid Age";
                flag = false;
                MessageBox.Show(error_message);
            }


            if (nictxt.Text.Length != 12)
            {
                error_message = error_message + "\n NIC Should contain 12 digits";
                flag = false;
                MessageBox.Show(error_message);
            }

          
            if (phonetxt.Text.Length != 9)
            {
                error_message = error_message + "\n Mobile Number  Should contain 10 digits";
                flag = false;
                MessageBox.Show(error_message);

            }

            if (!othourstxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n OT hours should be a number";
                flag = false;
                MessageBox.Show(error_message);
            }

            if (!basicsalarytxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Salary should be a number";
                flag = false;
                MessageBox.Show(error_message);
            }

            if (!workinghourstxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Working Hours should be a number";
                flag = false;
                MessageBox.Show(error_message);
            }

            if (!salarycutstxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Salary Cuts should be a number";
                flag = false;
                MessageBox.Show(error_message);

            }
            if (float.Parse(salarycutstxt.Text) <= 0)
            {
                error_message = error_message + "\n Salary Cannot be negative";
                flag = false;
                MessageBox.Show(error_message);
            }
            

            

            return flag;
        }

        private void workinghourstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void salarycutstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }

}
