using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShopApi.Data
{
    public class CoffeeDbContext:DbContext
    {
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> dbContextOptions):base(dbContextOptions)
        {

        }   
        public DbSet<Models.Menu>  Menus { get; set; }
        public DbSet<Models.Reservation> Reservations { get; set; }
    }
}
