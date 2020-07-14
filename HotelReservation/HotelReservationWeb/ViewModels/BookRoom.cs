using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationWeb.Models;
using HotelReservationWeb.ViewModels;

namespace HotelReservationWeb.ViewModels
{
    public class BookRoom
    {
        public Guest guest { get; set; }
        public int RoomId { get; set; }
    }
}
