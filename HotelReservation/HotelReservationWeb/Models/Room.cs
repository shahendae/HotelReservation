using System;
using System.Collections.Generic;

namespace HotelReservationWeb.Models
{
    public partial class Room
    {
        public Room()
        {
            Booking = new HashSet<Booking>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int FloorNo { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string View { get; set; }
        public int TypeId { get; set; }

        public virtual RoomType Type { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
