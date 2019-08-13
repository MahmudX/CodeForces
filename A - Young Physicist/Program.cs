using System;
namespace YoungPhysicist
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int z = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                x += int.Parse(input[0]);
                y += int.Parse(input[1]);
                z += int.Parse(input[2]);
            }
            string result = "";
            if (x == 0 && y == 0 && z == 0)
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
