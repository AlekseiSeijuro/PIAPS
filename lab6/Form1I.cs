using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    interface Form1I
    {
        void showFlights(FlightForView[] flv);
        void showPlaces(PlaceForView[] plv);
        void showTicket(Ticket t);
        void addSelectAllListener(EventHandler handler);
        void addSelectButton(EventHandler handler);
        void addBuyListener(EventHandler handler);
        void addGridCellClickListener(DataGridViewCellEventHandler handler);
        string getFromInput();
        string getToInput();
        string getBuyInput();
    }
}
