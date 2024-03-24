using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Task3{
    public static void fibbonachi(int fMax)
    {
        int f1 = 0;
        int f2 = 1;
        while (f1 <= fMax)
        {
            Console.WriteLine(f1);
            int temp = f1;
            f1 = f2;
            f2 += temp;
        }

                    
    }
}