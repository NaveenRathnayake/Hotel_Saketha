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

namespace Saketha_Hotel_System_Try_1.Restaurant_Manager
{
    public partial class Show_Foods : Form
    {
        //Connect the databse
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; password=@sliitproject3; database=hotel_saketha;");

        public Show_Foods()
        {
            InitializeComponent();
            display();
        }

        //method for display data in databse as a table
        public void display()
        {
            try
            {
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Starters'", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception)
            {
                MessageBox.Show(" Error While Loading ");
            }

            try
            {
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Main_Courses'", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show(" Error While Loading ");
            }

            try
            {
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Desserts'", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show(" Error While Loading ");
            }

            try
            {
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Drinks'", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show(" Error While Loading ");
            }

            try
            {
                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Food_Name, Price from add_food where Catagory = 'Shorts'", conn);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView5.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show(" Error While Loading ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
