using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Place
    {
        public int FlightId;
        public int placeNumber;
        public int price;
        public int id;

        public Place(int FlightId, int placeNumber, int price, int id)
        {
            this.FlightId=FlightId;
            this.placeNumber=placeNumber;
            this.price=price;
            this.id=id;
        }
    }
}
