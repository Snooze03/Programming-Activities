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
    public partial class FRM_Customers : Form
    {
        public FRM_Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            string fileName = "customers.xml";

            if (File.Exists(fileName))
            {
                DS_Customers.ReadXml(fileName);
            }
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DS_Customers.WriteXml("customers.xml");
        }

        private void BTN_CLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
