using System;
using System.Text;

namespace cognizent_GENCNEXT
{
    public class UpperCase
    {
        public static void uppercase(string str)
        {
            StringBuilder str2 = new StringBuilder("");
            for (int i = 0; i < str.Length; i++)
            {

                char ch = char.ToUpper(str[i]);
                str2.Append(ch);
            }
            Console.WriteLine(str2);
        }
        public static void Main(string[] args)
        {
            uppercase("null");
        }
    }
}
