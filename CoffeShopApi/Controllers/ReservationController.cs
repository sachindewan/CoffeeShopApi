using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShopApi.Data;
using CoffeShopApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly CoffeeDbContext _coffeeDbContext;

        public ReservationController(CoffeeDbContext coffeeDbContext)
        {
            this._coffeeDbContext = coffeeDbContext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _coffeeDbContext.Reservations.Add(reservation);
            _coffeeDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}