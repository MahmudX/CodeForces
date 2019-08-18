using System;
using System.Collections.Generic;

namespace DragonWar
{
    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int s = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            List<Dragon> dragons = new List<Dragon>();
            bool validator = true;

            for (int i = 0; i < n; i++)
            {
                Dragon dragon = new Dragon();
                string[] dragonInput = Console.ReadLine().Split();
                dragon.Strength = int.Parse(dragonInput[0]);
                dragon.Gain = int.Parse(dragonInput[1]);
                dragons.Add(dragon);
            }

            dragons.Sort((x, y) => x.Strength.CompareTo(y.Strength));

            foreach (var item in dragons)
            {
                if (item.Strength < s)
                {
                    s += item.Gain;
                }
                else
                {
                    validator = false;
                    break;
                }
            }
            if (validator)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
    class Dragon
    {
        public int Strength { get; set; }
        public int Gain { get; set; }
    }
}
