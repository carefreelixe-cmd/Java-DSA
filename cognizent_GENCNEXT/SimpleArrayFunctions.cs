using System;

class SimpleArrayDemo
{
    static void Main()
    {
        int[] arr = { 50, 20, 40, 10, 30 };
        
        Console.WriteLine($"Length: {arr.Length}");
        Console.WriteLine($"Rank: {arr.Rank}");

        Array.Sort(arr);
        Console.WriteLine($"After Sort: {string.Join(", ", arr)}");

        Array.Reverse(arr);
        Console.WriteLine($"After Reverse: {string.Join(", ", arr)}");

        int index = Array.IndexOf(arr, 30);
        Console.WriteLine($"Index of 30: {index}");

        int[] arr2 = { 1, 2, 3, 4, 5 };
        Array.Clear(arr2, 0, 3);
        Console.WriteLine($"After Clear: {string.Join(", ", arr2)}");

        int[] arr3 = { 10, 20, 30 };
        int[] arr4 = new int[3];
        Array.Copy(arr3, arr4, 3);
        Console.WriteLine($"Copied: {string.Join(", ", arr4)}");

        int[] arr5 = { 5, 10, 15, 20 };
        int found = Array.Find(arr5, x => x > 12);
        Console.WriteLine($"First element > 12: {found}");

        int[] results = Array.FindAll(arr5, x => x > 10);
        Console.WriteLine($"All elements > 10: {string.Join(", ", results)}");

        bool exists = Array.Exists(arr5, x => x == 15);
        Console.WriteLine($"Contains 15: {exists}");

        int[] arr6 = { 1, 2, 3 };
        int[] arr7 = (int[])arr6.Clone();
        arr7[0] = 999;
        Console.WriteLine($"Cloned: {string.Join(", ", arr7)}");
    }
}
