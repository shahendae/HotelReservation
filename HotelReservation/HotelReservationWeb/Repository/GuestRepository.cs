using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationWeb.Models;

namespace HotelReservationWeb.Repository
{
    public class GuestRepository : IGuestRepository
    {
        private readonly HotelReservationContext _context;
        public GuestRepository(HotelReservationContext context)
        {
            _context = context;
        }
        public Guest FindGuestById(int id)
        {
            return _context.Guest.Find(id);
        }
        public void AddNewGuest(Guest guest)
        {
            _context.Guest.Add(new Guest()
            {
                GuestId = guest.GuestId,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Phone = guest.Phone,
                Email = guest.Email
            });

            _context.SaveChanges();
        }
    }
}
