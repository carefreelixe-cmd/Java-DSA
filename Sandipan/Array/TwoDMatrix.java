package Sandipan.Array;
import java.util.Scanner;
public class TwoDMatrix {
    public static void main(String[] args)
    {

        Scanner sc=new Scanner(System.in);
        int matrix[][]=new int [5][5];
        int m=matrix.length
;
    int n=matrix[0].length;

    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            matrix[i][j]=sc.nextInt();
          
        }
        System.out.println();
    }

      for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
          System.out.print(matrix[i][j]+" "); 
          
        }
        System.out.println();
    }
}
}