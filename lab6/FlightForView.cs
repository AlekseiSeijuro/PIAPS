using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class FlightForView
    {
        public string from;
        public string to;
        public int durationMinutes;
        public DateTime startTime;

        public FlightForView(string from, string to, int durationMinutes, DateTime startTime)
        {
            this.from = from;
            this.to = to;
            this.durationMinutes = durationMinutes;
            this.startTime = startTime;
        }
    }
}
