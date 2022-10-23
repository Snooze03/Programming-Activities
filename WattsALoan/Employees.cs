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
    public partial class FRM_Employees : Form
    {
        public FRM_Employees()
        {
            InitializeComponent();
        }

        private void FRM_Employees_Load(object sender, EventArgs e)
        {
            string fileName = "employees.xml";

            if (File.Exists(fileName))
            {
                DS_Employees.ReadXml(fileName);
            }
        }

        private void FRM_Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            DS_Employees.WriteXml("employees.xml");
        }

        private void BTN_CLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DVG_Employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
