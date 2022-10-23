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
    public partial class FRM_LoanAllocations : Form
    {
        public FRM_LoanAllocations()
        {
            InitializeComponent();
        }

        private void LoanAllocations_Load(object sender, EventArgs e)
        {
            string strFilename = "employees.xml";

            if (File.Exists(strFilename)) DS_Employees.ReadXml(strFilename);
            strFilename = "customers.xml";
            if (File.Exists(strFilename)) DS_Customers.ReadXml(strFilename);
            strFilename = "loans.xml";
            if (File.Exists(strFilename)) DS_LoanAllocation.ReadXml(strFilename);
        }

        private void LoanAllocations_FormClosing(object sender, FormClosingEventArgs e)
        {
            DS_LoanAllocation.WriteXml("loans.xml");
        }

        private void BTN_CLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
