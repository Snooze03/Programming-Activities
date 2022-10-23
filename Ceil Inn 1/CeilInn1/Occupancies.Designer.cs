namespace CeilInn1
{
    partial class Occupancies
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewOccupancy = new System.Windows.Forms.Button();
            this.lvwOccupancies = new System.Windows.Forms.ListView();
            this.colOccupancyNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateOccupied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessedFor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomOccupied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRateApplied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(916, 514);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewOccupancy
            // 
            this.btnNewOccupancy.Location = new System.Drawing.Point(716, 514);
            this.btnNewOccupancy.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewOccupancy.Name = "btnNewOccupancy";
            this.btnNewOccupancy.Size = new System.Drawing.Size(190, 32);
            this.btnNewOccupancy.TabIndex = 4;
            this.btnNewOccupancy.Text = "New Occupancy...";
            this.btnNewOccupancy.UseVisualStyleBackColor = true;
            this.btnNewOccupancy.Click += new System.EventHandler(this.btnNewOccupancy_Click);
            // 
            // lvwOccupancies
            // 
            this.lvwOccupancies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOccupancyNumber,
            this.colDateOccupied,
            this.colProcessedBy,
            this.colProcessedFor,
            this.colRoomOccupied,
            this.colRateApplied,
            this.colPhoneUse});
            this.lvwOccupancies.FullRowSelect = true;
            this.lvwOccupancies.GridLines = true;
            this.lvwOccupancies.HideSelection = false;
            this.lvwOccupancies.Location = new System.Drawing.Point(20, 18);
            this.lvwOccupancies.Margin = new System.Windows.Forms.Padding(4);
            this.lvwOccupancies.Name = "lvwOccupancies";
            this.lvwOccupancies.Size = new System.Drawing.Size(1008, 476);
            this.lvwOccupancies.TabIndex = 3;
            this.lvwOccupancies.UseCompatibleStateImageBehavior = false;
            this.lvwOccupancies.View = System.Windows.Forms.View.Details;
            this.lvwOccupancies.SelectedIndexChanged += new System.EventHandler(this.lvwOccupancies_SelectedIndexChanged);
            // 
            // colOccupancyNumber
            // 
            this.colOccupancyNumber.Text = "Occupancy #";
            this.colOccupancyNumber.Width = 120;
            // 
            // colDateOccupied
            // 
            this.colDateOccupied.Text = "Date Occupied";
            this.colDateOccupied.Width = 160;
            // 
            // colProcessedBy
            // 
            this.colProcessedBy.Text = "Processed By";
            this.colProcessedBy.Width = 150;
            // 
            // colProcessedFor
            // 
            this.colProcessedFor.Text = "Processed For";
            this.colProcessedFor.Width = 150;
            // 
            // colRoomOccupied
            // 
            this.colRoomOccupied.Text = "Room Occupied";
            this.colRoomOccupied.Width = 200;
            // 
            // colRateApplied
            // 
            this.colRateApplied.Text = "Rate Applied";
            this.colRateApplied.Width = 120;
            // 
            // colPhoneUse
            // 
            this.colPhoneUse.Text = "Phone Use";
            this.colPhoneUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPhoneUse.Width = 100;
            // 
            // Occupancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 559);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewOccupancy);
            this.Controls.Add(this.lvwOccupancies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Occupancies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceil Inn - Occupancies";
            this.Load += new System.EventHandler(this.Occupancies_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewOccupancy;
        private System.Windows.Forms.ListView lvwOccupancies;
        private System.Windows.Forms.ColumnHeader colOccupancyNumber;
        private System.Windows.Forms.ColumnHeader colDateOccupied;
        private System.Windows.Forms.ColumnHeader colProcessedBy;
        private System.Windows.Forms.ColumnHeader colProcessedFor;
        private System.Windows.Forms.ColumnHeader colRoomOccupied;
        private System.Windows.Forms.ColumnHeader colRateApplied;
        private System.Windows.Forms.ColumnHeader colPhoneUse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}