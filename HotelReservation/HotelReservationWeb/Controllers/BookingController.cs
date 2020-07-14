using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelReservationWeb.ViewModels;
using HotelReservationWeb.Repository;
using HotelReservationWeb.Models;

namespace HotelReservationWeb.Controllers
{
    public class BookingController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IGuestRepository _guestRepository;
        private readonly IBookRepository _bookRepository;
        private static DateTime checkIn = DateTime.Now;
        private static DateTime checkOut = DateTime.Now;


        public BookingController(IRoomRepository roomRepository, 
            IGuestRepository guestRepository, IBookRepository bookRepository)
        {
            _roomRepository = roomRepository;
            _guestRepository = guestRepository;
            _bookRepository = bookRepository;
        }
        public IActionResult Reservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AvailableRooms(CheckRooms model)
        {
            checkIn = model.CheckIn;
            checkOut = model.CheckOut;
            if (ModelState.IsValid)
            {
                var availableRooms = _roomRepository.CheckAvailabileRooms(model);
                return View(availableRooms);
            }
            else if (model.TypeId == 0)
            {
                var availableRooms = _roomRepository.CheckAllRooms(model);
                return View(availableRooms);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public IActionResult AddReservation(BookRoom book)
        {
            if (ModelState.IsValid)
            {
                Guest guest = _guestRepository.FindGuestById(book.guest.GuestId);
                if (guest == null)
                {
                    _guestRepository.AddNewGuest(book.guest);
                }
                Booking newBook = new Booking()
                {
                    CheckIn = checkIn,
                    CheckOut = checkOut,
                    RoomId = book.RoomId,
                    GuestId = book.guest.GuestId
                };

                _bookRepository.AddNewReservation(newBook);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
