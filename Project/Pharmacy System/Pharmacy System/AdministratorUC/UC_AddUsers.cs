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
    public partial class UC_AddUsers : UserControl
    {
        function fn = new function();
        String query;


        public UC_AddUsers()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
            
        {
            String role = txtuserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String username = txtusername.Text;
            String pass = txtpassword.Text;

            try
            {
                query = "insert into users  (userRole,name,dob,mobile,email,username,pass) values('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Sign Up Successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Username Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtusername.Clear();
            txtEmail.Clear();
            txtpassword.Clear();
            txtMobile.Clear();
            txtDob.ResetText();
            txtuserRole.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtusername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"E:\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"E:\Pharmacy Management System in C#\no.png";
            }
        }

        private void txtuserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
