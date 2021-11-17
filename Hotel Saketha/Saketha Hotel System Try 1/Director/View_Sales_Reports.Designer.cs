namespace Saketha_Hotel_System_Try_1.Director
{
    partial class View_Sales_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Sales_Reports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.searchbtn2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Report_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restaurant_Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reception_Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Events_Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packages_Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel_Total_Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Location = new System.Drawing.Point(319, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 800);
            this.panel1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Report_ID,
            this.Restaurant_Total_Sales,
            this.Reception_Total_Sales,
            this.Events_Total_Sales,
            this.Packages_Total_Sales,
            this.Date,
            this.Hotel_Total_Sales});
            this.dataGridView1.Location = new System.Drawing.Point(461, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(882, 543);
            this.dataGridView1.TabIndex = 61;
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
            this.clearbtn.Location = new System.Drawing.Point(131, 421);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.ShadowDecoration.Parent = this.clearbtn;
            this.clearbtn.Size = new System.Drawing.Size(133, 49);
            this.clearbtn.TabIndex = 60;
            this.clearbtn.Text = "Refresh";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.datepick);
            this.panel6.Controls.Add(this.searchbtn2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(77, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 88);
            this.panel6.TabIndex = 59;
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
            this.label1.Location = new System.Drawing.Point(697, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sales Reports";
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
            this.Report_ID.DataPropertyName = "sales_Report_ID";
            this.Report_ID.HeaderText = "Report_ID";
            this.Report_ID.Name = "Report_ID";
            // 
            // Restaurant_Total_Sales
            // 
            this.Restaurant_Total_Sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Restaurant_Total_Sales.DataPropertyName = "restaurant_Total_Sales";
            this.Restaurant_Total_Sales.HeaderText = "Restaurant_Total_Sales";
            this.Restaurant_Total_Sales.Name = "Restaurant_Total_Sales";
            // 
            // Reception_Total_Sales
            // 
            this.Reception_Total_Sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reception_Total_Sales.DataPropertyName = "rooms_Total_Sales";
            this.Reception_Total_Sales.HeaderText = "Reception_Total_Sales";
            this.Reception_Total_Sales.Name = "Reception_Total_Sales";
            // 
            // Events_Total_Sales
            // 
            this.Events_Total_Sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Events_Total_Sales.DataPropertyName = "Events_Total_Sales";
            this.Events_Total_Sales.HeaderText = "Events_Total_Sales";
            this.Events_Total_Sales.Name = "Events_Total_Sales";
            // 
            // Packages_Total_Sales
            // 
            this.Packages_Total_Sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Packages_Total_Sales.DataPropertyName = "Packages_Total_Sales";
            this.Packages_Total_Sales.HeaderText = "Packages_Total_Sales";
            this.Packages_Total_Sales.Name = "Packages_Total_Sales";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Hotel_Total_Sales
            // 
            this.Hotel_Total_Sales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hotel_Total_Sales.DataPropertyName = "total_Sales";
            this.Hotel_Total_Sales.HeaderText = "Hotel_Total_Sales";
            this.Hotel_Total_Sales.Name = "Hotel_Total_Sales";
            // 
            // Sales_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1725, 1007);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Reports";
            this.Text = "Sales_Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker datepick;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Report_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restaurant_Total_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reception_Total_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Events_Total_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packages_Total_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel_Total_Sales;
    }
}