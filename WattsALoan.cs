using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WattsALoan1
{
    public partial class WattsALoan : Form
    {
        public WattsALoan()
        {
            InitializeComponent();
        }

        private void BTN_Payments_Click(object sender, EventArgs e)
        {
            // FRM_Payments frmPayments = new FRM_Payments();
            // frmPayments.ShowDialog();
        }

        private void BTN_Allocations_Click(object sender, EventArgs e)
        {
            FRM_LoanAllocations frmAllocations = new FRM_LoanAllocations();
            frmAllocations.ShowDialog();
        }

        private void BTN_Customers_Click(object sender, EventArgs e)
        {
            FRM_Customers frmCustomers = new FRM_Customers();   
            frmCustomers.ShowDialog();
        }

        private void BTN_Employees_Click(object sender, EventArgs e)
        {
            FRM_Employees frmEmployees = new FRM_Employees();
            frmEmployees.ShowDialog();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
