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
    public partial class OccupancyEditor : Form
    {
        public OccupancyEditor()
        {
            InitializeComponent();
        }

        private void OccupancyEditor_Load(object sender, EventArgs e)
        {
            int iOccupancyNumber = 100000;
            BinaryFormatter bfOccupancies = new BinaryFormatter();
            Collection<Occupancy> lstOccupancies = new Collection<Occupancy>();
            string strOccupanciesFile = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Occupancies.ocp";

            if (File.Exists(strOccupanciesFile) == true)
            {
                using (FileStream fsOccupancies = new FileStream(strOccupanciesFile,
                                                         FileMode.Open,
                                                     FileAccess.Read))
                {

                    lstOccupancies = (Collection<Occupancy>)bfOccupancies.Deserialize(fsOccupancies);

                    foreach (Occupancy order in lstOccupancies)
                    {
                        iOccupancyNumber = order.OccupancyNumber;
                    }
                }
            }

            txtOccupancyNumber.Text = (iOccupancyNumber + 1).ToString();
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
                        if( client.AccountNumber == txtAccountNumber.Text )
                            txtCustomerName.Text = client.LastName + ", " + client.FirstName;
                    }
                }
            }
        }

        private void txtRoomNumber_Leave(object sender, EventArgs e)
        {
            BinaryFormatter bfRooms = new BinaryFormatter();
            Collection<Room> lstRooms = new Collection<Room>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Rooms.rms";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsRooms = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read))
                {
                    lstRooms = (Collection<Room>)bfRooms.Deserialize(fsRooms);

                    foreach (Room rm in lstRooms)
                    {
                        if (rm.RoomNumber == txtRoomNumber.Text)
                            txtRoomDescription.Text = "Room type: " + rm.RoomType +
                                                      ", Bed type: " + rm.BedType +
                                                      ", Rate = " + rm.Rate.ToString("F") + "/night";
                    }
                }
            }
        }
    }
}
