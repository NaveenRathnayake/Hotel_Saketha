namespace Saketha_Hotel_System_Try_1.Accountant
{
    partial class Maintanance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintanance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.searchbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.costxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.destxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalRepBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProRepBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mainten_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clrBtn = new Guna.UI2.WinForms.Guna2Button();
            this.delBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.clrBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.costxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.destxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SalRepBtn);
            this.panel1.Controls.Add(this.ProRepBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Location = new System.Drawing.Point(127, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 650);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Searchlbl);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.search);
            this.panel2.Location = new System.Drawing.Point(40, 548);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 65);
            this.panel2.TabIndex = 56;
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(2, 2);
            this.Searchlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(55, 19);
            this.Searchlbl.TabIndex = 21;
            this.Searchlbl.Text = "Search";
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
            this.searchbtn.Location = new System.Drawing.Point(142, 15);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(47, 46);
            this.searchbtn.TabIndex = 23;
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
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.HoverState.Parent = this.search;
            this.search.Location = new System.Drawing.Point(6, 24);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderText = "Employee ID";
            this.search.SelectedText = "";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(116, 25);
            this.search.TabIndex = 22;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateBtn.BorderRadius = 20;
            this.UpdateBtn.CheckedState.Parent = this.UpdateBtn;
            this.UpdateBtn.CustomImages.Parent = this.UpdateBtn;
            this.UpdateBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.UpdateBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.HoverState.Parent = this.UpdateBtn;
            this.UpdateBtn.Location = new System.Drawing.Point(781, 573);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.ShadowDecoration.Parent = this.UpdateBtn;
            this.UpdateBtn.Size = new System.Drawing.Size(105, 40);
            this.UpdateBtn.TabIndex = 54;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // costxt
            // 
            this.costxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costxt.Location = new System.Drawing.Point(138, 311);
            this.costxt.Margin = new System.Windows.Forms.Padding(2);
            this.costxt.Name = "costxt";
            this.costxt.Size = new System.Drawing.Size(200, 23);
            this.costxt.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cost";
            // 
            // destxt
            // 
            this.destxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destxt.Location = new System.Drawing.Point(138, 254);
            this.destxt.Margin = new System.Windows.Forms.Padding(2);
            this.destxt.Name = "destxt";
            this.destxt.Size = new System.Drawing.Size(200, 23);
            this.destxt.TabIndex = 31;
            this.destxt.TextChanged += new System.EventHandler(this.destext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Description";
            // 
            // SalRepBtn
            // 
            this.SalRepBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.SalRepBtn.BorderRadius = 10;
            this.SalRepBtn.CheckedState.Parent = this.SalRepBtn;
            this.SalRepBtn.CustomImages.Parent = this.SalRepBtn;
            this.SalRepBtn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.SalRepBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.SalRepBtn.ForeColor = System.Drawing.Color.White;
            this.SalRepBtn.HoverState.Parent = this.SalRepBtn;
            this.SalRepBtn.Location = new System.Drawing.Point(309, 43);
            this.SalRepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SalRepBtn.Name = "SalRepBtn";
            this.SalRepBtn.ShadowDecoration.Parent = this.SalRepBtn;
            this.SalRepBtn.Size = new System.Drawing.Size(156, 40);
            this.SalRepBtn.TabIndex = 29;
            this.SalRepBtn.Text = "Maintenance";
            this.SalRepBtn.Click += new System.EventHandler(this.SalRepBtn_Click);
            // 
            // ProRepBtn
            // 
            this.ProRepBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ProRepBtn.BorderRadius = 10;
            this.ProRepBtn.CheckedState.Parent = this.ProRepBtn;
            this.ProRepBtn.CustomImages.Parent = this.ProRepBtn;
            this.ProRepBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.ProRepBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProRepBtn.ForeColor = System.Drawing.Color.White;
            this.ProRepBtn.HoverState.Parent = this.ProRepBtn;
            this.ProRepBtn.Location = new System.Drawing.Point(149, 43);
            this.ProRepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ProRepBtn.Name = "ProRepBtn";
            this.ProRepBtn.ShadowDecoration.Parent = this.ProRepBtn;
            this.ProRepBtn.Size = new System.Drawing.Size(156, 40);
            this.ProRepBtn.TabIndex = 26;
            this.ProRepBtn.Text = "Profit Report";
            this.ProRepBtn.Click += new System.EventHandler(this.ProRepBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mainten_Id,
            this.Description,
            this.Cost,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(404, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 350);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Mainten_Id
            // 
            this.Mainten_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mainten_Id.DataPropertyName = "mainten_Id";
            this.Mainten_Id.HeaderText = "mainten_Id";
            this.Mainten_Id.Name = "Mainten_Id";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
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
            this.logoutbtn.Location = new System.Drawing.Point(952, 43);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.ShadowDecoration.Parent = this.logoutbtn;
            this.logoutbtn.Size = new System.Drawing.Size(105, 40);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Saketha_Hotel_System_Try_1.Properties.Resources.H;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
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
            this.closebtn.Image = global::Saketha_Hotel_System_Try_1.Properties.Resources.cancel_25px;
            this.closebtn.ImageSize = new System.Drawing.Size(25, 25);
            this.closebtn.Location = new System.Drawing.Point(1056, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closebtn.ShadowDecoration.Parent = this.closebtn;
            this.closebtn.Size = new System.Drawing.Size(32, 34);
            this.closebtn.TabIndex = 7;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addBtn.BorderRadius = 20;
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(577, 573);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(105, 40);
            this.addBtn.TabIndex = 59;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.clrBtn.BorderRadius = 20;
            this.clrBtn.CheckedState.Parent = this.clrBtn;
            this.clrBtn.CustomImages.Parent = this.clrBtn;
            this.clrBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.clrBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.ForeColor = System.Drawing.Color.White;
            this.clrBtn.HoverState.Parent = this.clrBtn;
            this.clrBtn.Location = new System.Drawing.Point(404, 573);
            this.clrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.ShadowDecoration.Parent = this.clrBtn;
            this.clrBtn.Size = new System.Drawing.Size(105, 40);
            this.clrBtn.TabIndex = 60;
            this.clrBtn.Text = "Clear";
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.delBtn.BorderRadius = 20;
            this.delBtn.CheckedState.Parent = this.delBtn;
            this.delBtn.CustomImages.Parent = this.delBtn;
            this.delBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.delBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.HoverState.Parent = this.delBtn;
            this.delBtn.Location = new System.Drawing.Point(952, 551);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delBtn.Name = "delBtn";
            this.delBtn.ShadowDecoration.Parent = this.delBtn;
            this.delBtn.Size = new System.Drawing.Size(105, 40);
            this.delBtn.TabIndex = 61;
            this.delBtn.Text = "Delete";
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Maintanance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1226, 705);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Maintanance";
            this.Text = "Profit_Report";
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
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private Guna.UI2.WinForms.Guna2Button SalRepBtn;
        private Guna.UI2.WinForms.Guna2Button ProRepBtn;
        private System.Windows.Forms.TextBox costxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Searchlbl;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mainten_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button clrBtn;
        private Guna.UI2.WinForms.Guna2Button delBtn;
    }
}