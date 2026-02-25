using System;

namespace cognizent_GENCNEXT
{
    public class Substring
    {
        public static void subString(string str, int val1, int val2)
        {
            for (int i = val1; i < val2; i++)
            {
                Console.Write(str[i]);
            }
        }

        public static void Main(string[] args)
        {
            string str = "Hello World";
            string str2 = str.Substring(2, 5);
            Console.WriteLine("The Substring is '" + str2 + "'");
            subString(str, 2, 7);

        }

    }
}
