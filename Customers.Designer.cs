namespace WattsALoan1
{
    partial class FRM_Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DS_Customers = new System.Data.DataSet();
            this.TBL_Customer = new System.Data.DataTable();
            this.COL_AccountNumber = new System.Data.DataColumn();
            this.COL_FirstName = new System.Data.DataColumn();
            this.COL_LastName = new System.Data.DataColumn();
            this.COL_EmailAddress = new System.Data.DataColumn();
            this.COL_PhoneNumber = new System.Data.DataColumn();
            this.COL_CustomersDetails = new System.Data.DataColumn();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_CLose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_Customers
            // 
            this.DS_Customers.DataSetName = "Customers";
            this.DS_Customers.Tables.AddRange(new System.Data.DataTable[] {
            this.TBL_Customer});
            // 
            // TBL_Customer
            // 
            this.TBL_Customer.Columns.AddRange(new System.Data.DataColumn[] {
            this.COL_AccountNumber,
            this.COL_FirstName,
            this.COL_LastName,
            this.COL_EmailAddress,
            this.COL_PhoneNumber,
            this.COL_CustomersDetails});
            this.TBL_Customer.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "AccountNumber"}, false)});
            this.TBL_Customer.TableName = "Customer";
            // 
            // COL_AccountNumber
            // 
            this.COL_AccountNumber.AllowDBNull = false;
            this.COL_AccountNumber.ColumnName = "AccountNumber";
            // 
            // COL_FirstName
            // 
            this.COL_FirstName.ColumnName = "FirstName";
            // 
            // COL_LastName
            // 
            this.COL_LastName.AllowDBNull = false;
            this.COL_LastName.ColumnName = "LastName";
            // 
            // COL_EmailAddress
            // 
            this.COL_EmailAddress.ColumnName = "EmailAddress";
            // 
            // COL_PhoneNumber
            // 
            this.COL_PhoneNumber.ColumnName = "PhoneNumber";
            // 
            // COL_CustomersDetails
            // 
            this.COL_CustomersDetails.ColumnName = "CustomerDetails";
            this.COL_CustomersDetails.Expression = "AccountNumber + \': \' + FirstName + \' \' + LastName";
            this.COL_CustomersDetails.ReadOnly = true;
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.AutoGenerateColumns = false;
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.CustomerDetails});
            this.DGV_Customers.DataMember = "Customer";
            this.DGV_Customers.DataSource = this.DS_Customers;
            this.DGV_Customers.Location = new System.Drawing.Point(13, 13);
            this.DGV_Customers.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.Size = new System.Drawing.Size(913, 406);
            this.DGV_Customers.TabIndex = 0;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account #";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone #";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.DataPropertyName = "CustomerDetails";
            this.CustomerDetails.HeaderText = "Customer Details";
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.ReadOnly = true;
            this.CustomerDetails.Width = 200;
            // 
            // BTN_CLose
            // 
            this.BTN_CLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLose.Location = new System.Drawing.Point(790, 436);
            this.BTN_CLose.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CLose.Name = "BTN_CLose";
            this.BTN_CLose.Size = new System.Drawing.Size(136, 43);
            this.BTN_CLose.TabIndex = 2;
            this.BTN_CLose.Text = "Close";
            this.BTN_CLose.UseVisualStyleBackColor = true;
            this.BTN_CLose.Click += new System.EventHandler(this.BTN_CLose_Click);
            // 
            // FRM_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 499);
            this.Controls.Add(this.BTN_CLose);
            this.Controls.Add(this.DGV_Customers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Customers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watts a Loan - Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customers_FormClosing);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet DS_Customers;
        private System.Data.DataTable TBL_Customer;
        private System.Data.DataColumn COL_AccountNumber;
        private System.Data.DataColumn COL_FirstName;
        private System.Data.DataColumn COL_LastName;
        private System.Data.DataColumn COL_EmailAddress;
        private System.Data.DataColumn COL_PhoneNumber;
        private System.Data.DataColumn COL_CustomersDetails;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.Button BTN_CLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerDetails;
    }
}