using System;

namespace cognizent_GENCNEXT
{
    public class PrintString
    {
        // print letter
        public static void printLetter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + "");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {

            string name;
            Console.Write("Write Your Name : ");
            name = Console.ReadLine();
            string msg = "Hello World Quest";
            printLetter(msg);
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("The String length -- " + name.Length);
        }
    }
}
