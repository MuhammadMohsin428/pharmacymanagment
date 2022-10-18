namespace Pharmacy_System
{
    partial class pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsell = new Guna.UI2.WinForms.Guna2Button();
            this.btnvalidity = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnadduser = new Guna.UI2.WinForms.Guna2Button();
            this.btnmodify = new Guna.UI2.WinForms.Guna2Button();
            this.btnview = new Guna.UI2.WinForms.Guna2Button();
            this.btndashbord = new Guna.UI2.WinForms.Guna2Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_M_Validity1 = new Pharmacy_System.PharmacistUC.UC_M_Validity();
            this.uC_Modify1 = new Pharmacy_System.PharmacistUC.UC_Modify();
            this.uC_P_View1 = new Pharmacy_System.PharmacistUC.UC_P_View();
            this.uC_P_AddMedicines1 = new Pharmacy_System.PharmacistUC.UC_P_AddMedicines();
            this.uC_P_dashbord1 = new Pharmacy_System.PharmacistUC.UC_P_dashbord();
            this.uC_Sell_M1 = new Pharmacy_System.PharmacistUC.UC_Sell_M();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnsell);
            this.panel1.Controls.Add(this.btnvalidity);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.usernamelabel);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Controls.Add(this.btnmodify);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btndashbord);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 780);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 780);
            this.panel2.TabIndex = 3;
            // 
            // btnsell
            // 
            this.btnsell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btnsell.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnsell.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsell.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnsell.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnsell.CheckedState.Parent = this.btnsell;
            this.btnsell.CustomImages.Parent = this.btnsell;
            this.btnsell.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnsell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsell.ForeColor = System.Drawing.Color.White;
            this.btnsell.HoverState.FillColor = System.Drawing.Color.White;
            this.btnsell.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnsell.HoverState.Parent = this.btnsell;
            this.btnsell.Image = ((System.Drawing.Image)(resources.GetObject("btnsell.Image")));
            this.btnsell.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsell.Location = new System.Drawing.Point(0, 585);
            this.btnsell.Name = "btnsell";
            this.btnsell.ShadowDecoration.Parent = this.btnsell;
            this.btnsell.Size = new System.Drawing.Size(263, 45);
            this.btnsell.TabIndex = 9;
            this.btnsell.Text = "Sell Medicine";
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // btnvalidity
            // 
            this.btnvalidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btnvalidity.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnvalidity.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvalidity.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnvalidity.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnvalidity.CheckedState.Parent = this.btnvalidity;
            this.btnvalidity.CustomImages.Parent = this.btnvalidity;
            this.btnvalidity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnvalidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidity.ForeColor = System.Drawing.Color.White;
            this.btnvalidity.HoverState.FillColor = System.Drawing.Color.White;
            this.btnvalidity.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnvalidity.HoverState.Parent = this.btnvalidity;
            this.btnvalidity.Image = ((System.Drawing.Image)(resources.GetObject("btnvalidity.Image")));
            this.btnvalidity.ImageSize = new System.Drawing.Size(30, 30);
            this.btnvalidity.Location = new System.Drawing.Point(0, 521);
            this.btnvalidity.Name = "btnvalidity";
            this.btnvalidity.ShadowDecoration.Parent = this.btnvalidity;
            this.btnvalidity.Size = new System.Drawing.Size(263, 45);
            this.btnvalidity.TabIndex = 8;
            this.btnvalidity.Text = "Medicine Validity Check";
            this.btnvalidity.Click += new System.EventHandler(this.btnvalidity_Click);
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
            this.usernamelabel.Location = new System.Drawing.Point(35, 740);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(71, 31);
            this.usernamelabel.TabIndex = 7;
            this.usernamelabel.Text = "Latif";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 30);
            this.btnLogout.Location = new System.Drawing.Point(0, 636);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(263, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btnadduser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnadduser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadduser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnadduser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnadduser.CheckedState.Parent = this.btnadduser;
            this.btnadduser.CustomImages.Parent = this.btnadduser;
            this.btnadduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnadduser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnadduser.ForeColor = System.Drawing.Color.White;
            this.btnadduser.HoverState.Parent = this.btnadduser;
            this.btnadduser.Image = ((System.Drawing.Image)(resources.GetObject("btnadduser.Image")));
            this.btnadduser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnadduser.Location = new System.Drawing.Point(-1, 336);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.ShadowDecoration.Parent = this.btnadduser;
            this.btnadduser.Size = new System.Drawing.Size(263, 45);
            this.btnadduser.TabIndex = 3;
            this.btnadduser.Text = "Add Medicine";
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btnmodify.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnmodify.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmodify.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnmodify.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnmodify.CheckedState.Parent = this.btnmodify;
            this.btnmodify.CustomImages.Parent = this.btnmodify;
            this.btnmodify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnmodify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.Color.White;
            this.btnmodify.HoverState.Parent = this.btnmodify;
            this.btnmodify.Image = ((System.Drawing.Image)(resources.GetObject("btnmodify.Image")));
            this.btnmodify.ImageSize = new System.Drawing.Size(30, 30);
            this.btnmodify.Location = new System.Drawing.Point(0, 459);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.ShadowDecoration.Parent = this.btnmodify;
            this.btnmodify.Size = new System.Drawing.Size(263, 45);
            this.btnmodify.TabIndex = 5;
            this.btnmodify.Text = "Modify Medicine";
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btnview.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnview.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnview.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnview.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnview.CheckedState.Parent = this.btnview;
            this.btnview.CustomImages.Parent = this.btnview;
            this.btnview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.HoverState.Parent = this.btnview;
            this.btnview.Image = ((System.Drawing.Image)(resources.GetObject("btnview.Image")));
            this.btnview.ImageSize = new System.Drawing.Size(30, 30);
            this.btnview.Location = new System.Drawing.Point(-1, 398);
            this.btnview.Name = "btnview";
            this.btnview.ShadowDecoration.Parent = this.btnview;
            this.btnview.Size = new System.Drawing.Size(263, 45);
            this.btnview.TabIndex = 4;
            this.btnview.Text = "View Medicine";
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btndashbord
            // 
            this.btndashbord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btndashbord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btndashbord.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndashbord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btndashbord.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btndashbord.CheckedState.Parent = this.btndashbord;
            this.btndashbord.CustomImages.Parent = this.btndashbord;
            this.btndashbord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btndashbord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbord.ForeColor = System.Drawing.Color.White;
            this.btndashbord.HoverState.FillColor = System.Drawing.Color.White;
            this.btndashbord.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btndashbord.HoverState.Parent = this.btndashbord;
            this.btndashbord.Image = ((System.Drawing.Image)(resources.GetObject("btndashbord.Image")));
            this.btndashbord.ImageSize = new System.Drawing.Size(30, 30);
            this.btndashbord.Location = new System.Drawing.Point(0, 285);
            this.btndashbord.Name = "btndashbord";
            this.btndashbord.ShadowDecoration.Parent = this.btndashbord;
            this.btndashbord.Size = new System.Drawing.Size(259, 45);
            this.btndashbord.TabIndex = 2;
            this.btndashbord.Text = "Dashbord";
            this.btndashbord.Click += new System.EventHandler(this.btndashbord_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(64, 191);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(160, 31);
            this.AdminLabel.TabIndex = 1;
            this.AdminLabel.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
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
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_M_Validity1
            // 
            this.uC_M_Validity1.BackColor = System.Drawing.Color.White;
            this.uC_M_Validity1.Location = new System.Drawing.Point(268, 0);
            this.uC_M_Validity1.Name = "uC_M_Validity1";
            this.uC_M_Validity1.Size = new System.Drawing.Size(1297, 770);
            this.uC_M_Validity1.TabIndex = 7;
            // 
            // uC_Modify1
            // 
            this.uC_Modify1.BackColor = System.Drawing.Color.White;
            this.uC_Modify1.Location = new System.Drawing.Point(265, 0);
            this.uC_Modify1.Name = "uC_Modify1";
            this.uC_Modify1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Modify1.TabIndex = 6;
            // 
            // uC_P_View1
            // 
            this.uC_P_View1.BackColor = System.Drawing.Color.White;
            this.uC_P_View1.Location = new System.Drawing.Point(265, -2);
            this.uC_P_View1.Name = "uC_P_View1";
            this.uC_P_View1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_View1.TabIndex = 5;
            // 
            // uC_P_AddMedicines1
            // 
            this.uC_P_AddMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicines1.Location = new System.Drawing.Point(265, 0);
            this.uC_P_AddMedicines1.Name = "uC_P_AddMedicines1";
            this.uC_P_AddMedicines1.Size = new System.Drawing.Size(1477, 770);
            this.uC_P_AddMedicines1.TabIndex = 4;
            // 
            // uC_P_dashbord1
            // 
            this.uC_P_dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_P_dashbord1.Location = new System.Drawing.Point(268, 0);
            this.uC_P_dashbord1.Name = "uC_P_dashbord1";
            this.uC_P_dashbord1.Size = new System.Drawing.Size(1477, 770);
            this.uC_P_dashbord1.TabIndex = 3;
            // 
            // uC_Sell_M1
            // 
            this.uC_Sell_M1.BackColor = System.Drawing.Color.White;
            this.uC_Sell_M1.Location = new System.Drawing.Point(265, 0);
            this.uC_Sell_M1.Name = "uC_Sell_M1";
            this.uC_Sell_M1.Size = new System.Drawing.Size(1343, 951);
            this.uC_Sell_M1.TabIndex = 8;
            // 
            // pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 780);
            this.Controls.Add(this.uC_Sell_M1);
            this.Controls.Add(this.uC_M_Validity1);
            this.Controls.Add(this.uC_Modify1);
            this.Controls.Add(this.uC_P_View1);
            this.Controls.Add(this.uC_P_AddMedicines1);
            this.Controls.Add(this.uC_P_dashbord1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pharmacist";
            this.Load += new System.EventHandler(this.pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnvalidity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label usernamelabel;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnadduser;
        private Guna.UI2.WinForms.Guna2Button btnmodify;
        private Guna.UI2.WinForms.Guna2Button btnview;
        private Guna.UI2.WinForms.Guna2Button btndashbord;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_dashbord uC_P_dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicines uC_P_AddMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_View uC_P_View1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_Modify uC_Modify1;
        private Guna.UI2.WinForms.Guna2Button btnsell;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_M_Validity uC_M_Validity1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_Sell_M uC_Sell_M1;
    }
}