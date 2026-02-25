using System;

namespace Soumadip.Array
{
    public class ArrayOperation
    {
        // creating array
        public static void CreateArray(int[] k)
        {
            for (int i = 0; i < k.Length; i++)
            {
                Console.Write("Enter number[" + i + "] : ");
                k[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // display
        public static void display(int[] k)
        {
            Console.Write("\n\n[ ");
            for (int i = 0; i < k.Length; i++)
            {
                Console.Write(k[i] + "\t");

            }

            Console.Write("]\n\n");

        }

        // largest number
        public static void largest(int[] k)
        {
            int maxnum = int.MinValue;
            for (int i = 0; i < k.Length; i++)
            {
                if (maxnum < k[i])
                {
                    maxnum = k[i];
                }
            }
            Console.WriteLine("\n\nThe largest number in the array is " + maxnum);
            Console.WriteLine();
        }

        // smallest number
        public static void smallest(int[] k)
        {
            int minnum = int.MaxValue;
            for (int i = 0; i < k.Length; i++)
            {
                if (minnum > k[i])
                {
                    minnum = k[i];
                }
            }
            Console.WriteLine("\n\nThe smallest number in the array is " + minnum);
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter Element Size");
            size = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[size];
            CreateArray(num);
            display(num);
            largest(num);

            Console.Write("Do you want to see the smallest number? (1 = Yes): ");
            int choice;

            do
            {
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice != 1)
                {
                    Console.Write("Fuck i still waste your time choose to see smaleest number ");
                }

            } while (choice != 1);

            smallest(num);

        }

    }
}
