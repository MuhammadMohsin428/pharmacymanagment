using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Pharmacy_System.PharmacistUC
{
    public partial class UC_Sell_M : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;


        public UC_Sell_M()
        {
            InitializeComponent();
        }

        private void UC_Sell_M_Load(object sender, EventArgs e)
        {
            listBoxM.Items.Clear();
            query = "select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                listBoxM.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_Sell_M_Load(this, null);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            listBoxM.Items.Clear();
            query = "select mname from medic where mname like'" + txtsearch.Text + "%' and eDate >=getdate() and quantity >'0'";
            ds = fn.getData(query);

            for(int i=0; i<ds.Tables[0].Rows.Count;i++)
            {
                listBoxM.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxM_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNofunits.Clear();

            String name = listBoxM.GetItemText(listBoxM.SelectedItem);

            txtMname.Text = name;

            query = "select mid,eDate,perUnit from medic where mname='" + name + "'";
            ds = fn.getData(query);
            txtid.Text = ds.Tables[0].Rows[0][0].ToString();
            txtexpire.Text = ds.Tables[0].Rows[0][1].ToString();
            txtper.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNofunits_TextChanged(object sender, EventArgs e)
        {
            if(txtNofunits.Text!="")
            {
                Int64 unitprice = Int64.Parse(txtper.Text);
                Int64 noOfUnit = Int64.Parse(txtNofunits.Text);
                Int64 totalAmount = unitprice * noOfUnit;
                txtprice.Text = totalAmount.ToString();
            }
            else
            {
                txtprice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        

        private void btnaddcart_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                query = "select quantity from medic where mid='" + txtid.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNofunits.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtid.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMname.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtexpire.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtNofunits.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtper.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtprice.Text;

                    totalAmount = totalAmount + int.Parse(txtprice.Text);
                    totallabel.Text = "Rs. " + totalAmount.ToString();

                    query = "update medic set quantity='" + newQuantity + "'where mid='" + txtid + "'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is out of stock.\n only" + quantity + "Left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearALL();
                UC_Sell_M_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;

       

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

       

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(valueId !=null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid='" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "update medic set quantity='" + newQuantity + "' where mid='" + valueId + "'";
                    fn.setData(query, "Medicine Removed from cart.");
                    totalAmount = totalAmount - valueAmount;
                    totallabel.Text = "Rs. " + totalAmount.ToString();
                }
                UC_Sell_M_Load(this, null);
            }
        }

        private void btnpuchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount: " + totallabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totallabel.Text = "Rs.00";
            guna2DataGridView1.DataSource = 0;

        }



        private void clearALL()
        {
            txtid.Clear();
            txtMname.Clear();
            txtexpire.ResetText();
            txtper.Clear();
            txtNofunits.Clear();
        }
    }
}
