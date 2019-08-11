using System;
namespace LuminousCorp
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string hulkFeeling = "I hate";
            for (int i = 0; i < n - 1; i++)
            {
                if (i % 2 != 0)
                {
                    hulkFeeling += " that I hate";
                }
                else
                {
                    hulkFeeling += " that I love";
                }
            }
            hulkFeeling += " it";
            Console.WriteLine(hulkFeeling);
            Console.ReadLine();
        }
    }
}
