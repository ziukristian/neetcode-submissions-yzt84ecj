public class Solution {
    public int Rob(int[] nums) {
        
        var n = nums.Length;

        if(n<3) return nums.Max();

        var dp = new int[n];

        dp[n-1] = nums[n-1];
        dp[n-2] = nums[n-2];

        for(var i=n-3;i>=0;i--){
            dp[i] = Math.Max(nums[i] + dp[i+2], dp[i+1]);
        }

        return Math.Max(dp[0],dp[1]);

    }
}
