using System;
namespace CodeForces
{
    class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            if (a > 2)
            {
                var c = a % 2;
                if (c == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}