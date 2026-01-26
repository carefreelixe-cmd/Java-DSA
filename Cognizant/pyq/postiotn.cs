using System;
class postiotn
{
    static int CharacterSum(string str)
    {
        int sum = 0;
        char[] stringArray = str.ToCharArray(); // Move outside loop
        
        for(int i = 0; i < str.Length; i++)
        {
            char ch = stringArray[i];
            int charPosition = 0;
            
            // Handle uppercase letters (A-Z)
            if(ch >= 'A' && ch <= 'Z')
            {
                charPosition = ch - 'A' + 1; // A=1, B=2, ..., Z=26
            }
            // Handle lowercase letters (a-z)
            else if(ch >= 'a' && ch <= 'z')
            {
                charPosition = ch - 'a' + 1; // a=1, b=2, ..., z=26
            }
            // Ignore non-letter characters
            
            sum += charPosition;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        string test1 = "ABC";
        string test2 = "abc";
        string test3 = "AaBbCc";
        string test4 = "Hello";
        
        Console.WriteLine("ABC: " + CharacterSum(test1)); // 1+2+3 = 6
        Console.WriteLine("abc: " + CharacterSum(test2)); // 1+2+3 = 6
        Console.WriteLine("AaBbCc: " + CharacterSum(test3)); // 1+1+2+2+3+3 = 12
        Console.WriteLine("Hello: " + CharacterSum(test4)); // 8+5+12+12+15 = 52
    }
}