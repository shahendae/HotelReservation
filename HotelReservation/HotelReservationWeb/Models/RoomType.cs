using System;
using System.Collections.Generic;

namespace HotelReservationWeb.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Room = new HashSet<Room>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int MaxGuestNo { get; set; }

        public virtual ICollection<Room> Room { get; set; }
    }
}
