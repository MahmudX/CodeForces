using System;
namespace WordCapitalization
{
    class Program
    {
        public static void Main()
        {
            string userInput = Console.ReadLine();
            char a = char.ToUpper(userInput[0]);
            userInput = userInput.Remove(0, 1);
            string result = a.ToString() + userInput;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
