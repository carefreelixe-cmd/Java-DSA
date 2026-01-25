using System;

class dfs
{
    static int UniquePath(int n, int m)
    {
        // Create a 2D array to store number of paths
        int[,] dp = new int[n, m];
        
        // Fill first row - only one way to reach any cell (go right)
        for(int j = 0; j < m; j++)
        {
            dp[0, j] = 1;
        }
        
        // Fill first column - only one way to reach any cell (go down)
        for(int i = 0; i < n; i++)
        {
            dp[i, 0] = 1;
        }
        
        // Fill remaining cells
        // Each cell can be reached from top or left
        for(int i = 1; i < n; i++)
        {
            for(int j = 1; j < m; j++)
            {
                dp[i, j] = dp[i-1, j] + dp[i, j-1];
            }
        }
        
        // Return paths to bottom-right corner
        return dp[n-1, m-1];
    }
    
    static void Main(string[] args)
    {
        // Test case 1: n=3, m=3
        int n1 = 3, m1 = 3;
        Console.WriteLine($"Grid {n1}x{m1}: {UniquePath(n1, m1)} unique paths");
        
        // Test case 2: n=2, m=2
        int n2 = 2, m2 = 2;
        Console.WriteLine($"Grid {n2}x{m2}: {UniquePath(n2, m2)} unique paths");
        
        // Test case 3: n=3, m=2
        int n3 = 3, m3 = 2;
        Console.WriteLine($"Grid {n3}x{m3}: {UniquePath(n3, m3)} unique paths");
    }
}