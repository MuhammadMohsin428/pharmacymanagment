using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.PharmacistUC
{
    public partial class UC_P_View : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_View()
        {
            InitializeComponent();
        }

        private void UC_P_View_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);
           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String medicineId;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].ToString();
            }
            catch
            {

            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete Confirmation !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                query = "delete from medic where mid='" + medicineId + "'";
                fn.setData(query, "Medicine Record Deleated.");
                UC_P_View_Load(this, null);
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_P_View_Load(this, null);
        }
    }
}
