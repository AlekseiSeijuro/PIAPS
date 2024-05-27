using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8client
{
    interface ControllerI
    {
        void htgHandler(object sender, EventArgs e);
        void powOf2Handler(object sender, EventArgs e);
        void biggestSideHandler(object sender, EventArgs e);
    }
}
