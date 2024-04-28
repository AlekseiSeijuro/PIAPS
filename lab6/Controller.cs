using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab6
{

    class Controller : ControllerI
    {
        int WATCHINGFLIGHTS = 1;
        int WATCHINGPLACES = 2;


        Form1I view;
        FlightService.MyFlightsServiceSoap service;
        Flight[] flightsNow;
        Place[] placesNow;
        Flight pickedFlight;
        int state;

        public Controller()
        {
            view = new Form1();
            view.addSelectAllListener(selectAll);
            view.addSelectButton(selectWhere);
            view.addGridCellClickListener(selectPlaces);
            view.addBuyListener(buy);

            service = new FlightService.MyFlightsServiceSoapClient();
            FlightService.Flight[] flights = service.getFlights();
            Flight[] fl = new Flight[flights.Length];
            FlightForView[] flv = new FlightForView[flights.Length];
            for (int i = 0; i < flights.Length; i++)
            {
                fl[i] = new Flight(flights[i].id, flights[i].from, flights[i].to, flights[i].durationMinutes, flights[i].startTime);
                flv[i]=new FlightForView(flights[i].from, flights[i].to, flights[i].durationMinutes, flights[i].startTime);
            }
            flightsNow = fl;
            state = WATCHINGFLIGHTS;
            view.showFlights(flv);
            Application.Run((Form1)view);
        }

        public void selectAll(object sender, EventArgs e)
        {
            FlightService.Flight[] flights = service.getFlights();
            Flight[] fl = new Flight[flights.Length];
            FlightForView[] flv = new FlightForView[flights.Length];
            for (int i=0; i < flights.Length; i++){
                fl[i] = new Flight(flights[i].id, flights[i].from, flights[i].to, flights[i].durationMinutes, flights[i].startTime);
                flv[i] = new FlightForView(flights[i].from, flights[i].to, flights[i].durationMinutes, flights[i].startTime);
            }
            flightsNow = fl;
            state = WATCHINGFLIGHTS;
            view.showFlights(flv);

        }

        public void selectWhere(object sender, EventArgs e)
        {
            FlightService.Flight[] flights = service.getFlights().Where(f=> f.from==view.getFromInput() && f.to == view.getToInput()).ToArray();
            Flight[] fl = new Flight[flights.Length];
            FlightForView[] flv = new FlightForView[flights.Length];
            for (int i = 0; i < flights.Length; i++)
            {
                fl[i] = new Flight(flights[i].id, flights[i].from, flights[i].to, flights[i].durationMinutes, flights[i].startTime);
                flv[i] = new FlightForView(flights[i].from, flights[i].to, flights[i].durationMinutes, flights[i].startTime);
            }
            flightsNow = fl;
            state = WATCHINGFLIGHTS;
            view.showFlights(flv);
        }

        public void selectPlaces(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && state==WATCHINGFLIGHTS)
            {
                pickedFlight = flightsNow[e.RowIndex];

                FlightService.Place[] places=service.getPlacesOn(flightsNow[e.RowIndex].id);
                Place[] pl = new Place[places.Length];
                PlaceForView[] plv = new PlaceForView[places.Length];
                for (int i = 0; i < places.Length; i++)
                {
                    pl[i] = new Place(places[i].FlightId, places[i].placeNumber, places[i].price, places[i].id);
                    plv[i] = new PlaceForView(places[i].FlightId, places[i].placeNumber, places[i].price);
                }
                placesNow = pl;
                state = WATCHINGPLACES;
                view.showPlaces(plv);
            }
            
        }

        public void buy(object sender, EventArgs e)
        {
            Place buyPlace=null;
            for (int i=0; i<placesNow.Length; i++)
            {
                if (placesNow[i].placeNumber.ToString() == view.getBuyInput())
                {
                    buyPlace = placesNow[i];
                    break;
                }
            }
            if (buyPlace != null)
            {
                bool succes=service.buyTicketOn(buyPlace.id);
                if (succes)
                {
                    view.showTicket(new Ticket(pickedFlight.from, pickedFlight.to, pickedFlight.durationMinutes, pickedFlight.startTime, buyPlace.placeNumber, buyPlace.price));
                }
            }
            
        }

    }
}
