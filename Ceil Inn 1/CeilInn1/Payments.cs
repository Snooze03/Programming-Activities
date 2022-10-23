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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void ShowPayments()
        {
            Collection<Employee> employees;
            PaymentEditor editor = new PaymentEditor();
            BinaryFormatter bfPayments = new BinaryFormatter();
            BinaryFormatter bfEmployees = new BinaryFormatter();
            BinaryFormatter bfCustomers = new BinaryFormatter();
            string strEmployee = "", strCustomer = "";
            Collection<Payment> payments = new Collection<Payment>();
            Collection<Customer> customers = new Collection<Customer>();
            string strPaymentsFile = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Payments.pmt";
            string strCustomersFile = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Customers.cst";
            string strEmployeesFile = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Employees.mpl";

            if (File.Exists(strPaymentsFile) == true)
            {
                using (FileStream fsPayments = new FileStream(strPaymentsFile,
                                                              FileMode.Open,
                                                              FileAccess.Read))
                {
                    payments = (Collection<Payment>)bfPayments.Deserialize(fsPayments);

                    lvwPayments.Items.Clear();

                    foreach (Payment pmt in payments)
                    {
                        ListViewItem lviPayment = new ListViewItem(pmt.ReceiptNumber.ToString());

                        using (FileStream fsEmployees = new FileStream(strEmployeesFile,
                                                                       FileMode.Open,
                                                                       FileAccess.Read))
                        {
                            employees = (Collection<Employee>)bfEmployees.Deserialize(fsEmployees);

                            foreach (Employee clerk in employees)
                            {
                                if (clerk.EmployeeNumber == pmt.EmployeeNumber)
                                    strEmployee = clerk.EmployeeNumber + ": " +
                                                  clerk.FirstName + " " +
                                                  clerk.LastName;
                            }
                        }

                        lviPayment.SubItems.Add(strEmployee);

                        lviPayment.SubItems.Add(pmt.PaymentDate.ToLongDateString());

                        using (FileStream fsCustomers = new FileStream(strCustomersFile,
                                                                       FileMode.Open,
                                                                       FileAccess.Read))
                        {
                            customers = (Collection<Customer>)bfCustomers.Deserialize(fsCustomers);

                            foreach (Customer client in customers)
                            {
                                if (client.AccountNumber == pmt.AccountNumber)
                                    strCustomer = client.AccountNumber + ": " +
                                                  client.FirstName + " " +
                                                  client.LastName;
                            }
                        }

                        lviPayment.SubItems.Add(strCustomer);
                        lviPayment.SubItems.Add(pmt.FirstDayOccupied.ToLongDateString());
                        lviPayment.SubItems.Add(pmt.LastDayOccupied.ToLongDateString());
                        lviPayment.SubItems.Add(pmt.TotalNights.ToString());
                        lviPayment.SubItems.Add(pmt.AmountCharged.ToString("F"));
                        lviPayment.SubItems.Add(pmt.PhoneUse.ToString("F"));
                        lviPayment.SubItems.Add(pmt.SubTotal.ToString("F"));
                        lviPayment.SubItems.Add((pmt.TaxRate / 100).ToString("P"));
                        lviPayment.SubItems.Add(pmt.TaxAmount.ToString("F"));
                        lviPayment.SubItems.Add(pmt.TotalAmountPaid.ToString("F"));
                        lvwPayments.Items.Add(lviPayment);
                    }
                }
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            ShowPayments();
        }

        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            PaymentEditor editor = new PaymentEditor();
            BinaryFormatter bfPayments = new BinaryFormatter();
            Collection<Payment> payments = new Collection<Payment>();
            string strPaymentsFile = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Payments.pmt";

            if (editor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(strPaymentsFile) == true)
                {
                    using (FileStream fsPayments = new FileStream(strPaymentsFile,
                                                                    FileMode.Open,
                                                                    FileAccess.Read))
                    {
                        payments = (Collection<Payment>)bfPayments.Deserialize(fsPayments);
                    }
                }
                         
                Payment pmt = new Payment();
                        
                pmt.ReceiptNumber = int.Parse(editor.txtReceiptNumber.Text);
                pmt.EmployeeNumber = editor.txtEmployeeNumber.Text;
                pmt.PaymentDate = editor.dtpPaymentDate.Value;
                pmt.AccountNumber = editor.txtAccountNumber.Text;
                pmt.FirstDayOccupied = editor.dtpFirstDateOccupied.Value;
                pmt.LastDayOccupied  = editor.dtpLastDateOccupied.Value;
                pmt.TotalNights = int.Parse(editor.txtTotalNights.Text);
                pmt.AmountCharged = double.Parse(editor.txtAmountCharged.Text);
                pmt.PhoneUse  = double.Parse(editor.txtPhoneUse.Text);
                pmt.SubTotal = double.Parse(editor.txtSubTotal.Text);
                pmt.TaxRate = double.Parse(editor.txtTaxRate.Text);
                pmt.TaxAmount  = double.Parse(editor.txtTaxAmount.Text);
                pmt.TotalAmountPaid = double.Parse(editor.txtTotalAmountPaid.Text);
                        
                payments.Add(pmt);
                        
                using (FileStream fsPayments = new FileStream(strPaymentsFile,
                                                                FileMode.Create,
                                                                FileAccess.Write))
                {
                    bfPayments.Serialize(fsPayments, payments);
                }
            }

            ShowPayments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
