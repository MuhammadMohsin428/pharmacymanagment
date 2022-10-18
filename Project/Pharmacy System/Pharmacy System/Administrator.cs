using Pharmacy_System.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Administrator : Form
    {
        String user = "";
        public Administrator()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }

        public Administrator(string username)
        {
            InitializeComponent();
            usernamelabel.Text = username;
            user = username;
            view_User1.ID = ID;
            uC_Profile1.ID = ID;
        }

        private void btndashbord_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = true;
            uC_Dashbord1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            Hide();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            uC_AddUsers1.Visible = false;
            view_User1.Visible = false;
            uC_Profile1.Visible = false;
            btndashbord.PerformClick();
        }

        private void uC_AddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            uC_AddUsers1.Visible = true;
            uC_AddUsers1.BringToFront();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            view_User1.Visible = true;
            view_User1.BringToFront();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void uC_Profile1_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-JFK19PJ;Initial Catalog=M_Pharmacy;Integrated Security=True";
            return con;
        }
    }
}
