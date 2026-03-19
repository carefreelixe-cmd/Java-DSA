using System;
using System.Linq;

class ArrayDemo
{
    static void Main()
    {
        Console.WriteLine("===== ARRAY PROPERTIES & METHODS =====\n");

        // 1. ARRAY PROPERTIES
        Console.WriteLine("--- ARRAY PROPERTIES ---");
        int[] arr1 = { 10, 20, 30, 40, 50 };
        
        // Length Property
        Console.WriteLine($"Length: {arr1.Length}");  // Total number of elements
        
        // Rank Property
        Console.WriteLine($"Rank (Dimensions): {arr1.Rank}");  // 1 for single dimension
        
        // LongLength Property
        Console.WriteLine($"LongLength: {arr1.LongLength}");  // Length as long integer
        Console.WriteLine();

        // 2. SORT METHOD
        Console.WriteLine("--- SORT METHOD ---");
        int[] arr2 = { 50, 20, 40, 10, 30 };
        Console.WriteLine($"Before Sort: {string.Join(", ", arr2)}");
        Array.Sort(arr2);
        Console.WriteLine($"After Sort: {string.Join(", ", arr2)}");
        
        // Sort in Descending Order
        Array.Sort(arr2, (a, b) => b.CompareTo(a));
        Console.WriteLine($"Descending: {string.Join(", ", arr2)}");
        Console.WriteLine();

        // 3. REVERSE METHOD
        Console.WriteLine("--- REVERSE METHOD ---");
        int[] arr3 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Before Reverse: {string.Join(", ", arr3)}");
        Array.Reverse(arr3);
        Console.WriteLine($"After Reverse: {string.Join(", ", arr3)}");
        Console.WriteLine();

        // 4. INDEXOF METHOD
        Console.WriteLine("--- INDEXOF METHOD ---");
        int[] arr4 = { 10, 20, 30, 20, 40 };
        int index = Array.IndexOf(arr4, 20);
        Console.WriteLine($"Array: {string.Join(", ", arr4)}");
        Console.WriteLine($"First Index of 20: {index}");  // Returns first occurrence
        Console.WriteLine();

        // 5. LASTINDEXOF METHOD
        Console.WriteLine("--- LASTINDEXOF METHOD ---");
        int lastIndex = Array.LastIndexOf(arr4, 20);
        Console.WriteLine($"Last Index of 20: {lastIndex}");  // Returns last occurrence
        Console.WriteLine();

        // 6. BINARYSEARCH METHOD
        Console.WriteLine("--- BINARYSEARCH METHOD ---");
        int[] arr5 = { 10, 20, 30, 40, 50 };  // Must be sorted
        int searchResult = Array.BinarySearch(arr5, 30);
        Console.WriteLine($"Array: {string.Join(", ", arr5)}");
        Console.WriteLine($"Binary Search for 30: Index {searchResult}");
        int notFound = Array.BinarySearch(arr5, 25);
        Console.WriteLine($"Binary Search for 25 (not found): {notFound}");
        Console.WriteLine();

        // 7. CLEAR METHOD
        Console.WriteLine("--- CLEAR METHOD ---");
        int[] arr6 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Before Clear: {string.Join(", ", arr6)}");
        Array.Clear(arr6, 0, 3);  // Clear 3 elements starting from index 0
        Console.WriteLine($"After Clear(0, 3): {string.Join(", ", arr6)}");
        Console.WriteLine();

        // 8. COPY METHOD
        Console.WriteLine("--- COPY METHOD ---");
        int[] arr7 = { 10, 20, 30, 40, 50 };
        int[] arr8 = new int[5];
        Array.Copy(arr7, arr8, 5);  // Copy all elements
        Console.WriteLine($"Source: {string.Join(", ", arr7)}");
        Console.WriteLine($"Destination: {string.Join(", ", arr8)}");
        
        // Copy with offset
        int[] arr9 = new int[3];
        Array.Copy(arr7, 1, arr9, 0, 3);  // Copy 3 elements starting from index 1
        Console.WriteLine($"Partial Copy (index 1, 3 elements): {string.Join(", ", arr9)}");
        Console.WriteLine();

        // 9. FIND METHOD
        Console.WriteLine("--- FIND METHOD ---");
        int[] arr10 = { 5, 10, 15, 20, 25 };
        int found = Array.Find(arr10, element => element > 12);
        Console.WriteLine($"Array: {string.Join(", ", arr10)}");
        Console.WriteLine($"First element > 12: {found}");
        Console.WriteLine();

        // 10. FINDALL METHOD
        Console.WriteLine("--- FINDALL METHOD ---");
        int[] arr11 = { 5, 10, 15, 20, 25, 30 };
        int[] results = Array.FindAll(arr11, element => element > 15);
        Console.WriteLine($"Array: {string.Join(", ", arr11)}");
        Console.WriteLine($"All elements > 15: {string.Join(", ", results)}");
        Console.WriteLine();

        // 11. FINDINDEX METHOD
        Console.WriteLine("--- FINDINDEX METHOD ---");
        int[] arr12 = { 5, 10, 15, 20, 25 };
        int foundIndex = Array.FindIndex(arr12, element => element > 15);
        Console.WriteLine($"Array: {string.Join(", ", arr12)}");
        Console.WriteLine($"Index of first element > 15: {foundIndex}");
        Console.WriteLine();

        // 12. FINDLASTINDEX METHOD
        Console.WriteLine("--- FINDLASTINDEX METHOD ---");
        int[] arr13 = { 5, 10, 15, 20, 15, 25 };
        int foundLastIndex = Array.FindLastIndex(arr13, element => element == 15);
        Console.WriteLine($"Array: {string.Join(", ", arr13)}");
        Console.WriteLine($"Last Index of 15: {foundLastIndex}");
        Console.WriteLine();

        // 13. EXISTS METHOD
        Console.WriteLine("--- EXISTS METHOD ---");
        int[] arr14 = { 5, 10, 15, 20, 25 };
        bool exists = Array.Exists(arr14, element => element > 20);
        Console.WriteLine($"Array: {string.Join(", ", arr14)}");
        Console.WriteLine($"Contains element > 20: {exists}");
        Console.WriteLine();

        // 14. TRUEFORALL METHOD
        Console.WriteLine("--- TRUEFORALL METHOD ---");
        int[] arr15 = { 2, 4, 6, 8, 10 };
        bool allEven = Array.TrueForAll(arr15, element => element % 2 == 0);
        Console.WriteLine($"Array: {string.Join(", ", arr15)}");
        Console.WriteLine($"All elements are even: {allEven}");
        Console.WriteLine();

        // 15. RESIZE METHOD
        Console.WriteLine("--- RESIZE METHOD ---");
        int[] arr16 = { 10, 20, 30, 40, 50 };
        Console.WriteLine($"Original Length: {arr16.Length}");
        Array.Resize(ref arr16, 8);  // Increase size to 8
        Console.WriteLine($"After Resize(8): {string.Join(", ", arr16)}");
        Console.WriteLine($"New Length: {arr16.Length}");
        Console.WriteLine();

        // 16. CONSTRAINT PROPERTY
        Console.WriteLine("--- CONSTRAINTS PROPERTY ---");
        int[] arr17 = { 10, 20, 30 };
        Console.WriteLine($"Lower Bound: {arr17.GetLowerBound(0)}");
        Console.WriteLine($"Upper Bound: {arr17.GetUpperBound(0)}");
        Console.WriteLine();

        // 17. TOSTRING ON ELEMENTS
        Console.WriteLine("--- FOREACH WITH ELEMENTS ---");
        string[] arr18 = { "Apple", "Banana", "Cherry", "Date" };
        Console.WriteLine($"Array: {string.Join(", ", arr18)}");
        Console.WriteLine("Iterating:");
        foreach (string item in arr18)
        {
            Console.WriteLine($"  - {item}");
        }
        Console.WriteLine();

        // 18. CLONE METHOD
        Console.WriteLine("--- CLONE METHOD ---");
        int[] arr19 = { 10, 20, 30 };
        int[] arr20 = (int[])arr19.Clone();
        arr20[0] = 999;
        Console.WriteLine($"Original: {string.Join(", ", arr19)}");
        Console.WriteLine($"Cloned (modified): {string.Join(", ", arr20)}");
        Console.WriteLine();

        // 19. GETTYPE METHOD
        Console.WriteLine("--- GETTYPE METHOD ---");
        int[] arr21 = { 1, 2, 3 };
        string[] arr22 = { "a", "b", "c" };
        Console.WriteLine($"int[] Type: {arr21.GetType()}");
        Console.WriteLine($"string[] Type: {arr22.GetType()}");
        Console.WriteLine();

        // 20. MULTIDIMENSIONAL ARRAYS
        Console.WriteLine("--- MULTIDIMENSIONAL ARRAYS ---");
        int[,] arr2D = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine($"Rank (Dimensions): {arr2D.Rank}");
        Console.WriteLine($"Length: {arr2D.Length}");
        Console.WriteLine("2D Array:");
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                Console.Write(arr2D[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // 21. JAGGED ARRAYS
        Console.WriteLine("--- JAGGED ARRAYS ---");
        int[][] jaggedArr = new int[3][];
        jaggedArr[0] = new int[2] { 1, 2 };
        jaggedArr[1] = new int[3] { 3, 4, 5 };
        jaggedArr[2] = new int[4] { 6, 7, 8, 9 };
        Console.WriteLine("Jagged Array:");
        for (int i = 0; i < jaggedArr.Length; i++)
        {
            Console.WriteLine($"Row {i}: {string.Join(", ", jaggedArr[i])}");
        }
        Console.WriteLine();

        // 22. ARRAY WITH FOREACH AND INDEX
        Console.WriteLine("--- ARRAY WITH FOREACH AND INDEX (C# 8.0+) ---");
        int[] arr23 = { 100, 200, 300, 400 };
        foreach (int element in arr23)
        {
            int idx = Array.IndexOf(arr23, element);
            Console.WriteLine($"Index {idx}: {element}");
        }
        Console.WriteLine();

        // 23. SORT WITH CUSTOM COMPARISON
        Console.WriteLine("--- SORT WITH CUSTOM COMPARISON ---");
        string[] arr24 = { "apple", "Zebra", "banana", "Cherry" };
        Console.WriteLine($"Original: {string.Join(", ", arr24)}");
        Array.Sort(arr24, StringComparer.OrdinalIgnoreCase);
        Console.WriteLine($"Sorted (Case-Insensitive): {string.Join(", ", arr24)}");
        Console.WriteLine();

        // 24. FOREACH (INDEX OF) MULTIPLE OCCURRENCES
        Console.WriteLine("--- FOREACH ALL INDEXES ---");
        int[] arr25 = { 10, 20, 10, 30, 10, 40 };
        Console.WriteLine($"Array: {string.Join(", ", arr25)}");
        Console.WriteLine("All indexes of 10:");
        int startIndex = 0;
        while ((startIndex = Array.IndexOf(arr25, 10, startIndex)) != -1)
        {
            Console.WriteLine($"  Found at index: {startIndex}");
            startIndex++;
        }
        Console.WriteLine();

        // 25. PRACTICAL EXAMPLE - STUDENT GRADES
        Console.WriteLine("--- PRACTICAL EXAMPLE: STUDENT GRADES ---");
        int[] grades = { 85, 92, 78, 95, 88, 76, 90 };
        Console.WriteLine($"Grades: {string.Join(", ", grades)}");
        
        Array.Sort(grades);
        Console.WriteLine($"Sorted (Ascending): {string.Join(", ", grades)}");
        
        Array.Reverse(grades);
        Console.WriteLine($"Sorted (Descending): {string.Join(", ", grades)}");
        
        int maxGrade = grades[0];
        int minGrade = grades[grades.Length - 1];
        double avgGrade = 0;
        foreach (int grade in grades)
        {
            avgGrade += grade;
        }
        avgGrade /= grades.Length;
        
        Console.WriteLine($"Max Grade: {maxGrade}");
        Console.WriteLine($"Min Grade: {minGrade}");
        Console.WriteLine($"Average Grade: {avgGrade:F2}");
        
        int[] passingGrades = Array.FindAll(grades, g => g >= 80);
        Console.WriteLine($"Passing Grades (>=80): {string.Join(", ", passingGrades)}");
    }
}
