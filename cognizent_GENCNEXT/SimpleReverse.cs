using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string str = "Hello";
        
        StringBuilder sb = new StringBuilder(str);
        sb.Reverse();
        
        Console.WriteLine($"Original: {str}");
        Console.WriteLine($"Reversed: {sb}");
    }
}
