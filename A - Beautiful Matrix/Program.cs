using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
    START:


        Stopwatch stopwatch = new Stopwatch();
        int x = 0;
        int y = 0;
        bool val = false;
        int result;

        for (int i = 0; i < 5; i++)
        {
            int[] intArr = Array.ConvertAll(Console.ReadLine().Split(' '),
                arTemp => int.Parse(arTemp));
            stopwatch.Start();
            for (int j = 0; j < 5; j++)
            {
                if (intArr[j] == 1)
                {
                    y = j + 1;
                    x = i + 1;
                    break;
                }
                if (val)
                {
                    break;
                }
            }
            stopwatch.Stop();
        }

        stopwatch.Start();
        if (3 > x)
        {
            x = 3 - x;
        }
        else x -= 3;

        if (3 > y)
        {
            y = 3 - y;
        }
        else y -= 3;

        result = x + y;


        stopwatch.Stop();

        Console.WriteLine("Result: " + result);
        Console.WriteLine("Time Taken :" + stopwatch.Elapsed);
        Console.ReadLine();
        Console.Clear();
        goto START;
    }
}