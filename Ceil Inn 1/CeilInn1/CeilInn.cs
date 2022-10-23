using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CeilInn1
{
    public partial class CeilInn : Form
    {
        public CeilInn()
        {
            InitializeComponent();
        }

        private void CeilInn_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Microsoft Visual C# Application Design\Ceil Inn");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers clients = new Customers();
            clients.Show();
        }

        private void btnOccupancies_Click(object sender, EventArgs e)
        {
            Occupancies rentals = new Occupancies();
            rentals.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Rooms rms = new Rooms();
            rms.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments pmts = new Payments();
            pmts.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees staff = new Employees();
            staff.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
