using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace MyCom
{
    [Guid("EDA5DF22-A8A8-4B22-ADCA-FF607AECA937"),
        ClassInterface(ClassInterfaceType.None),
        ComSourceInterfaces(typeof(MyComEvents))]
    public class MyCom : MyComI
    {
        public double htg(double x)
        {
            
            return (Pow(E, x) - Pow(Math.E, (-x))) / (Pow(Math.E, x) + Pow(Math.E, (-x)));
        }

        public long powOf2(int x)
        {
            if (x == 0) return 1;
            else return 2 * powOf2(x - 1);
        }

        public string biggestSide(Point A, Point B, Point C)
        {
            double AB = Sqrt(Pow(A.X - B.X, 2) + Pow(A.Y - B.Y, 2));
            double AC = Sqrt(Pow(A.X - C.X, 2) + Pow(A.Y - C.Y, 2));
            double BC = Sqrt(Pow(B.X - C.X, 2) + Pow(B.Y - C.Y, 2));

            if ((AB >= AC) && (AB >= BC)) return "AB";
            else if ((AC >= AB) && (AC >= BC)) return "AC";
            else  return "BC";
        }

    }
}
