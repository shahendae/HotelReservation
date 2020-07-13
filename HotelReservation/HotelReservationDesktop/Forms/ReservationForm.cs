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
    public partial class ReservationForm : Form
    {
        HotelReservationEntities db;
        public ReservationForm()
        {
            InitializeComponent();
            db = new HotelReservationEntities();
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            if (FirstNametextBox.Text != "" && LastNametextBox.Text != ""
                && PhonetextBox.Text != "" && EmailtextBox.Text != "")
            {
                int GuestNationalId = Convert.ToInt32(SearchtextBox.Text);
                Guest guest = db.Guests.Find(GuestNationalId);
                if (guest == null)
                {
                    Guest newGuest = new Guest()
                    {
                        GuestId = GuestNationalId,
                        FirstName = FirstNametextBox.Text,
                        LastName = LastNametextBox.Text,
                        Phone = PhonetextBox.Text,
                        Email = EmailtextBox.Text
                    };
                    db.Guests.Add(newGuest);
                }

                Booking newBooking = new Booking()
                {
                    CheckIn = ChecKInTimePicker.Value,
                    CheckOut = CheckOutTimePicker.Value,
                    GuestId = GuestNationalId,
                    RoomId = Convert.ToInt32(RoomNumbercomboBox.SelectedValue)
                };
                db.Bookings.Add(newBooking);
                db.SaveChanges();
                MessageBox.Show("Booking Done Successfully", "New Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utilities.ClearControls(this);
            }
            else
            {
                MessageBox.Show("Cannot Add Empty Values", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchtextBox.Text != "")
            {
                int GuestNationalId = Convert.ToInt32(SearchtextBox.Text);
                Guest guest = db.Guests.Find(GuestNationalId);
                if (guest != null)
                {
                    FirstNametextBox.Text = guest.FirstName;
                    LastNametextBox.Text = guest.LastName;
                    PhonetextBox.Text = guest.Phone;
                    EmailtextBox.Text = guest.Email;
                }
            }
            else
            {
                MessageBox.Show("you MUST enter Guest National ID", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            RoomTypecomboBox.DataSource = db.RoomTypes.ToList();
            RoomTypecomboBox.ValueMember = "TypeId";
            RoomTypecomboBox.DisplayMember = "TypeName";

            int RoomTypeId = int.Parse(RoomTypecomboBox.SelectedValue.ToString());
            var Rooms = db.Rooms.Where(r => r.TypeId == RoomTypeId).ToList();
            RoomNumbercomboBox.DisplayMember = "RoomId";
            RoomNumbercomboBox.ValueMember = "RoomId";
            RoomNumbercomboBox.DataSource = Rooms;
        }

        private void RoomTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            RoomNumbercomboBox.DataSource = null;
            RoomNumbercomboBox.Items.Clear();
            FloortextBox.Text = "";
            PricetextBox.Text = "";
            ViewtextBox.Text = "";
            int OutValue;
            int RoomTypeId;
            if (int.TryParse(comboBox.SelectedValue.ToString(), out OutValue))
            {
                RoomTypeId = Convert.ToInt32(comboBox.SelectedValue.ToString());
                var Rooms = db.Rooms.Where(r => r.TypeId == RoomTypeId && r.Bookings.All(b => b.CheckIn > CheckOutTimePicker.Value || b.CheckOut < ChecKInTimePicker.Value)).ToList();
                RoomNumbercomboBox.DisplayMember = "RoomId";
                RoomNumbercomboBox.ValueMember = "RoomId";
                RoomNumbercomboBox.DataSource = Rooms;

            }
        }

        private void RoomNumbercomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int roomNumber = int.Parse(comboBox.SelectedValue.ToString());
            Room room = db.Rooms.Find(roomNumber);
            FloortextBox.Text = room.FloorNo.ToString();
            PricetextBox.Text = room.Price.ToString();
            ViewtextBox.Text = room.View;
        }
    }
}
