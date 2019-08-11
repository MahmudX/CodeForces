using System;
namespace Team
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                int p, v, t;
                string[] vs = Console.ReadLine().Split();
                p = int.Parse(vs[0]);
                v = int.Parse(vs[1]);
                t = int.Parse(vs[2]);
                if (p + v + t >= 2)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
