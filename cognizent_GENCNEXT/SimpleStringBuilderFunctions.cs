using System;
using System.Text;

class SimpleStringBuilderDemo
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");
        
        Console.WriteLine($"Length: {sb.Length}");
        Console.WriteLine($"Capacity: {sb.Capacity}");

        sb.Append(" World");
        Console.WriteLine($"After Append: {sb}");

        sb.AppendLine();
        sb.AppendLine("Line 1");
        Console.WriteLine($"After AppendLine: {sb}");

        sb.Insert(6, "Beautiful ");
        Console.WriteLine($"After Insert: {sb}");

        StringBuilder sb2 = new StringBuilder("Hello World");
        sb2.Replace("Hello", "Hi");
        Console.WriteLine($"After Replace: {sb2}");

        StringBuilder sb3 = new StringBuilder("Hello World");
        sb3.Remove(5, 6);
        Console.WriteLine($"After Remove: {sb3}");

        StringBuilder sb4 = new StringBuilder("Hello");
        Console.WriteLine($"Character at index 1: {sb4[1]}");

        StringBuilder sb5 = new StringBuilder("Hello World");
        sb5.Reverse();
        Console.WriteLine($"After Reverse: {sb5}");

        StringBuilder sb6 = new StringBuilder("Apple");
        string[] items = { "Banana", "Cherry" };
        sb6.AppendJoin(", ", items);
        Console.WriteLine($"After AppendJoin: {sb6}");

        StringBuilder sb7 = new StringBuilder("Test");
        sb7.Clear();
        Console.WriteLine($"After Clear: '{sb7}'");

        StringBuilder sb8 = new StringBuilder();
        sb8.AppendFormat("Name: {0}, Age: {1}", "John", 25);
        Console.WriteLine($"After AppendFormat: {sb8}");

        string result = sb8.ToString();
        Console.WriteLine($"ToString: {result}");
    }
}
