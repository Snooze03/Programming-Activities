namespace WattsALoan1
{
    partial class FRM_Payments
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
            this.DS_Employees = new System.Data.DataSet();
            this.TBL_Employee = new System.Data.DataTable();
            this.COL_EmployeeNumber = new System.Data.DataColumn();
            this.COL_FirstName = new System.Data.DataColumn();
            this.COL_LastName = new System.Data.DataColumn();
            this.COL_Title = new System.Data.DataColumn();
            this.COL_HourlySalary = new System.Data.DataColumn();
            this.COL_EmployeeDetails = new System.Data.DataColumn();
            this.COL_FullName = new System.Data.DataColumn();
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
            this.DS_Payments = new System.Data.DataSet();
            this.TBL_Payment = new System.Data.DataTable();
            this.COL_PaymentNumber = new System.Data.DataColumn();
            this.COL_PaymentDate = new System.Data.DataColumn();
            this.COL_ReceivedBy = new System.Data.DataColumn();
            this.COL_PaymentFor = new System.Data.DataColumn();
            this.COL_PaymentAmount = new System.Data.DataColumn();
            this.COL_Balance = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_CLose = new System.Windows.Forms.Button();
            this.BTN_Loans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_LoanAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Loan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Payments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.COL_FirstName,
            this.COL_LastName,
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
            // COL_FirstName
            // 
            this.COL_FirstName.ColumnName = "FirstName";
            // 
            // COL_LastName
            // 
            this.COL_LastName.AllowDBNull = false;
            this.COL_LastName.ColumnName = "LastName";
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
            // DS_Payments
            // 
            this.DS_Payments.DataSetName = "Payments";
            this.DS_Payments.Tables.AddRange(new System.Data.DataTable[] {
            this.TBL_Payment});
            // 
            // TBL_Payment
            // 
            this.TBL_Payment.Columns.AddRange(new System.Data.DataColumn[] {
            this.COL_PaymentNumber,
            this.COL_PaymentDate,
            this.COL_ReceivedBy,
            this.COL_PaymentFor,
            this.COL_PaymentAmount,
            this.COL_Balance});
            this.TBL_Payment.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "PaymentNumber"}, false)});
            this.TBL_Payment.TableName = "Payment";
            // 
            // COL_PaymentNumber
            // 
            this.COL_PaymentNumber.ColumnName = "PaymentNumber";
            // 
            // COL_PaymentDate
            // 
            this.COL_PaymentDate.ColumnName = "PaymentDate";
            this.COL_PaymentDate.DataType = typeof(System.DateTime);
            // 
            // COL_ReceivedBy
            // 
            this.COL_ReceivedBy.ColumnName = "ReceivedBy";
            // 
            // COL_PaymentFor
            // 
            this.COL_PaymentFor.ColumnName = "PaymentFor";
            // 
            // COL_PaymentAmount
            // 
            this.COL_PaymentAmount.ColumnName = "PaymentAmount";
            this.COL_PaymentAmount.DataType = typeof(double);
            this.COL_PaymentAmount.DefaultValue = 0D;
            // 
            // COL_Balance
            // 
            this.COL_Balance.ColumnName = "Balance";
            this.COL_Balance.DataType = typeof(double);
            this.COL_Balance.DefaultValue = 0D;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentNumberDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.receivedByDataGridViewTextBoxColumn,
            this.paymentForDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Payment";
            this.dataGridView1.DataSource = this.DS_Payments;
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // paymentNumberDataGridViewTextBoxColumn
            // 
            this.paymentNumberDataGridViewTextBoxColumn.DataPropertyName = "PaymentNumber";
            this.paymentNumberDataGridViewTextBoxColumn.HeaderText = "Pmt #";
            this.paymentNumberDataGridViewTextBoxColumn.Name = "paymentNumberDataGridViewTextBoxColumn";
            this.paymentNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.paymentDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Pmt Date";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // receivedByDataGridViewTextBoxColumn
            // 
            this.receivedByDataGridViewTextBoxColumn.DataPropertyName = "ReceivedBy";
            this.receivedByDataGridViewTextBoxColumn.DataSource = this.DS_Employees;
            this.receivedByDataGridViewTextBoxColumn.DisplayMember = "Employee.EmployeeNumber";
            this.receivedByDataGridViewTextBoxColumn.HeaderText = "Processed By";
            this.receivedByDataGridViewTextBoxColumn.Name = "receivedByDataGridViewTextBoxColumn";
            this.receivedByDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receivedByDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.receivedByDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentForDataGridViewTextBoxColumn
            // 
            this.paymentForDataGridViewTextBoxColumn.DataPropertyName = "PaymentFor";
            this.paymentForDataGridViewTextBoxColumn.DataSource = this.DS_LoanAllocation;
            this.paymentForDataGridViewTextBoxColumn.DisplayMember = "Loan.LoanNumber";
            this.paymentForDataGridViewTextBoxColumn.HeaderText = "Payment For";
            this.paymentForDataGridViewTextBoxColumn.Name = "paymentForDataGridViewTextBoxColumn";
            this.paymentForDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentForDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymentForDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.paymentAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "Pmt Amt";
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            this.paymentAmountDataGridViewTextBoxColumn.Width = 130;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.balanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 130;
            // 
            // BTN_CLose
            // 
            this.BTN_CLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLose.Location = new System.Drawing.Point(765, 454);
            this.BTN_CLose.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CLose.Name = "BTN_CLose";
            this.BTN_CLose.Size = new System.Drawing.Size(136, 43);
            this.BTN_CLose.TabIndex = 2;
            this.BTN_CLose.Text = "Close";
            this.BTN_CLose.UseVisualStyleBackColor = true;
            this.BTN_CLose.Click += new System.EventHandler(this.BTN_CLose_Click);
            // 
            // BTN_Loans
            // 
            this.BTN_Loans.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Loans.Location = new System.Drawing.Point(608, 454);
            this.BTN_Loans.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Loans.Name = "BTN_Loans";
            this.BTN_Loans.Size = new System.Drawing.Size(136, 43);
            this.BTN_Loans.TabIndex = 3;
            this.BTN_Loans.Text = "Loans...";
            this.BTN_Loans.UseVisualStyleBackColor = true;
            this.BTN_Loans.Click += new System.EventHandler(this.BTN_Loans_Click);
            // 
            // FRM_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 516);
            this.Controls.Add(this.BTN_Loans);
            this.Controls.Add(this.BTN_CLose);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Payments";
            this.Text = "Payments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payments_FormClosing);
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_LoanAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Loan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Payments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet DS_Employees;
        private System.Data.DataTable TBL_Employee;
        private System.Data.DataColumn COL_EmployeeNumber;
        private System.Data.DataColumn COL_FirstName;
        private System.Data.DataColumn COL_LastName;
        private System.Data.DataColumn COL_Title;
        private System.Data.DataColumn COL_HourlySalary;
        private System.Data.DataColumn COL_EmployeeDetails;
        private System.Data.DataColumn COL_FullName;
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
        private System.Data.DataSet DS_Payments;
        private System.Data.DataTable TBL_Payment;
        private System.Data.DataColumn COL_PaymentNumber;
        private System.Data.DataColumn COL_PaymentDate;
        private System.Data.DataColumn COL_ReceivedBy;
        private System.Data.DataColumn COL_PaymentFor;
        private System.Data.DataColumn COL_PaymentAmount;
        private System.Data.DataColumn COL_Balance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn receivedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTN_CLose;
        private System.Windows.Forms.Button BTN_Loans;
    }
}