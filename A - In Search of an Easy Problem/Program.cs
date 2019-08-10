using System;
using System.Collections.Generic;
namespace TestConsole
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] sarr = Console.ReadLine().Split(' ');
            int a = 0;
            foreach (var item in sarr)
            {
                a = a + int.Parse(item);
            }
            if (a == 0)
            {
                Console.WriteLine("EASY");
            }
            else
            {
                Console.WriteLine("HARD");
            }
        }
    }
}