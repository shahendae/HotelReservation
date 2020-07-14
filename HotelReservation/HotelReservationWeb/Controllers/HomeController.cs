using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelReservationWeb.Models;
using HotelReservationWeb.Repository;
using HotelReservationWeb.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelReservationWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITypeRepository _typeRepository;

        public HomeController(ILogger<HomeController> logger, ITypeRepository typeRepository)
        {
            _logger = logger;
            _typeRepository = typeRepository;
        }

        public IActionResult Index()
        {
            CheckRooms reservation = new CheckRooms()
            {
                RoomTypes = new SelectList(_typeRepository.GetAll(), "TypeId", "TypeName")
            };
            return View(reservation);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
