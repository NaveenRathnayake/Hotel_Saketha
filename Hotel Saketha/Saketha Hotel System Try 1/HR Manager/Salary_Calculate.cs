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

namespace Saketha_Hotel_System_Try_1.HR_Manager
{
    public partial class Salary_Calculate : Form
    {
        //make the connection with MySql Database
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = hotel_saketha");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        DataTable dt = new DataTable();

        public Salary_Calculate()
        {
            InitializeComponent();
            display();

        }

        //method for display  table
        public void display()
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Employee_ID, Name, Working_Hour, OT_Hours, Basic_Salary, Salary_Cut from add_employee", conn);
            DataTable dt1 = new DataTable();
            sqlAdapter.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }

        //method for clear the text feilds
        public void clearFeilds()
        {
            idtxt.Clear();
            nametxt.Clear();
            workinghourstxt.Clear();
            othourstxt.Clear();
            basicsalarytxt.Clear();
            salarycutstxt.Clear();
            disratetxt.Clear();
            netsaltxt.Clear();
            search.Clear();
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


        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            Add_Employees ae = new Add_Employees();
            this.Hide();
            ae.Show();
        }

        private void SalCalBtn_Click(object sender, EventArgs e)
        {
            Salary_Calculate sc = new Salary_Calculate();
            this.Hide();
            sc.Show();
        }



        private void closebtn_Click_1(object sender, EventArgs e)
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(idtxt.Text, nametxt.Text, workinghourstxt.Text, othourstxt.Text, basicsalarytxt.Text, salarycutstxt.Text, disratetxt.Text, netsaltxt.Text);
            this.dataGridView1.DataSource = dt;
            try
            {
                conn.Open();
                cmd = new MySqlCommand("insert into salary values ('' ,'" + idtxt.Text + "','" + nametxt.Text + "', '" + workinghourstxt.Text + "','" + othourstxt.Text + "', '" + basicsalarytxt.Text + "','" + salarycutstxt.Text + "','" + disratetxt.Text + "','" + netsaltxt.Text + "', now()) ", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Successful... ");
                conn.Close();
                
                display();
                clearFeilds();
            }
            catch (Exception)
            {
                MessageBox.Show("Error...!!!", "Error");
                clearFeilds();
            }

           


        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        //validations
        public Boolean validateSalary_Calculate()
        {
            Boolean flag = true;
            string error_message = "";

            if (!workinghourstxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Working Hours should be a number";
                flag = false;
            }

            if (!othourstxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n OT Hours should be a number";
                flag = false;
            }

            if (!basicsalarytxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Basic Salary should be a number";
                flag = false;
            }

            if (!salarycutstxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Salary Cutstxt should be a number";
                flag = false;
            }

            if (!disratetxt.Text.All(Char.IsDigit))
            {
                error_message = error_message + "\n Discount Rate should be a number";
                flag = false;
            }
            MessageBox.Show(error_message);

            return flag;
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                idtxt.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                nametxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                workinghourstxt.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                othourstxt.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                basicsalarytxt.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                salarycutstxt.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                
            }
        }

        private void idtxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void nametxt_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void basicsalarytxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void workinghourstxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void salarycutstxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void othourstxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string selectQuary = "Select * from add_employee where Employee_ID = '" + search.Text + "' ";
                cmd = new MySqlCommand(selectQuary, conn);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    conn.Close();
                    if (search.Text == null)
                    {
                        MessageBox.Show("Please Enter Employee ID...");
                        display();
                    }
                    else
                    {
                        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter("Select Employee_ID, Name, Working_Hour, OT_Hours, Basic_Salary, Salary_Cut from add_employee where Employee_ID = '" + search.Text + "' ", conn);
                        DataTable dt = new DataTable();
                        sqlAdapter.Fill(dt);
                        dataGridView2.DataSource = dt;
                        clearFeilds();

                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("There are no record for Entered ID...");
                    display();
                    clearFeilds();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Error while Searching... ", "Error");
                clearFeilds();
            }
        }

        private void Salary_Calculate_Load(object sender, EventArgs e)
        {
            dt.Columns.AddRange(new DataColumn[]{
                new DataColumn("Employee_Id", typeof(string)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Working_Hours", typeof(string)),
                new DataColumn("OT_Hours", typeof(string)),
                new DataColumn("Basic_Salary", typeof(string)),
                new DataColumn("Salary_Cuts", typeof(string)),
                new DataColumn("Discount_Rate", typeof(string)),
                new DataColumn("Net_Salary", typeof(string)),
            });
        }

        private void netsaltxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot Edit Here...!!!", "Error");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            workinghourstxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            othourstxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            basicsalarytxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            salarycutstxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dv = dataGridView1.Rows[i];
                if (dv.Selected == true)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer1 = new DGVPrinter();
            printer1.Title = "Employee Salary Pasheet";
            printer1.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer1.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer1.PageNumbers = true;
            printer1.PageNumberInHeader = false;
            printer1.PrintPreviewDataGridView(dataGridView1);
            printer1.HeaderCellAlignment = StringAlignment.Near;
            printer1.Footer = "By Accountant";
            printer1.FooterSpacing = 5;
        }

        private void disratetxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                netsaltxt.Text = Convert.ToString(((double.Parse(othourstxt.Text) * 250) + double.Parse(basicsalarytxt.Text) - double.Parse(salarycutstxt.Text)) * double.Parse(disratetxt.Text));

            }
            catch (Exception)
            {
                disratetxt.Clear();
            }
           
        }
    }
}
    

   