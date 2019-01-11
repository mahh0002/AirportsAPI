using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class AirportsDataFactory : DbContext
    {
        public AirportsDataFactory(DbContextOptions<AirportsDataFactory> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Flight> Flights { get; set; }
    }
}
