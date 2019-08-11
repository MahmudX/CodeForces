using System;
using System.Linq;

namespace NextRound
{
    class Program
    {
        public static void Main()
        {
            char[] userInput = Console.ReadLine().ToCharArray();
            bool log = false;
            if (userInput.Length < 7)
            {
                Console.WriteLine("NO");
            }
            else
            {
                int[] players = new int[userInput.Length];
                for (int i = 0; i < players.Length; i++)
                {
                    players[i] = int.Parse(userInput[i].ToString());
                }
                if (players.Length == 7)
                {
                    if (players.Sum() == 7 || players.Sum() == 0)
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
                    for (int i = 0; i < players.Length - 6; i++)
                    {
                        int x = players[i] + players[i + 1] + players[i + 2] + players[i + 3] +
                            players[i + 4] + players[i + 5] + players[i + 6];
                        if (x == 7 || x == 0)
                        {
                            log = true;
                        }
                    }
                    if (log)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
