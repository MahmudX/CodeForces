using System;
 
namespace TestConsole
{
    class Program
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            string[] sarr = s.Split(' ');
            ulong n = ulong.Parse(sarr[0]);
            ulong m = ulong.Parse(sarr[1]);
            ulong a = ulong.Parse(sarr[2]);
            ulong x, y;
            ulong z;
 
            if (a == 1)
            {
                z = m * n;
            }
            else
            {
                if (a < n)
                {
                    if (n % a != 0)
                    {
                        x = (n / a) + 1;
                    }
                    else
                    {
                        x = n / a;
                    }
                }
                else
                {
                    x = 1;
                }
                if (a < m)
                {
                    if (m % a != 0)
                    {
                        y = (m / a) + 1;
                    }
                    else
                    {
                        y = m / a;
                    }
                }
                else
                {
                    y = 1;
                }
                z = x * y;
            }
 
 
            Console.WriteLine(z);
 
        }
    }
}