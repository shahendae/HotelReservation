using HotelReservationDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationDesktop.Forms
{
    public partial class AllReservations : Form
    {
        HotelReservationEntities db;
        public AllReservations()
        {
            InitializeComponent();
            db = new HotelReservationEntities();
        }

        private void AllReservations_Load(object sender, EventArgs e)
        {
            GetBookingData();
        }
        private void GetBookingData()
        {
            ReservationsGridView.Rows.Clear();
            var reservationsList = db.Bookings.Include(r => r.Guest).ToList()
                .OrderByDescending(r => r.BookingId);
            foreach (var reserve in reservationsList)
            {
                ReservationsGridView.Rows.Add(reserve.BookingId, reserve.Guest.FirstName + " " +
                    reserve.Guest.LastName, reserve.CheckIn.ToShortDateString(),
                    reserve.CheckOut.ToShortDateString(), reserve.RoomId, "Cancel");
            }
            Utilities.FormatGridView(ReservationsGridView);
        }

        private void ReservationsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                int bookId = Convert.ToInt32(ReservationsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                var cancelBooking = db.Bookings.Find(bookId);
                db.Bookings.Remove(cancelBooking);
                db.SaveChanges();
                MessageBox.Show("Reservation Cancelled Successfully!", "Cancel Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBookingData();
            }
        }
    }
}
