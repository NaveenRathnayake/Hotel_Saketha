using MySql.Data.MySqlClient;
using Saketha_Hotel_System_Try_1.Director;
using Saketha_Hotel_System_Try_1.Head_Chef;
using Saketha_Hotel_System_Try_1.Restaurant_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saketha_Hotel_System_Try_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void loginbtn_Click(object sender, EventArgs e)
        {

            try
            {
                string username = usernametxt.Text;
                string password = passwordtxt.Text;
                MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from login where user_Name = '" + usernametxt.Text + "' and password = '" + passwordtxt.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    errormsg.Visible = false;
                    if (usernametxt.Text == "Rmanager")
                    {
                        Orders ro = new Orders();
                        this.Hide();
                        ro.Show();
                    }
                    else if (usernametxt.Text == "Headchef")
                    {
                        Tickets ht = new Tickets();
                        this.Hide();
                        ht.Show();
                    }
                    else if (usernametxt.Text == "Director")
                    {
                        Home h = new Home();
                        this.Hide();
                        h.Show();
                    }
                    else
                    {
                        errormsg.Visible = true;
                        passwordtxt.Clear();
                        usernametxt.Clear();
                    }

                }
                else
                {
                    errormsg.Visible = true;
                    passwordtxt.Clear();
                    usernametxt.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error While Data Validating....");
            }
            
        }

        private void passwordtxt_Enter(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
