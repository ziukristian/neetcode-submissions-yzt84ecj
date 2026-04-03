public class Solution {
    public int UniquePaths(int m, int n) {
        
        var dp = new int[m+1,n+1];

        dp[m - 1, n] = 1;

        for(var i=m-1;i>=0;i--){
            for(var j=n-1;j>=0;j--){
                dp[i,j] = dp[i+1,j] + dp[i,j+1];
            }
        }

        Console.WriteLine(dp[0,0]);

        return dp[0,0];
    }
}
