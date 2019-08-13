using System;
namespace PetyaandStrings
{
    class Program
    {
        public static void Main()
        {
            char[] firstCharArr = Console.ReadLine().ToLower().ToCharArray();
            char[] secondCharArr = Console.ReadLine().ToLower().ToCharArray();

            int result = 0;

            for (int i = 0; i < firstCharArr.Length; i++)
            {
                if (GetValue(firstCharArr[i]) < GetValue(secondCharArr[i]))
                {
                    result = -1;
                    break;
                }
                else if (GetValue(firstCharArr[i]) > GetValue(secondCharArr[i]))
                {
                    result = 1;
                    break;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int GetValue(char character)
        {
            int result = 0;
            switch (character)
                {
                    case 'a':
                        result = 1;
                        break;
                    case 'b':
                        result = 2;
                        break;
                    case 'c':
                        result = 3;
                        break;
                    case 'd':
                        result = 4;
                        break;
                    case 'e':
                        result = 5;
                        break;
                    case 'f':
                        result = 6;
                        break;
                    case 'g':
                        result = 7;
                        break;
                    case 'h':
                        result = 8;
                        break;
                    case 'i':
                        result = 9;
                        break;
                    case 'j':
                        result = 10;
                        break;
                    case 'k':
                        result = 11;
                        break;
                    case 'l':
                        result = 12;
                        break;
                    case 'm':
                        result = 13;
                        break;
                    case 'n':
                        result = 14;
                        break;
                    case 'o':
                        result = 15;
                        break;
                    case 'p':
                        result = 16;
                        break;
                    case 'q':
                        result = 17;
                        break;
                    case 'r':
                        result = 18;
                        break;
                    case 's':
                        result = 19;
                        break;
                    case 't':
                        result = 20;
                        break;
                    case 'u':
                        result = 21;
                        break;
                    case 'v':
                        result = 22;
                        break;
                    case 'w':
                        result = 23;
                        break;
                    case 'x':
                        result = 24;
                        break;
                    case 'y':
                        result = 25;
                        break;
                    case 'z':
                        result = 26;
                        break;
                    default:
                        break;
            }
            return result;
        }
    }
}
