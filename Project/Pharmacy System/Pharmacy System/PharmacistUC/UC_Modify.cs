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
    public partial class UC_Modify : UserControl
    {
        function fn = new function();
        String query;

        public UC_Modify()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtMID.Text != "")
            {
                query = "select*from medic where mid='" + txtMID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMID.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMname.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMdate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEdate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtavailablequantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtppu.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID:" + txtMID.Text + "exitst.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearALl();
            }
        }

        private void clearALl()
        {
            txtMID.Clear();
            txtMname.Clear();
            txtMno.Clear();
            txtMID.Clear();
            txtEdate.ResetText();
            txtMdate.ResetText();
            txtavailablequantity.Clear();
            txtppu.Clear();

            if(txtaddunit.Text!="0")
            {
                txtaddunit.Text = "0";
            }
            else
            {
                txtaddunit.Text = "0";
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearALl();
        }
        Int64 totalQunatity;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String mname=txtMname.Text;
            String mnumber = txtMno.Text;
            String mdate = txtMdate.Text;
            String edate = txtEdate.Text;
            Int64 quantity = Int64.Parse(txtavailablequantity.Text);
            Int64 addQuantity = Int64.Parse(txtaddunit.Text);
            Int64 unitprice = Int64.Parse(txtppu.Text);

            totalQunatity = quantity + addQuantity;
            //mid,mname,mnumber,mDate,eDate,quantity,perUnit
            query = "update medic set mname='" + mname + "',mnumber='" + mnumber + "',mdate='" + mdate + "',edate='" + edate + "',quantity=" + totalQunatity + ",perUnit=" + unitprice + " where mid='"+txtMID.Text+"'";
            fn.setData(query, "Medicine Details updated.");
        }
    }
}
