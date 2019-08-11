using System;
namespace NextRound
{
    class Program
    {
        public static void Main()
        {
            string[] userInput = Console.ReadLine().Split();
            string[] perScores = Console.ReadLine().Split();

            int n = int.Parse(userInput[0]);
            int k = int.Parse(userInput[1]);
            int x = int.Parse(perScores[k - 1]);
            int counter = 0;

            foreach (var item in perScores)
            {
                int j = int.Parse(item);
                if (j > 0 && j >= x)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
