package greedy;

public class fractionalKanapsack {
    public int knapsack(int[]weight,int[]value,int capacity)

    {
        int [][]dp= new int [weight.length+1][capacity+1];
        for(int i=1;i<=weight.length;i++)
        {
            for(w=1;w<=capacity;w++)
            {
                if(weight[i-1]<=w)
                {
                    dp[i][w]=Math.max(dp[i-1][w],value[i-1]+dp[i-1][w-weight[i-1]]);
                }

                else

                    {
                        dp[i][w]=dp[i-1][w];
                    }
            }
        }
return dp[weight.length][capacity];
    }
}
