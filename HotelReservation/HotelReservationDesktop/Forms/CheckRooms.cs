using HotelReservationDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationDesktop.Forms
{
    public partial class CheckRooms : Form
    {
        HotelReservationEntities db;
        public CheckRooms()
        {
            InitializeComponent();
            db = new HotelReservationEntities();
        }

        private void checkAvailability_Click(object sender, EventArgs e)
        {
            RoomsGridView.Visible = true;
            RoomsGridView.Rows.Clear();
            var roomsList = db.Rooms.Where(r => r.Bookings.All(b => b.CheckIn > CheckOutPicker.Value || b.CheckOut < CheckInPicker.Value)).ToList();
            foreach (Room room in roomsList)
            {
                RoomsGridView.Rows.Add(room.RoomId, room.RoomName, room.FloorNo,
                    room.RoomType.TypeName, room.View, room.Price);
            }
            Utilities.FormatGridView(RoomsGridView);
        }

        private void CheckRooms_Load(object sender, EventArgs e)
        {
            RoomsGridView.Visible = false;

        }
    }
}
