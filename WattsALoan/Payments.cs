using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WattsALoan1
{
    public partial class FRM_Payments : Form
    {
        public FRM_Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            string strFilename = "loans.xml";

            if (File.Exists(strFilename)) DS_LoanAllocation.ReadXml(strFilename);
            strFilename = "employees.xml";
            if (File.Exists(strFilename)) DS_Employees.ReadXml(strFilename);
            strFilename = "payments.xml";
            if (File.Exists(strFilename)) DS_Payments.ReadXml(strFilename);
        }

        private void Payments_FormClosing(object sender, FormClosingEventArgs e)
        {
            DS_Payments.WriteXml("payments.xml");
        }

        private void BTN_Loans_Click(object sender, EventArgs e)
        {
            FRM_LoanAllocations frmLoans = new FRM_LoanAllocations();
            frmLoans.ShowDialog();
        }

        private void BTN_CLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
