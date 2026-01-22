namespace Cognizant.Sandipan.removechar
{
    using System;
    class removechar
    {
        static void RemoveChar(String str)
        {
            char[] resultchar = str.ToCharArray();
            Console.WriteLine("Original String: " + str);
            Console.Write("After removing special characters: ");
            
            for(int i = 0; i < str.Length; i++)
            {
                if(Char.IsLetterOrDigit(resultchar[i]) || Char.IsWhiteSpace(resultchar[i]))
                {
                    Console.Write(resultchar[i]);
                }
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            String str = "@#Hdhjdj%$@#3hjjs";
            RemoveChar(str);
            
            // Test with another example
            String str2 = "Hello@World! 123#$";
            RemoveChar(str2);
        }
    }
}