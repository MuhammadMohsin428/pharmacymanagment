namespace Pharmacy_System
{
    partial class Administrator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnadduser = new Guna.UI2.WinForms.Guna2Button();
            this.btnprofile = new Guna.UI2.WinForms.Guna2Button();
            this.btnview = new Guna.UI2.WinForms.Guna2Button();
            this.btndashbord = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Profile1 = new Pharmacy_System.AdministratorUC.UC_Profile();
            this.view_User1 = new Pharmacy_System.AdministratorUC.View_User();
            this.uC_AddUsers1 = new Pharmacy_System.AdministratorUC.UC_AddUsers();
            this.uC_Dashbord1 = new Pharmacy_System.AdministratorUC.UC_Dashbord();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.usernamelabel);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Controls.Add(this.btnprofile);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btndashbord);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 730);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(271, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1206, 730);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(48, 649);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(71, 31);
            this.usernamelabel.TabIndex = 7;
            this.usernamelabel.Text = "Latif";
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 30);
            this.btnLogout.Location = new System.Drawing.Point(51, 541);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(181, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnadduser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadduser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnadduser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnadduser.CheckedState.Parent = this.btnadduser;
            this.btnadduser.CustomImages.Parent = this.btnadduser;
            this.btnadduser.FillColor = System.Drawing.Color.Gray;
            this.btnadduser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnadduser.ForeColor = System.Drawing.Color.White;
            this.btnadduser.HoverState.Parent = this.btnadduser;
            this.btnadduser.Image = ((System.Drawing.Image)(resources.GetObject("btnadduser.Image")));
            this.btnadduser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnadduser.Location = new System.Drawing.Point(53, 337);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.ShadowDecoration.Parent = this.btnadduser;
            this.btnadduser.Size = new System.Drawing.Size(181, 57);
            this.btnadduser.TabIndex = 3;
            this.btnadduser.Text = "Add User";
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnprofile.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprofile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnprofile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnprofile.CheckedState.Parent = this.btnprofile;
            this.btnprofile.CustomImages.Parent = this.btnprofile;
            this.btnprofile.FillColor = System.Drawing.Color.Gray;
            this.btnprofile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.Color.White;
            this.btnprofile.HoverState.Parent = this.btnprofile;
            this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
            this.btnprofile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnprofile.Location = new System.Drawing.Point(52, 463);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.ShadowDecoration.Parent = this.btnprofile;
            this.btnprofile.Size = new System.Drawing.Size(180, 60);
            this.btnprofile.TabIndex = 5;
            this.btnprofile.Text = "Profile";
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnview
            // 
            this.btnview.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnview.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnview.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnview.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnview.CheckedState.Parent = this.btnview;
            this.btnview.CustomImages.Parent = this.btnview;
            this.btnview.FillColor = System.Drawing.Color.Gray;
            this.btnview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.HoverState.Parent = this.btnview;
            this.btnview.Image = ((System.Drawing.Image)(resources.GetObject("btnview.Image")));
            this.btnview.ImageSize = new System.Drawing.Size(30, 30);
            this.btnview.Location = new System.Drawing.Point(54, 400);
            this.btnview.Name = "btnview";
            this.btnview.ShadowDecoration.Parent = this.btnview;
            this.btnview.Size = new System.Drawing.Size(180, 57);
            this.btnview.TabIndex = 4;
            this.btnview.Text = "View User";
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btndashbord
            // 
            this.btndashbord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btndashbord.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndashbord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btndashbord.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btndashbord.CheckedState.Parent = this.btndashbord;
            this.btndashbord.CustomImages.Parent = this.btndashbord;
            this.btndashbord.FillColor = System.Drawing.Color.Gray;
            this.btndashbord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbord.ForeColor = System.Drawing.Color.White;
            this.btndashbord.HoverState.Parent = this.btndashbord;
            this.btndashbord.Image = ((System.Drawing.Image)(resources.GetObject("btndashbord.Image")));
            this.btndashbord.ImageSize = new System.Drawing.Size(30, 30);
            this.btndashbord.Location = new System.Drawing.Point(53, 283);
            this.btndashbord.Name = "btndashbord";
            this.btndashbord.ShadowDecoration.Parent = this.btndashbord;
            this.btndashbord.Size = new System.Drawing.Size(180, 48);
            this.btndashbord.TabIndex = 2;
            this.btndashbord.Text = "Dashbord";
            this.btndashbord.Click += new System.EventHandler(this.btndashbord_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(47, 217);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(187, 31);
            this.AdminLabel.TabIndex = 1;
            this.AdminLabel.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.view_User1);
            this.panel2.Controls.Add(this.uC_AddUsers1);
            this.panel2.Controls.Add(this.uC_Dashbord1);
            this.panel2.Location = new System.Drawing.Point(271, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 591);
            this.panel2.TabIndex = 2;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1102, 770);
            this.uC_Profile1.TabIndex = 3;
            this.uC_Profile1.Load += new System.EventHandler(this.uC_Profile1_Load);
            // 
            // view_User1
            // 
            this.view_User1.BackColor = System.Drawing.Color.White;
            this.view_User1.Location = new System.Drawing.Point(0, 0);
            this.view_User1.Name = "view_User1";
            this.view_User1.Size = new System.Drawing.Size(1461, 833);
            this.view_User1.TabIndex = 2;
            // 
            // uC_AddUsers1
            // 
            this.uC_AddUsers1.BackColor = System.Drawing.Color.White;
            this.uC_AddUsers1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUsers1.Name = "uC_AddUsers1";
            this.uC_AddUsers1.Size = new System.Drawing.Size(1461, 833);
            this.uC_AddUsers1.TabIndex = 1;
            // 
            // uC_Dashbord1
            // 
            this.uC_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_Dashbord1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dashbord1.Name = "uC_Dashbord1";
            this.uC_Dashbord1.Size = new System.Drawing.Size(1461, 833);
            this.uC_Dashbord1.TabIndex = 0;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernamelabel;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnadduser;
        private Guna.UI2.WinForms.Guna2Button btnprofile;
        private Guna.UI2.WinForms.Guna2Button btnview;
        private Guna.UI2.WinForms.Guna2Button btndashbord;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private AdministratorUC.UC_Dashbord uC_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdministratorUC.UC_AddUsers uC_AddUsers1;
        private AdministratorUC.View_User view_User1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdministratorUC.UC_Profile uC_Profile1;
    }
}