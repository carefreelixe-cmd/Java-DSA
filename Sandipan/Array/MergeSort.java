package Sandipan.Array;

public class MergeSort {
    public static void mergeSort(){
        public static int  mergeSort(int arr,int st,int end)
        {
            if(st<end)
            {
                int mild=(st+end)/2;
                mergeSort(arr,st,mild);
                mergeSort(arr,mild+1,end);
                merge(arr,st,mild,end)
            }
        }

        public static void merge(int arr,int st,int end,int mild)
        {
            int leftsize=mild-st+1;
            int rightsize=end-mild;
            int left[]=new int[leftsize];
            int right=new int [rightsize];
            for(int i=0;i<leftsize;i++)
            {
                left[i]=arr[st+i];
            }
            for(int j=0;j<rightsize;j++)
            {
                right[j]=arr[mild+1+j];
            }
            int i=0,j=0;
            int k=st;
            while(i<leftsize && j<rightsize)
            {
                if(left[i]<=right[j])
                {
                    arr[k]=left[i];
                    i++;
                }
                else
                {
                    arr[k]=right[j];
                    j++;
                }
                k++;
            }
        }
    }
}
