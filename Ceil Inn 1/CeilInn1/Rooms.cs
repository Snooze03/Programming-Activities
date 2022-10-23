using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Runtime.Serialization.Formatters.Binary;

namespace CeilInn1
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void ShowRooms()
        {
            BinaryFormatter bfRooms = new BinaryFormatter();
            Collection<Room> lstRooms = new Collection<Room>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Rooms.rms";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsRooms = new FileStream(strFileName,
                                                               FileMode.Open,
                                                               FileAccess.Read))
                {
                    lstRooms = (Collection<Room>)bfRooms.Deserialize(fsRooms);

                    lvwRooms.Items.Clear();

                    foreach (Room rm in lstRooms)
                    {
                        ListViewItem lviRoom = new ListViewItem(rm.RoomNumber);

                        lviRoom.SubItems.Add(rm.RoomType);
                        lviRoom.SubItems.Add(rm.BedType);
                        lviRoom.SubItems.Add(rm.Rate.ToString("F"));
                        lviRoom.SubItems.Add(rm.OccupancyStatus);

                        lvwRooms.Items.Add(lviRoom);
                    }
                }
            }
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            ShowRooms();
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            RoomEditor editor = new RoomEditor();
            BinaryFormatter bfRooms = new BinaryFormatter();
            Collection<Room> lstRooms = new Collection<Room>();

            string strFileName = @"C:\Microsoft Visual C# Application Design\Ceil Inn\Rooms.rms";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream fsRooms = new FileStream(strFileName,
                                                        FileMode.Open,
                                                        FileAccess.Read))
                {
                    // Store the list of customers in the collection
                    lstRooms = (Collection<Room>)bfRooms.Deserialize(fsRooms);
                }  // Close the file stream
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                Room rm = new Room();

                rm.RoomNumber = editor.txtRoomNumber.Text;
                rm.RoomType = editor.cbxRoomTypes.Text;
                rm.BedType = editor.cbxBedTypes.Text;
                rm.Rate = double.Parse(editor.txtRate.Text);
                rm.OccupancyStatus = editor.cbxOccupanciesStatus.Text;
                lstRooms.Add(rm);

                using (FileStream fsCustomers = new FileStream(strFileName,
                                                            FileMode.Create,
                                                            FileAccess.Write))
                {
                    // Serialize the list of properties
                    bfRooms.Serialize(fsCustomers, lstRooms);
                }

                // Show the list of properties
                ShowRooms();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
