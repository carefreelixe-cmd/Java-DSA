using System;
class dsa
{
    static int MinOperation(int []arr,int n)
    {
      int operation=0;
      for(int i=0;i<arr.Length;i++)
        {
            int required=i+1;
            if(arr[i]<required)
            {
                operation+=required-arr[i];
            }
        }
        return operation;
    }
}