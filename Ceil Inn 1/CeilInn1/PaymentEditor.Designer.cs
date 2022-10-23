namespace CeilInn1
{
    partial class PaymentEditor
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
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAccountDetails = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblReceiptNumber = new System.Windows.Forms.Label();
            this.lblRoomOccupiedFrom = new System.Windows.Forms.Label();
            this.dtpFirstDateOccupied = new System.Windows.Forms.DateTimePicker();
            this.dtpLastDateOccupied = new System.Windows.Forms.DateTimePicker();
            this.lblLastDateOccupied = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalNights = new System.Windows.Forms.TextBox();
            this.txtAmountCharged = new System.Windows.Forms.TextBox();
            this.lblAmountCharged = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtPhoneUse = new System.Windows.Forms.TextBox();
            this.lblPhoneUse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Location = new System.Drawing.Point(130, 651);
            this.txtReceiptNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(90, 24);
            this.txtReceiptNumber.TabIndex = 46;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(195, 158);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(92, 24);
            this.txtAccountNumber.TabIndex = 31;
            this.txtAccountNumber.Leave += new System.EventHandler(this.txtAccountNumber_Leave);
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(195, 90);
            this.txtEmployeeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(92, 24);
            this.txtEmployeeNumber.TabIndex = 28;
            this.txtEmployeeNumber.Leave += new System.EventHandler(this.txtEmployeeNumber_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-2, 613);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(512, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "_______________________________________________________________";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(406, 648);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(300, 648);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 32);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtAccountDetails
            // 
            this.txtAccountDetails.Location = new System.Drawing.Point(195, 194);
            this.txtAccountDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountDetails.Name = "txtAccountDetails";
            this.txtAccountDetails.Size = new System.Drawing.Size(298, 24);
            this.txtAccountDetails.TabIndex = 45;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(81, 162);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(78, 18);
            this.lblAccountNumber.TabIndex = 30;
            this.lblAccountNumber.Text = "Account #:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Processed for Customer _____________________________________";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(298, 90);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(194, 24);
            this.txtEmployeeName.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Employee #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Payment Processed by _______________________________________";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(195, 27);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(298, 24);
            this.dtpPaymentDate.TabIndex = 25;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(16, 27);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(105, 18);
            this.lblPaymentDate.TabIndex = 24;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // lblReceiptNumber
            // 
            this.lblReceiptNumber.AutoSize = true;
            this.lblReceiptNumber.Location = new System.Drawing.Point(16, 655);
            this.lblReceiptNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiptNumber.Name = "lblReceiptNumber";
            this.lblReceiptNumber.Size = new System.Drawing.Size(74, 18);
            this.lblReceiptNumber.TabIndex = 40;
            this.lblReceiptNumber.Text = "Receipt #:";
            // 
            // lblRoomOccupiedFrom
            // 
            this.lblRoomOccupiedFrom.AutoSize = true;
            this.lblRoomOccupiedFrom.Location = new System.Drawing.Point(16, 240);
            this.lblRoomOccupiedFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomOccupiedFrom.Name = "lblRoomOccupiedFrom";
            this.lblRoomOccupiedFrom.Size = new System.Drawing.Size(161, 18);
            this.lblRoomOccupiedFrom.TabIndex = 47;
            this.lblRoomOccupiedFrom.Text = "Room Occupied From:";
            // 
            // dtpFirstDateOccupied
            // 
            this.dtpFirstDateOccupied.Location = new System.Drawing.Point(195, 235);
            this.dtpFirstDateOccupied.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFirstDateOccupied.Name = "dtpFirstDateOccupied";
            this.dtpFirstDateOccupied.Size = new System.Drawing.Size(298, 24);
            this.dtpFirstDateOccupied.TabIndex = 48;
            // 
            // dtpLastDateOccupied
            // 
            this.dtpLastDateOccupied.Location = new System.Drawing.Point(195, 277);
            this.dtpLastDateOccupied.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLastDateOccupied.Name = "dtpLastDateOccupied";
            this.dtpLastDateOccupied.Size = new System.Drawing.Size(298, 24);
            this.dtpLastDateOccupied.TabIndex = 50;
            // 
            // lblLastDateOccupied
            // 
            this.lblLastDateOccupied.AutoSize = true;
            this.lblLastDateOccupied.Location = new System.Drawing.Point(147, 277);
            this.lblLastDateOccupied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastDateOccupied.Name = "lblLastDateOccupied";
            this.lblLastDateOccupied.Size = new System.Drawing.Size(30, 18);
            this.lblLastDateOccupied.TabIndex = 49;
            this.lblLastDateOccupied.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Payment _____________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Total Nights:";
            // 
            // txtTotalNights
            // 
            this.txtTotalNights.Location = new System.Drawing.Point(366, 323);
            this.txtTotalNights.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalNights.Name = "txtTotalNights";
            this.txtTotalNights.Size = new System.Drawing.Size(70, 24);
            this.txtTotalNights.TabIndex = 53;
            this.txtTotalNights.Text = "1";
            this.txtTotalNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountCharged
            // 
            this.txtAmountCharged.Location = new System.Drawing.Point(364, 392);
            this.txtAmountCharged.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountCharged.Name = "txtAmountCharged";
            this.txtAmountCharged.Size = new System.Drawing.Size(72, 24);
            this.txtAmountCharged.TabIndex = 55;
            this.txtAmountCharged.Text = "0.00";
            this.txtAmountCharged.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmountCharged
            // 
            this.lblAmountCharged.AutoSize = true;
            this.lblAmountCharged.Location = new System.Drawing.Point(254, 396);
            this.lblAmountCharged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountCharged.Name = "lblAmountCharged";
            this.lblAmountCharged.Size = new System.Drawing.Size(98, 18);
            this.lblAmountCharged.TabIndex = 54;
            this.lblAmountCharged.Text = "Amt Charged:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(348, 510);
            this.txtTaxRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(88, 24);
            this.txtTaxRate.TabIndex = 57;
            this.txtTaxRate.Text = "7.70";
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 513);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tax Rate:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(238, 464);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 32);
            this.btnCalculate.TabIndex = 58;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotalAmountPaid
            // 
            this.txtTotalAmountPaid.Location = new System.Drawing.Point(348, 582);
            this.txtTotalAmountPaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmountPaid.Name = "txtTotalAmountPaid";
            this.txtTotalAmountPaid.Size = new System.Drawing.Size(88, 24);
            this.txtTotalAmountPaid.TabIndex = 62;
            this.txtTotalAmountPaid.Text = "0.00";
            this.txtTotalAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(234, 585);
            this.lblAmountPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(96, 18);
            this.lblAmountPaid.TabIndex = 61;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(348, 546);
            this.txtTaxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(88, 24);
            this.txtTaxAmount.TabIndex = 60;
            this.txtTaxAmount.Text = "0.00";
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(230, 549);
            this.lblTaxAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(91, 18);
            this.lblTaxAmount.TabIndex = 59;
            this.lblTaxAmount.Text = "Tax Amount:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(442, 513);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(21, 18);
            this.lblPercent.TabIndex = 63;
            this.lblPercent.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "/night";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(364, 428);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(72, 24);
            this.txtSubTotal.TabIndex = 66;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(254, 432);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(76, 18);
            this.lblSubTotal.TabIndex = 65;
            this.lblSubTotal.Text = "Sub-Total:";
            // 
            // txtPhoneUse
            // 
            this.txtPhoneUse.Location = new System.Drawing.Point(130, 392);
            this.txtPhoneUse.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneUse.Name = "txtPhoneUse";
            this.txtPhoneUse.Size = new System.Drawing.Size(72, 24);
            this.txtPhoneUse.TabIndex = 68;
            this.txtPhoneUse.Text = "0.00";
            this.txtPhoneUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhoneUse
            // 
            this.lblPhoneUse.AutoSize = true;
            this.lblPhoneUse.Location = new System.Drawing.Point(20, 396);
            this.lblPhoneUse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneUse.Name = "lblPhoneUse";
            this.lblPhoneUse.Size = new System.Drawing.Size(86, 18);
            this.lblPhoneUse.TabIndex = 67;
            this.lblPhoneUse.Text = "Phone Use:";
            // 
            // PaymentEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(524, 702);
            this.Controls.Add(this.txtPhoneUse);
            this.Controls.Add(this.lblPhoneUse);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtTotalAmountPaid);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtTaxAmount);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmountCharged);
            this.Controls.Add(this.lblAmountCharged);
            this.Controls.Add(this.txtTotalNights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLastDateOccupied);
            this.Controls.Add(this.lblLastDateOccupied);
            this.Controls.Add(this.dtpFirstDateOccupied);
            this.Controls.Add(this.lblRoomOccupiedFrom);
            this.Controls.Add(this.txtReceiptNumber);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAccountDetails);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblReceiptNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceil Inn - Payment Editor";
            this.Load += new System.EventHandler(this.PaymentEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAccountNumber;
        public System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox txtAccountDetails;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblReceiptNumber;
        private System.Windows.Forms.Label lblRoomOccupiedFrom;
        private System.Windows.Forms.Label lblLastDateOccupied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountCharged;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPhoneUse;
        public System.Windows.Forms.TextBox txtReceiptNumber;
        public System.Windows.Forms.TextBox txtPhoneUse;
        public System.Windows.Forms.DateTimePicker dtpFirstDateOccupied;
        public System.Windows.Forms.DateTimePicker dtpLastDateOccupied;
        public System.Windows.Forms.TextBox txtTotalNights;
        public System.Windows.Forms.TextBox txtAmountCharged;
        public System.Windows.Forms.TextBox txtTaxRate;
        public System.Windows.Forms.TextBox txtTotalAmountPaid;
        public System.Windows.Forms.TextBox txtTaxAmount;
        public System.Windows.Forms.TextBox txtSubTotal;

    }
}