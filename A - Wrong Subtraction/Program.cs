using System;
namespace TestConsole
{
    class Program
    {
        public static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(' ');
            int a = int.Parse(inputArr[0]);
            int b = int.Parse(inputArr[1]);
 
            for (int i = 0; i < b; i++)
            {
 
                if (a % 10 != 0)
                {
                    a = --a;
                }
                else
                {
                    a = a / 10;
                }
            }
            Console.WriteLine(a);
        }
    }
}