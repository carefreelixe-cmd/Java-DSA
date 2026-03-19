// create 2d arr, print 2d arr, 

using System;
class Arr2d
{
      static void Main(String[] args)
      {
            Console.WriteLine("Enter the Numebr of Row: ");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Numebr of Coloumn: ");
            int n=int.Parse(Console.ReadLine());
            int [,] arr=new int[m,n];
            for(int i=0;i<m;i++)
            {
                  for(int j=0;j<n;j++)
                  {
                        arr[i,j]=int.Parse(Console.ReadLine());
                  }
            }
            // print the matrix
            Console.WriteLine("\n\n\t the Matrix ---->\n\n");
            for(int i=0;i<m;i++)
            {
                  for(int j=0;j<n;j++)
                  {
                        Console.Write(arr[i,j]+" ");
                  }
                  Console.WriteLine();
            }
      }
}