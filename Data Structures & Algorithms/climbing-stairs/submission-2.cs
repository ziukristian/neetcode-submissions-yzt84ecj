public class Solution {
    public int ClimbStairs(int n) {    

        if(n==1 || n==2) return n; 
        
        var dp = new int[n];

        dp[n-1] = 1;
        dp[n-2] = 2;

        for(var i=n-3;i>=0;i--){
            dp[i] = dp[i+1] + dp[i+2];
        }

        return dp[0];
    }
}
