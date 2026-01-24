using System;
using System.Collections.Generic;

namespace Cognizant.Sandipan.RemoveDuplicate
{
    class RemoveDuplicate
    {
        // Remove duplicate characters from string
        static void RemoveDuplicateString(string str)
        {
            char[] charArray = str.ToCharArray();
            string result = "";

            Console.WriteLine("Original String: " + str);

            for (int i = 0; i < charArray.Length; i++)
            {
                if (!result.Contains(charArray[i]))
                {
                    result += charArray[i];
                }
            }

            Console.WriteLine("After removing duplicates: " + result);
            Console.WriteLine();
        }

        // Remove duplicates using List
        static void RemoveDuplicateNumber(int[] arr)
        {
            Console.Write("Original Array: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            List<int> temp = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!temp.Contains(arr[i]))
                {
                    temp.Add(arr[i]);
                }
            }

            Console.Write("After removing duplicates: ");
            foreach (int num in temp)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
        }

        // Remove duplicates using only loops (no collection)
        static void RemoveDuplicateLoop(int[] arr)
        {
            Console.Write("Original Array: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[] temp = new int[arr.Length];
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < k; j++)
                {
                    if (arr[i] == temp[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp[k] = arr[i];
                    k++;
                }
            }

            Console.Write("After removing duplicates: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(temp[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            string str1 = "programming";
            RemoveDuplicateString(str1);

            int[] arr1 = { 1, 2, 2, 3, 4, 4, 5 };
            RemoveDuplicateNumber(arr1);

            RemoveDuplicateNumber(new int[] { 10, 20, 20, 30, 40, 50, 50, 60 });

            RemoveDuplicateLoop(new int[] { 5, 5, 10, 20, 20, 30 });

            string str2 = "hello world";
            RemoveDuplicateString(str2);
        }
    }
}
