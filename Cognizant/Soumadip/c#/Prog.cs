using System;

public class Program
{
    public static string LongestEvenVowelWord(string s)
    {
        string[] words = s.Split(' ');
        string result = "00";

        foreach (string w in words)
        {
            if (string.IsNullOrEmpty(w)) continue;

            char c = char.ToLower(w[0]);

            if (w.Length % 2 == 0 && "aeiou".Contains(c))
            {
                if (result == "00" || w.Length > result.Length)
                {
                    result = w;
                }
            }
        }

        return result;
    }

    static void Main()
    {
        string sentence = "Apple orange umbrella ink octopus egg";
        Console.WriteLine(LongestEvenVowelWord(sentence)); // Output: "orange"
    }
}