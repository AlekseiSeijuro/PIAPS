using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Flight
    {
        public int id;
        public string from;
        public string to;
        public int durationMinutes;
        public DateTime startTime;

        public Flight(int id, string from, string to, int durationMinutes, DateTime startTime)
        {
            this.id = id;
            this.from = from;
            this.to = to;
            this.durationMinutes = durationMinutes;
            this.startTime = startTime;
        }
    }
}
