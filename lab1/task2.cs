using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Task2{
    public static void years()
    {
        string yearDescription="";
        for (int i=1900; i<=2000; i++)
        {
            if (i % 4 == 0)
            {
                if ((i % 400 == 0) ||(i % 100 != 0)){
                    yearDescription = "Високосный";
                }
                else
                {
                    yearDescription = "Не високосный";
                }
            }
            else
            {
                yearDescription = "Не високосный";
            }
            Console.WriteLine(i +" "+ yearDescription);

        }
    }

}