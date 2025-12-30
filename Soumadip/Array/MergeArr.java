package Soumadip.Array;

public class MergeArr {
      public static void merge (int num1[] ,int num2[]) 
      {
            int newArr[]=new int[num1.length+num2.length];
            int k=0;
            for(int i=0;i<num1.length;i++)
            {
                  newArr[k]=num1[i];
                  k++;
            }
            for(int j=0;j<num2.length;j++)
            {
                  newArr[k]=num2[j];
                  k++;
            }
            for(int m=0;m<newArr.length;m++)
            {
                  System.out.print(newArr[m]+"|");
            }
      }
      public static void main(String[] args) {
            int a[]={1,2,3,0,0,4};
            int b[]={8,4,5,7};
            merge(a,b);
      }

}
