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
    public partial class pharmacist : Form
    {
        public pharmacist()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btndashbord_Click(object sender, EventArgs e)
        {
            uC_P_dashbord1.Visible = true;
            uC_P_dashbord1.BringToFront();
        }

        private void pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_dashbord1.Visible = false;
            uC_P_AddMedicines1.Visible = false;
            uC_P_View1.Visible = false;
            uC_Modify1.Visible = false;
            uC_M_Validity1.Visible = false;
            uC_Sell_M1.Visible = false;
            btndashbord.PerformClick();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicines1.Visible = true;
            uC_P_AddMedicines1.BringToFront();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            uC_P_View1.Visible = true;
            uC_P_View1.BringToFront();
        }
        private void btnmodify_Click(object sender, EventArgs e)
        {
            uC_Modify1.Visible = true;
            uC_Modify1.BringToFront();
        }

        private void btnvalidity_Click(object sender, EventArgs e)
        {
            uC_M_Validity1.Visible = true;
            uC_M_Validity1.BringToFront();
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            uC_Sell_M1.Visible = true;
            uC_Sell_M1.BringToFront();
        }
    }
}
