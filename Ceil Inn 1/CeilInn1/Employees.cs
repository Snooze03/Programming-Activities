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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void ShowEmployees()
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

                    lvwEmployees.Items.Clear();

                    foreach (Employee clerk in lstEmployees)
                    {
                        ListViewItem lviEmployee = new ListViewItem(clerk.EmployeeNumber);

                        lviEmployee.SubItems.Add(clerk.FirstName);
                        lviEmployee.SubItems.Add(clerk.LastName);
                        lviEmployee.SubItems.Add(clerk.Title);

                        lvwEmployees.Items.Add(lviEmployee);
                    }
                }
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            Collection<Employee> lstEmployees = new Collection<Employee>();
            EmployeeEditor editor = new EmployeeEditor();
            BinaryFormatter bfEmployees = new BinaryFormatter();

            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Employees.mpl";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsEmployees = new FileStream(strFileName,
                                                            FileMode.Open,
                                                            FileAccess.Read))
                {
                    lstEmployees = (Collection<Employee>)bfEmployees.Deserialize(fsEmployees);
                }
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                Employee clerk = new Employee();

                clerk.EmployeeNumber = editor.txtEmployeeNumber.Text;
                clerk.FirstName = editor.txtFirstName.Text;
                clerk.LastName = editor.txtLastName.Text;
                clerk.Title = editor.txtTitle.Text;

                lstEmployees.Add(clerk);

                using (FileStream fsEmployees = new FileStream(strFileName,
                                                            FileMode.Create,
                                                            FileAccess.Write))
                {
                    bfEmployees.Serialize(fsEmployees, lstEmployees);
                }

                ShowEmployees();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
