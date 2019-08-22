using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
    START:
        int n = int.Parse(Console.ReadLine());
        int[] profits = new int[n];
        Stopwatch stopwatch = new Stopwatch();
        for (int i = 0; i < n; i++)
        {
            int[] itemArr = Array.ConvertAll(Console.ReadLine().Split(' '),
                arTemp => int.Parse(arTemp));
            int b = itemArr[0];
            int p = itemArr[1];
            int f = itemArr[2];

            int[] priceArr = Array.ConvertAll(Console.ReadLine().Split(' '),
                arTemp => int.Parse(arTemp));
            int h = priceArr[0];
            int c = priceArr[1];

            int profit = 0;
            stopwatch.Start();
            if (b >= 2)
            {
                if (b % 2 != 0)
                {
                    b -= 1;
                }

                if (h > c)
                {
                    if (p * 2 < b)
                    {
                        int temp = (b - (p * 2)) / 2;
                        profit = p * h;

                        if (temp > f)
                        {
                            profit += f * c;
                        }
                        else
                        {
                            profit += temp * c;
                        }
                    }
                    else if (p * 2 > b || p * 2 == b)
                    {
                        profit = (b / 2) * h;
                    }
                }
                else if (c > h)
                {
                    if (f * 2 < b)
                    {
                        int temp = (b - (f * 2)) / 2;
                        profit = f * c;
                        if (temp > p)
                        {
                            profit += p * h;
                        }
                        else
                        {
                            profit += temp * h;
                        }
                    }
                    else if (f * 2 > b || f * 2 == b)
                    {
                        profit = (b / 2) * c;
                    }
                }
                else
                {
                    if (p + f <= b / 2)
                    {
                        profit = (p + f) * c;
                    }
                    else if (p + f > b / 2)
                    {
                        profit = (b / 2) * c;
                    }

                }
            }
            stopwatch.Stop();
            profits[i] = profit;
        }
        foreach (var item in profits)
        {
            Console.WriteLine("Profits :" + item);
        }
        Console.WriteLine("Time Taken :" + stopwatch.Elapsed);

        Console.ReadLine();
        Console.Clear();
        goto START;
    }
}