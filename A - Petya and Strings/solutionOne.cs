using System;
namespace PetyaAndStrings
{
    class Program
    {
        public static void Main()
        {
            string firstInput= Console.ReadLine().ToLower();
            string secondInput = Console.ReadLine().ToLower();
            Console.WriteLine(firstInput.CompareTo(secondInput));
            Console.ReadLine();
        }
    }
}