using System;
namespace DominoPilinghs
{
    class Program
    {
        public static void Main()
        {
            string[] userInput = Console.ReadLine().Split();
            int m = int.Parse(userInput[0]);
            int n = int.Parse(userInput[1]);
            int result;
            if ((m * n) % 2 != 0)
            {
                result = ((m * n) - 1) / 2;
            }
            else
            {
                result = (m * n) / 2;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
