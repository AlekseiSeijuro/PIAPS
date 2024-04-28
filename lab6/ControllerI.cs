using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    interface ControllerI
    {
        void selectAll(object sender, EventArgs e);
        void selectWhere(object sender, EventArgs e);
        void selectPlaces(object sender, DataGridViewCellEventArgs e);
        void buy(object sender, EventArgs e);
    }
}
