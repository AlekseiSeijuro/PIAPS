using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8client
{
    class Controller : ControllerI
    {
        FormI view;
        MyCom.MyComI solver;
        public Controller()
        {
            solver = new MyCom.MyCom();
            view = new Form1();
            view.addHtgButtonListener(htgHandler);
            view.addPowOf2ButtonListener(powOf2Handler);
            view.addBiggestSideButtonListener(biggestSideHandler);

            Application.Run((Form1)view);
        }

        public void htgHandler(object sender, EventArgs e){
            string htg = solver.htg(view.getHtgInput()).ToString();
            view.showHtg(htg);
        }
        public void powOf2Handler(object sender, EventArgs e)
        {
            string powOf2 = solver.powOf2(view.getPowOf2Input()).ToString();
            view.showPowOf2(powOf2);
        }
        public void biggestSideHandler(object sender, EventArgs e)
        {
            Point[] points = view.getPointsInput();
            string biggestSide = solver.biggestSide(points[0], points[1], points[2]);
            view.showBiggestSide(biggestSide);
        }

    }
}
