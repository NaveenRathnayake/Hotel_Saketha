namespace Saketha_Hotel_System_Try_1.Restaurant_Manager
{
    partial class Add_foods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_foods));
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fdpreviewbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addticketsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addfoodsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.foodprice = new System.Windows.Forms.TextBox();
            this.foodpricetxt = new System.Windows.Forms.Label();
            this.ordersbtn = new Guna.UI2.WinForms.Guna2Button();
            this.foodname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.deletefoodbtn = new Guna.UI2.WinForms.Guna2Button();
            this.updatefoodbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addfoodbtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.ComboBox();
            this.searchbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Food_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.selectbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fdpreviewbtn);
            this.panel1.Controls.Add(this.addticketsbtn);
            this.panel1.Controls.Add(this.addfoodsbtn);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.foodprice);
            this.panel1.Controls.Add(this.foodpricetxt);
            this.panel1.Controls.Add(this.ordersbtn);
            this.panel1.Controls.Add(this.foodname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.deletefoodbtn);
            this.panel1.Controls.Add(this.updatefoodbtn);
            this.panel1.Controls.Add(this.addfoodbtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(308, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 800);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // selectbox
            // 
            this.selectbox.FormattingEnabled = true;
            this.selectbox.Items.AddRange(new object[] {
            "Starters",
            "Main_Courses",
            "Desserts",
            "Drinks",
            "Shorts"});
            this.selectbox.Location = new System.Drawing.Point(272, 235);
            this.selectbox.Name = "selectbox";
            this.selectbox.Size = new System.Drawing.Size(197, 24);
            this.selectbox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Food Catagory";
            // 
            // fdpreviewbtn
            // 
            this.fdpreviewbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.fdpreviewbtn.BorderRadius = 20;
            this.fdpreviewbtn.CheckedState.Parent = this.fdpreviewbtn;
            this.fdpreviewbtn.CustomImages.Parent = this.fdpreviewbtn;
            this.fdpreviewbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.fdpreviewbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.fdpreviewbtn.ForeColor = System.Drawing.Color.White;
            this.fdpreviewbtn.HoverState.Parent = this.fdpreviewbtn;
            this.fdpreviewbtn.Location = new System.Drawing.Point(889, 50);
            this.fdpreviewbtn.Name = "fdpreviewbtn";
            this.fdpreviewbtn.ShadowDecoration.Parent = this.fdpreviewbtn;
            this.fdpreviewbtn.Size = new System.Drawing.Size(161, 68);
            this.fdpreviewbtn.TabIndex = 36;
            this.fdpreviewbtn.Text = "Preview Food Details";
            this.fdpreviewbtn.Click += new System.EventHandler(this.fdpreviewbtn_Click);
            // 
            // addticketsbtn
            // 
            this.addticketsbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addticketsbtn.BorderRadius = 10;
            this.addticketsbtn.CheckedState.Parent = this.addticketsbtn;
            this.addticketsbtn.CustomImages.Parent = this.addticketsbtn;
            this.addticketsbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.addticketsbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addticketsbtn.ForeColor = System.Drawing.Color.White;
            this.addticketsbtn.HoverState.Parent = this.addticketsbtn;
            this.addticketsbtn.Location = new System.Drawing.Point(338, 50);
            this.addticketsbtn.Name = "addticketsbtn";
            this.addticketsbtn.ShadowDecoration.Parent = this.addticketsbtn;
            this.addticketsbtn.Size = new System.Drawing.Size(154, 49);
            this.addticketsbtn.TabIndex = 35;
            this.addticketsbtn.Text = "Order Reports";
            this.addticketsbtn.Click += new System.EventHandler(this.addticketsbtn_Click);
            // 
            // addfoodsbtn
            // 
            this.addfoodsbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addfoodsbtn.BorderRadius = 10;
            this.addfoodsbtn.CheckedState.Parent = this.addfoodsbtn;
            this.addfoodsbtn.CustomImages.Parent = this.addfoodsbtn;
            this.addfoodsbtn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.addfoodsbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.addfoodsbtn.ForeColor = System.Drawing.Color.White;
            this.addfoodsbtn.HoverState.Parent = this.addfoodsbtn;
            this.addfoodsbtn.Location = new System.Drawing.Point(498, 50);
            this.addfoodsbtn.Name = "addfoodsbtn";
            this.addfoodsbtn.ShadowDecoration.Parent = this.addfoodsbtn;
            this.addfoodsbtn.Size = new System.Drawing.Size(140, 49);
            this.addfoodsbtn.TabIndex = 34;
            this.addfoodsbtn.Text = "Add Foods";
            this.addfoodsbtn.Click += new System.EventHandler(this.addfoodsbtn_Click);
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
            this.closebtn.TabIndex = 33;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click_1);
            // 
            // foodprice
            // 
            this.foodprice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodprice.Location = new System.Drawing.Point(272, 418);
            this.foodprice.Name = "foodprice";
            this.foodprice.Size = new System.Drawing.Size(194, 28);
            this.foodprice.TabIndex = 32;
            // 
            // foodpricetxt
            // 
            this.foodpricetxt.AutoSize = true;
            this.foodpricetxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodpricetxt.Location = new System.Drawing.Point(84, 414);
            this.foodpricetxt.Name = "foodpricetxt";
            this.foodpricetxt.Size = new System.Drawing.Size(125, 26);
            this.foodpricetxt.TabIndex = 31;
            this.foodpricetxt.Text = "Food Price";
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
            this.ordersbtn.Location = new System.Drawing.Point(192, 50);
            this.ordersbtn.Name = "ordersbtn";
            this.ordersbtn.ShadowDecoration.Parent = this.ordersbtn;
            this.ordersbtn.Size = new System.Drawing.Size(140, 49);
            this.ordersbtn.TabIndex = 30;
            this.ordersbtn.Text = "Orders";
            this.ordersbtn.Click += new System.EventHandler(this.ordersbtn_Click);
            // 
            // foodname
            // 
            this.foodname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodname.Location = new System.Drawing.Point(272, 326);
            this.foodname.Name = "foodname";
            this.foodname.Size = new System.Drawing.Size(197, 28);
            this.foodname.TabIndex = 29;
            this.foodname.TextChanged += new System.EventHandler(this.foodname_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Food Name";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.SkyBlue;
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(587, 701);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(140, 49);
            this.guna2Button4.TabIndex = 27;
            this.guna2Button4.Text = "Clear";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // deletefoodbtn
            // 
            this.deletefoodbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.deletefoodbtn.BorderRadius = 20;
            this.deletefoodbtn.CheckedState.Parent = this.deletefoodbtn;
            this.deletefoodbtn.CustomImages.Parent = this.deletefoodbtn;
            this.deletefoodbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.deletefoodbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletefoodbtn.ForeColor = System.Drawing.Color.White;
            this.deletefoodbtn.HoverState.Parent = this.deletefoodbtn;
            this.deletefoodbtn.Location = new System.Drawing.Point(1256, 701);
            this.deletefoodbtn.Name = "deletefoodbtn";
            this.deletefoodbtn.ShadowDecoration.Parent = this.deletefoodbtn;
            this.deletefoodbtn.Size = new System.Drawing.Size(140, 49);
            this.deletefoodbtn.TabIndex = 26;
            this.deletefoodbtn.Text = "Delete";
            this.deletefoodbtn.Click += new System.EventHandler(this.deletefoodbtn_Click);
            // 
            // updatefoodbtn
            // 
            this.updatefoodbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.updatefoodbtn.BorderRadius = 20;
            this.updatefoodbtn.CheckedState.Parent = this.updatefoodbtn;
            this.updatefoodbtn.CustomImages.Parent = this.updatefoodbtn;
            this.updatefoodbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.updatefoodbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatefoodbtn.ForeColor = System.Drawing.Color.White;
            this.updatefoodbtn.HoverState.Parent = this.updatefoodbtn;
            this.updatefoodbtn.Location = new System.Drawing.Point(1032, 701);
            this.updatefoodbtn.Name = "updatefoodbtn";
            this.updatefoodbtn.ShadowDecoration.Parent = this.updatefoodbtn;
            this.updatefoodbtn.Size = new System.Drawing.Size(140, 49);
            this.updatefoodbtn.TabIndex = 25;
            this.updatefoodbtn.Text = "Update";
            this.updatefoodbtn.Click += new System.EventHandler(this.updatefoodbtn_Click);
            // 
            // addfoodbtn
            // 
            this.addfoodbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addfoodbtn.BorderRadius = 20;
            this.addfoodbtn.CheckedState.Parent = this.addfoodbtn;
            this.addfoodbtn.CustomImages.Parent = this.addfoodbtn;
            this.addfoodbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addfoodbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.addfoodbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfoodbtn.ForeColor = System.Drawing.Color.White;
            this.addfoodbtn.HoverState.Parent = this.addfoodbtn;
            this.addfoodbtn.Location = new System.Drawing.Point(806, 701);
            this.addfoodbtn.Name = "addfoodbtn";
            this.addfoodbtn.ShadowDecoration.Parent = this.addfoodbtn;
            this.addfoodbtn.Size = new System.Drawing.Size(140, 49);
            this.addfoodbtn.TabIndex = 24;
            this.addfoodbtn.Text = "Add ";
            this.addfoodbtn.Click += new System.EventHandler(this.addfoodbtn_Click_1);
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
            this.logoutbtn.Location = new System.Drawing.Point(1256, 50);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.ShadowDecoration.Parent = this.logoutbtn;
            this.logoutbtn.Size = new System.Drawing.Size(140, 49);
            this.logoutbtn.TabIndex = 23;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.Searchlbl);
            this.panel2.Location = new System.Drawing.Point(144, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 80);
            this.panel2.TabIndex = 22;
            // 
            // search
            // 
            this.search.FormattingEnabled = true;
            this.search.Items.AddRange(new object[] {
            "Starters",
            "Main_Courses",
            "Desserts",
            "Drinks",
            "Shorts"});
            this.search.Location = new System.Drawing.Point(25, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 24);
            this.search.TabIndex = 39;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.CheckedState.Parent = this.searchbtn;
            this.searchbtn.CustomImages.Parent = this.searchbtn;
            this.searchbtn.FillColor = System.Drawing.Color.Empty;
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.Parent = this.searchbtn;
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.searchbtn.Location = new System.Drawing.Point(190, 25);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(63, 50);
            this.searchbtn.TabIndex = 23;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(3, 3);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(140, 23);
            this.Searchlbl.TabIndex = 21;
            this.Searchlbl.Text = "Search Food ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Food_ID,
            this.Catagory,
            this.Food_Name,
            this.Food_Price});
            this.dataGridView1.Location = new System.Drawing.Point(587, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(809, 447);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Food_ID
            // 
            this.Food_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Food_ID.DataPropertyName = "Food_Id";
            this.Food_ID.HeaderText = "Food_ID";
            this.Food_ID.Name = "Food_ID";
            // 
            // Catagory
            // 
            this.Catagory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Catagory.DataPropertyName = "Catagory";
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.Name = "Catagory";
            // 
            // Food_Name
            // 
            this.Food_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Food_Name.DataPropertyName = "Food_Name";
            this.Food_Name.HeaderText = "Food_Name";
            this.Food_Name.Name = "Food_Name";
            // 
            // Food_Price
            // 
            this.Food_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Food_Price.DataPropertyName = "Price";
            this.Food_Price.HeaderText = "Food_Price(Rs)";
            this.Food_Price.Name = "Food_Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Saketha_Hotel_System_Try_1.Properties.Resources.H;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Add_foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1779, 865);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_foods";
            this.Text = "Add_foods";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.TextBox foodprice;
        private System.Windows.Forms.Label foodpricetxt;
        private Guna.UI2.WinForms.Guna2Button ordersbtn;
        private System.Windows.Forms.TextBox foodname;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button deletefoodbtn;
        private Guna.UI2.WinForms.Guna2Button updatefoodbtn;
        private Guna.UI2.WinForms.Guna2Button addfoodbtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private Guna.UI2.WinForms.Guna2Button addticketsbtn;
        private Guna.UI2.WinForms.Guna2Button addfoodsbtn;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn;
        private Guna.UI2.WinForms.Guna2Button fdpreviewbtn;
        private System.Windows.Forms.ComboBox selectbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_Price;
    }
}