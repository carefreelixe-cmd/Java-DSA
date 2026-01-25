
using System;
using System.Collections.Generic;
namespace Cognizant.Sandipan.c_sharp
{
    class dict
    {
        static void DictionaryExample()
        {
            Dictionary<string,int>ages=new Dictionary<string, int>();
            ages["Alice"]=25;
            ages["Bob"]=30;
            ages["Charlie"]=35;
            Console.WriteLine($"Alice's age: {ages["Alice"]}");
            Console.WriteLine("All ages:");
            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine($"  {ages.Keys}: {ages.Values}");
            }
        }
        
    }
}