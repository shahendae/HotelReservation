using HotelReservationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationWeb.Repository
{
    public interface IGuestRepository
    {
        public void AddNewGuest(Guest guest);
        public Guest FindGuestById(int id);
    }
}
