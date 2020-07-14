using System;
using System.Collections.Generic;

namespace HotelReservationWeb.Models
{
    public partial class Guest
    {
        public Guest()
        {
            Booking = new HashSet<Booking>();
        }

        public int GuestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
