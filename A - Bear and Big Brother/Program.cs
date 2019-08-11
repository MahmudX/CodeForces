using System;
namespace BearandBigBrother
{
    class Program
    {
        public static void Main()
        {
            string[] weights = Console.ReadLine().Split();
            int limak = int.Parse(weights[0]);
            int bob = int.Parse(weights[1]);
            int years = 0;
            while (limak <= bob)
            {
                limak = limak * 3;
                bob = bob * 2;
                years++;
            }
            Console.WriteLine(years);
            Console.ReadLine();
        }
    }
}
