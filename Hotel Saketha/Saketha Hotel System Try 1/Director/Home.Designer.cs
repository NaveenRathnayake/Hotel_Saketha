namespace Saketha_Hotel_System_Try_1.Director
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salesrepbtn = new Guna.UI2.WinForms.Guna2Button();
            this.profrepbtn = new Guna.UI2.WinForms.Guna2Button();
            this.logindetailsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(507, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 720);
            this.panel1.TabIndex = 12;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.homebtn.BorderRadius = 10;
            this.homebtn.CheckedState.Parent = this.homebtn;
            this.homebtn.CustomImages.Parent = this.homebtn;
            this.homebtn.FillColor = System.Drawing.Color.DarkSlateGray;
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
            this.logoutbtn.Location = new System.Drawing.Point(809, 53);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.ShadowDecoration.Parent = this.logoutbtn;
            this.logoutbtn.Size = new System.Drawing.Size(140, 49);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
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
            this.closebtn.Location = new System.Drawing.Point(1001, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closebtn.ShadowDecoration.Parent = this.closebtn;
            this.closebtn.Size = new System.Drawing.Size(42, 42);
            this.closebtn.TabIndex = 7;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.salesrepbtn);
            this.panel2.Controls.Add(this.profrepbtn);
            this.panel2.Controls.Add(this.logindetailsbtn);
            this.panel2.Location = new System.Drawing.Point(154, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 377);
            this.panel2.TabIndex = 20;
            // 
            // salesrepbtn
            // 
            this.salesrepbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.salesrepbtn.BorderRadius = 20;
            this.salesrepbtn.CheckedState.Parent = this.salesrepbtn;
            this.salesrepbtn.CustomImages.Parent = this.salesrepbtn;
            this.salesrepbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salesrepbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.salesrepbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesrepbtn.ForeColor = System.Drawing.Color.White;
            this.salesrepbtn.HoverState.Parent = this.salesrepbtn;
            this.salesrepbtn.Location = new System.Drawing.Point(438, 71);
            this.salesrepbtn.Name = "salesrepbtn";
            this.salesrepbtn.ShadowDecoration.Parent = this.salesrepbtn;
            this.salesrepbtn.Size = new System.Drawing.Size(187, 66);
            this.salesrepbtn.TabIndex = 17;
            this.salesrepbtn.Text = "Sales Report";
            this.salesrepbtn.Click += new System.EventHandler(this.salesrepbtn_Click);
            // 
            // profrepbtn
            // 
            this.profrepbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.profrepbtn.BorderRadius = 20;
            this.profrepbtn.CheckedState.Parent = this.profrepbtn;
            this.profrepbtn.CustomImages.Parent = this.profrepbtn;
            this.profrepbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.profrepbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profrepbtn.ForeColor = System.Drawing.Color.White;
            this.profrepbtn.HoverState.Parent = this.profrepbtn;
            this.profrepbtn.Location = new System.Drawing.Point(80, 71);
            this.profrepbtn.Name = "profrepbtn";
            this.profrepbtn.ShadowDecoration.Parent = this.profrepbtn;
            this.profrepbtn.Size = new System.Drawing.Size(196, 66);
            this.profrepbtn.TabIndex = 19;
            this.profrepbtn.Text = "Profit Report";
            this.profrepbtn.Click += new System.EventHandler(this.profrepbtn_Click);
            // 
            // logindetailsbtn
            // 
            this.logindetailsbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.logindetailsbtn.BorderRadius = 20;
            this.logindetailsbtn.CheckedState.Parent = this.logindetailsbtn;
            this.logindetailsbtn.CustomImages.Parent = this.logindetailsbtn;
            this.logindetailsbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.logindetailsbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logindetailsbtn.ForeColor = System.Drawing.Color.White;
            this.logindetailsbtn.HoverState.Parent = this.logindetailsbtn;
            this.logindetailsbtn.Location = new System.Drawing.Point(265, 236);
            this.logindetailsbtn.Name = "logindetailsbtn";
            this.logindetailsbtn.ShadowDecoration.Parent = this.logindetailsbtn;
            this.logindetailsbtn.Size = new System.Drawing.Size(203, 68);
            this.logindetailsbtn.TabIndex = 18;
            this.logindetailsbtn.Text = "Login Details";
            this.logindetailsbtn.Click += new System.EventHandler(this.logindetailsbtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saketha_Hotel_System_Try_1.Properties.Resources.vecteezy_blue_wave_background_ma1120;
            this.ClientSize = new System.Drawing.Size(1487, 816);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button salesrepbtn;
        private Guna.UI2.WinForms.Guna2Button profrepbtn;
        private Guna.UI2.WinForms.Guna2Button logindetailsbtn;
    }
}