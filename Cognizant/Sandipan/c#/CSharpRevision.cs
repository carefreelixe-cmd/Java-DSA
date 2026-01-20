using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cognizant.Sandipan.c_sharp
{
    class CSharpRevision
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# REVISION EXAMPLES ===\n");

            // ============================================
            // 1. SYSTEM - Basic types and console I/O
            // ============================================
            Console.WriteLine("--- System Namespace ---");
            int num = 42;
            string text = "Hello C#";
            Console.WriteLine(text);
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date: {now}");
            double sqrt = Math.Sqrt(16);
            Console.WriteLine($"Square root of 16: {sqrt}");
            Console.WriteLine();

            // ============================================
            // 2. SYSTEM.COLLECTIONS.GENERIC - Modern Collections
            // ============================================
            Console.WriteLine("--- System.Collections.Generic ---");

            // List (like ArrayList in Java)
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);
            numbers.Add(7);
            numbers.Remove(3);
            Console.WriteLine("List: " + string.Join(", ", numbers));

            // Dictionary (like HashMap in Java)
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["Alice"] = 25;
            ages["Bob"] = 30;
            ages["Charlie"] = 35;
            Console.WriteLine($"Alice's age: {ages["Alice"]}");
            Console.WriteLine("All ages:");
            foreach (var pair in ages)
            {
                Console.WriteLine($"  {pair.Key}: {pair.Value}");
            }

            // Queue (FIFO - First In First Out)
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");  // First
            Console.WriteLine($"Peek: {queue.Peek()}");        // Second

            // Stack (LIFO - Last In First Out)
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine($"Pop: {stack.Pop()}");   // 30
            Console.WriteLine($"Peek: {stack.Peek()}"); // 20
            Console.WriteLine();

            // ============================================
            // 3. SYSTEM.LINQ - Queries (like Java Streams)
            // ============================================
            Console.WriteLine("--- System.Linq ---");

            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Filter even numbers
            var evens = nums.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers: " + string.Join(", ", evens));

            // Map/Transform - squares
            var squares = nums.Select(n => n * n).ToList();
            Console.WriteLine("Squares: " + string.Join(", ", squares));

            // Filter and Transform
            var evenSquares = nums.Where(n => n % 2 == 0)
                                  .Select(n => n * n)
                                  .ToList();
            Console.WriteLine("Even squares: " + string.Join(", ", evenSquares));

            // Find first element
            var first = nums.First();
            Console.WriteLine($"First element: {first}");
            
            var firstEven = nums.First(n => n % 2 == 0);
            Console.WriteLine($"First even: {firstEven}");

            // Sum, Max, Min, Average
            int sum = nums.Sum();
            int max = nums.Max();
            int min = nums.Min();
            double avg = nums.Average();
            Console.WriteLine($"Sum: {sum}, Max: {max}, Min: {min}, Avg: {avg}");

            // Count with condition
            int countGreaterThan5 = nums.Count(n => n > 5);
            Console.WriteLine($"Numbers > 5: {countGreaterThan5}");

            // Sort
            var sorted = nums.OrderBy(n => n).ToList();
            var descending = nums.OrderByDescending(n => n).ToList();
            Console.WriteLine("Ascending: " + string.Join(", ", sorted));
            Console.WriteLine("Descending: " + string.Join(", ", descending));

            // Any and All
            bool hasEven = nums.Any(n => n % 2 == 0);
            bool allPositive = nums.All(n => n > 0);
            Console.WriteLine($"Has even numbers: {hasEven}");
            Console.WriteLine($"All positive: {allPositive}");

            // Take and Skip
            var firstThree = nums.Take(3).ToList();
            var skipFirstThree = nums.Skip(3).ToList();
            Console.WriteLine("First 3: " + string.Join(", ", firstThree));
            Console.WriteLine("Skip 3: " + string.Join(", ", skipFirstThree));
            Console.WriteLine();

            // ============================================
            // 4. SYSTEM.COLLECTIONS - Non-generic (Old style)
            // ============================================
            Console.WriteLine("--- System.Collections (Old Style) ---");

            // ArrayList (stores any type - less type safe)
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("text");
            arrayList.Add(true);
            arrayList.Add(3.14);
            Console.WriteLine("ArrayList contains: " + string.Join(", ", arrayList.ToArray()));

            // Hashtable (like old HashMap)
            Hashtable hashtable = new Hashtable();
            hashtable["name"] = "John";
            hashtable["age"] = 30;
            hashtable["active"] = true;
            Console.WriteLine($"Name: {hashtable["name"]}, Age: {hashtable["age"]}");
            Console.WriteLine();

            // ============================================
            // 5. COMPLETE PRACTICAL EXAMPLE
            // ============================================
            Console.WriteLine("--- Practical Example: Student Management ---");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20, Grade = 85 },
                new Student { Name = "Bob", Age = 22, Grade = 92 },
                new Student { Name = "Charlie", Age = 21, Grade = 78 },
                new Student { Name = "David", Age = 20, Grade = 88 },
                new Student { Name = "Eve", Age = 23, Grade = 95 }
            };

            // Students with grade >= 85
            var topStudents = students.Where(s => s.Grade >= 85).ToList();
            Console.WriteLine("Top Students (Grade >= 85):");
            foreach (var student in topStudents)
            {
                Console.WriteLine($"  {student.Name}: {student.Grade}");
            }

            // Students aged 20, sorted by grade
            var age20Sorted = students.Where(s => s.Age == 20)
                                     .OrderByDescending(s => s.Grade)
                                     .ToList();
            Console.WriteLine("\nAge 20 students (sorted by grade):");
            foreach (var student in age20Sorted)
            {
                Console.WriteLine($"  {student.Name}: {student.Grade}");
            }

            // Average grade
            double avgGrade = students.Average(s => s.Grade);
            Console.WriteLine($"\nAverage Grade: {avgGrade:F2}");

            // Highest grade student
            var topGradeStudent = students.OrderByDescending(s => s.Grade).First();
            Console.WriteLine($"Highest Grade: {topGradeStudent.Name} ({topGradeStudent.Grade})");

            // Group by age
            var groupedByAge = students.GroupBy(s => s.Age);
            Console.WriteLine("\nStudents grouped by age:");
            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"  Age {group.Key}: {string.Join(", ", group.Select(s => s.Name))}");
            }

            Console.WriteLine("\n=== END OF REVISION ===");
        }
    }

    // Student class for examples
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
}
