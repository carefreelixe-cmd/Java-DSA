using System;
using System.Text;

class ReverseStringWithStringBuilder
{
    static void Main()
    {
        Console.WriteLine("===== REVERSE STRING USING STRINGBUILDER =====\n");

        // METHOD 1: Using StringBuilder.Reverse()
        Console.WriteLine("--- METHOD 1: Using StringBuilder.Reverse() ---");
        string original1 = "Hello World";
        StringBuilder sb1 = new StringBuilder(original1);
        Console.WriteLine($"Original: {original1}");
        sb1.Reverse();
        Console.WriteLine($"Reversed: {sb1}");
        Console.WriteLine();

        // METHOD 2: Reverse Multiple Strings
        Console.WriteLine("--- METHOD 2: Reverse Multiple Strings ---");
        string[] words = { "C#", "Programming", "Reverse", "StringBuilder" };
        Console.WriteLine("Original Strings:");
        foreach (string word in words)
        {
            Console.WriteLine($"  {word}");
        }
        
        Console.WriteLine("Reversed Strings:");
        foreach (string word in words)
        {
            StringBuilder sb = new StringBuilder(word);
            sb.Reverse();
            Console.WriteLine($"  {sb}");
        }
        Console.WriteLine();

        // METHOD 3: Reverse with Additional Operations
        Console.WriteLine("--- METHOD 3: Reverse with Additional Operations ---");
        string text = "CSharp";
        StringBuilder sb3 = new StringBuilder(text);
        sb3.Reverse();
        sb3.Append(" is awesome!");
        Console.WriteLine($"Original: {text}");
        Console.WriteLine($"Reversed + Append: {sb3}");
        Console.WriteLine();

        // METHOD 4: Reverse Substring (Manual Approach)
        Console.WriteLine("--- METHOD 4: Reverse Specific Part ---");
        string sentence = "The Quick Brown Fox";
        StringBuilder sb4 = new StringBuilder(sentence);
        // Reverse from index 4 to 9 ("Quick")
        ReversePartial(sb4, 4, 10);  // "Quick" reversed
        Console.WriteLine($"Original: {sentence}");
        Console.WriteLine($"Reversed 'Quick': {sb4}");
        Console.WriteLine();

        // METHOD 5: Case-Sensitive Reverse
        Console.WriteLine("--- METHOD 5: Case-Sensitive Reverse ---");
        string mixedCase = "HeLLo WoRLd";
        StringBuilder sb5 = new StringBuilder(mixedCase);
        Console.WriteLine($"Original: {mixedCase}");
        sb5.Reverse();
        Console.WriteLine($"Reversed: {sb5}");
        Console.WriteLine();

        // METHOD 6: Reverse Number as String
        Console.WriteLine("--- METHOD 6: Reverse Numbers ---");
        string numberStr = "123456789";
        StringBuilder sb6 = new StringBuilder(numberStr);
        Console.WriteLine($"Original: {numberStr}");
        sb6.Reverse();
        Console.WriteLine($"Reversed: {sb6}");
        Console.WriteLine();

        // METHOD 7: Reverse Palindrome Check
        Console.WriteLine("--- METHOD 7: Palindrome Check ---");
        string[] testStrings = { "racecar", "hello", "madam", "world", "noon" };
        foreach (string str in testStrings)
        {
            StringBuilder sb = new StringBuilder(str);
            sb.Reverse();
            bool isPalindrome = str.Equals(sb.ToString());
            Console.WriteLine($"{str} -> {sb} : Palindrome = {isPalindrome}");
        }
        Console.WriteLine();

        // METHOD 8: Reverse with StringBuilder Capacity
        Console.WriteLine("--- METHOD 8: Reverse with Capacity Info ---");
        string str8 = "StringBuilder";
        StringBuilder sb8 = new StringBuilder(str8);
        Console.WriteLine($"Original: {sb8}");
        Console.WriteLine($"Length: {sb8.Length}");
        Console.WriteLine($"Capacity before Reverse: {sb8.Capacity}");
        sb8.Reverse();
        Console.WriteLine($"Reversed: {sb8}");
        Console.WriteLine($"Capacity after Reverse: {sb8.Capacity}");
        Console.WriteLine();

        // METHOD 9: Reverse and Clear
        Console.WriteLine("--- METHOD 9: Reverse and Clear ---");
        string str9 = "Temporary";
        StringBuilder sb9 = new StringBuilder(str9);
        Console.WriteLine($"Original: {sb9}");
        sb9.Reverse();
        Console.WriteLine($"Reversed: {sb9}");
        sb9.Clear();
        Console.WriteLine($"Cleared: '{sb9}' (Empty)");
        Console.WriteLine();

        // METHOD 10: Reverse Multiple Times
        Console.WriteLine("--- METHOD 10: Reverse Multiple Times ---");
        string str10 = "Test";
        StringBuilder sb10 = new StringBuilder(str10);
        Console.WriteLine($"Original: {sb10}");
        sb10.Reverse();
        Console.WriteLine($"1st Reverse: {sb10}");
        sb10.Reverse();
        Console.WriteLine($"2nd Reverse: {sb10}");  // Should be back to original
        Console.WriteLine();

        // METHOD 11: Compare Original and Reversed
        Console.WriteLine("--- METHOD 11: Compare Original and Reversed ---");
        string original11 = "Compare";
        StringBuilder sb11Original = new StringBuilder(original11);
        StringBuilder sb11Reversed = new StringBuilder(original11);
        sb11Reversed.Reverse();
        Console.WriteLine($"Original:  {sb11Original}");
        Console.WriteLine($"Reversed:  {sb11Reversed}");
        Console.WriteLine($"Are they different: {!sb11Original.ToString().Equals(sb11Reversed.ToString())}");
        Console.WriteLine();

        // METHOD 12: Complex Example - Reverse and Format
        Console.WriteLine("--- METHOD 12: Reverse and Format ---");
        string email = "user@domain.com";
        StringBuilder sb12 = new StringBuilder(email);
        sb12.Reverse();
        string reversedEmail = sb12.ToString();
        Console.WriteLine($"Original Email: {email}");
        Console.WriteLine($"Reversed Email: {reversedEmail}");
        Console.WriteLine();

        // METHOD 13: Reverse Entire Sentence Word by Word
        Console.WriteLine("--- METHOD 13: Reverse Each Word in Sentence ---");
        string sentence13 = "Reverse Each Word";
        string[] wordsInSentence = sentence13.Split(' ');
        StringBuilder sb13 = new StringBuilder();
        foreach (string word in wordsInSentence)
        {
            StringBuilder wordBuilder = new StringBuilder(word);
            wordBuilder.Reverse();
            sb13.Append(wordBuilder).Append(" ");
        }
        Console.WriteLine($"Original: {sentence13}");
        Console.WriteLine($"Each Word Reversed: {sb13.ToString().Trim()}");
        Console.WriteLine();

        // METHOD 14: Performance - Reverse Large String
        Console.WriteLine("--- METHOD 14: Performance - Reverse Large String ---");
        string largeString = new string('A', 10000);
        var watch = System.Diagnostics.Stopwatch.StartNew();
        StringBuilder sbLarge = new StringBuilder(largeString);
        sbLarge.Reverse();
        watch.Stop();
        Console.WriteLine($"Reversed 10,000 characters in: {watch.ElapsedMilliseconds}ms");
        Console.WriteLine($"First 50 chars: {sbLarge.ToString().Substring(0, 50)}");
        Console.WriteLine();

        // METHOD 15: Reverse with Special Characters
        Console.WriteLine("--- METHOD 15: Reverse with Special Characters ---");
        string special = "Hello@World#2024!";
        StringBuilder sb15 = new StringBuilder(special);
        Console.WriteLine($"Original: {special}");
        sb15.Reverse();
        Console.WriteLine($"Reversed: {sb15}");
    }

    // Helper method to reverse a specific portion of StringBuilder
    static void ReversePartial(StringBuilder sb, int startIndex, int endIndex)
    {
        char[] chars = sb.ToString().ToCharArray();
        Array.Reverse(chars, startIndex, endIndex - startIndex);
        sb.Clear();
        sb.Append(new string(chars));
    }
}
