using System;
using System.Collections.Generic;


namespace Cognizant.Sandipan.c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ListExample();
        }

        static void ListExample()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            Console.WriteLine("List elements:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}