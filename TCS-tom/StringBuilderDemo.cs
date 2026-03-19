using System;
using System.Text;

class StringBuilderDemo
{
    static void Main()
    {
        Console.WriteLine("===== StringBuilder Properties & Methods =====\n");

        // 1. PROPERTIES
        Console.WriteLine("--- PROPERTIES ---");
        StringBuilder sb = new StringBuilder("Hello");
        
        // Length Property
        Console.WriteLine($"Length: {sb.Length}");  // Current number of characters
        
        // Capacity Property
        Console.WriteLine($"Capacity: {sb.Capacity}");  // Total allocated space
        
        // MaxCapacity Property
        Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}");  // Maximum capacity
        Console.WriteLine();

        // 2. APPEND METHODS
        Console.WriteLine("--- APPEND METHODS ---");
        StringBuilder sb1 = new StringBuilder();
        sb1.Append("Hello");
        Console.WriteLine($"Append: {sb1}");

        sb1.Append(" World");
        Console.WriteLine($"After Append: {sb1}");

        // AppendLine
        StringBuilder sb2 = new StringBuilder();
        sb2.AppendLine("Line 1");
        sb2.AppendLine("Line 2");
        Console.WriteLine($"AppendLine:\n{sb2}");

        // AppendFormat (printf-style formatting)
        StringBuilder sb3 = new StringBuilder();
        sb3.AppendFormat("Name: {0}, Age: {1}", "John", 25);
        Console.WriteLine($"AppendFormat: {sb3}");

        // AppendJoin (join multiple values)
        StringBuilder sb4 = new StringBuilder();
        string[] names = { "Alice", "Bob", "Charlie" };
        sb4.AppendJoin(", ", names);
        Console.WriteLine($"AppendJoin: {sb4}");
        Console.WriteLine();

        // 3. INSERT METHOD
        Console.WriteLine("--- INSERT METHOD ---");
        StringBuilder sb5 = new StringBuilder("Hello World");
        sb5.Insert(6, "Beautiful ");
        Console.WriteLine($"Insert: {sb5}");
        Console.WriteLine();

        // 4. REMOVE METHOD
        Console.WriteLine("--- REMOVE METHOD ---");
        StringBuilder sb6 = new StringBuilder("Hello World");
        sb6.Remove(5, 6);  // Start index 5, remove 6 characters
        Console.WriteLine($"Remove: {sb6}");
        Console.WriteLine();

        // 5. REPLACE METHOD
        Console.WriteLine("--- REPLACE METHOD ---");
        StringBuilder sb7 = new StringBuilder("Hello World Hello");
        sb7.Replace("Hello", "Hi");
        Console.WriteLine($"Replace All: {sb7}");

        StringBuilder sb8 = new StringBuilder("Hello World Hello");
        sb8.Replace("Hello", "Hi", 0, 5);  // Replace in specific range
        Console.WriteLine($"Replace in Range: {sb8}");
        Console.WriteLine();

        // 6. CLEAR METHOD
        Console.WriteLine("--- CLEAR METHOD ---");
        StringBuilder sb9 = new StringBuilder("Hello World");
        Console.WriteLine($"Before Clear: {sb9}");
        sb9.Clear();
        Console.WriteLine($"After Clear: {sb9}");
        Console.WriteLine();

        // 7. CHARACTER ACCESS (Indexer)
        Console.WriteLine("--- CHARACTER ACCESS (INDEXER) ---");
        StringBuilder sb10 = new StringBuilder("Hello");
        Console.WriteLine($"Character at index 1: {sb10[1]}");
        sb10[0] = 'J';
        Console.WriteLine($"After changing index 0: {sb10}");
        Console.WriteLine();

        // 8. TOSTRING METHOD
        Console.WriteLine("--- TOSTRING METHOD ---");
        StringBuilder sb11 = new StringBuilder("Convert to String");
        string result = sb11.ToString();
        Console.WriteLine($"ToString: {result}");
        Console.WriteLine($"Type: {result.GetType().Name}");
        Console.WriteLine();

        // 8.5 REVERSE METHOD
        Console.WriteLine("--- REVERSE METHOD ---");
        StringBuilder sb11b = new StringBuilder("Hello World");
        Console.WriteLine($"Original: {sb11b}");
        sb11b.Reverse();
        Console.WriteLine($"Reversed: {sb11b}");
        Console.WriteLine();

        // 9. APPEND WITH DIFFERENT DATA TYPES
        Console.WriteLine("--- APPEND WITH DIFFERENT DATA TYPES ---");
        StringBuilder sb12 = new StringBuilder();
        sb12.Append(123);           // int
        sb12.Append(" ");
        sb12.Append(45.67);         // double
        sb12.Append(" ");
        sb12.Append(true);          // bool
        sb12.Append(" ");
        sb12.Append('A');           // char
        Console.WriteLine($"Mixed Types: {sb12}");
        Console.WriteLine();

        // 10. CAPACITY MANAGEMENT
        Console.WriteLine("--- CAPACITY MANAGEMENT ---");
        StringBuilder sb13 = new StringBuilder(5);  // Initial capacity 5
        Console.WriteLine($"Initial Capacity: {sb13.Capacity}");
        sb13.Append("Hello World");
        Console.WriteLine($"After Append: {sb13}");
        Console.WriteLine($"Capacity After Growth: {sb13.Capacity}");
        Console.WriteLine();

        // 11. APPENDING SUBSTRING
        Console.WriteLine("--- APPEND SUBSTRING ---");
        StringBuilder sb14 = new StringBuilder();
        string str = "Programming";
        sb14.Append(str, 0, 7);  // Append first 7 characters
        Console.WriteLine($"Substring Append: {sb14}");
        Console.WriteLine();

        // 12. COMBINATION EXAMPLE
        Console.WriteLine("--- COMBINATION EXAMPLE ---");
        StringBuilder sb15 = new StringBuilder();
        sb15.AppendLine("=== Student Information ===");
        sb15.AppendFormat("Name: {0}\n", "John Doe");
        sb15.AppendFormat("Roll No: {0}\n", 101);
        sb15.AppendFormat("Grade: {0}\n", 'A');
        string[] subjects = { "Math", "Science", "English" };
        sb15.Append("Subjects: ");
        sb15.AppendJoin(", ", subjects);
        Console.WriteLine(sb15.ToString());
        Console.WriteLine();

        // 13. PERFORMANCE COMPARISON
        Console.WriteLine("--- PERFORMANCE: STRING vs STRINGBUILDER ---");
        var watch1 = System.Diagnostics.Stopwatch.StartNew();
        string s = "";
        for (int i = 0; i < 1000; i++)
        {
            s += i;
        }
        watch1.Stop();
        Console.WriteLine($"String Concatenation (1000 iterations): {watch1.ElapsedMilliseconds}ms");

        var watch2 = System.Diagnostics.Stopwatch.StartNew();
        StringBuilder sb16 = new StringBuilder();
        for (int i = 0; i < 1000; i++)
        {
            sb16.Append(i);
        }
        watch2.Stop();
        Console.WriteLine($"StringBuilder (1000 iterations): {watch2.ElapsedMilliseconds}ms");
        Console.WriteLine();

        // 14. EQUALS and EnsureCapacity
        Console.WriteLine("--- ADDITIONAL METHODS ---");
        StringBuilder sb17 = new StringBuilder("Test");
        sb17.EnsureCapacity(100);  // Ensure minimum capacity
        Console.WriteLine($"Capacity after EnsureCapacity(100): {sb17.Capacity}");

        // Get substring
        StringBuilder sb18 = new StringBuilder("Hello World");
        string substring = sb18.ToString(0, 5);  // Get substring
        Console.WriteLine($"Substring (0, 5): {substring}");
    }
}
