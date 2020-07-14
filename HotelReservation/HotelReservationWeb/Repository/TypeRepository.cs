using HotelReservationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationWeb.Repository
{
    public class TypeRepository : ITypeRepository
    {
        private readonly HotelReservationContext _context;

        public TypeRepository(HotelReservationContext context)
        {
            _context = context;
        }
        public IEnumerable<RoomType> GetAll()
        {
            return _context.RoomType.ToList();
        }
    }
}
