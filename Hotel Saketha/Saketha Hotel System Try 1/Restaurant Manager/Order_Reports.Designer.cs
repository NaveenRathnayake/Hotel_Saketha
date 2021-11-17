namespace Saketha_Hotel_System_Try_1.Restaurant_Manager
{
    partial class Order_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Reports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.printbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchbtn3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.search3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.search1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.addticketsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addfoodsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ordersbtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addticketsbtn);
            this.panel1.Controls.Add(this.addfoodsbtn);
            this.panel1.Controls.Add(this.ordersbtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Location = new System.Drawing.Point(307, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 800);
            this.panel1.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.datepick);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(16, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 88);
            this.panel6.TabIndex = 28;
            // 
            // datepick
            // 
            this.datepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepick.Location = new System.Drawing.Point(20, 44);
            this.datepick.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(208, 22);
            this.datepick.TabIndex = 24;
            this.datepick.Value = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            this.datepick.ValueChanged += new System.EventHandler(this.datepick_ValueChanged);
            this.datepick.MouseLeave += new System.EventHandler(this.datepick_MouseLeave);
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.printbtn.BorderRadius = 20;
            this.printbtn.CheckedState.Parent = this.printbtn;
            this.printbtn.CustomImages.Parent = this.printbtn;
            this.printbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.printbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.White;
            this.printbtn.HoverState.Parent = this.printbtn;
            this.printbtn.Location = new System.Drawing.Point(209, 22);
            this.printbtn.Name = "printbtn";
            this.printbtn.ShadowDecoration.Parent = this.printbtn;
            this.printbtn.Size = new System.Drawing.Size(96, 50);
            this.printbtn.TabIndex = 58;
            this.printbtn.Text = "Print";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
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
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.clearbtn.BorderRadius = 20;
            this.clearbtn.CheckedState.Parent = this.clearbtn;
            this.clearbtn.CustomImages.Parent = this.clearbtn;
            this.clearbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.clearbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.HoverState.Parent = this.clearbtn;
            this.clearbtn.Location = new System.Drawing.Point(924, 671);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.ShadowDecoration.Parent = this.clearbtn;
            this.clearbtn.Size = new System.Drawing.Size(133, 49);
            this.clearbtn.TabIndex = 57;
            this.clearbtn.Text = "Refresh";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(116, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1237, 198);
            this.panel3.TabIndex = 40;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket_Id1,
            this.Food_Name,
            this.Unit_Price,
            this.Quantity,
            this.Total});
            this.dataGridView2.Location = new System.Drawing.Point(331, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(887, 163);
            this.dataGridView2.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.searchbtn3);
            this.panel5.Controls.Add(this.search3);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(16, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 88);
            this.panel5.TabIndex = 28;
            // 
            // searchbtn3
            // 
            this.searchbtn3.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn3.CheckedState.Parent = this.searchbtn3;
            this.searchbtn3.CustomImages.Parent = this.searchbtn3;
            this.searchbtn3.FillColor = System.Drawing.Color.Empty;
            this.searchbtn3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbtn3.ForeColor = System.Drawing.Color.White;
            this.searchbtn3.HoverState.Parent = this.searchbtn3;
            this.searchbtn3.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn3.Image")));
            this.searchbtn3.ImageSize = new System.Drawing.Size(25, 25);
            this.searchbtn3.Location = new System.Drawing.Point(190, 28);
            this.searchbtn3.Name = "searchbtn3";
            this.searchbtn3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.searchbtn3.ShadowDecoration.Parent = this.searchbtn3;
            this.searchbtn3.Size = new System.Drawing.Size(63, 57);
            this.searchbtn3.TabIndex = 23;
            this.searchbtn3.Click += new System.EventHandler(this.searchbtn3_Click);
            // 
            // search3
            // 
            this.search3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search3.DefaultText = "";
            this.search3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search3.DisabledState.Parent = this.search3;
            this.search3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search3.FocusedState.Parent = this.search3;
            this.search3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.search3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search3.HoverState.Parent = this.search3;
            this.search3.Location = new System.Drawing.Point(39, 40);
            this.search3.Margin = new System.Windows.Forms.Padding(4);
            this.search3.Name = "search3";
            this.search3.PasswordChar = '\0';
            this.search3.PlaceholderText = "Order ID";
            this.search3.SelectedText = "";
            this.search3.ShadowDecoration.Parent = this.search3;
            this.search3.Size = new System.Drawing.Size(154, 31);
            this.search3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search by Order Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Food Sales Report";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Searchlbl);
            this.panel2.Location = new System.Drawing.Point(116, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 201);
            this.panel2.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_Id,
            this.Customer_Name,
            this.Order_Total,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(331, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(887, 165);
            this.dataGridView1.TabIndex = 28;
            // 
            // Order_Id
            // 
            this.Order_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Order_Id.DataPropertyName = "Order_Id";
            this.Order_Id.HeaderText = "Order_Id";
            this.Order_Id.Name = "Order_Id";
            this.Order_Id.ReadOnly = true;
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer_Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            // 
            // Order_Total
            // 
            this.Order_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Order_Total.DataPropertyName = "Order_Total";
            this.Order_Total.HeaderText = "Order_Total";
            this.Order_Total.Name = "Order_Total";
            this.Order_Total.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.search1);
            this.panel4.Controls.Add(this.printbtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(556, 646);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 88);
            this.panel4.TabIndex = 27;
            // 
            // search1
            // 
            this.search1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search1.DefaultText = "";
            this.search1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search1.DisabledState.Parent = this.search1;
            this.search1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search1.FocusedState.Parent = this.search1;
            this.search1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.search1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search1.HoverState.Parent = this.search1;
            this.search1.Location = new System.Drawing.Point(29, 41);
            this.search1.Margin = new System.Windows.Forms.Padding(4);
            this.search1.Name = "search1";
            this.search1.PasswordChar = '\0';
            this.search1.PlaceholderText = "Order ID";
            this.search1.SelectedText = "";
            this.search1.ShadowDecoration.Parent = this.search1;
            this.search1.Size = new System.Drawing.Size(154, 31);
            this.search1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Print by Order Id";
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(3, 3);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(126, 23);
            this.Searchlbl.TabIndex = 21;
            this.Searchlbl.Text = "Order Report";
            this.Searchlbl.Click += new System.EventHandler(this.Searchlbl_Click);
            // 
            // addticketsbtn
            // 
            this.addticketsbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addticketsbtn.BorderRadius = 10;
            this.addticketsbtn.CheckedState.Parent = this.addticketsbtn;
            this.addticketsbtn.CustomImages.Parent = this.addticketsbtn;
            this.addticketsbtn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.addticketsbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addticketsbtn.ForeColor = System.Drawing.Color.White;
            this.addticketsbtn.HoverState.Parent = this.addticketsbtn;
            this.addticketsbtn.Location = new System.Drawing.Point(337, 53);
            this.addticketsbtn.Name = "addticketsbtn";
            this.addticketsbtn.ShadowDecoration.Parent = this.addticketsbtn;
            this.addticketsbtn.Size = new System.Drawing.Size(154, 49);
            this.addticketsbtn.TabIndex = 38;
            this.addticketsbtn.Text = "Order Reports";
            this.addticketsbtn.Click += new System.EventHandler(this.addticketsbtn_Click);
            // 
            // addfoodsbtn
            // 
            this.addfoodsbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addfoodsbtn.BorderRadius = 10;
            this.addfoodsbtn.CheckedState.Parent = this.addfoodsbtn;
            this.addfoodsbtn.CustomImages.Parent = this.addfoodsbtn;
            this.addfoodsbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.addfoodsbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.addfoodsbtn.ForeColor = System.Drawing.Color.White;
            this.addfoodsbtn.HoverState.Parent = this.addfoodsbtn;
            this.addfoodsbtn.Location = new System.Drawing.Point(497, 53);
            this.addfoodsbtn.Name = "addfoodsbtn";
            this.addfoodsbtn.ShadowDecoration.Parent = this.addfoodsbtn;
            this.addfoodsbtn.Size = new System.Drawing.Size(140, 49);
            this.addfoodsbtn.TabIndex = 37;
            this.addfoodsbtn.Text = "Add Foods";
            this.addfoodsbtn.Click += new System.EventHandler(this.addfoodsbtn_Click);
            // 
            // ordersbtn
            // 
            this.ordersbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ordersbtn.BorderRadius = 10;
            this.ordersbtn.CheckedState.Parent = this.ordersbtn;
            this.ordersbtn.CustomImages.Parent = this.ordersbtn;
            this.ordersbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.ordersbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersbtn.ForeColor = System.Drawing.Color.White;
            this.ordersbtn.HoverState.Parent = this.ordersbtn;
            this.ordersbtn.Location = new System.Drawing.Point(191, 53);
            this.ordersbtn.Name = "ordersbtn";
            this.ordersbtn.ShadowDecoration.Parent = this.ordersbtn;
            this.ordersbtn.Size = new System.Drawing.Size(140, 49);
            this.ordersbtn.TabIndex = 36;
            this.ordersbtn.Text = "Orders";
            this.ordersbtn.Click += new System.EventHandler(this.ordersbtn_Click);
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
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit_Price.DataPropertyName = "Unit_Price";
            this.Unit_Price.HeaderText = "Unit_Price";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // Food_Name
            // 
            this.Food_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Food_Name.DataPropertyName = "Food_Name";
            this.Food_Name.HeaderText = "Food_Name";
            this.Food_Name.Name = "Food_Name";
            this.Food_Name.ReadOnly = true;
            // 
            // Ticket_Id1
            // 
            this.Ticket_Id1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ticket_Id1.DataPropertyName = "Ticket_Id";
            this.Ticket_Id1.HeaderText = "Ticket_Id";
            this.Ticket_Id1.Name = "Ticket_Id1";
            this.Ticket_Id1.ReadOnly = true;
            // 
            // Order_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1785, 928);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_Reports";
            this.Text = "Add_Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private Guna.UI2.WinForms.Guna2Button addticketsbtn;
        private Guna.UI2.WinForms.Guna2Button addfoodsbtn;
        private Guna.UI2.WinForms.Guna2Button ordersbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn3;
        private Guna.UI2.WinForms.Guna2TextBox search3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox search1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private Guna.UI2.WinForms.Guna2Button printbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}