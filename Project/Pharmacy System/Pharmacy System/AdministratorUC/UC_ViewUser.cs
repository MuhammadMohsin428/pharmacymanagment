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
    public partial class View_User : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";


        public View_User()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }


        private void View_User_Load(object sender, EventArgs e)
        {
            query = "select *from users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query="select * from users where username like'"+txtUsername.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Conf rmation |", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query = "delete from users where username='" + userName + "'";
                    fn.setData(query, "User Record Deleted.");
                    View_User_Load(this, null);
                }
                else
                {
                    MessageBox.Show("you are trying to delete \n your own profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            View_User_Load(this, null);
        }
    }
}
