using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class PlaceForView
    {
        public int FlightId;
        public int placeNumber;
        public int price;

        public PlaceForView(int FlightId, int placeNumber, int price)
        {
            this.FlightId = FlightId;
            this.placeNumber = placeNumber;
            this.price = price;
        }
    }
}
