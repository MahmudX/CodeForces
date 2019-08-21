using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] intArr = Array.ConvertAll(Console.ReadLine().Split(' '),
            arTemp => Convert.ToDouble(arTemp));
        double a = 0d;
        foreach (var item in intArr)
        {
            a += item;
        }

        a = a / n;

        Console.WriteLine(String.Format("{0:0.000000000000}", a));
    }
}