using System;
using System.Text;

class ReverseStringBuilder
{
    static void Main()
    {
        string input = "Hello";
        
        StringBuilder sb = new StringBuilder(input);
        sb.Reverse();
        
        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Reversed: {sb}");
    }
}
