using System;
 
namespace MakeProductEqualOne
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
 
            int[] numbers = new int[n];
            double counter = 0;
            int zero = 0;
            int result = 1;
 
            string[] inputs = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(inputs[i]);
                if (numbers[i] <= -1)
                {
                    counter += (numbers[i] * (-1)) - 1;
                    numbers[i] = -1;
 
                }
                else if (numbers[i] >= 1)
                {
                    counter += numbers[i] - 1;
                    numbers[i] = 1;
                }
                else
                {
                    counter++;
                    zero++;
                    numbers[i] = 1;
                }
                result *= numbers[i];
            }
            if (zero == 0 && result == -1)
            {
                counter += 2;
            }
            Console.WriteLine(counter);
        }
    }
}
