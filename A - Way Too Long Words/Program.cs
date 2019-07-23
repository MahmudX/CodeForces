using System;

namespace Codeforces
{
    class Program
    {
        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            string[] words = new string[x];
            for (int i = 0; i < x; i++)
            {
                words[i] = Console.ReadLine();
            }

            foreach (var item in words)
            {
                char[] charArr = item.ToCharArray();
                if (charArr.Length > 10)
                {
                    int n = charArr.Length - 2;
                    Console.WriteLine(charArr[0].ToString() + n +
        charArr[charArr.Length - 1].ToString());
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}