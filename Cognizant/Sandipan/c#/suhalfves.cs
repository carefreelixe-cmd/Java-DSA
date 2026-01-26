using System;
class suhalfves
{
    static int luckyNumber(int[] arr)
    {
        int firstHalfSum = 0;
        int secondHalfSum = 0;
        
        for(int i = 0; i < arr.Length / 2; i++)
        {
            firstHalfSum += arr[i];
        }

        for(int j = arr.Length / 2; j < arr.Length; j++)
        {
            secondHalfSum += arr[j];
        }

        if(firstHalfSum == secondHalfSum)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    static void Main(string[] args)
    {
        int[] arr1 = {1, 2, 3, 4};
        int[] arr2 = {1, 2, 3, 6};
        int[] arr3 = {5, 5, 5, 5};
        
        Console.WriteLine("Array {1, 2, 3, 4}: " + luckyNumber(arr1)); // Output: 0 (3 != 7)
        Console.WriteLine("Array {1, 2, 3, 6}: " + luckyNumber(arr2)); // Output: 1 (3 == 9? No, 1+2=3, 3+6=9, so 0)
        Console.WriteLine("Array {5, 5, 5, 5}: " + luckyNumber(arr3)); // Output: 1 (10 == 10)
    }
}