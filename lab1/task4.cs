using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Task4
{
    public static void factr(int a)
    {
        int f = 1;
        for(int i=1; i<=a; i++)
        {
            f *= i;
        }
        Console.WriteLine(f);
    }
}