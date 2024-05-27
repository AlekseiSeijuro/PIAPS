using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8client
{
    interface FormI
    {
        double getHtgInput();
        int getPowOf2Input();
        Point[] getPointsInput();

        void showHtg(string htg);
        void showPowOf2(string powOf2);
        void showBiggestSide(string biggestSide);

        void addHtgButtonListener(EventHandler handler);
        void addPowOf2ButtonListener(EventHandler handler);
        void addBiggestSideButtonListener(EventHandler handler);

    }
}
