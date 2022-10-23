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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void ShowCustomers()
        {
            BinaryFormatter bfCustomers = new BinaryFormatter();
            Collection<Customer> lstCustomers = new Collection<Customer>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Customers.cst";

            // Make sure the file exists
            if (File.Exists(strFileName) == true)
            {
                // if so, create a file stream
                using( FileStream fsCustomers = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read))
                {
                    // If some customers records were created already,
                    // get them and store them in the collection
                    lstCustomers = (Collection<Customer>)bfCustomers.Deserialize(fsCustomers);

                    // First, empty the list view
                    lvwCustomers.Items.Clear();

                    // Visit each customer in the collection and add it to the list view
                    foreach (Customer client in lstCustomers)
                    {
                        ListViewItem lviCustomer = new ListViewItem(client.AccountNumber);

                        lviCustomer.SubItems.Add(client.FirstName);
                        lviCustomer.SubItems.Add(client.LastName);
                        lviCustomer.SubItems.Add(client.PhoneNumber);
                        lviCustomer.SubItems.Add(client.EmergencyName);
                        lviCustomer.SubItems.Add(client.EmergencyPhone);

                        lvwCustomers.Items.Add(lviCustomer);
                    }
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            CustomerEditor editor = new CustomerEditor();
            BinaryFormatter bfCustomers = new BinaryFormatter();
            Collection<Customer> lstCustomers = new Collection<Customer>();

            // Get a reference to the file that holds the customers records
            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Customers.cst";

            // First check if the file was previously created
            if (File.Exists(strFileName) == true)
            {
                // If the list of customers exists already,
                // get it and store it in a file stream
                using (FileStream fsCustomers = new FileStream(strFileName,
                                                        FileMode.Open,
                                                        FileAccess.Read))
                {
                    // Store the list of customers in the collection
                    lstCustomers = (Collection<Customer>)bfCustomers.Deserialize(fsCustomers);
                          
                }  // Close the file stream
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                Customer client = new Customer();

                client.AccountNumber = editor.txtAccountNumber.Text;
                client.FirstName = editor.txtFirstName.Text;
                client.LastName = editor.txtLastName.Text;
                client.PhoneNumber = editor.txtPhoneNumber.Text;
                client.EmergencyName = editor.txtEmergencyName.Text;
                client.EmergencyPhone = editor.txtEmergencyPhone.Text;

                // Add the property in the collection
                lstCustomers.Add(client);

                // Create a file stream to hold the list of properties
                using (FileStream fsCustomers = new FileStream(strFileName,
                                                            FileMode.Create,
                                                            FileAccess.Write))
                {
                    // Serialize the list of properties
                    bfCustomers.Serialize(fsCustomers, lstCustomers);
                }

                // Show the list of properties
                ShowCustomers();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
