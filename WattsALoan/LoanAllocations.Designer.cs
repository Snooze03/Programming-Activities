namespace WattsALoan1
{
    partial class FRM_LoanAllocations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DS_LoanAllocation = new System.Data.DataSet();
            this.TBL_Loan = new System.Data.DataTable();
            this.COL_DateAllocated = new System.Data.DataColumn();
            this.COL_LoanNumber = new System.Data.DataColumn();
            this.COL_PreparedBy = new System.Data.DataColumn();
            this.COL_PreparedFor = new System.Data.DataColumn();
            this.COL_Principal = new System.Data.DataColumn();
            this.COL_InterestRate = new System.Data.DataColumn();
            this.COL_Periods = new System.Data.DataColumn();
            this.COL_InterestEarned = new System.Data.DataColumn();
            this.COL_FutureValue = new System.Data.DataColumn();
            this.COL_MonthlyPayment = new System.Data.DataColumn();
            this.DS_Customers = new System.Data.DataSet();
            this.TBL_Customer = new System.Data.DataTable();
            this.COL_AccountNumber = new System.Data.DataColumn();
            this.COL_FirstName = new System.Data.DataColumn();
            this.COL_LastName = new System.Data.DataColumn();
            this.COL_EmailAddress = new System.Data.DataColumn();
            this.COL_PhoneNumber = new System.Data.DataColumn();
            this.COL_CustomersDetails = new System.Data.DataColumn();
            this.DS_Employees = new System.Data.DataSet();
            this.TBL_Employee = new System.Data.DataTable();
            this.COL_EmployeeNumber = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.COL_Title = new System.Data.DataColumn();
            this.COL_HourlySalary = new System.Data.DataColumn();
            this.COL_EmployeeDetails = new System.Data.DataColumn();
            this.COL_FullName = new System.Data.DataColumn();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.BTN_CLose = new System.Windows.Forms.Button();
            this.loanNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAllocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.preparedForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.principalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestEarnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futureValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS_LoanAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Loan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_LoanAllocation
            // 
            this.DS_LoanAllocation.DataSetName = "LoanAllocations";
            this.DS_LoanAllocation.Tables.AddRange(new System.Data.DataTable[] {
            this.TBL_Loan});
            // 
            // TBL_Loan
            // 
            this.TBL_Loan.Columns.AddRange(new System.Data.DataColumn[] {
            this.COL_DateAllocated,
            this.COL_LoanNumber,
            this.COL_PreparedBy,
            this.COL_PreparedFor,
            this.COL_Principal,
            this.COL_InterestRate,
            this.COL_Periods,
            this.COL_InterestEarned,
            this.COL_FutureValue,
            this.COL_MonthlyPayment});
            this.TBL_Loan.TableName = "Loan";
            // 
            // COL_DateAllocated
            // 
            this.COL_DateAllocated.ColumnName = "DateAllocated";
            this.COL_DateAllocated.DataType = typeof(System.DateTime);
            // 
            // COL_LoanNumber
            // 
            this.COL_LoanNumber.ColumnName = "LoanNumber";
            // 
            // COL_PreparedBy
            // 
            this.COL_PreparedBy.ColumnName = "PreparedBy";
            // 
            // COL_PreparedFor
            // 
            this.COL_PreparedFor.ColumnName = "PreparedFor";
            // 
            // COL_Principal
            // 
            this.COL_Principal.ColumnName = "Principal";
            this.COL_Principal.DataType = typeof(double);
            // 
            // COL_InterestRate
            // 
            this.COL_InterestRate.ColumnName = "InterestRate";
            this.COL_InterestRate.DataType = typeof(double);
            this.COL_InterestRate.DefaultValue = 8.75D;
            // 
            // COL_Periods
            // 
            this.COL_Periods.ColumnName = "Periods";
            this.COL_Periods.DataType = typeof(double);
            this.COL_Periods.DefaultValue = 36D;
            // 
            // COL_InterestEarned
            // 
            this.COL_InterestEarned.ColumnName = "InterestEarned";
            this.COL_InterestEarned.DataType = typeof(double);
            this.COL_InterestEarned.Expression = "Principal * (InterestRate / 100) * (Periods / 12)";
            this.COL_InterestEarned.ReadOnly = true;
            // 
            // COL_FutureValue
            // 
            this.COL_FutureValue.ColumnName = "FutureValue";
            this.COL_FutureValue.DataType = typeof(double);
            this.COL_FutureValue.Expression = "Principal + InterestEarned";
            this.COL_FutureValue.ReadOnly = true;
            // 
            // COL_MonthlyPayment
            // 
            this.COL_MonthlyPayment.ColumnName = "MonthlyPayment";
            this.COL_MonthlyPayment.DataType = typeof(double);
            this.COL_MonthlyPayment.Expression = "FutureValue / Periods";
            this.COL_MonthlyPayment.ReadOnly = true;
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
            // DS_Employees
            // 
            this.DS_Employees.DataSetName = "Employees";
            this.DS_Employees.Tables.AddRange(new System.Data.DataTable[] {
            this.TBL_Employee});
            // 
            // TBL_Employee
            // 
            this.TBL_Employee.Columns.AddRange(new System.Data.DataColumn[] {
            this.COL_EmployeeNumber,
            this.dataColumn1,
            this.dataColumn2,
            this.COL_Title,
            this.COL_HourlySalary,
            this.COL_EmployeeDetails,
            this.COL_FullName});
            this.TBL_Employee.TableName = "Employee";
            // 
            // COL_EmployeeNumber
            // 
            this.COL_EmployeeNumber.AllowDBNull = false;
            this.COL_EmployeeNumber.ColumnName = "EmployeeNumber";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "FirstName";
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.ColumnName = "LastName";
            // 
            // COL_Title
            // 
            this.COL_Title.ColumnName = "Title";
            // 
            // COL_HourlySalary
            // 
            this.COL_HourlySalary.ColumnName = "HourlySalary";
            this.COL_HourlySalary.DataType = typeof(double);
            this.COL_HourlySalary.DefaultValue = 8.75D;
            // 
            // COL_EmployeeDetails
            // 
            this.COL_EmployeeDetails.ColumnName = "EmployeeDetails";
            this.COL_EmployeeDetails.Expression = "EmployeeNumber + \': \' +FirstName + \' \' + LastName";
            this.COL_EmployeeDetails.ReadOnly = true;
            // 
            // COL_FullName
            // 
            this.COL_FullName.ColumnName = "FullName";
            this.COL_FullName.Expression = "LastName + \',\' + FirstName";
            this.COL_FullName.ReadOnly = true;
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.AutoGenerateColumns = false;
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanNumberDataGridViewTextBoxColumn,
            this.dateAllocatedDataGridViewTextBoxColumn,
            this.preparedByDataGridViewTextBoxColumn,
            this.preparedForDataGridViewTextBoxColumn,
            this.principalDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn,
            this.periodsDataGridViewTextBoxColumn,
            this.interestEarnedDataGridViewTextBoxColumn,
            this.futureValueDataGridViewTextBoxColumn,
            this.monthlyPaymentDataGridViewTextBoxColumn});
            this.DGV_Customers.DataMember = "Loan";
            this.DGV_Customers.DataSource = this.DS_LoanAllocation;
            this.DGV_Customers.Location = new System.Drawing.Point(18, 17);
            this.DGV_Customers.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.Size = new System.Drawing.Size(1383, 474);
            this.DGV_Customers.TabIndex = 0;
            // 
            // BTN_CLose
            // 
            this.BTN_CLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLose.Location = new System.Drawing.Point(1265, 510);
            this.BTN_CLose.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_CLose.Name = "BTN_CLose";
            this.BTN_CLose.Size = new System.Drawing.Size(136, 43);
            this.BTN_CLose.TabIndex = 2;
            this.BTN_CLose.Text = "Close";
            this.BTN_CLose.UseVisualStyleBackColor = true;
            this.BTN_CLose.Click += new System.EventHandler(this.BTN_CLose_Click);
            // 
            // loanNumberDataGridViewTextBoxColumn
            // 
            this.loanNumberDataGridViewTextBoxColumn.DataPropertyName = "LoanNumber";
            this.loanNumberDataGridViewTextBoxColumn.HeaderText = "Loan #";
            this.loanNumberDataGridViewTextBoxColumn.Name = "loanNumberDataGridViewTextBoxColumn";
            this.loanNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateAllocatedDataGridViewTextBoxColumn
            // 
            this.dateAllocatedDataGridViewTextBoxColumn.DataPropertyName = "DateAllocated";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateAllocatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateAllocatedDataGridViewTextBoxColumn.HeaderText = "Date Allocated";
            this.dateAllocatedDataGridViewTextBoxColumn.Name = "dateAllocatedDataGridViewTextBoxColumn";
            this.dateAllocatedDataGridViewTextBoxColumn.Width = 120;
            // 
            // preparedByDataGridViewTextBoxColumn
            // 
            this.preparedByDataGridViewTextBoxColumn.DataPropertyName = "PreparedBy";
            this.preparedByDataGridViewTextBoxColumn.DataSource = this.DS_Employees;
            this.preparedByDataGridViewTextBoxColumn.DisplayMember = "Employee.EmployeeDetails";
            this.preparedByDataGridViewTextBoxColumn.HeaderText = "Prepared By";
            this.preparedByDataGridViewTextBoxColumn.Name = "preparedByDataGridViewTextBoxColumn";
            this.preparedByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.preparedByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.preparedByDataGridViewTextBoxColumn.Width = 150;
            // 
            // preparedForDataGridViewTextBoxColumn
            // 
            this.preparedForDataGridViewTextBoxColumn.DataPropertyName = "PreparedFor";
            this.preparedForDataGridViewTextBoxColumn.DataSource = this.DS_Customers;
            this.preparedForDataGridViewTextBoxColumn.DisplayMember = "Customer.CustomerDetails";
            this.preparedForDataGridViewTextBoxColumn.HeaderText = "Prepared For";
            this.preparedForDataGridViewTextBoxColumn.Name = "preparedForDataGridViewTextBoxColumn";
            this.preparedForDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.preparedForDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.preparedForDataGridViewTextBoxColumn.Width = 150;
            // 
            // principalDataGridViewTextBoxColumn
            // 
            this.principalDataGridViewTextBoxColumn.DataPropertyName = "Principal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.principalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.principalDataGridViewTextBoxColumn.HeaderText = "Principal";
            this.principalDataGridViewTextBoxColumn.Name = "principalDataGridViewTextBoxColumn";
            this.principalDataGridViewTextBoxColumn.Width = 130;
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.interestRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.interestRateDataGridViewTextBoxColumn.HeaderText = "Rate (%)";
            this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            this.interestRateDataGridViewTextBoxColumn.Width = 120;
            // 
            // periodsDataGridViewTextBoxColumn
            // 
            this.periodsDataGridViewTextBoxColumn.DataPropertyName = "Periods";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.periodsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.periodsDataGridViewTextBoxColumn.HeaderText = "Prd (Months)";
            this.periodsDataGridViewTextBoxColumn.Name = "periodsDataGridViewTextBoxColumn";
            this.periodsDataGridViewTextBoxColumn.Width = 130;
            // 
            // interestEarnedDataGridViewTextBoxColumn
            // 
            this.interestEarnedDataGridViewTextBoxColumn.DataPropertyName = "InterestEarned";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.interestEarnedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.interestEarnedDataGridViewTextBoxColumn.HeaderText = "Interest Earned";
            this.interestEarnedDataGridViewTextBoxColumn.Name = "interestEarnedDataGridViewTextBoxColumn";
            this.interestEarnedDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestEarnedDataGridViewTextBoxColumn.Width = 150;
            // 
            // futureValueDataGridViewTextBoxColumn
            // 
            this.futureValueDataGridViewTextBoxColumn.DataPropertyName = "FutureValue";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.futureValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.futureValueDataGridViewTextBoxColumn.HeaderText = "Future Value";
            this.futureValueDataGridViewTextBoxColumn.Name = "futureValueDataGridViewTextBoxColumn";
            this.futureValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.futureValueDataGridViewTextBoxColumn.Width = 130;
            // 
            // monthlyPaymentDataGridViewTextBoxColumn
            // 
            this.monthlyPaymentDataGridViewTextBoxColumn.DataPropertyName = "MonthlyPayment";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.monthlyPaymentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.monthlyPaymentDataGridViewTextBoxColumn.HeaderText = "Pmt/Month";
            this.monthlyPaymentDataGridViewTextBoxColumn.Name = "monthlyPaymentDataGridViewTextBoxColumn";
            this.monthlyPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthlyPaymentDataGridViewTextBoxColumn.Width = 130;
            // 
            // FRM_LoanAllocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 569);
            this.Controls.Add(this.BTN_CLose);
            this.Controls.Add(this.DGV_Customers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_LoanAllocations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watts a Loan - LoanAllocations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoanAllocations_FormClosing);
            this.Load += new System.EventHandler(this.LoanAllocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_LoanAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Loan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet DS_LoanAllocation;
        private System.Data.DataTable TBL_Loan;
        private System.Data.DataColumn COL_DateAllocated;
        private System.Data.DataColumn COL_LoanNumber;
        private System.Data.DataColumn COL_PreparedBy;
        private System.Data.DataColumn COL_PreparedFor;
        private System.Data.DataColumn COL_Principal;
        private System.Data.DataColumn COL_InterestRate;
        private System.Data.DataColumn COL_Periods;
        private System.Data.DataColumn COL_InterestEarned;
        private System.Data.DataColumn COL_FutureValue;
        private System.Data.DataColumn COL_MonthlyPayment;
        private System.Data.DataSet DS_Customers;
        private System.Data.DataTable TBL_Customer;
        private System.Data.DataColumn COL_AccountNumber;
        private System.Data.DataColumn COL_FirstName;
        private System.Data.DataColumn COL_LastName;
        private System.Data.DataColumn COL_EmailAddress;
        private System.Data.DataColumn COL_PhoneNumber;
        private System.Data.DataColumn COL_CustomersDetails;
        private System.Data.DataSet DS_Employees;
        private System.Data.DataTable TBL_Employee;
        private System.Data.DataColumn COL_EmployeeNumber;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn COL_Title;
        private System.Data.DataColumn COL_HourlySalary;
        private System.Data.DataColumn COL_EmployeeDetails;
        private System.Data.DataColumn COL_FullName;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.Button BTN_CLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAllocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn preparedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn preparedForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestEarnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn futureValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyPaymentDataGridViewTextBoxColumn;
    }
}