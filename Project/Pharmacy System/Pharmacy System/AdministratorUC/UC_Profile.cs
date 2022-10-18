using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.AdministratorUC
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;

        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { usernameLabel.Text = value; }
        }
    

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtno.Text);
            String email = txtEmail.Text;
            String username = usernameLabel.Text;
            String pass = txtPassword.Text;

            query = "update user set userRole='" + role + "',name='" + name + "',dob='" + dob + "',mobile=" + mobile + ",email='" + email + "',pass='" + pass + "' where username='" + username + "'";
            fn.setData(query, "profile Updation Successful.");
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + usernameLabel.Text + "'";
            DataSet ds = fn.getData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtno.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }
    }
}
