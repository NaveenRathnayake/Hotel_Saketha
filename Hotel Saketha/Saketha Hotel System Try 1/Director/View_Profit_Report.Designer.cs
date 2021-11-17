namespace Saketha_Hotel_System_Try_1.Director
{
    partial class View_Profit_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Profit_Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.searchbtn2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Report_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sales_of_Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Order_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Salary_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Maintanance_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Location = new System.Drawing.Point(335, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 800);
            this.panel1.TabIndex = 12;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.clearbtn.BorderRadius = 20;
            this.clearbtn.CheckedState.Parent = this.clearbtn;
            this.clearbtn.CustomImages.Parent = this.clearbtn;
            this.clearbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.HoverState.Parent = this.clearbtn;
            this.clearbtn.Location = new System.Drawing.Point(141, 456);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.ShadowDecoration.Parent = this.clearbtn;
            this.clearbtn.Size = new System.Drawing.Size(133, 49);
            this.clearbtn.TabIndex = 58;
            this.clearbtn.Text = "Refresh";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.datepick);
            this.panel6.Controls.Add(this.searchbtn2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(77, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 88);
            this.panel6.TabIndex = 29;
            // 
            // datepick
            // 
            this.datepick.Location = new System.Drawing.Point(20, 44);
            this.datepick.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(178, 22);
            this.datepick.TabIndex = 24;
            this.datepick.Value = new System.DateTime(2021, 9, 9, 0, 0, 0, 0);
            // 
            // searchbtn2
            // 
            this.searchbtn2.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn2.CheckedState.Parent = this.searchbtn2;
            this.searchbtn2.CustomImages.Parent = this.searchbtn2;
            this.searchbtn2.FillColor = System.Drawing.Color.Empty;
            this.searchbtn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbtn2.ForeColor = System.Drawing.Color.White;
            this.searchbtn2.HoverState.Parent = this.searchbtn2;
            this.searchbtn2.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn2.Image")));
            this.searchbtn2.ImageSize = new System.Drawing.Size(25, 25);
            this.searchbtn2.Location = new System.Drawing.Point(190, 26);
            this.searchbtn2.Name = "searchbtn2";
            this.searchbtn2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.searchbtn2.ShadowDecoration.Parent = this.searchbtn2;
            this.searchbtn2.Size = new System.Drawing.Size(63, 57);
            this.searchbtn2.TabIndex = 23;
            this.searchbtn2.Click += new System.EventHandler(this.searchbtn2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Search by Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(616, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Profit Reports";
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.homebtn.BorderRadius = 10;
            this.homebtn.CheckedState.Parent = this.homebtn;
            this.homebtn.CustomImages.Parent = this.homebtn;
            this.homebtn.FillColor = System.Drawing.Color.DarkCyan;
            this.homebtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.HoverState.Parent = this.homebtn;
            this.homebtn.Location = new System.Drawing.Point(199, 53);
            this.homebtn.Name = "homebtn";
            this.homebtn.ShadowDecoration.Parent = this.homebtn;
            this.homebtn.Size = new System.Drawing.Size(140, 49);
            this.homebtn.TabIndex = 19;
            this.homebtn.Text = "Home";
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Report_ID,
            this.Total_Sales_of_Hotel,
            this.Item_Order_Cost,
            this.Employee_Salary_Cost,
            this.Total_Maintanance_Cost,
            this.Date,
            this.Total_Profit});
            this.dataGridView1.Location = new System.Drawing.Point(417, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(915, 543);
            this.dataGridView1.TabIndex = 18;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.logoutbtn.BorderRadius = 20;
            this.logoutbtn.CheckedState.Parent = this.logoutbtn;
            this.logoutbtn.CustomImages.Parent = this.logoutbtn;
            this.logoutbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.HoverState.Parent = this.logoutbtn;
            this.logoutbtn.Location = new System.Drawing.Point(1213, 53);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.ShadowDecoration.Parent = this.logoutbtn;
            this.logoutbtn.Size = new System.Drawing.Size(140, 49);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // closebtn
            // 
            this.closebtn.CheckedState.Parent = this.closebtn;
            this.closebtn.CustomImages.Parent = this.closebtn;
            this.closebtn.FillColor = System.Drawing.Color.Empty;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.HoverState.Parent = this.closebtn;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageSize = new System.Drawing.Size(25, 25);
            this.closebtn.Location = new System.Drawing.Point(1408, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closebtn.ShadowDecoration.Parent = this.closebtn;
            this.closebtn.Size = new System.Drawing.Size(42, 42);
            this.closebtn.TabIndex = 7;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Report_ID
            // 
            this.Report_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Report_ID.DataPropertyName = "Profit_Report_ID";
            this.Report_ID.HeaderText = "Report_ID";
            this.Report_ID.Name = "Report_ID";
            // 
            // Total_Sales_of_Hotel
            // 
            this.Total_Sales_of_Hotel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Sales_of_Hotel.DataPropertyName = "Total_Sales_of_Hotel";
            this.Total_Sales_of_Hotel.HeaderText = "Sales";
            this.Total_Sales_of_Hotel.Name = "Total_Sales_of_Hotel";
            // 
            // Item_Order_Cost
            // 
            this.Item_Order_Cost.DataPropertyName = "Item_Order_of_Cost";
            this.Item_Order_Cost.HeaderText = "Item_Order_Cost";
            this.Item_Order_Cost.Name = "Item_Order_Cost";
            // 
            // Employee_Salary_Cost
            // 
            this.Employee_Salary_Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Employee_Salary_Cost.DataPropertyName = "Total_Employee_Salary_Cost";
            this.Employee_Salary_Cost.HeaderText = "Salary_Cost";
            this.Employee_Salary_Cost.Name = "Employee_Salary_Cost";
            // 
            // Total_Maintanance_Cost
            // 
            this.Total_Maintanance_Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Maintanance_Cost.DataPropertyName = "Total_Maintenance_Cost";
            this.Total_Maintanance_Cost.HeaderText = "Maintanance_Cost";
            this.Total_Maintanance_Cost.Name = "Total_Maintanance_Cost";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Total_Profit
            // 
            this.Total_Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Profit.DataPropertyName = "Total_Profit";
            this.Total_Profit.HeaderText = "Total_Profit";
            this.Total_Profit.Name = "Total_Profit";
            // 
            // Profit_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1804, 1048);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profit_Report";
            this.Text = "Profit_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker datepick;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Report_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Sales_of_Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Order_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Salary_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Maintanance_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Profit;
    }
}