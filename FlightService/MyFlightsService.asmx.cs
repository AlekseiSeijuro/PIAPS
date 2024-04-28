using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FlightsService
{
    /// <summary>
    /// Сводное описание для MyFlightsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]

 
    public class MyFlightsService : System.Web.Services.WebService
    {
        [WebMethod]
        public Flight[] getFlights()
        {
            FlightsContext db = new FlightsContext();
            Flight[] flights=db.Flights.ToArray();
            db.Dispose();
            return flights;
        }

        [WebMethod]
        public Place[]  getPlacesOn(int FId)
        {
            FlightsContext db = new FlightsContext();
            Place[] places = db.Places.Where(p => p.FlightId == FId).ToArray();
            db.Dispose();
            return places;
        }

        [WebMethod]
        public bool buyTicketOn(int id)
        {
            FlightsContext db = new FlightsContext();
            Place[] place = db.Places.Where(p => p.id == id).ToArray();

            if (place.Length != 0)
            {
                db.Places.Remove(place[0]);
                db.SaveChanges();

                db.Dispose();
                return true;
            }
            else
            {
                db.Dispose();
                return false;
            }

        }
    }
}
