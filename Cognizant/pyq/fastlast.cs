using System;
class fastlast
{
    static void FirstAndLastSwap(string[] arr)
    {
        if(arr.Length < 2)
        {
            return; // Nothing to swap
        }

        // Swap only first and last element
        string temp = arr[0];
        arr[0] = arr[arr.Length - 1];
        arr[arr.Length - 1] = temp;
    }
static void FirstandLastSwapOfaString(string str)
{
    char[] charArray = str.ToCharArray();
    int n = charArray.Length;
    if (n < 2)
    {
        Console.WriteLine(str); // Nothing to swap
        return;
    }

    // Swap only first and last character
    char temp = charArray[0];
    charArray[0] = charArray[n - 1];
    charArray[n - 1] = temp;

    string swappedStr = new string(charArray);
    Console.WriteLine(swappedStr);
}
    static void Main(string[] args)
    {
        string[] arr1 = {"Apple", "Banana", "Cherry", "Date"};
        
        Console.WriteLine("Before swap: " + string.Join(", ", arr1));
        FirstAndLastSwap(arr1);
        Console.WriteLine("After swap: " + string.Join(", ", arr1));
        
        // Test with 2 elements
        string[] arr2 = {"First", "Last"};
        Console.WriteLine("\nBefore swap: " + string.Join(", ", arr2));
        FirstAndLastSwap(arr2);
        Console.WriteLine("After swap: " + string.Join(", ", arr2));
    }
}