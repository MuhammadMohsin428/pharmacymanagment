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
    public partial class UC_P_AddMedicines : UserControl
    {
        function fn = new function();
        String query;


        public UC_P_AddMedicines()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMID.Text != "" && txtMname.Text != "" && txtMno.Text != "" && txtMdate.Text != "" && txtEdate.Text != "" && txtquantity.Text != "" && txtppu.Text != "")
            {
                String mid = txtMID.Text;
                String mname = txtMname.Text;
                String mnumber = txtMno.Text;
                String mdate = txtMdate.Text;
                String edate = txtEdate.Text;
                Int64 quantity = Int64.Parse(txtquantity.Text);
                Int64 perUnit = Int64.Parse(txtppu.Text);

                query= "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit)values('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "'," + quantity + "," + perUnit + ")";
                fn.setData(query, "Medicine Added to Database");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearALL();
        }
        public void clearALL()
        {
            txtMID.Clear();
            txtMname.Clear();
            txtMno.Clear();
            txtppu.Clear();
            txtMdate.ResetText();
            txtEdate.ResetText();
            txtquantity.Clear();
        }
    }
}
