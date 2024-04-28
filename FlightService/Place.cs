using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlightsService
{
    public class Place
    {
        public int FlightId { get; set; }
        public int placeNumber { get; set; }
        public int price { get; set; }

        [Key]
        public int id { get; set; }

        public Place()
        {
            this.FlightId = 0;
            this.placeNumber = 0;
            this.price = 0;
        }
    }
}