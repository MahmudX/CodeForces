using System;

namespace SoldierBananas
{
    class Program
    {
        public static void Main()
        {
            int queryNumber = int.Parse(Console.ReadLine());
            string[] results = new string[queryNumber];

            for (int j = 0; j < queryNumber; j++)
            {
                bool cheacker = false;
                int studentNumber = int.Parse(Console.ReadLine());

                int n = studentNumber;

                string[] initialIndexInput = Console.ReadLine().Split();

                if (n < 4)
                {
                    cheacker = false;
                }
                else
                {
                    int[] indexList = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        indexList[i] = int.Parse(initialIndexInput[i]);
                    }

                    // Clockwise
                    // Starts with '1'
                    if (indexList[0] == 1 && indexList[1] == 2 && indexList[n - 1] > 1)
                    {
                        for (int i = 0; i < n - 1; i++)
                        {
                            if (indexList[i] != indexList[i + 1] - 1)
                            {
                                cheacker = true;
                                break;
                            }
                        }
                    }

                    // Starts with 'N'
                    else if (indexList[0] > indexList[n - 1] && indexList[1] == 1)
                    {
                        for (int i = 1; i < n - 1; i++)
                        {
                            if (indexList[i] != indexList[i + 1] - 1)
                            {
                                cheacker = true;
                                break;
                            }
                        }
                    }

                    // Starts with a random int
                    else if (indexList[1] == indexList[0] + 1 && indexList[n - 1] == indexList[0] - 1)
                    {
                        for (int i = 0; i < n - 1; i++)
                        {
                            if (indexList[i + 1] == 1)
                            {
                                continue;
                            }
                            if (indexList[i] != indexList[i + 1] - 1)
                            {
                                cheacker = true;
                                break;
                            }
                        }
                    }

                    // Counter Clockwise 
                    // Starts with 'N'
                    else if (indexList[0] == indexList[1] + 1 && indexList[n - 1] == 1)
                    {
                        for (int i = 0; i < n - 1; i++)
                        {
                            if (indexList[i] != indexList[i + 1] + 1)
                            {
                                cheacker = true;
                                break;
                            }
                        }
                    }

                    // Starts with '1'
                    else if (indexList[0] == 1 && indexList[n - 1] == 2 && indexList[1] > 1)
                    {
                        for (int i = 1; i < n - 1; i++)
                        {
                            if (indexList[i] != indexList[i + 1] + 1)
                            {
                                cheacker = true;
                                break;
                            }
                        }
                    }

                    // Starts with a random int
                    else if (indexList[0] == indexList[1] + 1 && indexList[0] == indexList[n - 1] - 1)
                    {
                        for (int i = 0; i < n - 1; i++)
                        {
                            if (indexList[i] == 1)
                            {
                                continue;
                            }
                            if (indexList[i] != indexList[i + 1] + 1)
                            {
                                cheacker = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        cheacker = true;
                    }
                }

                if (cheacker == false)
                {
                    results[j] = "YES";
                }
                else
                {
                    results[j] = "NO";
                }
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
