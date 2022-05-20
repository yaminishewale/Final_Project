using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRMS6.Data;
using HouseRentalManagementApp.Models;

namespace HRMS6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        List<Booking> bookings = new List<Booking>()
        {
            new Booking(){BookingId = 1, Address="Bhopal", Amount=3000, Duration=5},
            new Booking(){BookingId = 2,  Address="Bhopal", Amount=3000, Duration=5},
            new Booking(){BookingId = 3,  Address="Bhopal", Amount=3000, Duration=5},
            new Booking(){BookingId = 4,  Address="Bhopal", Amount=3000, Duration=5},
            new Booking(){BookingId = 5,  Address="Bhopal", Amount=3000, Duration=5},
            new Booking(){BookingId = 6,  Address="Bhopal", Amount=3000, Duration=5},
        };

        [HttpGet]
        public IActionResult Gets()
        {
            if (bookings.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(bookings);
        }

        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        {
            var booking = bookings.SingleOrDefault(x => x.BookingId == id);
            if (booking == null)
            {
                return NotFound("No Student Found");
            }
            return Ok(booking);
        }

    }
}
