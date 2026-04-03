public class Solution {
    public int LengthOfLIS(int[] nums) {
        
        var dp = new int[nums.Length];
        var max = 0;

        for(var i = 0;i<nums.Length;i++){

            dp[i] = 1;

            for(var j=0;j<i;j++){
                if(nums[j]>=nums[i]) continue;
                dp[i] = Math.Max(dp[j]+1,dp[i]);
                
            }

            max = Math.Max(dp[i],max);

        }

        return max;
    }
}
