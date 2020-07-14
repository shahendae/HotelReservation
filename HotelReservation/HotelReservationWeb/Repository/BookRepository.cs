using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationWeb.Models;

namespace HotelReservationWeb.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly HotelReservationContext _context;

        public BookRepository(HotelReservationContext context)
        {
            _context = context;
        }
        public void AddNewReservation(Booking booking)
        {
            _context.Booking.Add(new Booking()
            {
                CheckIn = booking.CheckIn,
                CheckOut = booking.CheckOut,
                GuestId = booking.GuestId,
                RoomId = booking.RoomId
            });
            _context.SaveChanges();
        }
    }
}
