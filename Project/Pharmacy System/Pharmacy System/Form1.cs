using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Form1 : Form

    {
        function fn = new function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            query = "select*from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "root" && txtpassword.Text == "root")
                {
                    Administrator admin = new Administrator(txtUsername.Text);
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select *from users where username='" + txtUsername.Text + "'and pass='" + txtpassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "pharmacist")
                    {
                        pharmacist pharm = new pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

































                /* if (txtUsername.Text == "Admin" && txtpassword.Text == "pass") 
                 {
                     Administrator am = new Administrator();
                     am.Show();
                     this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
