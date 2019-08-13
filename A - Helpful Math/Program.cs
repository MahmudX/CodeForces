using System;
namespace HelpfulMaths
{
    class Program
    {
        public static void Main()
        {
            string[] userInput = Console.ReadLine().Split('+');
            int[] numbers = new int[userInput.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(userInput[i]);
            }
            Array.Sort(numbers);
            string result = String.Join("+", numbers);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
