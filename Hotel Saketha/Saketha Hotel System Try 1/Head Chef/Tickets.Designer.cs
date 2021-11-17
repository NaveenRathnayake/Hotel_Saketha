namespace Saketha_Hotel_System_Try_1.Head_Chef
{
    partial class Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchbtn2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.completebtn = new Guna.UI2.WinForms.Guna2Button();
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.reqkitchenitemsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.alertbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ticketsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Ticket_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.completebtn);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.reqkitchenitemsbtn);
            this.panel1.Controls.Add(this.alertbtn);
            this.panel1.Controls.Add(this.ticketsbtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Location = new System.Drawing.Point(319, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 800);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.searchbtn2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(144, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 93);
            this.panel3.TabIndex = 27;
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
            this.searchbtn2.Location = new System.Drawing.Point(92, 29);
            this.searchbtn2.Name = "searchbtn2";
            this.searchbtn2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.searchbtn2.ShadowDecoration.Parent = this.searchbtn2;
            this.searchbtn2.Size = new System.Drawing.Size(63, 57);
            this.searchbtn2.TabIndex = 23;
            this.searchbtn2.Click += new System.EventHandler(this.searchbtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "View Completed Tickets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(861, 411);
            this.dataGridView1.TabIndex = 58;
            // 
            // completebtn
            // 
            this.completebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.completebtn.BorderRadius = 20;
            this.completebtn.CheckedState.Parent = this.completebtn;
            this.completebtn.CustomImages.Parent = this.completebtn;
            this.completebtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.completebtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.completebtn.ForeColor = System.Drawing.Color.White;
            this.completebtn.HoverState.Parent = this.completebtn;
            this.completebtn.Location = new System.Drawing.Point(818, 696);
            this.completebtn.Name = "completebtn";
            this.completebtn.ShadowDecoration.Parent = this.completebtn;
            this.completebtn.Size = new System.Drawing.Size(230, 49);
            this.completebtn.TabIndex = 57;
            this.completebtn.Text = "Mark As Completed";
            this.completebtn.Click += new System.EventHandler(this.completebtn_Click);
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
            this.clearbtn.Location = new System.Drawing.Point(205, 593);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.ShadowDecoration.Parent = this.clearbtn;
            this.clearbtn.Size = new System.Drawing.Size(133, 49);
            this.clearbtn.TabIndex = 56;
            this.clearbtn.Text = "Refresh";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.Searchlbl);
            this.panel2.Location = new System.Drawing.Point(144, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 88);
            this.panel2.TabIndex = 26;
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
            this.searchbtn.Location = new System.Drawing.Point(190, 28);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(63, 57);
            this.searchbtn.TabIndex = 23;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.Parent = this.search;
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.FocusedState.Parent = this.search;
            this.search.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.HoverState.Parent = this.search;
            this.search.Location = new System.Drawing.Point(39, 40);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderText = "Order ID";
            this.search.SelectedText = "";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(154, 31);
            this.search.TabIndex = 22;
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(3, 3);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(172, 23);
            this.Searchlbl.TabIndex = 21;
            this.Searchlbl.Text = "Search by Order Id";
            this.Searchlbl.Click += new System.EventHandler(this.Searchlbl_Click);
            // 
            // reqkitchenitemsbtn
            // 
            this.reqkitchenitemsbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.reqkitchenitemsbtn.BorderRadius = 10;
            this.reqkitchenitemsbtn.CheckedState.Parent = this.reqkitchenitemsbtn;
            this.reqkitchenitemsbtn.CustomImages.Parent = this.reqkitchenitemsbtn;
            this.reqkitchenitemsbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.reqkitchenitemsbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqkitchenitemsbtn.ForeColor = System.Drawing.Color.White;
            this.reqkitchenitemsbtn.HoverState.Parent = this.reqkitchenitemsbtn;
            this.reqkitchenitemsbtn.Location = new System.Drawing.Point(366, 53);
            this.reqkitchenitemsbtn.Name = "reqkitchenitemsbtn";
            this.reqkitchenitemsbtn.ShadowDecoration.Parent = this.reqkitchenitemsbtn;
            this.reqkitchenitemsbtn.Size = new System.Drawing.Size(236, 49);
            this.reqkitchenitemsbtn.TabIndex = 24;
            this.reqkitchenitemsbtn.Text = "Request Kitchen Items";
            this.reqkitchenitemsbtn.Click += new System.EventHandler(this.reqkitchenitemsbtn_Click);
            // 
            // alertbtn
            // 
            this.alertbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.alertbtn.BorderRadius = 10;
            this.alertbtn.CheckedState.Parent = this.alertbtn;
            this.alertbtn.CustomImages.Parent = this.alertbtn;
            this.alertbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.alertbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertbtn.ForeColor = System.Drawing.Color.White;
            this.alertbtn.HoverState.Parent = this.alertbtn;
            this.alertbtn.Location = new System.Drawing.Point(608, 53);
            this.alertbtn.Name = "alertbtn";
            this.alertbtn.ShadowDecoration.Parent = this.alertbtn;
            this.alertbtn.Size = new System.Drawing.Size(202, 49);
            this.alertbtn.TabIndex = 23;
            this.alertbtn.Text = "Low Quality Alerts";
            this.alertbtn.Click += new System.EventHandler(this.alertbtn_Click);
            // 
            // ticketsbtn
            // 
            this.ticketsbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ticketsbtn.BorderRadius = 10;
            this.ticketsbtn.CheckedState.Parent = this.ticketsbtn;
            this.ticketsbtn.CustomImages.Parent = this.ticketsbtn;
            this.ticketsbtn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.ticketsbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsbtn.ForeColor = System.Drawing.Color.White;
            this.ticketsbtn.HoverState.Parent = this.ticketsbtn;
            this.ticketsbtn.Location = new System.Drawing.Point(166, 53);
            this.ticketsbtn.Name = "ticketsbtn";
            this.ticketsbtn.ShadowDecoration.Parent = this.ticketsbtn;
            this.ticketsbtn.Size = new System.Drawing.Size(194, 49);
            this.ticketsbtn.TabIndex = 19;
            this.ticketsbtn.Text = "Tickets";
            this.ticketsbtn.Click += new System.EventHandler(this.ticketsbtn_Click);
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
            this.logoutbtn.Location = new System.Drawing.Point(1253, 53);
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
            // Ticket_Id
            // 
            this.Ticket_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ticket_Id.DataPropertyName = "Ticket_Id";
            this.Ticket_Id.HeaderText = "Ticket_Id";
            this.Ticket_Id.Name = "Ticket_Id";
            this.Ticket_Id.Visible = false;
            // 
            // Order_Id
            // 
            this.Order_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Order_Id.DataPropertyName = "Order_Id";
            this.Order_Id.HeaderText = "Order_Id";
            this.Order_Id.Name = "Order_Id";
            // 
            // Food_Name
            // 
            this.Food_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Food_Name.DataPropertyName = "Food_Name";
            this.Food_Name.HeaderText = "Food_Name";
            this.Food_Name.Name = "Food_Name";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1890, 1033);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button ticketsbtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private Guna.UI2.WinForms.Guna2Button reqkitchenitemsbtn;
        private Guna.UI2.WinForms.Guna2Button alertbtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private System.Windows.Forms.Label Searchlbl;
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private Guna.UI2.WinForms.Guna2Button completebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_Name;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn2;
        private System.Windows.Forms.Label label1;
    }
}