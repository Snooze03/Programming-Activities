namespace CeilInn1
{
    partial class Rooms
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.lvwRooms = new System.Windows.Forms.ListView();
            this.colRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBedType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOccupancyStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsRooms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuNewRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRoomDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(371, 400);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(212, 400);
            this.btnNewRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(150, 32);
            this.btnNewRoom.TabIndex = 7;
            this.btnNewRoom.Text = "New Room...";
            this.btnNewRoom.UseVisualStyleBackColor = true;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // lvwRooms
            // 
            this.lvwRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomNumber,
            this.colRoomType,
            this.colBedType,
            this.colRate,
            this.colOccupancyStatus});
            this.lvwRooms.ContextMenuStrip = this.cmsRooms;
            this.lvwRooms.FullRowSelect = true;
            this.lvwRooms.GridLines = true;
            this.lvwRooms.HideSelection = false;
            this.lvwRooms.Location = new System.Drawing.Point(18, 19);
            this.lvwRooms.Margin = new System.Windows.Forms.Padding(4);
            this.lvwRooms.Name = "lvwRooms";
            this.lvwRooms.Size = new System.Drawing.Size(465, 358);
            this.lvwRooms.TabIndex = 6;
            this.lvwRooms.UseCompatibleStateImageBehavior = false;
            this.lvwRooms.View = System.Windows.Forms.View.Details;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.Text = "Room #";
            this.colRoomNumber.Width = 80;
            // 
            // colRoomType
            // 
            this.colRoomType.Text = "Room Type";
            this.colRoomType.Width = 100;
            // 
            // colBedType
            // 
            this.colBedType.Text = "Bed Type";
            this.colBedType.Width = 100;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate";
            this.colRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRate.Width = 80;
            // 
            // colOccupancyStatus
            // 
            this.colOccupancyStatus.Text = "Status";
            this.colOccupancyStatus.Width = 90;
            // 
            // cmsRooms
            // 
            this.cmsRooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewRoom,
            this.mnuInsertRoom,
            this.mnuEditRoomDetails,
            this.mnuDeleteRoom});
            this.cmsRooms.Name = "cmsRooms";
            this.cmsRooms.Size = new System.Drawing.Size(177, 92);
            // 
            // mnuNewRoom
            // 
            this.mnuNewRoom.Name = "mnuNewRoom";
            this.mnuNewRoom.Size = new System.Drawing.Size(176, 22);
            this.mnuNewRoom.Text = "&New Room...";
            // 
            // mnuInsertRoom
            // 
            this.mnuInsertRoom.Enabled = false;
            this.mnuInsertRoom.Name = "mnuInsertRoom";
            this.mnuInsertRoom.Size = new System.Drawing.Size(176, 22);
            this.mnuInsertRoom.Text = "&Insert Room...";
            // 
            // mnuEditRoomDetails
            // 
            this.mnuEditRoomDetails.Enabled = false;
            this.mnuEditRoomDetails.Name = "mnuEditRoomDetails";
            this.mnuEditRoomDetails.Size = new System.Drawing.Size(176, 22);
            this.mnuEditRoomDetails.Text = "&Edit Room Details...";
            // 
            // mnuDeleteRoom
            // 
            this.mnuDeleteRoom.Enabled = false;
            this.mnuDeleteRoom.Name = "mnuDeleteRoom";
            this.mnuDeleteRoom.Size = new System.Drawing.Size(176, 22);
            this.mnuDeleteRoom.Text = "&Delete Room";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 447);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewRoom);
            this.Controls.Add(this.lvwRooms);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceil Inn - Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.cmsRooms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.ListView lvwRooms;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private System.Windows.Forms.ColumnHeader colRoomType;
        private System.Windows.Forms.ColumnHeader colBedType;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colOccupancyStatus;
        private System.Windows.Forms.ContextMenuStrip cmsRooms;
        private System.Windows.Forms.ToolStripMenuItem mnuNewRoom;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertRoom;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRoomDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteRoom;
    }
}