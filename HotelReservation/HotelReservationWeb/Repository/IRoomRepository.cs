using HotelReservationWeb.Models;
using HotelReservationWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationWeb.Repository
{
    public interface IRoomRepository
    {
        IEnumerable<Room> CheckAvailabileRooms(CheckRooms reservation);
        IEnumerable<Room> CheckAllRooms(CheckRooms reservation);
    }
}
