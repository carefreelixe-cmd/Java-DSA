package Practice.Sandipan.Array;

public class TwoDto1d {

public void convert2Dto1D(int arr[][])
{
    for(int i=0;i<arr.length;i++)
    {
        for(int j=0;j<arr[i].length;j++)
        {
            System.out.print(arr[i][j]+" ");
        }
    }

    
}

public static void main(String[] args) {
   
    int arr[][]={{1,2,3},{4,5,6},{7,8,9}};
    //function under class object thast why we acces this way 
    //this can be done by easiest way
    TwoDto1d    obj=new TwoDto1d();
    obj.convert2Dto1D(arr);
}
}