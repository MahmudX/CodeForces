using System;

namespace EvenOddGame
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("Ehab");
            }
            else
            {
                Console.WriteLine("Mahmoud");
            }
            Console.ReadLine();
        }
    }
}
