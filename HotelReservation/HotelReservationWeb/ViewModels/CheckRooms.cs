using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationWeb.ViewModels
{
    public class CheckRooms
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int TypeId { get; set; }
        public SelectList RoomTypes { get; set; }
    }
}
