using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationWeb.Models;
using HotelReservationWeb.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationWeb.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly HotelReservationContext _context;

        public RoomRepository(HotelReservationContext context)
        {
            _context = context;
        }
        public IEnumerable<Room> CheckAvailabileRooms(CheckRooms reservation)
        {
            var roomList = _context.Room
                .Include(r => r.Type)
                .Where(r => r.TypeId == reservation.TypeId && r.Booking.All(b => b.CheckIn > reservation.CheckOut || b.CheckOut < reservation.CheckIn))
                .ToList();
            return roomList;
        }
        public IEnumerable<Room> CheckAllRooms(CheckRooms reservation)
        {
            var roomList = _context.Room
                .Include(r => r.Type)
                .Where(r => r.Booking.All(b => b.CheckIn > reservation.CheckOut || b.CheckOut < reservation.CheckIn))
                .ToList();
            return roomList;
        }
    }
}
