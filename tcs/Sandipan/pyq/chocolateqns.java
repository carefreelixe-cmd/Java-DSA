package tcs.pyq;

public class chocolateqns {
    public static  int[] chocolateQuestion(int []arr,int n)
    {

        int [] temp =  new int [n];
        int index=0;
        for(int i=0;i<n;i++)
        {
            if(arr[i]!=0)
            {
                temp[index++]=arr[i];
            }
        }
 return temp;
       

       
    }


    public static void main(String []args)
    {
        int n=8;
        int [] temp1={4,5,0,1,9,0,5,0};
        int [] result= chocolateQuestion(temp1,n);
    }
}
