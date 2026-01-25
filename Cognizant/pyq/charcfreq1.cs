using System;

class charcfreq1
{
    static void FirstUniqueChar(string str)
    {
        // Count frequency of each character
        int[] freq = new int[256]; // For all ASCII characters
        
        for(int i = 0; i < str.Length; i++)
        {
            freq[str[i]]++;
        }
        
        // Find first character with frequency 1
        for(int i = 0; i < str.Length; i++)
        {
            if(freq[str[i]] == 1)
            {
                Console.WriteLine($"First unique character: {str[i]}");
                return;
            }
        }
        
        // No unique character found
        Console.WriteLine(-1);
    }
    
    static void Main(string[] args)
    {
        FirstUniqueChar("leetcode");  // Output: l
        FirstUniqueChar("loveleetcode");  // Output: v
        FirstUniqueChar("aabb");  // Output: -1
        FirstUniqueChar("statistics");  // Output: a
    }
}