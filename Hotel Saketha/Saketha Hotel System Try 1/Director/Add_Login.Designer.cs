namespace Saketha_Hotel_System_Try_1.Director
{
    partial class Add_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Location = new System.Drawing.Point(326, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 800);
            this.panel1.TabIndex = 11;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(258, 391);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(222, 22);
            this.password.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password";
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
            this.User_ID,
            this.User_Name,
            this.User_Password});
            this.dataGridView1.Location = new System.Drawing.Point(582, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(827, 431);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // User_ID
            // 
            this.User_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_ID.DataPropertyName = "login_Id";
            this.User_ID.HeaderText = "User_ID";
            this.User_ID.Name = "User_ID";
            // 
            // User_Name
            // 
            this.User_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Name.DataPropertyName = "user_Name";
            this.User_Name.HeaderText = "User_Name";
            this.User_Name.Name = "User_Name";
            // 
            // User_Password
            // 
            this.User_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Password.DataPropertyName = "password";
            this.User_Password.HeaderText = "Password";
            this.User_Password.Name = "User_Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(258, 262);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(222, 22);
            this.username.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Name";
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.clearbtn.BorderRadius = 20;
            this.clearbtn.CheckedState.Parent = this.clearbtn;
            this.clearbtn.CustomImages.Parent = this.clearbtn;
            this.clearbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.HoverState.Parent = this.clearbtn;
            this.clearbtn.Location = new System.Drawing.Point(612, 704);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.ShadowDecoration.Parent = this.clearbtn;
            this.clearbtn.Size = new System.Drawing.Size(140, 49);
            this.clearbtn.TabIndex = 13;
            this.clearbtn.Text = "Clear";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.deletebtn.BorderRadius = 20;
            this.deletebtn.CheckedState.Parent = this.deletebtn;
            this.deletebtn.CustomImages.Parent = this.deletebtn;
            this.deletebtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.HoverState.Parent = this.deletebtn;
            this.deletebtn.Location = new System.Drawing.Point(1241, 704);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.ShadowDecoration.Parent = this.deletebtn;
            this.deletebtn.Size = new System.Drawing.Size(140, 49);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "Delete";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.updatebtn.BorderRadius = 20;
            this.updatebtn.CheckedState.Parent = this.updatebtn;
            this.updatebtn.CustomImages.Parent = this.updatebtn;
            this.updatebtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.updatebtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.HoverState.Parent = this.updatebtn;
            this.updatebtn.Location = new System.Drawing.Point(1029, 704);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.ShadowDecoration.Parent = this.updatebtn;
            this.updatebtn.Size = new System.Drawing.Size(140, 49);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "Update";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addbtn.BorderRadius = 20;
            this.addbtn.CheckedState.Parent = this.addbtn;
            this.addbtn.CustomImages.Parent = this.addbtn;
            this.addbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.HoverState.Parent = this.addbtn;
            this.addbtn.Location = new System.Drawing.Point(821, 704);
            this.addbtn.Name = "addbtn";
            this.addbtn.ShadowDecoration.Parent = this.addbtn;
            this.addbtn.Size = new System.Drawing.Size(140, 49);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add ";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
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
            // Add_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1472, 965);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Login";
            this.Text = "Add_Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private Guna.UI2.WinForms.Guna2Button deletebtn;
        private Guna.UI2.WinForms.Guna2Button updatebtn;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Password;
    }
}