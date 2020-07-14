using HotelReservationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationWeb.Repository
{
    public interface IGuestRepository
    {
        void AddNewGuest(Guest guest);
        Guest FindGuestById(int id);
    }
}
