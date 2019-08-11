using System;
namespace Team
{
    class Program
    {
        public static void Main()
        {
            char[] userStr = Console.ReadLine().ToLower().ToCharArray();
            string result = "";
            foreach (var item in userStr)
            {
                if (item != 'a' 
                    && item != 'e' 
                    && item != 'i' 
                    && item != 'o' 
                    && item != 'u'
                    && item != 'y')
                {
                    result += "." + item;
                }
            }Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
