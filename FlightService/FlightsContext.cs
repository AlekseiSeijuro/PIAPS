using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FlightsService
{
    public class FlightsContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Place> Places { get; set; }
    }
}