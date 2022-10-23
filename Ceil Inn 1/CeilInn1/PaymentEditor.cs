using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Runtime.Serialization.Formatters.Binary;

namespace CeilInn1
{
    public partial class PaymentEditor : Form
    {
        public PaymentEditor()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // If there is no payment amount, don't do anything
            if (string.IsNullOrEmpty(txtAmountCharged.Text))
                return;

            txtSubTotal.Text = ((Convert.ToInt16(txtTotalNights.Text) * Convert.ToDouble(txtAmountCharged.Text)) + Convert.ToDouble(txtPhoneUse.Text)).ToString("F");
            txtTaxAmount.Text = (Convert.ToDouble(txtSubTotal.Text) * Convert.ToDouble(txtTaxRate.Text) / 100).ToString("F");
            txtTotalAmountPaid.Text = (Convert.ToDouble(txtSubTotal.Text) + Convert.ToDouble(txtTaxAmount.Text)).ToString("F");
        }

        private void PaymentEditor_Load(object sender, EventArgs e)
        {
            int iReceiptNumber = 1000;
            BinaryFormatter bfPayments = new BinaryFormatter();
            Collection<Payment> lstPaymentes = new Collection<Payment>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Payments.pmt";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsPayments = new FileStream(strFileName,
                                                         FileMode.Open,
                                                     FileAccess.Read))
                {

                    lstPaymentes = (Collection<Payment>)bfPayments.Deserialize(fsPayments);

                    foreach (Payment pmt in lstPaymentes)
                    {
                        iReceiptNumber = pmt.ReceiptNumber;
                    }
                }
            }

            txtReceiptNumber.Text = (iReceiptNumber + 1).ToString();
        }

        private void txtEmployeeNumber_Leave(object sender, EventArgs e)
        {
            Collection<Employee> lstEmployees;
            BinaryFormatter bfEmployees = new BinaryFormatter();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Employees.mpl";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsEmployees = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read))
                {
                    lstEmployees = (Collection<Employee>)bfEmployees.Deserialize(fsEmployees);

                    foreach (Employee empl in lstEmployees)
                    {
                        if (empl.EmployeeNumber == txtEmployeeNumber.Text)
                            txtEmployeeName.Text = empl.LastName + ", " + empl.FirstName;
                    }
                }
            }
        }

        private void txtAccountNumber_Leave(object sender, EventArgs e)
        {
            BinaryFormatter bfCustomers = new BinaryFormatter();
            Collection<Customer> lstCustomers = new Collection<Customer>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Customers.cst";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsCustomers = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read))
                {
                    lstCustomers = (Collection<Customer>)bfCustomers.Deserialize(fsCustomers);

                    foreach (Customer client in lstCustomers)
                    {
                        if (client.AccountNumber == txtAccountNumber.Text)
                            txtAccountDetails.Text = client.LastName + ", " + client.FirstName;
                    }
                }
            }
        }
    }
}
