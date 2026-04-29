using System;
using System.Collections.Generic;

class ProgramList
{
      static void Main(String[] args)
      {
            int n;
            List<int> list=new List<int>();
            Console.WriteLine("Enter the Limit: ");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                  int val=0;
                  Console.WriteLine("Add Elememt: "+i+" :");
                  val=int.Parse(Console.ReadLine());
                  list.Add(val);
            }
            Console.WriteLine("List elements:");
            foreach(int item in list)
            {
                  Console.Write(item+" ");
            }
            // Console.ReadLine();
      }
}