using System;
namespace SoldierBananas
{
    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int w = int.Parse(input[2]);
            int result = 0;

            for (int i = 1; i < w + 1; i++)
            {
                result += k * i;
            }

            if (result > n)
            {
                result = result - n;
            }
            else
            {
                result = 0;

            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
