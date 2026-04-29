using System;

namespace cognizent_GENCNEXT
{
    public class CompareString
    {

        public static void compare(string str1, string str2)
        {
            if (str1.Equals(str2))
            {
                Console.WriteLine("Both input string are equal !!");
            }
            else
            {
                Console.WriteLine("Both input string are not equal !!");
            }
        }
        public static void compareLexicograph(string str1, string str2)
        {
            if (str1.CompareTo(str2) == 0)
            {
                Console.WriteLine("Both input string are equal !!");
            }
            else if (str1.CompareTo(str2) > 0)
            {
                Console.WriteLine("'" + str1 + "' is lexicographically bigger than string '" + str2 + "'");
            }
            else
            {
                Console.WriteLine("'" + str2 + "' is lexicographically bigger than string '" + str1 + "'");
            }
        }
        public static void compareIgnoreCase(string str1, string str2)
        {
            if (string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase) == 0)
            {
                Console.WriteLine("Both input string are equal !!");
            }
            else if (string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase) > 0)
            {
                Console.WriteLine("'" + str1 + "' is lexicographically bigger than string '" + str2 + "'");
            }
            else
            {
                Console.WriteLine("'" + str2 + "' is lexicographically bigger than string '" + str1 + "'");
            }
        }
        public static void Main(string[] args)
        {
            string str1, str2;
            Console.Write("Enter First String : ");
            str1 = Console.ReadLine();
            Console.Write("Enter Second String : ");
            str2 = Console.ReadLine();
            compare(str1, str2);
            compareLexicograph(str1, str2);
            compareIgnoreCase(str1, str2);
        }
    }
}
