namespace WattsALoan1
{
    partial class FRM_Employees
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
            this.DS_Employees = new System.Data.DataSet();
            this.TBL_Employee = new System.Data.DataTable();
            this.COL_EmployeeNumber = new System.Data.DataColumn();
            this.COL_FirstName = new System.Data.DataColumn();
            this.COL_LastName = new System.Data.DataColumn();
            this.COL_Title = new System.Data.DataColumn();
            this.COL_HourlySalary = new System.Data.DataColumn();
            this.COL_EmployeeDetails = new System.Data.DataColumn();
            this.COL_FullName = new System.Data.DataColumn();
            this.DVG_Employees = new System.Windows.Forms.DataGridView();
            this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_CLose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Employees)).BeginInit();
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
            // DVG_Employees
            // 
            this.DVG_Employees.AutoGenerateColumns = false;
            this.DVG_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.FullName,
            this.titleDataGridViewTextBoxColumn,
            this.hourlySalaryDataGridViewTextBoxColumn,
            this.employeeDetailsDataGridViewTextBoxColumn});
            this.DVG_Employees.DataMember = "Employee";
            this.DVG_Employees.DataSource = this.DS_Employees;
            this.DVG_Employees.Location = new System.Drawing.Point(18, 17);
            this.DVG_Employees.Margin = new System.Windows.Forms.Padding(4);
            this.DVG_Employees.Name = "DVG_Employees";
            this.DVG_Employees.Size = new System.Drawing.Size(1023, 454);
            this.DVG_Employees.TabIndex = 0;
            this.DVG_Employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_Employees_CellContentClick);
            // 
            // employeeNumberDataGridViewTextBoxColumn
            // 
            this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "Empl #";
            this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
            this.employeeNumberDataGridViewTextBoxColumn.Width = 110;
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
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // hourlySalaryDataGridViewTextBoxColumn
            // 
            this.hourlySalaryDataGridViewTextBoxColumn.DataPropertyName = "HourlySalary";
            this.hourlySalaryDataGridViewTextBoxColumn.HeaderText = "Salary/Hr";
            this.hourlySalaryDataGridViewTextBoxColumn.Name = "hourlySalaryDataGridViewTextBoxColumn";
            this.hourlySalaryDataGridViewTextBoxColumn.Width = 110;
            // 
            // employeeDetailsDataGridViewTextBoxColumn
            // 
            this.employeeDetailsDataGridViewTextBoxColumn.DataPropertyName = "EmployeeDetails";
            this.employeeDetailsDataGridViewTextBoxColumn.HeaderText = "Employee Details";
            this.employeeDetailsDataGridViewTextBoxColumn.Name = "employeeDetailsDataGridViewTextBoxColumn";
            this.employeeDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeDetailsDataGridViewTextBoxColumn.Width = 200;
            // 
            // BTN_CLose
            // 
            this.BTN_CLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLose.Location = new System.Drawing.Point(905, 490);
            this.BTN_CLose.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CLose.Name = "BTN_CLose";
            this.BTN_CLose.Size = new System.Drawing.Size(136, 43);
            this.BTN_CLose.TabIndex = 1;
            this.BTN_CLose.Text = "Close";
            this.BTN_CLose.UseVisualStyleBackColor = true;
            this.BTN_CLose.Click += new System.EventHandler(this.BTN_CLose_Click);
            // 
            // FRM_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 547);
            this.Controls.Add(this.BTN_CLose);
            this.Controls.Add(this.DVG_Employees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Employees";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watts a Loan - Employees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Employees_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Employees)).EndInit();
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
        private System.Windows.Forms.DataGridView DVG_Employees;
        private System.Windows.Forms.Button BTN_CLose;
        private System.Data.DataColumn COL_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlySalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDetailsDataGridViewTextBoxColumn;
    }
}