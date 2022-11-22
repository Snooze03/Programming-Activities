using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment
{
    public partial class FRM_StudentInfo : Form
    {
        public OdbcConnection connection = new OdbcConnection();
        public OdbcCommand cmd = new OdbcCommand();
        public OdbcDataReader dr1, dr2;
        public OdbcDataAdapter da;


        // public DataTable dt = new DataTable();
        // public DataSet ds = new DataSet();


        public FRM_StudentInfo()
        {
            InitializeComponent();

            connection.Close();
            connection.ConnectionString = "DRIVER={MySQL ODBC 5.1 Unicode Driver};Server=localhost;Port=3306;DATABASE=enrollment;uId=root;pwd=root;OPTION=3;";
            connection.Open();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
