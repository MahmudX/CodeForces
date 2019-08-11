using System;
namespace BitPP
{
    class Program
    {
        public static void Main()
        {
            int x = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s == "++X" || s == "X++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
