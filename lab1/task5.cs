using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Task5
{
    public static void eratosfen(int a)
    {
        bool[] m=new bool[a+1];
        m[0] = false;
        for (int i = 1; i <= a; i++) m[i] = true;

        for(int i=2; i<=a/2; i++)
        {
            int now = i*2;
            while (now <= a) {
                m[now] = false;
                now += i;
            }
        }

        for(int i=0; i<=a; i++)
        {
            if (m[i]) Console.WriteLine(i);
        }
    }
}