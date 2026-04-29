using System;

namespace cognizent_GENCNEXT
{
    public class PalindromeString
    {

        public static bool palindrome(string str)
        {
            int n = str.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (str[i] != str[n - i - 1])
                {
                    return false;
                }
            }
            return true;

        }

        public static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter any string : ");
            str = Console.ReadLine();
            bool val = palindrome(str);
            if (val == true)
            {
                Console.WriteLine("'" + str + "' the string is palindromic\n\n");
            }
            else
            {
                Console.WriteLine("'" + str + "' the string is not palindromic\n\n");
            }
        }
    }
}
