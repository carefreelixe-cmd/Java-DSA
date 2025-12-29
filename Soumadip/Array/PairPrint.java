package Soumadip.Array;

public class PairPrint {
      public static void pairarr(int[] arr)
      {
            for(int i=0;i<arr.length;i++)
            {
                  int s=arr[i];
                  for(int j=i+1;j<arr.length;j++)
                  {
                        System.out.print("("+s+","+arr[j]+") | ");
                  }
                  System.out.println();
            }
      }
      public static void subarr(int[] arr)
      {
            for(int i=0;i<arr.length;i++)
            {
                  int s=i;
                  for(int j=i+1;j<arr.length;j++)
                  {
                        int e=j;
                        System.out.print("(");
                        for(int k=s;k<=e;k++)
                        {
                              System.out.print("|"+arr[k]+"|");
                        }
                        System.out.print(") , ");
                  }
                  s++;
                  System.out.println();
            }
      }
       public static void display(int[] arr)
      {
            System.out.println("\t\t---- The Array ----> \n");
            for(int i=0;i<arr.length;i++)
            {
                  System.out.println(arr[i]+"\t");
            }
            System.out.println("\n\n");
      }
      public static void main(String[] args) {
            int[] nums={10,20,30,40,50};
            subarr(nums);
            display(nums);
      }
}
