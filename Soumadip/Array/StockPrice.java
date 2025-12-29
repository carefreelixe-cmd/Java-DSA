package Soumadip.Array;

public class StockPrice {
      public static int stockprofit(int[] arr)
      {
            int buyprice=Integer.MAX_VALUE;
            int maxprofit=0;
            for(int i=0;i<arr.length;i++)
            {
                  int profit;
                  if(buyprice<arr[i])
                  {
                        profit=arr[i]-buyprice;
                        maxprofit=Math.max(profit, buyprice);
                  }
                  else{
                        buyprice=arr[i];
                  }
            }
            return maxprofit;
      }
       public static void main(String[] args) {
            int[] nums={10,20,30,40,50};
            int max=stockprofit(nums);
            // display(nums);
            System.out.println(max);
      }
}
