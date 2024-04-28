using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Ticket
    {
        public string from;
        public string to;
        public int durationMinutes;
        public DateTime startTime;
        public int placeNumber;
        public int price;

        public Ticket(string from, string to, int durationMinutes, DateTime startTime, int placeNumber, int price)
        {
            this.from = from;
            this.to = to;
            this.durationMinutes = durationMinutes;
            this.startTime = startTime;
            this.placeNumber = placeNumber;
            this.price = price;
        }
    }
}
