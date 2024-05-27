using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCom
{
    [InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("7B8FC112-EA7E-448F-A175-161DA3C03316")]
    public interface MyComI
    {
        double htg(double x);
        long powOf2(int i);
        string biggestSide(Point A, Point B, Point C);
    }
}
