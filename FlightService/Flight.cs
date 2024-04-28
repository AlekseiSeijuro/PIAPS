using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlightsService
{
    public class Flight
    {
        [Key]
        public int id { get; set; }

        public string from { get; set; }
        public string to { get; set; }
        public int durationMinutes { get; set; }
        public DateTime startTime { get; set; }

        public Flight()
        {
            this.id = 0;
            this.from = "Nothing";
            this.to = "Nothing";
            this.durationMinutes = 0;
            this.startTime = DateTime.Now;
        }
    }
}