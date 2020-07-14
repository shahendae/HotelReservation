using System;
using System.Collections.Generic;

namespace HotelReservationWeb.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }

        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
    }
}
