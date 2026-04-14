public class Solution {
    public int MinCostClimbingStairs(int[] cost) {

        var n = cost.Length;

        if(n == 1) return cost[0];
        if(n == 0) return 0;

        var dp = new int[n];

        dp[n-1] = cost[n-1];
        dp[n-2] = cost[n-2];
        
        for(var i=cost.Length-3;i>=0;i--){
            dp[i] = cost[i]+Math.Min(dp[i+1],dp[i+2]);
        }

        return Math.Min(dp[0],dp[1]);
    }
}
