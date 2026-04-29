using System;

namespace cognizent_GENCNEXT
{
    public class StockPrice
    {
        public static int stockprofit(int[] arr)
        {
            int buyprice = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int profit;
                if (buyprice < arr[i])
                {
                    profit = arr[i] - buyprice;
                    maxprofit = Math.Max(profit, buyprice);
                }
                else
                {
                    buyprice = arr[i];
                }
            }
            return maxprofit;
        }
        public static void Main(string[] args)
        {
            int[] nums = { 10, 20, 30, 40, 50 };
            int max = stockprofit(nums);
            // display(nums);
            Console.WriteLine(max);
        }
    }
}
