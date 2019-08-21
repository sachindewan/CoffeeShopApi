using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShopApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly CoffeeDbContext _coffeeDbContext;

        public MenusController(CoffeeDbContext coffeeDbContext)
        {
            this._coffeeDbContext = coffeeDbContext;
        }
        [HttpGet]
        public IActionResult GetMenuResult()
        {
            var menus = _coffeeDbContext.Menus.Include(x=>x.SubMenu);
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenuResult(int id)
        {
            var menus = _coffeeDbContext.Menus.Include(x => x.SubMenu).FirstOrDefault(m=>m.Id==id);
            if (menus == null)
            {
                return NotFound();
            }
            return Ok(menus);
        }
    }
}