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
    public partial class UC_M_Validity : UserControl
    {
        function fn = new function();
        String query;


        public UC_M_Validity()
        {
            InitializeComponent();
        }

        private void txtcheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtcheck.SelectedIndex==0)
            {
                query = "select * from medic where eDate >= getdate()";
                setDataGridView(query, "Valid Medicines", Color.Black);
            }
            else if (txtcheck.SelectedIndex == 1)
            {
                query = "select * from medic where eDate <= getdate()";
                setDataGridView(query, "Expired Medicines", Color.Red);
            }
            else if(txtcheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                setDataGridView(query, "", Color.Black);
            }
        }
        private void setDataGridView(String query,String labelName,Color col)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            setLabel.Text = "labelName";
            setLabel.ForeColor =col;
        }

        private void UC_M_Validity_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }
    }
}
